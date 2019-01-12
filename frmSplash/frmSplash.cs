using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace frmSplash
{
    public partial class frmSplash : Form
    {
        string LoadMessage; // String will contain text.
        string connectionString;
        SqlConnection connection;
        SqlDataReader DataReader;

        List<int> LessonDates_ID = new List<int>();
        List<int> LessonDates_ScheduleID = new List<int>();
        List<DateTime> LessonDates_Dates = new List<DateTime>();
        List<bool> LessonDates_Attended = new List<bool>();
        List<int> LessonDates_ID_Appending = new List<int>();
        List<int> LessonDates_ScheduleID_Appending = new List<int>();
        List<DateTime> LessonDates_Dates_Appending = new List<DateTime>();
        List<bool> LessonDates_Attended_Appending = new List<bool>();

        List<int> Students_ID = new List<int>();
        List<string> Students_FirstName = new List<string>();
        List<string> Students_OtherNames = new List<string>();
        List<string> Students_Surname = new List<string>();
        List<DateTime> Students_DateOfBirth = new List<DateTime>();
        List<string> Students_Address = new List<string>();
        List<string> Students_Town = new List<string>();
        List<string> Students_PostCode = new List<string>();
        List<string> Students_ContactNumber = new List<string>();
        List<string> Students_EmailAddress = new List<string>();
        List<int> Students_GradeID = new List<int>();
        List<int> Students_InstrumentID = new List<int>();
        List<bool> Students_Payment = new List<bool>();

        List<int> ScheduledLessons_ID = new List<int>();
        List<int> ScheduledLessons_StudentID = new List<int>();
        List<int> ScheduledLessons_TeacherID = new List<int>();
        List<int> ScheduledLessons_PurchasedLessonID = new List<int>();
        List<string> ScheduledLessons_NumberOfWeeks = new List<string>();
        List<DateTime> ScheduledLessons_StartDate = new List<DateTime>();
        List<string> ScheduledLessons_BookedDays = new List<string>();
        List<string> ScheduledLessons_BookedTime = new List<string>();
        List<DateTime> ScheduledLessons_EndDate = new List<DateTime>();

        bool ScheduledLessons_AppendComplete;

        List<string> Reallocation_Students_FirstName = new List<string>();
        List<string> Reallocation_Students_OtherNames = new List<string>();
        List<string> Reallocation_Students_Surname = new List<string>();
        List<DateTime> Reallocation_Students_DateOfBirth = new List<DateTime>();
        List<string> Reallocation_Students_Address = new List<string>();
        List<string> Reallocation_Students_Town = new List<string>();
        List<string> Reallocation_Students_PostCode = new List<string>();
        List<string> Reallocation_Students_ContactNumber = new List<string>();
        List<string> Reallocation_Students_EmailAddress = new List<string>();
        List<int> Reallocation_Students_GradeID = new List<int>();
        List<int> Reallocation_Students_InstrumentID = new List<int>();
        List<bool> Reallocation_Students_Payment = new List<bool>();
        List<int> Rellocation_ScheduleLessonsID = new List<int>();
        List<int> Reallocation_StudentAbsences = new List<int>();
        List<int> Reallocation_LessonDates_ScheduleID = new List<int>();
        List<bool> Reallocation_LessonDates_Attended = new List<bool>();
        List<DateTime> Reallocation_LessonDates_Dates = new List<DateTime>();
        List<int> Reallocation_Desired_ScheduleIDs = new List<int>();
        List<int> Reallocation_Desired_StudentIDs = new List<int>();

        List<int> LessonDate_Archive_ID = new List<int>();
        List<int> LessonDate_Archive_ScheduleID = new List<int>();
        List<DateTime> LessonDate_Archive_Date = new List<DateTime>();
        List<bool> LessonDate_Archive_Attended = new List<bool>();

        DateTime CurrentDate;
        DateTime Reference;
        bool Completed;



        public frmSplash()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;

            // This initalises the clock present within the form.
            tLoad.Start();

            Establish_DataBase_Connection();
            LocalStorage_LessonDates();
            LocalStorage_LessonDate_Archive();
            LocalStorage_ScheduledLessons();
            LocalStorage_Students();
            Schedule_Archive();
            Student_Reallocation();
        }

        // LOAD TIMER
        private void tLoad_Tick(object sender, EventArgs e)
        {
            LoadingBar.Increment(2); // This will cause the loading bar to increase each time the clock ticks.
            UpdateLoadMessage(); // This line of code will run the updateLoadMessage function, each tick.
        }

        // LOADING PROGRESS OUTCOMES
        public void UpdateLoadMessage()
        {
            // This function will be used to identify the progress of the loading bar,
            // and will update the loading message accoridnly.

            if (LoadingBar.Value > 0 && LoadingBar.Value < 25)
            {
                LoadMessage = "Initalising program...";
                
            }
            else if (LoadingBar.Value > 25 && LoadingBar.Value < 75)
            {
                LoadMessage = "Organising files...";
                Archive_Passed_LessonDates();
            }
            else if (LoadingBar.Value > 75)
            {
                LoadMessage = "Finalsing program...";
            }

            if (LoadingBar.Value == 100)
            {
                OpenMenu(); // This line of code is used to run the OpenMenu function.
            }

            lblLoadingProgress.Text = LoadMessage; // Update the label accordinly.
        }

        // ESTABLISH DATABASE CONNECTION
        public void Establish_DataBase_Connection()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Connection Error.");
                }
            }
        }

        // OPEN MAIN MENU
        public void OpenMenu()
        {
            // This function will attempt to open the Main menu.
            if (LoadingBar.Value == 100) // Checks the progress bar.
            {
                tLoad.Stop(); // Disables timer.
                frmMain MainMenu = new frmMain(); // Assigns local value to main form.
                MainMenu.Show(); // Opens Main form.
                this.Hide(); // Closes this form.


            }
        }

        // TEST BUTTON
        private void btnIndex_Click(object sender, EventArgs e)
        {
            // This is merely a testing program.
            GlobalVariables.UserLoggedIn = true;

            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
            tLoad.Stop();
        }

        // CLOSE SYSTEM
        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        // STORE LESSON DATE INFORMATION
        public void LocalStorage_LessonDates()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LessonDates", connection))
                {

                    DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        LessonDates_ID.Add(DataReader.GetInt32(0));
                        LessonDates_ScheduleID.Add(DataReader.GetInt32(1));
                        LessonDates_Dates.Add(DataReader.GetDateTime(2));
                        LessonDates_Attended.Add(DataReader.GetBoolean(3));

                        Reallocation_LessonDates_ScheduleID.Add(DataReader.GetInt32(1));
                        Reallocation_LessonDates_Dates.Add(DataReader.GetDateTime(2));
                        Reallocation_LessonDates_Attended.Add(DataReader.GetBoolean(3));
                    }
                }
            }
        }

        // STORE STUDENT INFORMATION
        public void LocalStorage_Students()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students", connection))
                {

                    DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        Students_ID.Add(DataReader.GetInt32(0));
                        Students_FirstName.Add(DataReader.GetString(1));
                        Students_OtherNames.Add(DataReader.GetString(2));
                        Students_Surname.Add(DataReader.GetString(3));
                        Students_DateOfBirth.Add(DataReader.GetDateTime(4));
                        Students_Address.Add(DataReader.GetString(5));
                        Students_Town.Add(DataReader.GetString(6));
                        Students_PostCode.Add(DataReader.GetString(7));
                        Students_ContactNumber.Add(DataReader.GetString(8));
                        Students_EmailAddress.Add(DataReader.GetString(9));
                        Students_GradeID.Add(DataReader.GetInt32(10));
                        Students_InstrumentID.Add(DataReader.GetInt32(11));
                        Students_Payment.Add(DataReader.GetBoolean(12));
                        Reallocation_StudentAbsences.Add(0);
                    }
                }
            }
        }

        // STORE SCHEDULED LESSONS INFORMATION
        public void LocalStorage_ScheduledLessons()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Scheduled_Lessons", connection))
                {

                    DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        ScheduledLessons_ID.Add(DataReader.GetInt32(0));
                        ScheduledLessons_StudentID.Add(DataReader.GetInt32(1));
                        ScheduledLessons_TeacherID.Add(DataReader.GetInt32(2));
                        ScheduledLessons_PurchasedLessonID.Add(DataReader.GetInt32(3));
                        ScheduledLessons_NumberOfWeeks.Add(DataReader.GetString(4));
                        ScheduledLessons_StartDate.Add(DataReader.GetDateTime(5));
                        ScheduledLessons_BookedDays.Add(DataReader.GetString(6));
                        ScheduledLessons_BookedTime.Add(DataReader.GetString(7));
                        ScheduledLessons_EndDate.Add(DataReader.GetDateTime(8));
                    }
                }
            }
        }

        // STORE LESSON DATE ARCHIVE INFORMATION
        public void LocalStorage_LessonDate_Archive()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LessonDate_Archive", connection))
                {

                    DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        LessonDate_Archive_ID.Add(DataReader.GetInt32(0));
                        LessonDate_Archive_ScheduleID.Add(DataReader.GetInt32(2));
                        LessonDate_Archive_Date.Add(DataReader.GetDateTime(3));
                        LessonDate_Archive_Attended.Add(DataReader.GetBoolean(4));

                        Reallocation_LessonDates_ScheduleID.Add(DataReader.GetInt32(2));
                        Reallocation_LessonDates_Dates.Add(DataReader.GetDateTime(3));
                        Reallocation_LessonDates_Attended.Add(DataReader.GetBoolean(4));
                    }
                }
            }
        }

        // ARCHIVE COMPLETE LESSONS
        public void Archive_Passed_LessonDates()
        {
            if (Completed == false)
            {
                Completed = true;

                for (int x = 0; x < LessonDates_ID.Count(); x++)
                {
                    CurrentDate = DateTime.Today;
                    if (LessonDates_Dates[x] < CurrentDate)
                    {
                        LessonDates_ID_Appending.Add(LessonDates_ID[x]);
                    }
                }

                try
                {
                    for (int x = 0; x < LessonDates_ID_Appending.Count(); x++)
                    {
                        for (int y = 0; y < LessonDates_ID.Count(); y++)
                        {
                            if (LessonDates_ID[y] == LessonDates_ID_Appending[x])
                            {
                                LessonDates_ScheduleID_Appending.Add(LessonDates_ScheduleID[y]);
                                LessonDates_Dates_Appending.Add(LessonDates_Dates[y]);
                                LessonDates_Attended_Appending.Add(LessonDates_Attended[y]);
                            }
                        }
                    }



                    for (int x = 0; x < LessonDates_ID_Appending.Count(); x++)
                    {
                        using (connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO LessonDate_Archive (LessonDatesID, ScheduleID, Date, Attended) VALUES (@LessonDateID, @ScheduleID, @Date, @Attended)", connection))
                            {
                                cmd.Parameters.AddWithValue("@LessonDateID", LessonDates_ID_Appending[x]);
                                cmd.Parameters.AddWithValue("@ScheduleID", LessonDates_ScheduleID[x]);
                                cmd.Parameters.AddWithValue("@Date", LessonDates_Dates_Appending[x]);
                                cmd.Parameters.AddWithValue("@Attended", LessonDates_Attended_Appending[x]);

                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cnd = new SqlCommand("DELETE FROM LessonDates WHERE LessonDatesID = @LessonDateID", connection))
                            {
                                cnd.Parameters.AddWithValue("@LessonDateID", LessonDates_ID_Appending[x]);

                                cnd.ExecuteNonQuery();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }

                Archieve_Clear_OldRecords();
                Archieve_Clear_OldRecords();
            }
        }

        // CLEAR OLD ARCHIVED LESSON DATES
        public void Archieve_Clear_OldRecords()
        {
            CurrentDate = DateTime.Today;
            CurrentDate = CurrentDate.AddMonths(-2);

            for (int x = 0; x < LessonDate_Archive_ID.Count(); x++)
            {
                if (LessonDate_Archive_Date[x] < CurrentDate)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cnd = new SqlCommand("DELETE FROM LessonDate_Archive WHERE LessonDates_ArchiveID = @LessonDateID", connection))
                        {
                            connection.Open();
                            cnd.Parameters.AddWithValue("@LessonDateID", LessonDate_Archive_ID[x]);

                            cnd.ExecuteNonQuery();
                        }
                    }
                }
            }

        }

        // REALLOCATE STUDENTS
        public void Student_Reallocation()
        {
            CurrentDate = DateTime.Today;
            Reference = CurrentDate;
            CurrentDate = CurrentDate.AddMonths(-1);

            // Identify lesson values which have been completed within the last month.
            for (int x = 0; x < Reallocation_LessonDates_ScheduleID.Count(); x++)
            {
                // Any lessons that fall outside of the previous month, will be removed from storage.
                // This essentially means that they will not be checked.
                if (Reallocation_LessonDates_Dates[x] < CurrentDate || Reallocation_LessonDates_Dates[x] > Reference)
                {
                    Reallocation_LessonDates_ScheduleID.RemoveAt(x);
                    Reallocation_LessonDates_Dates.RemoveAt(x);
                    Reallocation_LessonDates_Attended.RemoveAt(x);
                    x -= 1;
                }

            }

            for (int x = 0; x < Reallocation_LessonDates_ScheduleID.Count(); x++)
            {
                for (int y = 0; y < ScheduledLessons_ID.Count(); y++)
                {
                    if (Reallocation_LessonDates_ScheduleID[x] == ScheduledLessons_ID[y])
                    {
                        Reallocation_Desired_ScheduleIDs.Add(Reallocation_LessonDates_ScheduleID[x]);

                    }
                }
            }

            for (int x = 0; x < ScheduledLessons_ID.Count(); x++)
            {
                for (int y = 0; y < Reallocation_Desired_ScheduleIDs.Count(); y++)
                {
                    if (ScheduledLessons_ID[x] == Reallocation_Desired_ScheduleIDs[y])
                    {
                        Reallocation_Desired_StudentIDs.Add(ScheduledLessons_StudentID[x]);
                    }
                }
            }

            for (int x = 0; x < Reallocation_Desired_StudentIDs.Count(); x++)
            {
                for (int y = 0; y < Students_ID.Count(); y++)
                {
                    if (Reallocation_Desired_StudentIDs[x] == Students_ID[y])
                    {
                        Reallocation_StudentAbsences[y] += 1;
                    }
    
                }
            }

            int r = 0;
            for (int x = 0; x < Reallocation_Desired_StudentIDs.Count(); x++)
            {
                while (r < Students_ID.Count())
                {
                    if (Reallocation_StudentAbsences[r] > 3)
                    {
                        Reallocation_Students_FirstName.Add(Students_FirstName[r]);
                        Reallocation_Students_OtherNames.Add(Students_OtherNames[r]);
                        Reallocation_Students_Surname.Add(Students_Surname[r]);
                        Reallocation_Students_DateOfBirth.Add(Students_DateOfBirth[r]);
                        Reallocation_Students_Address.Add(Students_Address[r]);
                        Reallocation_Students_Town.Add(Students_Town[r]);
                        Reallocation_Students_PostCode.Add(Students_PostCode[r]);
                        Reallocation_Students_ContactNumber.Add(Students_ContactNumber[r]);
                        Reallocation_Students_EmailAddress.Add(Students_EmailAddress[r]);
                        Reallocation_Students_GradeID.Add(Students_GradeID[r]);
                        Reallocation_Students_InstrumentID.Add(Students_InstrumentID[r]);
                        Reallocation_Students_Payment.Add(Students_Payment[r]);
                        r++;
                    }
                    else
                    {
                        r++;
                    }
                }
            }

            //
            //
            //
            //
            //


        }

        // SCHEDULE ARCHIVE
        public void Schedule_Archive()
        {
            CurrentDate = DateTime.Today;
            for (int x = 0; x < ScheduledLessons_ID.Count(); x++)
            {
                ScheduledLessons_AppendComplete = false;

                if (ScheduledLessons_EndDate[x] < CurrentDate)
                {
                    if (ScheduledLessons_EndDate != null && ScheduledLessons_StartDate != null)
                    {

                        using (connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Archive_ScheduledLessons (ScheduleID, StudentID, TeacherID, Purchased_LessonID, Number_Of_Weeks, Start_Date, Booked_Days, Booked_Time, End_Date) VALUES (@ScheduleID, @StudentID, @TeacherID, @Purchased_LessonsID, @Number_Of_Weeks, @Start_Date, @Booked_Days, @Booked_Time, @End_Date)", connection))
                            {
                                cmd.Parameters.AddWithValue("@ScheduleID", ScheduledLessons_ID[x]);
                                cmd.Parameters.AddWithValue("@StudentID", ScheduledLessons_StudentID[x]);
                                cmd.Parameters.AddWithValue("@TeacherID", ScheduledLessons_TeacherID[x]);
                                cmd.Parameters.AddWithValue("@Purchased_LessonsID", ScheduledLessons_PurchasedLessonID[x]);
                                cmd.Parameters.AddWithValue("@Number_Of_Weeks", ScheduledLessons_NumberOfWeeks[x]);
                                cmd.Parameters.AddWithValue("@Start_Date", ScheduledLessons_StartDate[x]);
                                cmd.Parameters.AddWithValue("@Booked_Days", ScheduledLessons_BookedDays[x]);
                                cmd.Parameters.AddWithValue("@Booked_Time", ScheduledLessons_BookedTime[x]);
                                cmd.Parameters.AddWithValue("@End_Date", ScheduledLessons_EndDate[x]);

                                cmd.ExecuteNonQuery();
                                ScheduledLessons_AppendComplete = true;
                            }

                            if (ScheduledLessons_AppendComplete == true)
                            {
                                using (SqlCommand cnd = new SqlCommand("DELETE FROM Scheduled_Lessons WHERE ScheduleID = @ScheduleID", connection))
                                {
                                    cnd.Parameters.AddWithValue("@ScheduleID", ScheduledLessons_ID[x]);

                                    cnd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (SqlCommand cnd = new SqlCommand("DELETE FROM Archive_ScheduledLessons WHERE ScheduleID = @ScheduleID", connection))
                                {
                                    cnd.Parameters.AddWithValue("@ScheduleID", ScheduledLessons_ID[x]);

                                    cnd.ExecuteNonQuery();
                                    MessageBox.Show("Archive Failed");
                                }
                            }
                        }

                    }
                }
            }
        }







    }





    
}


