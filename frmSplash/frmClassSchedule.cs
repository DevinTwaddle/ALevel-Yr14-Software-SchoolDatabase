using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace frmSplash
{
    public partial class frmClassSchedule : Form
    {
        SqlConnection connection;
        string connectionString;
        SqlDataReader DataReader;
        int A;
        int B;

        // Scheduled_Lessons Details
        List<int> ScheduleID = new List<int>();
        List<int> StudentID_Schedule = new List<int>();
        List<DateTime> ScheduleDate = new List<DateTime>();
        List<int> TeacherID_Schedule = new List<int>();
        List<string> ScheduledTime = new List<string>();

        // Student Details
        List<int> StudentID_Student = new List<int>();
        List<string> StudentFirstName = new List<string>();
        List<string> StudentLastName = new List<string>();
        List<int> InstrumentID_Students = new List<int>();

        // Teacher Details
        List<int> TeacherID_Teachers = new List<int>();
        List<string> TeacherFirstName = new List<string>();
        List<string> TeacherLastName = new List<string>();
        List<int> RoomID_Teachers = new List<int>();

        // Instrument Details
        List<int> InstrumentID_instruments = new List<int>();
        List<string> InstrumentName = new List<string>();

        // Desired Values
        List<int> DesiredTeacherIDs = new List<int>();
        List<string> DesiredStudentFirstName = new List<string>();
        List<string> DesiredStudentLastName = new List<string>();
        List<int> DesiredInstrumentID = new List<int>();
        List<int> DesiredScheduleIDs = new List<int>();
        List<int> DesiredStudentIDs = new List<int>();
        List<string> DesiredTeacherFirstName = new List<string>();
        List<string> DesiredTeacherLastName = new List<string>();
        List<string> DesiredInstrumentName = new List<string>();
        List<int> DesiredRoomID = new List<int>();
        List<string> DesiredScheduledTime = new List<string>();

        List<bool> DesiredDisplay = new List<bool>();


        public frmClassSchedule()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }


        private void frmClassSchedule_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 6; x++)
            {
                DesiredDisplay.Add(false);
            }

            // This block of code will check the selected date, and update the format accodingly for visual astetics.
            if (GlobalVariables.SelectedDay == 1 || GlobalVariables.SelectedDay == 21 || GlobalVariables.SelectedDay == 31)
            {
                lblDatePlaceholder.Text = String.Format("{0}st {1} {2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthString, GlobalVariables.SelectedYear);
            }
            else if (GlobalVariables.SelectedDay == 2 || GlobalVariables.SelectedDay == 22)
            {
                lblDatePlaceholder.Text = String.Format("{0}nd {1} {2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthString, GlobalVariables.SelectedYear);
            }
            else if (GlobalVariables.SelectedDay == 3 || GlobalVariables.SelectedDay == 23)
            {
                lblDatePlaceholder.Text = String.Format("{0}rd {1} {2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthString, GlobalVariables.SelectedYear);
            }
            else
            {
                lblDatePlaceholder.Text = String.Format("{0}th {1} {2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthString, GlobalVariables.SelectedYear);
            }

            lblTimePlaceholder.Text = GlobalVariables.SelectedTimeTextFormat;

            lblErrorMessage.Hide();
            ScheduledLessons();
            StudentDetails();
            TeacherDetails();
            InstrumentDetails();
            AssignDatabaseValues();
            DisplayInformaiton();
            ErrorTest();
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "";
            GlobalVariables.SelectedDay = 0;
            GlobalVariables.SelectedMonthInt = 0;
            GlobalVariables.SelectedMonthString = "";
            GlobalVariables.SelectedYear = 0;
            GlobalVariables.SelectedScheduleDate = "00/00/0000";

            A = 0;
            B = 0;

            frmPrivateTuition Main = new frmPrivateTuition();
            Main.Show();
            this.Hide();
        }


        public void ScheduledLessons()
        {
            GlobalVariables.SelectedTime = GlobalVariables.SelectedTime.Substring(0, 5);
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Scheduled_Lessons WHERE End_Date=@Date AND Booked_Time=@Time", connection))
                {
                    Command.Parameters.AddWithValue("@Date", Convert.ToDateTime(GlobalVariables.SelectedScheduleDate));
                    Command.Parameters.AddWithValue("@Time", GlobalVariables.SelectedTime);

                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        DesiredScheduleIDs.Add(DataReader.GetInt32(0));
                        DesiredStudentIDs.Add(DataReader.GetInt32(1));
                        ScheduleDate.Add(DataReader.GetDateTime(5));
                        DesiredTeacherIDs.Add(DataReader.GetInt32(2));
                        DesiredScheduledTime.Add(DataReader.GetString(7));
                    }
                }
            }
        }


        public void StudentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command2 = new SqlCommand("SELECT * FROM Students", connection))
                {

                    DataReader = Command2.ExecuteReader();
                    while (DataReader.Read())
                    {
                        StudentID_Student.Add(DataReader.GetInt32(0));
                        StudentFirstName.Add(DataReader.GetString(1));
                        StudentLastName.Add(DataReader.GetString(3));
                        InstrumentID_Students.Add(DataReader.GetInt32(11));



                    }
                }
            }
        }


        public void TeacherDetails()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command3 = new SqlCommand("SELECT * FROM Teachers", connection))
                {

                    DataReader = Command3.ExecuteReader();
                    while (DataReader.Read())
                    {
                        TeacherID_Teachers.Add(DataReader.GetInt32(0));
                        TeacherFirstName.Add(DataReader.GetString(1));
                        TeacherLastName.Add(DataReader.GetString(2));
                        RoomID_Teachers.Add(DataReader.GetInt32(9));
                    }
                }
            }
        }


        public void InstrumentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command4 = new SqlCommand("SELECT * FROM Instruments", connection))
                {

                    DataReader = Command4.ExecuteReader();
                    while (DataReader.Read())
                    {
                        InstrumentID_instruments.Add(DataReader.GetInt32(0));
                        InstrumentName.Add(DataReader.GetString(2));
                    }
                }
            }
        }


        private void btnCalender_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "";

            frmCalenderTimes LessonTimes = new frmCalenderTimes();
            LessonTimes.Show();
            this.Hide();
        }


        public void AssignDatabaseValues()
        {
            // Save Desired Student information
            for (int x = 0; x < StudentID_Student.Count(); x++)
            {
                for (int y = 0; y < DesiredStudentIDs.Count(); y++)
                {
                    if (DesiredStudentIDs[y] == StudentID_Student[x])
                    {
                        DesiredStudentFirstName.Add(StudentFirstName[x]);
                        DesiredStudentLastName.Add(StudentLastName[x]);
                        DesiredInstrumentID.Add(InstrumentID_Students[x]);
                    }
                }
            }


            // Save Desired Teacher Information
            for (int x = 0; x < TeacherID_Teachers.Count(); x++)
            {
                for (int y = 0; y < DesiredTeacherIDs.Count(); y++)
                {
                    if (DesiredTeacherIDs[y] == TeacherID_Teachers[x])
                    {
                        DesiredTeacherFirstName.Add(TeacherFirstName[x]);
                        DesiredTeacherLastName.Add(TeacherLastName[x]);
                        DesiredRoomID.Add(RoomID_Teachers[x]);
                    }
                }
            }


            // Save Desired Instrument Information
            for (int x = 0; x < InstrumentID_instruments.Count(); x++)
            {
                for (int y = 0; y < DesiredInstrumentID.Count(); y++)
                {
                    if (DesiredInstrumentID[y] == InstrumentID_instruments[x])
                    {
                        DesiredInstrumentName.Add(InstrumentName[x]);
                    }
                }
            }
        }


        public void DisplayInformaiton()
        {
            B = 0;

            for (int x = 0; x < DesiredScheduleIDs.Count(); x++)
            {
                if (DesiredDisplay[0] == false)
                {
                    lblStudentName1.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName1.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName1.Text = DesiredInstrumentName[x];
                    lblRoomID1.Text = Convert.ToString(DesiredRoomID[x]);
                    lblStudentName6.Text = x.ToString();
                    DesiredDisplay[0] = true;
                }
                else if (DesiredDisplay[1] == false)
                {
                    lblStudentName2.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName2.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName2.Text = DesiredInstrumentName[x];
                    lblRoomID2.Text = Convert.ToString(DesiredRoomID[x]);
                    lblTeacherName6.Text = x.ToString();
                    DesiredDisplay[1] = true;
                }
                else if (DesiredDisplay[2] == false)
                {
                    lblStudentName3.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName3.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName3.Text = DesiredInstrumentName[x];
                    lblRoomID3.Text = Convert.ToString(DesiredRoomID[x]);
                    lblInstrumentName6.Text = x.ToString();
                    DesiredDisplay[2] = true;
                }
                else if (DesiredDisplay[3] == false)
                {
                    lblStudentName4.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName4.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName4.Text = DesiredInstrumentName[x];
                    lblRoomID4.Text = Convert.ToString(DesiredRoomID[x]);
                    DesiredDisplay[3] = true;
                }
                else if (DesiredDisplay[4] == false)
                {
                    lblStudentName5.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName5.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName5.Text = DesiredInstrumentName[x];
                    lblRoomID5.Text = Convert.ToString(DesiredRoomID[x]);
                    DesiredDisplay[4] = true;
                }
                else if (DesiredDisplay[5] == false)
                {
                    lblStudentName6.Text = DesiredStudentFirstName[x] + " " + DesiredStudentLastName[x];
                    lblTeacherName6.Text = DesiredTeacherFirstName[x] + " " + DesiredTeacherLastName[x];
                    lblInstrumentName6.Text = DesiredInstrumentName[x];
                    lblRoomID6.Text = Convert.ToString(DesiredRoomID[x]);
                    DesiredDisplay[5] = true;
                }
            }

              
              
                if (DesiredDisplay[0] == false && DesiredDisplay.Count > 0)
                {
                    HideDisplay1();
                    HideDisplay2();
                    HideDisplay3();
                    HideDisplay4();
                    HideDisplay5();
                    HideDisplay6();

                    lblErrorMessage.Show();
                    lblErrorMessage.Location = new Point(180, 268);
                    lblErrorMessage.Text = "There are currently no scheduled" + System.Environment.NewLine + "    classes for this date and time.";
                }

                if (DesiredDisplay[1] == false && DesiredDisplay.Count > 1)
                {
                    HideDisplay2();
                    HideDisplay3();
                    HideDisplay4();
                    HideDisplay5();
                    HideDisplay6();
                }

                if (DesiredDisplay[2] == false && DesiredDisplay.Count > 2)
                {
                    HideDisplay3();
                    HideDisplay4();
                    HideDisplay5();
                    HideDisplay6();
                }

                if (DesiredDisplay[3] == false && DesiredDisplay.Count > 3)
                {
                    HideDisplay4();
                    HideDisplay5();
                    HideDisplay6();
                }

                if (DesiredDisplay[4] == false && DesiredDisplay.Count > 4)
                {
                    HideDisplay5();
                    HideDisplay6();
                }

                if (DesiredDisplay[5] == false && DesiredDisplay.Count > 5)
                {
                    HideDisplay6();
                }

        }
            
        


        public void HideDisplay1()
        {
            pbDisplay1.Hide();
            lblStudentName1.Hide();
            lblTeacherName1.Hide();
            lblInstrumentName1.Hide();
            lblRoomID1.Hide();
        }


        public void HideDisplay2()
        {
            pbDisplay2.Hide();
            lblStudentName2.Hide();
            lblTeacherName2.Hide();
            lblInstrumentName2.Hide();
            lblRoomID2.Hide();
        }


        public void HideDisplay3()
        {
            pbDisplay3.Hide();
            lblStudentName3.Hide();
            lblTeacherName3.Hide();
            lblInstrumentName3.Hide();
            lblRoomID3.Hide();
        }


        public void HideDisplay4()
        {
            pbDisplay4.Hide();
            lblStudentName4.Hide();
            lblTeacherName4.Hide();
            lblInstrumentName4.Hide();
            lblRoomID4.Hide();
        }


        public void HideDisplay5()
        {
            pbDisplay5.Hide();
            lblStudentName5.Hide();
            lblTeacherName5.Hide();
            lblInstrumentName5.Hide();
            lblRoomID5.Hide();
        }


        public void HideDisplay6()
        {
            pbDisplay6.Hide();
            lblStudentName6.Hide();
            lblTeacherName6.Hide();
            lblInstrumentName6.Hide();
            lblRoomID6.Hide();
        }


        public void ErrorTest()
        {
            A = 0;
            B = 0;

            while (A < DesiredScheduleIDs.Count)
            {
                while(B < DesiredTeacherIDs.Count)
                {
                    int placeholder = DesiredTeacherIDs[A];

                    if (DesiredTeacherIDs[A] == DesiredTeacherIDs[B] && DesiredTeacherIDs[B] != placeholder && GlobalVariables.scheduleErrorMessage == true)
                    {
                        MessageBox.Show("A Teacher has been assigned to multple lesson for the same date and time. Please review schedule");
                    }

                    placeholder = DesiredRoomID[A];

                    if(DesiredRoomID[A] == RoomID_Teachers[B] && DesiredRoomID[B] != placeholder && GlobalVariables.scheduleErrorMessage == true)
                    {
                        MessageBox.Show("A Room has been assigned multiple lessons for the same date and time. Please review schedule");
                    }

                    B++;
                }
                A++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Load Add New Record Form
            GlobalVariables.PreviousForm = "Calender";
            frmAddField AddField = new frmAddField();
            AddField.Show();
            this.Hide();
        }

        public void LoadScheduleCalender()
        {
            frmScheduleTable ScheduleTable = new frmScheduleTable();
            ScheduleTable.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[0];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[0];
            LoadScheduleCalender();
        }

        private void pbDisplay2_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[1];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[1];
            LoadScheduleCalender();
        }

        private void pbDisplay3_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[2];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[2];
            LoadScheduleCalender();
        }

        private void pbDisplay4_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[3];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[3];
            LoadScheduleCalender();
        }

        private void pbDisplay5_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[4];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[4];
            LoadScheduleCalender();
        }

        private void pbDisplay6_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = true;
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[5];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[5];
            LoadScheduleCalender();
        }
    }

}






