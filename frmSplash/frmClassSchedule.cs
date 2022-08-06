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
        int C;

        // Scheduled_Lessons Details
        List<int> ScheduleID = new List<int>();
        List<int> StudentID_Schedule = new List<int>();
        List<DateTime> ScheduleDate = new List<DateTime>();
        List<int> TeacherID_Schedule = new List<int>();
        List<TimeSpan> ScheduledTime = new List<TimeSpan>();

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
        List<TimeSpan> DesiredScheduledTime = new List<TimeSpan>();

        List<bool> DesiredDisplay = new List<bool>();


        public frmClassSchedule()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }


        private void frmClassSchedule_Load(object sender, EventArgs e)
        {
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
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Scheduled_Lessons", connection))
                {

                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        ScheduleID.Add(DataReader.GetInt32(0));
                        StudentID_Schedule.Add(DataReader.GetInt32(1));
                        ScheduleDate.Add(DataReader.GetDateTime(5));
                        TeacherID_Schedule.Add(DataReader.GetInt32(2));
                        DesiredDisplay.Add(false);
                        ScheduledTime.Add(DataReader.GetTimeSpan(7));
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
            // Save Desired Schedule Information
            while (A < ScheduleID.Count)
            {
                string test = Convert.ToString(ScheduleDate[A]);
                test = test.Substring(0, 10);


                if (test == GlobalVariables.SelectedScheduleDate && ScheduledTime[A].ToString() == GlobalVariables.SelectedTime)
                {
                    DesiredScheduleIDs.Add(ScheduleID[A]);
                    DesiredStudentIDs.Add(StudentID_Schedule[A]);
                    DesiredTeacherIDs.Add(TeacherID_Schedule[A]);
                }
                A++;
            }


            // Save Desired Student information
            A = 0;

            while (A < DesiredStudentIDs.Count)
            {
                while (B < StudentID_Student.Count)
                {
                    if (DesiredStudentIDs[A] == StudentID_Student[B])
                    {
                        DesiredStudentFirstName.Add(StudentFirstName[B]);
                        DesiredStudentLastName.Add(StudentLastName[B]);
                        DesiredInstrumentID.Add(InstrumentID_Students[B]);
                    }
                    B++;
                }

                A++;
                B = 0;
            }


            // Save Desired Teacher Information
            A = 0;
            B = 0;

            while (A < DesiredTeacherIDs.Count)
            {
                while (B < TeacherID_Teachers.Count)
                {
                    if (DesiredTeacherIDs[A] == TeacherID_Teachers[B])
                    {
                        DesiredTeacherFirstName.Add(TeacherFirstName[B]);
                        DesiredTeacherLastName.Add(TeacherLastName[B]);
                        DesiredRoomID.Add(RoomID_Teachers[B]);
                    }
                    B++;
                }

                A++;
                B = 0;
            }


            // Save Desired Instrument Information
            A = 0;
            B = 0;

            while (A < DesiredInstrumentID.Count)
            {
                while (B < InstrumentID_instruments.Count)
                {
                    if (DesiredInstrumentID[A] == InstrumentID_instruments[B])
                    {
                        DesiredInstrumentName.Add(InstrumentName[B]);
                    }
                    B++;
                }

                A++;
                B = 0;
            }
        }


        public void DisplayInformaiton()
        {

            B = 0;
            A = 0;

            while (A < DesiredScheduleIDs.Count)
            {
                if (DesiredDisplay[0] == false)
                {

                    lblStudentName1.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName1.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName1.Text = DesiredInstrumentName[A];
                    lblRoomID1.Text = Convert.ToString(DesiredRoomID[A]);
                    lblStudentName6.Text = A.ToString();
                    DesiredDisplay[0] = true;
                }
                else if (DesiredDisplay[1] == false)
                {
                    lblStudentName2.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName2.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName2.Text = DesiredInstrumentName[A];
                    lblRoomID2.Text = Convert.ToString(DesiredRoomID[A]);
                    lblTeacherName6.Text = A.ToString();
                    DesiredDisplay[1] = true;
                }
                else if (DesiredDisplay[2] == false)
                {
                    lblStudentName3.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName3.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName3.Text = DesiredInstrumentName[A];
                    lblRoomID3.Text = Convert.ToString(DesiredRoomID[A]);
                    lblInstrumentName6.Text = A.ToString();
                    DesiredDisplay[2] = true;
                }
                else if (DesiredDisplay[3] == false)
                {
                    lblStudentName4.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName4.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName4.Text = DesiredInstrumentName[A];
                    lblRoomID4.Text = Convert.ToString(DesiredRoomID[A]);
                    DesiredDisplay[3] = true;
                }
                else if (DesiredDisplay[4] == false)
                {
                    lblStudentName5.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName5.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName5.Text = DesiredInstrumentName[A];
                    lblRoomID5.Text = Convert.ToString(DesiredRoomID[A]);
                    DesiredDisplay[4] = true;
                }
                else if (DesiredDisplay[5] == false)
                {
                    lblStudentName6.Text = DesiredStudentFirstName[A] + " " + DesiredStudentLastName[A];
                    lblTeacherName6.Text = DesiredTeacherFirstName[A] + " " + DesiredTeacherLastName[A];
                    lblInstrumentName6.Text = DesiredInstrumentName[A];
                    lblRoomID6.Text = Convert.ToString(DesiredRoomID[A]);
                    DesiredDisplay[5] = true;
                }
                A++;
            }


            if (DesiredDisplay[0] == false)
            {
                HideDisplay1();
                HideDisplay2();
                HideDisplay3();
                HideDisplay4();
                HideDisplay5();
                HideDisplay6();

                lblErrorMessage.Show();
                lblErrorMessage.Location = new Point(180,268);
                lblErrorMessage.Text = "There are currently no scheudled" + System.Environment.NewLine + "    classes for this date and time.";
            }

            if (DesiredDisplay[1] == false)
            {
                HideDisplay2();
                HideDisplay3();
                HideDisplay4();
                HideDisplay5();
                HideDisplay6();
            }

            if (DesiredDisplay[2] == false)
            {
                HideDisplay3();
                HideDisplay4();
                HideDisplay5();
                HideDisplay6();
            }

            if (DesiredDisplay[3] == false)
            {
                HideDisplay4();
                HideDisplay5();
                HideDisplay6();
            }

            if (DesiredDisplay[4] == false)
            {
                HideDisplay5();
                HideDisplay6();
            }

            if (DesiredDisplay[5] == false)
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
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[0];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[0];
            LoadScheduleCalender();
        }

        private void pbDisplay2_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[1];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[1];
            LoadScheduleCalender();
        }

        private void pbDisplay3_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[2];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[2];
            LoadScheduleCalender();
        }

        private void pbDisplay4_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[3];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[3];
            LoadScheduleCalender();
        }

        private void pbDisplay5_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[4];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[4];
            LoadScheduleCalender();
        }

        private void pbDisplay6_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalenderStudentID = DesiredStudentIDs[5];
            GlobalVariables.CalenderScheduledID = DesiredScheduleIDs[5];
            LoadScheduleCalender();
        }
    }

}






