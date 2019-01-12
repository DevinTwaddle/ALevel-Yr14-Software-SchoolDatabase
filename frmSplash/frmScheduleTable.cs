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
    public partial class frmScheduleTable : Form
    {
        SqlConnection connection;
        string connectionString;
        int CurrentStudentID;
        int MinStudentID;
        int MaxStudentID;
        SqlDataReader DataReader;
        List<int> AllStudentIDs = new List<int>();
        List<string> AllStudent_FirstNames = new List<string>();
        List<string> AllStudent_Surnames = new List<string>();
        List<string> AllStudent_FullNameValues = new List<string>();
        string SearchedStudent;
        char SearchTest;
        string Search_FirstName;
        string Search_Surname;
        List<int> StudentID_FirstNameMatches = new List<int>();
        List<int> StudentID_SurnameMatches = new List<int>();
        int Search_DesiredStudentID;
        bool Firstdisplay;

        List<int> Schedule_ID = new List<int>();
        List<int> Schedule_StudentID = new List<int>();
        List<int> Schedule_TeacherID = new List<int>();
        List<int> Schedule_BundleID = new List<int>();
        List<string> Schedule_Weeks = new List<string>();
        List<DateTime> Schedule_StartDate = new List<DateTime>();
        List<string> Schedule_BookedDays = new List<string>();
        List<string> Schedule_BookedTime = new List<string>();
        List<DateTime> Schedule_EndDate = new List<DateTime>();


        public frmScheduleTable()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmScheduleTable_Load(object sender, EventArgs e)
        {
            btnCalendarReturn.Hide();
            DisplayStudentDetails();
            DisplayTeacherDetails();
            DisplayScheduleDetails();
            DisplayGradeDetails();
            StoreScheduleInformation();

            if (GlobalVariables.CalendarReturn == true)
            {
                btnCalendarReturn.Show();
            }

            if (GlobalVariables.CalenderStudentID != 0)
            {
                lbStudentID.Text = GlobalVariables.CalenderStudentID.ToString();
                lbScheduledLessons.Text = GlobalVariables.CalenderScheduledID.ToString();
            }

        }

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            GlobalVariables.CalendarReturn = false;
            frmPrivateTuition PrivateTuition = new frmPrivateTuition();
            PrivateTuition.Show();
            this.Hide();
        }

        // ADD RECORD
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "ScheduledLessonTable";
            GlobalVariables.Purpose = "Add";

            frmAddField Addscheudle = new frmAddField();
            Addscheudle.Show();
            this.Hide();
        }

        // DISPLAY SCHEDULE INFORMATION
        public void DisplayScheduleDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Scheduled_Lessons WHERE StudentID = @Value", connection))
            {
                command.Parameters.Add(new SqlParameter("@value", lbStudentID.Text));

                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable ScheduledDetails = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(ScheduledDetails);

                    lbTeacherID.DisplayMember = "TeacherID";
                    lbTeacherID.ValueMember = "ScheduleID";
                    lbTeacherID.DataSource = ScheduledDetails;

                    lbScheduledLessons.DisplayMember = "ScheduleID";
                    lbScheduledLessons.ValueMember = "ScheduleID";
                    lbScheduledLessons.DataSource = ScheduledDetails;

                    dataGridView1.DataSource = ScheduledDetails;
                }
            }

        }

        // DISPLAY STUDENT INFORMATION
        public void DisplayStudentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students ORDER BY First_Name", connection))
            {
                DataTable StudentTable = new DataTable();
                adaptor.Fill(StudentTable);

                lbStudentID.DisplayMember = "StudentID";
                lbStudentID.ValueMember = "StudentID";
                lbStudentID.DataSource = StudentTable;

                lbFirstName.DisplayMember = "First_Name";
                lbFirstName.ValueMember = "StudentID";
                lbFirstName.DataSource = StudentTable;

                lbSurname.DisplayMember = "Surname";
                lbSurname.ValueMember = "StudentID";
                lbSurname.DataSource = StudentTable;

                lbContactNumber.DisplayMember = "Contact_Number";
                lbContactNumber.ValueMember = "StudentID";
                lbContactNumber.DataSource = StudentTable;

                lbGradeID.DisplayMember = "GradeID";
                lbGradeID.ValueMember = "StudentID";
                lbGradeID.DataSource = StudentTable;

                using (connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand Max = new SqlCommand("SELECT MAX(StudentID) FROM Students", connection))
                    {
                        connection.Open();
                        MaxStudentID = (int)Max.ExecuteScalar();
                        connection.Close();
                    }

                    using (connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand Min = new SqlCommand("Select Min(StudentID) FROM Students", connection))
                        {
                            connection.Open();
                            MinStudentID = (int)Min.ExecuteScalar();
                            connection.Close();
                        }

                        StoreAllStudentIDs();
                        Fill_StudentSearchBox();
                    }
                }
            }
        }

        public void StoreScheduleInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * FROM Scheduled_Lessons", connection))
                {
                    connection.Open();
                    DataReader = cmd.ExecuteReader();

                    while (DataReader.Read())
                    {
                        Schedule_ID.Add(DataReader.GetInt32(0));
                        Schedule_StudentID.Add(DataReader.GetInt32(1));
                        Schedule_TeacherID.Add(DataReader.GetInt32(2));
                        Schedule_BundleID.Add(DataReader.GetInt32(3));
                        Schedule_Weeks.Add(DataReader.GetString(4));
                        Schedule_StartDate.Add(DataReader.GetDateTime(5));
                        Schedule_BookedDays.Add(DataReader.GetString(6));
                        Schedule_BookedTime.Add(DataReader.GetString(7));
                        Schedule_EndDate.Add(DataReader.GetDateTime(8));
                    }

                    connection.Close();
                }
            }
        }
    

        // DISPLAY GRADE INFORMATION
        public void DisplayGradeDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Gradecommmand = new SqlCommand("SELECT * FROM Grade WHERE GradeID = @ID", connection))
            {
                Gradecommmand.Parameters.Add(new SqlParameter("@ID", lbGradeID.Text));

                using (SqlDataAdapter GradeAdaptor = new SqlDataAdapter())
                {
                    connection.Open();

                    DataTable Grades = new DataTable();
                    GradeAdaptor.SelectCommand = Gradecommmand;
                    GradeAdaptor.Fill(Grades);

                    lbGrade.DisplayMember = "GradeLevel";
                    lbGrade.ValueMember = "GradeID";
                    lbGrade.DataSource = Grades;
                }
            }
        }

        // DISPLAY TEACHER INFORMATION
        public void DisplayTeacherDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Teachers WHERE TeacherID = @ID", connection))
            {
                command.Parameters.Add(new SqlParameter("@ID", lbTeacherID.Text));

                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable TeacherTable = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(TeacherTable);


                    lbTeacherFirst_Name.DisplayMember = "First_Name";
                    lbTeacherFirst_Name.ValueMember = "TeacherID";
                    lbTeacherFirst_Name.DataSource = TeacherTable;

                    lbTeacherSurname.DisplayMember = "Surname";
                    lbTeacherSurname.ValueMember = "TeacherID";
                    lbTeacherSurname.DataSource = TeacherTable;

                    lbSpecialisation.DisplayMember = "Specialisation";
                    lbSpecialisation.ValueMember = "TeacherID";
                    lbSpecialisation.DataSource = TeacherTable;

                    lbRoomID.DisplayMember = "RoomID";
                    lbRoomID.ValueMember = "TeacherID";
                    lbRoomID.DataSource = TeacherTable;
                }
            }
        }

        
        private void lbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayScheduleDetails();
            DisplayTeacherDetails();
            DisplayGradeDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // VIEW NEXT RECORD
        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            CurrentStudentID = Convert.ToInt32(lbStudentID.Text);

            if (CurrentStudentID == MaxStudentID)
            {
                lbStudentID.SelectedValue = MinStudentID;
            }
            else
            {
                CurrentStudentID += 1;
                lbStudentID.SelectedValue = CurrentStudentID;
            }
        }

        // VIEW PREVIOUS RECORD
        private void btnPreviousStudent_Click(object sender, EventArgs e)
        {
            CurrentStudentID = Convert.ToInt32(lbStudentID.Text);

            if (CurrentStudentID == MinStudentID)
            {
                lbStudentID.SelectedValue = MaxStudentID;
            }
            else
            {
                CurrentStudentID += -1;
                lbStudentID.SelectedValue = CurrentStudentID;
            }
        }

        // RETURN TO CALENDAR
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariables.scheduleErrorMessage = false;
            frmClassSchedule ClassSchedule = new frmClassSchedule();
            ClassSchedule.Show();
            this.Hide();
        }

        // REMOVE RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "ScheduledLessonTable";

            // To remove a record, the user needs to login.
            if (GlobalVariables.UserLoggedIn == false)
            {
                // If no user is currently logged in, load login form.
                frmUserLogin Login = new frmUserLogin();
                Login.Show();
                this.Hide();
            }
            else
            {
                if (lbScheduledLessons.Text != null && !string.IsNullOrWhiteSpace(lbScheduledLessons.Text))
                {
                    // If a user is logged in, load confirmation page.
                    GlobalVariables.TableID = Convert.ToInt32(lbScheduledLessons.Text);
                    GlobalVariables.FieldNames = lbFirstName.Text + " " + lbSurname.Text;

                    frmConfirmation Confirmation = new frmConfirmation();
                    Confirmation.Show();
                }
                else
                {
                    MessageBox.Show("Please select a scheduled Lesson Reocrd from the menu below. If none are present, then this student has no scheduled lessons.");
                }
            }
        }

        // STORE STUDENT INFORMATION
        public void StoreAllStudentIDs()
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
                        AllStudentIDs.Add(DataReader.GetInt32(0));
                        AllStudent_FirstNames.Add(DataReader.GetString(1));
                        AllStudent_Surnames.Add(DataReader.GetString(3));
                    }
                }
                connection.Close();
            }
        }

        // FILL SEARCH BOX
        public void Fill_StudentSearchBox()
        {
            for (int x = 0; x < AllStudentIDs.Count(); x++)
            {
                AllStudent_FullNameValues.Add(AllStudent_FirstNames[x] + " " + AllStudent_Surnames[x]);
            }

            AllStudent_FullNameValues.Sort();
            cbStudentID.DataSource = AllStudent_FullNameValues;
        }

        // STUDENT SEARCH FUNCTION
        private void cbStudentID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StudentID_FirstNameMatches.Clear();
            StudentID_SurnameMatches.Clear();


            // identifies and stores selected value.
            SearchedStudent = cbStudentID.SelectedValue.ToString();

            for (int Y = 0; Y < SearchedStudent.Length; Y++)
            {
                // Then take each charater present within the string, and seperately look for a 'Space'.
                SearchTest = Convert.ToChar(SearchedStudent.Substring(Y, 1));
                if (SearchTest == ' ')
                {
                    // If located, seperate first name from surname.
                    Search_FirstName = SearchedStudent.Substring(0, (Y));
                    Search_Surname = SearchedStudent.Substring((Y + 1), (SearchedStudent.Length - (Search_FirstName.Length + 1)));
                    break;
                }
            }

            // Then proceed to take the first name, and compare it against all first names in the system.
            for (int x = 0; x < AllStudent_FirstNames.Count(); x++)
            {
                // If their is a match, record the associated student ID.
                if (AllStudent_FirstNames[x] == Search_FirstName)
                {
                    StudentID_FirstNameMatches.Add(AllStudentIDs[x]);
                }
            }

            // Then compare the collected surname against the student table inforamtion.
            for (int z = 0; z < AllStudent_Surnames.Count(); z++)
            {
                // if their is a match, then once again categorise the associated student ID.
                if (AllStudent_Surnames[z] == Search_Surname)
                {
                    StudentID_SurnameMatches.Add(AllStudentIDs[z]);
                }
            }

            // This block of code will be used to handle the scenario in which multiple students possess the same first, or surnames.
            // I will compare all collected student IDs, for a match should only occur should the desired student be located.
            for (int x = 0; x < StudentID_FirstNameMatches.Count(); x++)
            {
                for (int y = 0; y < StudentID_SurnameMatches.Count(); y++)
                {
                    if (StudentID_FirstNameMatches[x] == StudentID_SurnameMatches[y])
                    {
                        // Depending on whether the system contains students with matching firstnames or surnames, list will contain different values.
                        // For this reason, the system will try both posibilities, should one fial to work.
                        try
                        {
                            Search_DesiredStudentID = StudentID_FirstNameMatches[x];
                        }
                        catch (Exception SearchFail)
                        {
                            Search_DesiredStudentID = StudentID_SurnameMatches[y];
                        }
                    }

                }
            }

            // Then fianlly, update the form as  to display the information for the selected student.
            lbStudentID.SelectedValue = Search_DesiredStudentID;

            if (Firstdisplay == false)
            {
                lbStudentID.SelectedValue = AllStudentIDs[0];
                Firstdisplay = true;
            }
        }

        // BUTTON SELECT MODIFCATIONS
        // Previous Record
        private void btnPreviousStudent_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousStudent.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnPreviousStudent_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousStudent.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Next Record
        private void btnNextStudent_MouseEnter(object sender, EventArgs e)
        {
            btnNextStudent.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnNextStudent_MouseLeave(object sender, EventArgs e)
        {
            btnNextStudent.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Add New Record
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnAddRecord.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnAddRecord.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Remove Record
        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.Firebrick;
            this.Cursor = Cursors.Arrow;
        }

        // Calendar Return
        private void btnCalendarReturn_MouseEnter(object sender, EventArgs e)
        {
            btnCalendarReturn.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnCalendarReturn_MouseLeave(object sender, EventArgs e)
        {
            btnCalendarReturn.BackColor = Color.Chocolate;
            this.Cursor = Cursors.Arrow;
        }

        // Main Menu Return
        private void btnReturn_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.Firebrick;
            this.Cursor = Cursors.Arrow;
        }

        // First Record
        private void pbFirstRecord_MouseEnter(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pbFirstRecord_MouseLeave(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2;
            this.Cursor = Cursors.Arrow;
        }

        // Last Record
        private void pbLastRecord_MouseEnter(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pbLastRecord_MouseLeave(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted_;
            this.Cursor = Cursors.Arrow;
        }

        // Update Record
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Chocolate;
            this.Cursor = Cursors.Arrow;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbScheduledLessons.Text != null && !string.IsNullOrWhiteSpace(lbScheduledLessons.Text))
            {
                GlobalVariables.PreviousForm = "ScheduledLessonTable";
                GlobalVariables.Purpose = "Update";
                GlobalVariables.UpdateID = lbScheduledLessons.GetItemText(lbScheduledLessons.SelectedItem);

                for (int x = 0; x < Schedule_ID.Count(); x++)
                {
                    if (Convert.ToInt32(lbScheduledLessons.GetItemText(lbScheduledLessons.SelectedItem)) == Schedule_ID[x])
                    {
                        GlobalVariables.Schedule_StudentID = Convert.ToString(Schedule_StudentID[x]);
                        GlobalVariables.Schedule_TeacherID = Convert.ToString(Schedule_TeacherID[x]);
                        GlobalVariables.Schedule_PurchaseID = Convert.ToString(Schedule_BundleID[x]);
                        GlobalVariables.Schedule_Weeks = Schedule_Weeks[x];
                        GlobalVariables.Schedule_StartDate = Schedule_StartDate[x].ToString();
                        GlobalVariables.Schedule_BookedDays = Schedule_BookedDays[x];
                        GlobalVariables.Schedule_BookedTime = Schedule_BookedTime[x];
                        GlobalVariables.Schedule_EndDate = Schedule_EndDate[x].ToString();
                        break;
                    }
                }

                frmAddField UpdateRecord = new frmAddField();
                UpdateRecord.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a Scheduled Lesson Record. (Select from Record Display)");
            }
        }

        // FIRST / LAST RECORD
        private void pbFirstRecord_Click(object sender, EventArgs e)
        {
            lbStudentID.SelectedValue = AllStudentIDs[0];
        }
        private void pbLastRecord_Click(object sender, EventArgs e)
        {
            lbStudentID.SelectedValue = AllStudentIDs[(AllStudentIDs.Count() - 1)];
        }
    }
}
