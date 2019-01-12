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
    public partial class frmViewUpcomingLessons : Form
    {
        SqlConnection connection;
        string connectionString;
        SqlDataReader DataReader;

        List<int> ScheduledLessons_ScheduledID = new List<int>();
        List<int> ScheduledLessons_StudentID = new List<int>();
        List<int> ScheduledLessons_TeacherID = new List<int>();
        List<int> ScheduledLessons_PurchasedID = new List<int>();
        List<string> ScheduledLessons_Time = new List<string>();

        List<int> Students_StudentID = new List<int>();
        List<string> Students_FirstName = new List<string>();
        List<string> Students_Surname = new List<string>();
        List<string> Students_FullName = new List<string>();

        List<int> Teacher_TeacherID = new List<int>();
        List<string> Teacher_FirstName = new List<string>();
        List<string> Teacher_Surname = new List<string>();
        List<string> Teacher_FullName = new List<string>();

        List<int> LessonDates_LessonDateID = new List<int>();
        List<int> LessonDates_ScheduleID = new List<int>();
        List<DateTime> LessonDates_Dates = new List<DateTime>();
        List<bool> LessonDates_Attended = new List<bool>();

        List<int> Display_LessonID = new List<int>();
        List<string> Display_Name = new List<string>();
        List<int> Display_PurchaseID = new List<int>();
        List<DateTime> Display_Date = new List<DateTime>();
        List<string> Display_Time = new List<string>();
        List<string> Display_Day = new List<string>();
        List<bool> Display_Attended = new List<bool>();

        List<int> Desired_ScheduleID = new List<int>();
        List<int> Desired_StudentID = new List<int>();
        List<int> Desired_TeacherID = new List<int>();

        List<int> PageTest = new List<int>();

        List<bool> Displays = new List<bool>();

        bool Student;
        string Day;
        DateTime Date;

        int TotalPages;
        int Additional_Records;

        int Display_Start;
        int Display_End;
        string Search_Entity;

        DateTime DateFilter;
        DateTime DateFilter_Start;
        DateTime DateFilter_End;
        string DateFilter_String;
        bool AssignPageNumber;
        bool Limit;

        int SelectedPage;
        int MaxPage;
        int StandardPageIncrment = 6;
        int PageIndexReference;

        bool[] HideDisplays = new bool[6];

        public frmViewUpcomingLessons()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
            label1.Text = "0 / 0";
            Display_Start = 0;
            Display_End = 5;
            Store_DisplayInformation();
            Search_Fill();
            Hide_Displays();
        }

        public void LocalStorage_Student()
        {
            // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Students", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Students_StudentID.Add(DataReader.GetInt32(0));
                        Students_FirstName.Add(DataReader.GetString(1));
                        Students_Surname.Add(DataReader.GetString(3));
                    }
                }
                connection.Close();
            }

            for (int x = 0; x < Students_StudentID.Count(); x++)
            {
                Students_FullName.Add(Students_FirstName[x] + " " + Students_Surname[x]);
            }

        }

        public void LocalStorage_Teacher()
        {
            // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Teachers", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Teacher_TeacherID.Add(DataReader.GetInt32(0));
                        Teacher_FirstName.Add(DataReader.GetString(1));
                        Teacher_Surname.Add(DataReader.GetString(2));
                    }
                }
                connection.Close();
            }

            for (int x = 0; x < Teacher_TeacherID.Count(); x++)
            {
                Teacher_FullName.Add(Teacher_FirstName[x] + " " + Teacher_Surname[x]);
            }
        }

        public void LocalStorage_LessonDates()
        {
            // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM LessonDates", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        LessonDates_LessonDateID.Add(DataReader.GetInt32(0));
                        LessonDates_ScheduleID.Add(DataReader.GetInt32(1));
                        LessonDates_Dates.Add(DataReader.GetDateTime(2));
                        LessonDates_Attended.Add(DataReader.GetBoolean(3));
                    }
                }
            }

            for (int x = 0; x < LessonDates_LessonDateID.Count(); x++)
            {
                Display_LessonID.Add(LessonDates_LessonDateID[x]);
            }
        }

        public void LocalStorage_ScheduledLessons()
        {
            // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Scheduled_Lessons", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        ScheduledLessons_ScheduledID.Add(DataReader.GetInt32(0));
                        ScheduledLessons_StudentID.Add(DataReader.GetInt32(1));
                        ScheduledLessons_TeacherID.Add(DataReader.GetInt32(2));
                        ScheduledLessons_PurchasedID.Add(DataReader.GetInt32(3));
                        ScheduledLessons_Time.Add(DataReader.GetString(7));
                    }
                }
            }
        }

        public void LocalStorage_Clear()
        {
            ScheduledLessons_ScheduledID.Clear();
            ScheduledLessons_StudentID.Clear();
            ScheduledLessons_TeacherID.Clear();
            ScheduledLessons_PurchasedID.Clear();
            ScheduledLessons_Time.Clear();

            Students_StudentID.Clear();
            Students_FirstName.Clear();
            Students_Surname.Clear();
            Students_FullName.Clear();

            Teacher_TeacherID.Clear();
            Teacher_FirstName.Clear();
            Teacher_Surname.Clear();
            Teacher_FullName.Clear();

            LessonDates_LessonDateID.Clear();
            LessonDates_ScheduleID.Clear();
            LessonDates_Dates.Clear();
            LessonDates_Attended.Clear();

            Display_LessonID.Clear();
            Display_Name.Clear();
            Display_PurchaseID.Clear();
            Display_Date.Clear();
            Display_Time.Clear();
            Display_Day.Clear();
            Display_Attended.Clear();

            Desired_ScheduleID.Clear();
            Desired_StudentID.Clear();
            Desired_TeacherID.Clear();
        }


  
        public void Search_Fill()
        {
            if (Student == true)
            {
                Students_FullName.Sort();
                cbEntityID.DataSource = Students_FullName;
            }
            else if (Student == false)
            {
                Teacher_FullName.Sort();
                cbEntityID.DataSource = Teacher_FullName;
            }
        }



        private void btnSelectedEntity_Click(object sender, EventArgs e)
        {
            if (btnSelectedEntity.Text == "Student")
            {
                Student = false;
                btnSelectedEntity.Text = "Teacher";
            }
            else if (btnSelectedEntity.Text == "Teacher")
            {
                Student = true;
                btnSelectedEntity.Text = "Student";
            }

            Store_DisplayInformation();
            Search_Fill();
        }

        private void cbEntityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (Displays.Count < 7)
            {
                Displays.Add(false);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Store_DisplayInformation();
            Search_Fill();


            Search_Entity = cbEntityID.Text;

            // Locate Desired Student ID
            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (Display_Name[x] != Search_Entity)
                {
                    Display_LessonID.RemoveAt(x);
                    Display_PurchaseID.RemoveAt(x);
                    Display_Name.RemoveAt(x);
                    Display_Date.RemoveAt(x);
                    Display_Day.RemoveAt(x);
                    Display_Attended.RemoveAt(x);
                    Display_Time.RemoveAt(x);
                    x -= 1;
                }
            }


            DateFilter_String = cbFilter.Text;
            if (DateFilter_String == "Today")
            {
                DateFilter = DateTime.Today;
            }
            else if (DateFilter_String == "This Week")
            {
               
            }
            else if (DateFilter_String == "This Month")
            {
                DateFilter = DateTime.Today;
                DateFilter = DateFilter.AddMonths(1);
            }



            DateFilter_Start = DateTime.Today;

            for (int x = 0; x < Display_Date.Count(); x++)
            {
                if (DateFilter_String == "Today")
                {
                    if (Display_Date[x] != DateFilter)
                    {
                        Display_LessonID.RemoveAt(x);
                        Display_PurchaseID.RemoveAt(x);
                        Display_Name.RemoveAt(x);
                        Display_Date.RemoveAt(x);
                        Display_Day.RemoveAt(x);
                        Display_Attended.RemoveAt(x);
                        Display_Time.RemoveAt(x);
                        x -= 1;
                    }
                }
                else if (DateFilter_String == "This Week")
                {
                    DateFilter_End = DateFilter_Start.AddDays(7);

                    if (Display_Date[x] > DateFilter_Start && Display_Date[x] < DateFilter_End)
                    {
                        Display_LessonID.RemoveAt(x);
                        Display_PurchaseID.RemoveAt(x);
                        Display_Name.RemoveAt(x);
                        Display_Date.RemoveAt(x);
                        Display_Day.RemoveAt(x);
                        Display_Attended.RemoveAt(x);
                        Display_Time.RemoveAt(x);
                        x -= 1;
                    }
                }
                else if (DateFilter_String == "This Month")
                {
                    DateFilter_End = DateFilter_Start.AddMonths(1);
                    if (Display_Date[x] > DateFilter_Start && Display_Date[x] < DateFilter_End)
                    {
                        Display_LessonID.RemoveAt(x);
                        Display_PurchaseID.RemoveAt(x);
                        Display_Name.RemoveAt(x);
                        Display_Date.RemoveAt(x);
                        Display_Day.RemoveAt(x);
                        Display_Attended.RemoveAt(x);
                        Display_Time.RemoveAt(x);
                        x -= 1;
                    }

                }
                else if (DateFilter_String == "All Time")
                {
                    break;
                }
            }

            for (int x = 0; x < Display_LessonID.Count(); x++)
            {
                Displays.Add(false);
            }

            for (int x = 0; x < Displays.Count(); x++)
            {
                Displays[x] = false;
            }

            TotalPages = 0;
            SelectedPage = 1;
            lblErrorMessage.Hide();
            Additional_Records = 0;
            PageIndexReference = 0;
            AssignPageNumber = false;
            Display_DisplayInformation();
            AssignPageNumber = true;
            Hide_Displays();
        }


        public void Store_DisplayInformation()
        {
            LocalStorage_Clear();

            LocalStorage_Student();
            LocalStorage_Teacher();
            LocalStorage_ScheduledLessons();
            LocalStorage_LessonDates();

            for (int x = 0; x < LessonDates_LessonDateID.Count(); x++)
            {
                for (int y = 0; y < ScheduledLessons_ScheduledID.Count(); y++)
                {
                    if (LessonDates_ScheduleID[x] == ScheduledLessons_ScheduledID[y])
                    {
                        Desired_ScheduleID.Add(LessonDates_LessonDateID[x]);
                        Desired_StudentID.Add(ScheduledLessons_StudentID[y]);
                        Desired_TeacherID.Add(ScheduledLessons_TeacherID[y]);
                        Display_Date.Add(LessonDates_Dates[x]);
                        Display_Attended.Add(LessonDates_Attended[x]);
                        Display_PurchaseID.Add(ScheduledLessons_PurchasedID[y]);
                        Display_Time.Add(ScheduledLessons_Time[y]);
                    }
                }
            }

            for (int x = 0; x < Display_Date.Count(); x++)
            {
                Date = Display_Date[x];
                Day = Date.DayOfWeek.ToString();

                Display_Day.Add(Day);
            }

            if (Student == true)
            {
                for (int x = 0; x < Desired_StudentID.Count(); x++)
                {
                    for (int y = 0; y < Students_StudentID.Count(); y++)
                    {
                        if (Desired_StudentID[x] == Students_StudentID[y])
                        {
                            Display_Name.Add(Students_FullName[y]);
                        }
                    }
                }
            }
            else if (Student == false)
            {
                for (int x = 0; x < Desired_TeacherID.Count(); x++)
                {
                    for (int y = 0; y < Teacher_TeacherID.Count(); y++)
                    {
                        if (Desired_TeacherID[x] == Teacher_TeacherID[y])
                        {
                            Display_Name.Add(Teacher_FullName[y]);
                        }
                    }
                }
            }
        }

        public void Display_DisplayInformation()
        {
            // Calculate total pages needed
            if (PageTest.Count() > 0)
            {
                PageTest.Clear();
            }

            for (int x = 0; x < Display_LessonID.Count(); x++)
            {
                PageTest.Add(1);
            }


            if (AssignPageNumber == false)
            {
                while (PageTest.Count() >= 6)
                {
                    for (int x = 0; x < 6; x++)
                    {
                        PageTest.RemoveAt(0);
                    }
                    TotalPages++;
                }

                if (PageTest.Count() > 0)
                {
                    Additional_Records = PageTest.Count();
                }

                PageIndexReference = (SelectedPage * StandardPageIncrment);
                PageIndexReference = PageIndexReference - 1;
            }

            label1.Text = (SelectedPage + " / " + TotalPages);


            if (TotalPages > 0 && Additional_Records == 0)
            {
                if (Displays[0] == false)
                {
                    // 1st Display
                    lblLessonID1.Show();
                    lblEntityName1.Show();
                    lblPurchasedLessonID1.Show();
                    lblStartDate1.Show();
                    lblBookedDays1.Show();
                    lblBookedTime1.Show();
                    checkAttended1.Show();
                    pbDisplay1.Show();

                    lblLessonID1.Text = Display_LessonID[(PageIndexReference - 5)].ToString();
                    lblEntityName1.Text = Display_Name[(PageIndexReference - 5)];
                    lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 5)].ToString();
                    lblStartDate1.Text = Display_Date[(PageIndexReference - 5)].ToString();
                    lblBookedDays1.Text = Display_Day[(PageIndexReference - 5)].ToString();
                    lblBookedTime1.Text = Display_Time[(PageIndexReference - 5)].ToString();
                    if (Display_Attended[(PageIndexReference - 5)] == true)
                    {
                        checkAttended1.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended1.CheckState = CheckState.Unchecked;
                    }
                    Displays[0] = true;
                }

                // 2nd Display
                if (Displays[1] == false)
                {
                    lblLessonID2.Show();
                    lblEntityName2.Show();
                    lblPurchasedLessonID2.Show();
                    lblStartDate2.Show();
                    lblBookedDays2.Show();
                    lblBookedTime2.Show();
                    checkAttended2.Show();
                    pbDisplay2.Show();

                    lblLessonID2.Text = Display_LessonID[(PageIndexReference - 4)].ToString();
                    lblEntityName2.Text = Display_Name[(PageIndexReference - 4)];
                    lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference - 4)].ToString();
                    lblStartDate2.Text = Display_Date[(PageIndexReference - 4)].ToString();
                    lblBookedDays2.Text = Display_Day[(PageIndexReference - 4)].ToString();
                    lblBookedTime2.Text = Display_Time[(PageIndexReference - 4)].ToString();
                    if (Display_Attended[(PageIndexReference - 4)] == true)
                    {
                        checkAttended2.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended2.CheckState = CheckState.Unchecked;
                    }
                    Displays[1] = true;
                }


                // 3rd Display
                if (Displays[2] == false)
                {
                    lblLessonID3.Show();
                    lblEntityName3.Show();
                    lblPurchasedLessonID3.Show();
                    lblStartDate3.Show();
                    lblBookedDays3.Show();
                    lblBookedTime3.Show();
                    checkAttended3.Show();
                    pbDisplay3.Show();

                    lblLessonID3.Text = Display_LessonID[(PageIndexReference - 3)].ToString();
                    lblEntityName3.Text = Display_Name[(PageIndexReference - 3)];
                    lblPurchasedLessonID3.Text = Display_PurchaseID[(PageIndexReference - 3)].ToString();
                    lblStartDate3.Text = Display_Date[(PageIndexReference - 3)].ToString();
                    lblBookedDays3.Text = Display_Day[(PageIndexReference - 3)].ToString();
                    lblBookedTime3.Text = Display_Time[(PageIndexReference - 3)].ToString();
                    if (Display_Attended[(PageIndexReference - 3)] == true)
                    {
                        checkAttended3.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended3.CheckState = CheckState.Unchecked;
                    }
                    Displays[2] = true;
                }


                // 4th Display
                if (Displays[3] == false)
                {
                    lblLessonID4.Show();
                    lblEntityName4.Show();
                    lblPurchasedLessonID4.Show();
                    lblStartDate4.Show();
                    lblBookedDays4.Show();
                    lblBookedTime4.Show();
                    checkAttended4.Show();
                    pbDisplay4.Show();

                    lblLessonID4.Text = Display_LessonID[(PageIndexReference - 2)].ToString();
                    lblEntityName4.Text = Display_Name[(PageIndexReference - 2)];
                    lblPurchasedLessonID4.Text = Display_PurchaseID[(PageIndexReference - 2)].ToString();
                    lblStartDate4.Text = Display_Date[(PageIndexReference - 2)].ToString();
                    lblBookedDays4.Text = Display_Day[(PageIndexReference - 2)].ToString();
                    lblBookedTime4.Text = Display_Time[(PageIndexReference - 2)].ToString();
                    if (Display_Attended[(PageIndexReference - 2)] == true)
                    {
                        checkAttended4.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended4.CheckState = CheckState.Unchecked;
                    }
                    Displays[3] = true;
                }


                // 5th Display
                if (Displays[4] == false)
                {
                    lblLessonID5.Show();
                    lblEntityName5.Show();
                    lblPurchasedLessonID5.Show();
                    lblStartDate5.Show();
                    lblBookedDays5.Show();
                    lblBookedTime5.Show();
                    checkAttended5.Show();
                    pbDisplay5.Show();

                    lblLessonID5.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                    lblEntityName5.Text = Display_Name[(PageIndexReference - 1)];
                    lblPurchasedLessonID5.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                    lblStartDate5.Text = Display_Date[(PageIndexReference - 1)].ToString();
                    lblBookedDays5.Text = Display_Day[(PageIndexReference - 1)].ToString();
                    lblBookedTime5.Text = Display_Time[(PageIndexReference - 1)].ToString();
                    if (Display_Attended[(PageIndexReference - 1)] == true)
                    {
                        checkAttended5.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended5.CheckState = CheckState.Unchecked;
                    }
                    Displays[4] = true;
                }


                // 6th Display
                if (Displays[5] == false)
                {
                    lblLessonID6.Show();
                    lblEntityName6.Show();
                    lblPurchasedLessonID6.Show();
                    lblStartDate6.Show();
                    lblBookedDays6.Show();
                    lblBookedTime6.Show();
                    checkAttended6.Show();
                    pbDisplay6.Show();

                    lblLessonID6.Text = Display_LessonID[PageIndexReference].ToString();
                    lblEntityName6.Text = Display_Name[PageIndexReference];
                    lblPurchasedLessonID6.Text = Display_PurchaseID[PageIndexReference].ToString();
                    lblStartDate6.Text = Display_Date[PageIndexReference].ToString();
                    lblBookedDays6.Text = Display_Day[PageIndexReference].ToString();
                    lblBookedTime6.Text = Display_Time[PageIndexReference].ToString();
                    if (Display_Attended[PageIndexReference] == true)
                    {
                        checkAttended6.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended6.CheckState = CheckState.Unchecked;
                    }
                    Displays[5] = true;
                }
                AssignPageNumber = true;
            }
            else if (TotalPages > 0 && Additional_Records > 0)
            {
                if (Displays[0] == false)
                {
                    // 1st Display
                    lblLessonID1.Show();
                    lblEntityName1.Show();
                    lblPurchasedLessonID1.Show();
                    lblStartDate1.Show();
                    lblBookedDays1.Show();
                    lblBookedTime1.Show();
                    checkAttended1.Show();
                    pbDisplay1.Show();

                    lblLessonID1.Text = Display_LessonID[(PageIndexReference - 5)].ToString();
                    lblEntityName1.Text = Display_Name[(PageIndexReference - 5)];
                    lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 5)].ToString();
                    lblStartDate1.Text = Display_Date[(PageIndexReference - 5)].ToString();
                    lblBookedDays1.Text = Display_Day[(PageIndexReference - 5)].ToString();
                    lblBookedTime1.Text = Display_Time[(PageIndexReference - 5)].ToString();
                    if (Display_Attended[(PageIndexReference - 5)] == true)
                    {
                        checkAttended1.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended1.CheckState = CheckState.Unchecked;
                    }
                    Displays[0] = true;
                }

                // 2nd Display
                if (Displays[1] == false)
                {
                    lblLessonID2.Show();
                    lblEntityName2.Show();
                    lblPurchasedLessonID2.Show();
                    lblStartDate2.Show();
                    lblBookedDays2.Show();
                    lblBookedTime2.Show();
                    checkAttended2.Show();
                    pbDisplay2.Show();

                    lblLessonID2.Text = Display_LessonID[(PageIndexReference - 4)].ToString();
                    lblEntityName2.Text = Display_Name[(PageIndexReference - 4)];
                    lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference - 4)].ToString();
                    lblStartDate2.Text = Display_Date[(PageIndexReference - 4)].ToString();
                    lblBookedDays2.Text = Display_Day[(PageIndexReference - 4)].ToString();
                    lblBookedTime2.Text = Display_Time[(PageIndexReference - 4)].ToString();
                    if (Display_Attended[(PageIndexReference - 4)] == true)
                    {
                        checkAttended2.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended2.CheckState = CheckState.Unchecked;
                    }
                    Displays[1] = true;
                }


                // 3rd Display
                if (Displays[2] == false)
                {
                    lblLessonID3.Show();
                    lblEntityName3.Show();
                    lblPurchasedLessonID3.Show();
                    lblStartDate3.Show();
                    lblBookedDays3.Show();
                    lblBookedTime3.Show();
                    checkAttended3.Show();
                    pbDisplay3.Show();

                    lblLessonID3.Text = Display_LessonID[(PageIndexReference - 3)].ToString();
                    lblEntityName3.Text = Display_Name[(PageIndexReference - 3)];
                    lblPurchasedLessonID3.Text = Display_PurchaseID[(PageIndexReference - 3)].ToString();
                    lblStartDate3.Text = Display_Date[(PageIndexReference - 3)].ToString();
                    lblBookedDays3.Text = Display_Day[(PageIndexReference - 3)].ToString();
                    lblBookedTime3.Text = Display_Time[(PageIndexReference - 3)].ToString();
                    if (Display_Attended[(PageIndexReference - 3)] == true)
                    {
                        checkAttended3.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended3.CheckState = CheckState.Unchecked;
                    }
                    Displays[2] = true;
                }


                // 4th Display
                if (Displays[3] == false)
                {
                    lblLessonID4.Show();
                    lblEntityName4.Show();
                    lblPurchasedLessonID4.Show();
                    lblStartDate4.Show();
                    lblBookedDays4.Show();
                    lblBookedTime4.Show();
                    checkAttended4.Show();
                    pbDisplay4.Show();

                    lblLessonID4.Text = Display_LessonID[(PageIndexReference - 2)].ToString();
                    lblEntityName4.Text = Display_Name[(PageIndexReference - 2)];
                    lblPurchasedLessonID4.Text = Display_PurchaseID[(PageIndexReference - 2)].ToString();
                    lblStartDate4.Text = Display_Date[(PageIndexReference - 2)].ToString();
                    lblBookedDays4.Text = Display_Day[(PageIndexReference - 2)].ToString();
                    lblBookedTime4.Text = Display_Time[(PageIndexReference - 2)].ToString();
                    if (Display_Attended[(PageIndexReference - 2)] == true)
                    {
                        checkAttended4.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended4.CheckState = CheckState.Unchecked;
                    }
                    Displays[3] = true;
                }


                // 5th Display
                if (Displays[4] == false)
                {
                    lblLessonID5.Show();
                    lblEntityName5.Show();
                    lblPurchasedLessonID5.Show();
                    lblStartDate5.Show();
                    lblBookedDays5.Show();
                    lblBookedTime5.Show();
                    checkAttended5.Show();
                    pbDisplay5.Show();

                    lblLessonID5.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                    lblEntityName5.Text = Display_Name[(PageIndexReference - 1)];
                    lblPurchasedLessonID5.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                    lblStartDate5.Text = Display_Date[(PageIndexReference - 1)].ToString();
                    lblBookedDays5.Text = Display_Day[(PageIndexReference - 1)].ToString();
                    lblBookedTime5.Text = Display_Time[(PageIndexReference - 1)].ToString();
                    if (Display_Attended[(PageIndexReference - 1)] == true)
                    {
                        checkAttended5.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended5.CheckState = CheckState.Unchecked;
                    }
                    Displays[4] = true;
                }


                // 6th Display
                if (Displays[5] == false)
                {
                    lblLessonID6.Show();
                    lblEntityName6.Show();
                    lblPurchasedLessonID6.Show();
                    lblStartDate6.Show();
                    lblBookedDays6.Show();
                    lblBookedTime6.Show();
                    checkAttended6.Show();
                    pbDisplay6.Show();

                    lblLessonID6.Text = Display_LessonID[PageIndexReference].ToString();
                    lblEntityName6.Text = Display_Name[PageIndexReference];
                    lblPurchasedLessonID6.Text = Display_PurchaseID[PageIndexReference].ToString();
                    lblStartDate6.Text = Display_Date[PageIndexReference].ToString();
                    lblBookedDays6.Text = Display_Day[PageIndexReference].ToString();
                    lblBookedTime6.Text = Display_Time[PageIndexReference].ToString();
                    if (Display_Attended[PageIndexReference] == true)
                    {
                        checkAttended6.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkAttended6.CheckState = CheckState.Unchecked;
                    }
                    Displays[5] = true;
                }

                Display_DisplayInformation_Extra();
                AssignPageNumber = true;
            }
            else if (TotalPages == 0 && Additional_Records > 0)
            {
                Display_DisplayInformation_Extra();
                AssignPageNumber = true;
            }
        }


        public void Display_DisplayInformation_Extra()
        {
            if (AssignPageNumber == false)
            {

                PageIndexReference = PageIndexReference + Additional_Records;
                TotalPages += 1;

                if (TotalPages == 1)
                {
                    PageIndexReference -= 6;
                }
            }



           
            if (SelectedPage == TotalPages)
            {
                if (Additional_Records == 5)
                {
                    if (Displays[0] == false)
                    {
                        // 1st Display
                        lblLessonID1.Show();
                        lblEntityName1.Show();
                        lblPurchasedLessonID1.Show();
                        lblStartDate1.Show();
                        lblBookedDays1.Show();
                        lblBookedTime1.Show();
                        checkAttended1.Show();
                        pbDisplay1.Show();

                        lblLessonID1.Text = Display_LessonID[(PageIndexReference - 4)].ToString();
                        lblEntityName1.Text = Display_Name[(PageIndexReference - 4)];
                        lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 4)].ToString();
                        lblStartDate1.Text = Display_Date[(PageIndexReference - 4)].ToString();
                        lblBookedDays1.Text = Display_Day[(PageIndexReference - 4)].ToString();
                        lblBookedTime1.Text = Display_Time[(PageIndexReference - 4)].ToString();
                        if (Display_Attended[(PageIndexReference - 4)] == true)
                        {
                            checkAttended1.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended1.CheckState = CheckState.Unchecked;
                        }
                        Displays[0] = true;
                    }
                    // 2nd Display
                    if (Displays[1] == false)
                    {
                        lblLessonID2.Show();
                        lblEntityName2.Show();
                        lblPurchasedLessonID2.Show();
                        lblStartDate2.Show();
                        lblBookedDays2.Show();
                        lblBookedTime2.Show();
                        checkAttended2.Show();
                        pbDisplay2.Show();

                        lblLessonID2.Text = Display_LessonID[(PageIndexReference - 3)].ToString();
                        lblEntityName2.Text = Display_Name[(PageIndexReference - 3)];
                        lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference - 3)].ToString();
                        lblStartDate2.Text = Display_Date[(PageIndexReference - 3)].ToString();
                        lblBookedDays2.Text = Display_Day[(PageIndexReference - 3)].ToString();
                        lblBookedTime2.Text = Display_Time[(PageIndexReference - 3)].ToString();
                        if (Display_Attended[(PageIndexReference - 3)] == true)
                        {
                            checkAttended2.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended2.CheckState = CheckState.Unchecked;
                        }
                        Displays[1] = true;
                    }
                    // 3rd Display
                    if (Displays[2] == false)
                    {
                        lblLessonID3.Show();
                        lblEntityName3.Show();
                        lblPurchasedLessonID3.Show();
                        lblStartDate3.Show();
                        lblBookedDays3.Show();
                        lblBookedTime3.Show();
                        checkAttended3.Show();
                        pbDisplay3.Show();

                        lblLessonID3.Text = Display_LessonID[(PageIndexReference - 2)].ToString();
                        lblEntityName3.Text = Display_Name[(PageIndexReference - 2)];
                        lblPurchasedLessonID3.Text = Display_PurchaseID[(PageIndexReference - 2)].ToString();
                        lblStartDate3.Text = Display_Date[(PageIndexReference - 2)].ToString();
                        lblBookedDays3.Text = Display_Day[(PageIndexReference - 2)].ToString();
                        lblBookedTime3.Text = Display_Time[(PageIndexReference - 2)].ToString();
                        if (Display_Attended[(PageIndexReference - 2)] == true)
                        {
                            checkAttended3.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended3.CheckState = CheckState.Unchecked;
                        }
                        Displays[2] = true;
                    }
                    // 4th Display
                    if (Displays[3] == false)
                    {
                        lblLessonID4.Show();
                        lblEntityName4.Show();
                        lblPurchasedLessonID4.Show();
                        lblStartDate4.Show();
                        lblBookedDays4.Show();
                        lblBookedTime4.Show();
                        checkAttended4.Show();
                        pbDisplay4.Show();

                        lblLessonID4.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                        lblEntityName4.Text = Display_Name[(PageIndexReference - 1)];
                        lblPurchasedLessonID4.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                        lblStartDate4.Text = Display_Date[(PageIndexReference - 1)].ToString();
                        lblBookedDays4.Text = Display_Day[(PageIndexReference - 1)].ToString();
                        lblBookedTime4.Text = Display_Time[(PageIndexReference - 1)].ToString();
                        if (Display_Attended[(PageIndexReference - 1)] == true)
                        {
                            checkAttended4.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended4.CheckState = CheckState.Unchecked;
                        }
                        Displays[3] = true;
                    }
                    // 5th Display
                    if (Displays[4] == false)
                    {
                        lblLessonID5.Show();
                        lblEntityName5.Show();
                        lblPurchasedLessonID5.Show();
                        lblStartDate5.Show();
                        lblBookedDays5.Show();
                        lblBookedTime5.Show();
                        checkAttended5.Show();
                        pbDisplay5.Show();

                        lblLessonID5.Text = Display_LessonID[(PageIndexReference)].ToString();
                        lblEntityName5.Text = Display_Name[(PageIndexReference)];
                        lblPurchasedLessonID5.Text = Display_PurchaseID[(PageIndexReference)].ToString();
                        lblStartDate5.Text = Display_Date[(PageIndexReference)].ToString();
                        lblBookedDays5.Text = Display_Day[(PageIndexReference)].ToString();
                        lblBookedTime5.Text = Display_Time[(PageIndexReference)].ToString();
                        if (Display_Attended[(PageIndexReference)] == true)
                        {
                            checkAttended5.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended5.CheckState = CheckState.Unchecked;
                        }
                        Displays[4] = true;
                    }


                }

                else if (Additional_Records == 4)
                {
                    if (Displays[0] == false)
                    {
                        // 1st Display
                        lblLessonID1.Show();
                        lblEntityName1.Show();
                        lblPurchasedLessonID1.Show();
                        lblStartDate1.Show();
                        lblBookedDays1.Show();
                        lblBookedTime1.Show();
                        checkAttended1.Show();
                        pbDisplay1.Show();

                        lblLessonID1.Text = Display_LessonID[(PageIndexReference - 3)].ToString();
                        lblEntityName1.Text = Display_Name[(PageIndexReference - 3)];
                        lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 3)].ToString();
                        lblStartDate1.Text = Display_Date[(PageIndexReference - 3)].ToString();
                        lblBookedDays1.Text = Display_Day[(PageIndexReference - 3)].ToString();
                        lblBookedTime1.Text = Display_Time[(PageIndexReference - 3)].ToString();
                        if (Display_Attended[(PageIndexReference - 3)] == true)
                        {
                            checkAttended1.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended1.CheckState = CheckState.Unchecked;
                        }
                        Displays[0] = true;
                    }
                    // 2nd Display
                    if (Displays[1] == false)
                    {
                        lblLessonID2.Show();
                        lblEntityName2.Show();
                        lblPurchasedLessonID2.Show();
                        lblStartDate2.Show();
                        lblBookedDays2.Show();
                        lblBookedTime2.Show();
                        checkAttended2.Show();
                        pbDisplay2.Show();

                        lblLessonID2.Text = Display_LessonID[(PageIndexReference - 2)].ToString();
                        lblEntityName2.Text = Display_Name[(PageIndexReference - 2)];
                        lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference - 2)].ToString();
                        lblStartDate2.Text = Display_Date[(PageIndexReference - 2)].ToString();
                        lblBookedDays2.Text = Display_Day[(PageIndexReference - 2)].ToString();
                        lblBookedTime2.Text = Display_Time[(PageIndexReference - 2)].ToString();
                        if (Display_Attended[(PageIndexReference - 2)] == true)
                        {
                            checkAttended2.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended2.CheckState = CheckState.Unchecked;
                        }
                        Displays[1] = true;
                    }
                    // 3rd Display
                    if (Displays[2] == false)
                    {
                        lblLessonID3.Show();
                        lblEntityName3.Show();
                        lblPurchasedLessonID3.Show();
                        lblStartDate3.Show();
                        lblBookedDays3.Show();
                        lblBookedTime3.Show();
                        checkAttended3.Show();
                        pbDisplay3.Show();

                        lblLessonID3.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                        lblEntityName3.Text = Display_Name[(PageIndexReference - 1)];
                        lblPurchasedLessonID3.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                        lblStartDate3.Text = Display_Date[(PageIndexReference - 1)].ToString();
                        lblBookedDays3.Text = Display_Day[(PageIndexReference - 1)].ToString();
                        lblBookedTime3.Text = Display_Time[(PageIndexReference - 1)].ToString();
                        if (Display_Attended[(PageIndexReference - 1)] == true)
                        {
                            checkAttended3.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended3.CheckState = CheckState.Unchecked;
                        }
                        Displays[2] = true;
                    }
                    // 4th Display
                    if (Displays[3] == false)
                    {
                        lblLessonID4.Show();
                        lblEntityName4.Show();
                        lblPurchasedLessonID4.Show();
                        lblStartDate4.Show();
                        lblBookedDays4.Show();
                        lblBookedTime4.Show();
                        checkAttended4.Show();
                        pbDisplay4.Show();

                        lblLessonID4.Text = Display_LessonID[(PageIndexReference)].ToString();
                        lblEntityName4.Text = Display_Name[(PageIndexReference)];
                        lblPurchasedLessonID4.Text = Display_PurchaseID[(PageIndexReference)].ToString();
                        lblStartDate4.Text = Display_Date[(PageIndexReference)].ToString();
                        lblBookedDays4.Text = Display_Day[(PageIndexReference)].ToString();
                        lblBookedTime4.Text = Display_Time[(PageIndexReference)].ToString();
                        if (Display_Attended[(PageIndexReference)] == true)
                        {
                            checkAttended4.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended4.CheckState = CheckState.Unchecked;
                        }
                        Displays[3] = true;
                    }
                }

                else if (Additional_Records == 3)
                {
                    if (Displays[0] == false)
                    {
                        // 1st Display
                        lblLessonID1.Show();
                        lblEntityName1.Show();
                        lblPurchasedLessonID1.Show();
                        lblStartDate1.Show();
                        lblBookedDays1.Show();
                        lblBookedTime1.Show();
                        checkAttended1.Show();
                        pbDisplay1.Show();

                        lblLessonID1.Text = Display_LessonID[(PageIndexReference - 2)].ToString();
                        lblEntityName1.Text = Display_Name[(PageIndexReference - 2)];
                        lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 2)].ToString();
                        lblStartDate1.Text = Display_Date[(PageIndexReference - 2)].ToString();
                        lblBookedDays1.Text = Display_Day[(PageIndexReference - 2)].ToString();
                        lblBookedTime1.Text = Display_Time[(PageIndexReference - 2)].ToString();
                        if (Display_Attended[(PageIndexReference - 2)] == true)
                        {
                            checkAttended1.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended1.CheckState = CheckState.Unchecked;
                        }
                        Displays[0] = true;
                    }
                    // 2nd Display
                    if (Displays[1] == false)
                    {
                        lblLessonID2.Show();
                        lblEntityName2.Show();
                        lblPurchasedLessonID2.Show();
                        lblStartDate2.Show();
                        lblBookedDays2.Show();
                        lblBookedTime2.Show();
                        checkAttended2.Show();
                        pbDisplay2.Show();

                        lblLessonID2.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                        lblEntityName2.Text = Display_Name[(PageIndexReference - 1)];
                        lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                        lblStartDate2.Text = Display_Date[(PageIndexReference - 1)].ToString();
                        lblBookedDays2.Text = Display_Day[(PageIndexReference - 1)].ToString();
                        lblBookedTime2.Text = Display_Time[(PageIndexReference - 1)].ToString();
                        if (Display_Attended[(PageIndexReference - 1)] == true)
                        {
                            checkAttended2.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended2.CheckState = CheckState.Unchecked;
                        }
                        Displays[1] = true;
                    }
                    // 3rd Display
                    if (Displays[2] == false)
                    {
                        lblLessonID3.Show();
                        lblEntityName3.Show();
                        lblPurchasedLessonID3.Show();
                        lblStartDate3.Show();
                        lblBookedDays3.Show();
                        lblBookedTime3.Show();
                        checkAttended3.Show();
                        pbDisplay3.Show();

                        lblLessonID3.Text = Display_LessonID[(PageIndexReference)].ToString();
                        lblEntityName3.Text = Display_Name[(PageIndexReference)];
                        lblPurchasedLessonID3.Text = Display_PurchaseID[(PageIndexReference)].ToString();
                        lblStartDate3.Text = Display_Date[(PageIndexReference)].ToString();
                        lblBookedDays3.Text = Display_Day[(PageIndexReference)].ToString();
                        lblBookedTime3.Text = Display_Time[(PageIndexReference)].ToString();
                        if (Display_Attended[(PageIndexReference)] == true)
                        {
                            checkAttended3.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended3.CheckState = CheckState.Unchecked;
                        }
                        Displays[2] = true;
                    }
                }

                else if (Additional_Records == 2)
                {
                    if (Displays[0] == false)
                    {
                        // 1st Display
                        lblLessonID1.Show();
                        lblEntityName1.Show();
                        lblPurchasedLessonID1.Show();
                        lblStartDate1.Show();
                        lblBookedDays1.Show();
                        lblBookedTime1.Show();
                        checkAttended1.Show();
                        pbDisplay1.Show();

                        lblLessonID1.Text = Display_LessonID[(PageIndexReference - 1)].ToString();
                        lblEntityName1.Text = Display_Name[(PageIndexReference - 1)];
                        lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference - 1)].ToString();
                        lblStartDate1.Text = Display_Date[(PageIndexReference - 1)].ToString();
                        lblBookedDays1.Text = Display_Day[(PageIndexReference - 1)].ToString();
                        lblBookedTime1.Text = Display_Time[(PageIndexReference - 1)].ToString();
                        if (Display_Attended[(PageIndexReference - 1)] == true)
                        {
                            checkAttended1.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended1.CheckState = CheckState.Unchecked;
                        }
                        Displays[0] = true;
                    }
                    // 2nd Display
                    if (Displays[1] == false)
                    {
                        lblLessonID2.Show();
                        lblEntityName2.Show();
                        lblPurchasedLessonID2.Show();
                        lblStartDate2.Show();
                        lblBookedDays2.Show();
                        lblBookedTime2.Show();
                        checkAttended2.Show();
                        pbDisplay2.Show();

                        lblLessonID2.Text = Display_LessonID[(PageIndexReference)].ToString();
                        lblEntityName2.Text = Display_Name[(PageIndexReference)];
                        lblPurchasedLessonID2.Text = Display_PurchaseID[(PageIndexReference)].ToString();
                        lblStartDate2.Text = Display_Date[(PageIndexReference)].ToString();
                        lblBookedDays2.Text = Display_Day[(PageIndexReference)].ToString();
                        lblBookedTime2.Text = Display_Time[(PageIndexReference)].ToString();
                        if (Display_Attended[(PageIndexReference)] == true)
                        {
                            checkAttended2.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended2.CheckState = CheckState.Unchecked;
                        }
                        Displays[1] = true;
                    }
                }

                else if (Additional_Records == 1)
                {
                    if (Displays[0] == false)
                    {
                        // 1st Display
                        lblLessonID1.Show();
                        lblEntityName1.Show();
                        lblPurchasedLessonID1.Show();
                        lblStartDate1.Show();
                        lblBookedDays1.Show();
                        lblBookedTime1.Show();
                        checkAttended1.Show();
                        pbDisplay1.Show();

                        lblLessonID1.Text = Display_LessonID[(PageIndexReference)].ToString();
                        lblEntityName1.Text = Display_Name[(PageIndexReference)];
                        lblPurchasedLessonID1.Text = Display_PurchaseID[(PageIndexReference)].ToString();
                        lblStartDate1.Text = Display_Date[(PageIndexReference)].ToString();
                        lblBookedDays1.Text = Display_Day[(PageIndexReference)].ToString();
                        lblBookedTime1.Text = Display_Time[(PageIndexReference)].ToString();
                        if (Display_Attended[(PageIndexReference)] == true)
                        {
                            checkAttended1.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            checkAttended1.CheckState = CheckState.Unchecked;
                        }
                        Displays[0] = true;
                    }

                }
            }
            PageIndexReference = PageIndexReference - Additional_Records;
            
        }
        



        private void btnNext_Page_Click(object sender, EventArgs e)
        {
            if (SelectedPage > 0 && SelectedPage != TotalPages)
            {
                SelectedPage += 1;
                for (int x = 0; x < Displays.Count(); x++)
                {
                    Displays[x] = false;
                }
            }

            if (SelectedPage == TotalPages && Additional_Records > 0 && AssignPageNumber == true)
            {
                PageIndexReference = (TotalPages - 1);
                PageIndexReference = (PageIndexReference * StandardPageIncrment) + Additional_Records;
                PageIndexReference -= 1;

                Display_DisplayInformation();
                Hide_Displays();
            }

        }

        private void btnPrevious_Page_Click(object sender, EventArgs e)
        {
            if (SelectedPage == TotalPages && Additional_Records > 0 && SelectedPage != 1)
            {
                PageIndexReference = (TotalPages - 1);
                PageIndexReference = (PageIndexReference * StandardPageIncrment);
                PageIndexReference -= 1;
            }

            if (SelectedPage > 1)
            {
                SelectedPage -= 1;
                for (int x = 0; x < Displays.Count(); x++)
                {
                    Displays[x] = false;
                }

                Display_DisplayInformation();
                Hide_Displays();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition MainMenu = new frmPrivateTuition();
            MainMenu.Show();
            this.Close();
        }


        public void Hide_Displays()
        {
            for (int x = 0; x < HideDisplays.Count(); x++)
            {
                HideDisplays[x] = false;
            }




            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName1.Text == Display_Name[x])
                {
                    HideDisplays[0] = true;
                    break;
                }
            }

            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName2.Text == Display_Name[x])
                {
                    HideDisplays[1] = true;
                    break;
                }
            }

            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName3.Text == Display_Name[x])
                {
                    HideDisplays[2] = true;
                    break;
                }
            }
 
            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName4.Text == Display_Name[x])
                {
                    HideDisplays[3] = true;
                    break;
                }
            }

            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName5.Text == Display_Name[x])
                {
                    HideDisplays[4] = true;
                    break;
                }
            }

            for (int x = 0; x < Display_Name.Count(); x++)
            {
                if (lblEntityName6.Text == Display_Name[x])
                {
                    HideDisplays[5] = true;
                    break;
                }
            }


            if (HideDisplays[0] == false)
            {
                Hide_Display1();
                Hide_Display2();
                Hide_Display3();
                Hide_Display4();
                Hide_Display5();
                Hide_Display6();

                lblErrorMessage.Show();
                lblErrorMessage.Location = new Point(264, 339);
                if (Student == true)
                {
                    lblErrorMessage.Text = "No scheduled classes for this Student, within this time period!";
                }
                else
                {
                    lblErrorMessage.Text = "No scheduled classes for this Teacher, within this time period!";
                }
            }
            if (HideDisplays[1] == false)
            {
                Hide_Display2();
                Hide_Display3();
                Hide_Display4();
                Hide_Display5();
                Hide_Display6();
            }
            if (HideDisplays[2] == false)
            {
                Hide_Display3();
                Hide_Display4();
                Hide_Display5();
                Hide_Display6();
            }
            if (HideDisplays[3] == false)
            {
                Hide_Display4();
                Hide_Display5();
                Hide_Display6();
            }
            if (HideDisplays[4] == false)
            {
                Hide_Display5();
                Hide_Display6();
            }
            if (HideDisplays[5] == false)
            {
                Hide_Display6();
            }
        }


        public void Hide_Display1()
        {
            lblLessonID1.Hide();
            lblEntityName1.Hide();
            lblPurchasedLessonID1.Hide();
            lblStartDate1.Hide();
            lblBookedDays1.Hide();
            lblBookedTime1.Hide();
            checkAttended1.Hide();
            pbDisplay1.Hide();
        }
        public void Hide_Display2()
        {
            lblLessonID2.Hide();
            lblEntityName2.Hide();
            lblPurchasedLessonID2.Hide();
            lblStartDate2.Hide();
            lblBookedDays2.Hide();
            lblBookedTime2.Hide();
            checkAttended2.Hide();
            pbDisplay2.Hide();
        }
        public void Hide_Display3()
        {
            lblLessonID3.Hide();
            lblEntityName3.Hide();
            lblPurchasedLessonID3.Hide();
            lblStartDate3.Hide();
            lblBookedDays3.Hide();
            lblBookedTime3.Hide();
            checkAttended3.Hide();
            pbDisplay3.Hide();
        }
        public void Hide_Display4()
        {
            lblLessonID4.Hide();
            lblEntityName4.Hide();
            lblPurchasedLessonID4.Hide();
            lblStartDate4.Hide();
            lblBookedDays4.Hide();
            lblBookedTime4.Hide();
            checkAttended4.Hide();
            pbDisplay4.Hide();
        }
        public void Hide_Display5()
        {
            lblLessonID5.Hide();
            lblEntityName5.Hide();
            lblPurchasedLessonID5.Hide();
            lblStartDate5.Hide();
            lblBookedDays5.Hide();
            lblBookedTime5.Hide();
            checkAttended5.Hide();
            pbDisplay5.Hide();
        }
        public void Hide_Display6()
        {
            lblLessonID6.Hide();
            lblEntityName6.Hide();
            lblPurchasedLessonID6.Hide();
            lblStartDate6.Hide();
            lblBookedDays6.Hide();
            lblBookedTime6.Hide();
            checkAttended6.Hide();
            pbDisplay6.Hide();
        }


    }
}

