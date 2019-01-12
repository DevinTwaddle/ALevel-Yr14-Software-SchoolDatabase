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
    public partial class frmAddField : Form
    {
        List<int> AllScheduledLessonsIDs = new List<int>();
        List<int> AllScheduledLessonsStudentIDs = new List<int>();
        List<int> AllScheduledLessonsTeacherIDs = new List<int>();
        List<int> AllScheduledLessonsBundleIDs = new List<int>();
        List<string> AllScheduledBookedDays = new List<string>();
        List<DateTime> AllScheduledLessonsStartDates = new List<DateTime>();
        List<DateTime> AllScheduledLessonsEndDates = new List<DateTime>();
        List<string> AllStartWeekDays = new List<string>();
        List<int> AllLessonDatesScheduleIDs = new List<int>();

        List<int> PurchasedLesson_IDs = new List<int>();
        List<int> PurchasedLessons_StudentID = new List<int>();
        List<int> PurchasedLessons_LessonBundleID = new List<int>();
        List<int> Student_ID = new List<int>();
        List<int> Student_GradeID = new List<int>();
        List<int> LessonBundle_ID = new List<int>();
        List<int> LessonBundle_BundleCost = new List<int>();
        List<double> LessonBundle_Multiplier = new List<double>();
        List<int> Grade_ID = new List<int>();
        List<int> Grade_Cost = new List<int>();
        List<int> LessonDates_Archive_ID = new List<int>();

        int Desired_PurchasedLesson_StudentID;
        int Desired_PurchasedLesson_ID;
        int Desired_PurchasedLessons_LessonBundleID;
        int Desired_Student_Grade;
        int Desired_LessonBundle_Cost;
        double Desired_LessonBundle_Multiplier;
        int Desired_Grade_GradeFee;


        List<double> TotalBundleCost = new List<double>();

        bool[] WeekDays = new bool[5];
        DateTime CurrentStartDate;
        string CurrentStartDay;
        string SearchDay;

        int x = 0;
        int y = 0;
        SqlDataReader DataReader;

        SqlConnection connection;
        string connectionString;
        string Querystring;
        bool ContainsNumbers;
        List<bool> ValidFields = new List<bool>();
        DateTime EnteredDate = new DateTime();
        string SelectedDate;
        bool SpacePresent;
        int Spacelocation;
        char[] StringChracters = new char[50];
        bool containsLetters;
        string FirstSection;
        string SecondSection;
        bool PresenceOfSymbols;
        bool PresenceOfPunctuation;
        int NumberOfBookedDays;
        DateTime AppendDate;
        int AppendID;
        bool AppendAttend = false;

        bool Presence_Number;
        bool Presence_Letter;
        bool Presence_Punctuation;
        bool Presence_Symbol;

        string Postcode_Value;
        string Postcode_BT;
        string Postcode_Number;
        string Postcode_Letters;

        string SubstringTest;
        int ATCount;

        int TotalFields;
        int TotalInstruments;
        int TotalGradeRange;
        int TotalBundleRange;

        int CalendarButton;

        int TotalSelectedDays;


        List<int> Grade_IDs = new List<int>();
        List<int> Instrument_IDs = new List<int>();
        List<string> Specialisation = new List<string>();
        List<string> RoomTypes = new List<string>();
        List<int> Room_IDs = new List<int>();

        List<int> Students_StudentID = new List<int>();
        List<string> Students_FirstName = new List<string>();
        List<string> Students_Surname = new List<string>();
        List<string> Students_FullName_AND_StudentID = new List<string>();

        List<int> Teachers_TeacherID = new List<int>();
        List<string> Teachers_FirstName = new List<string>();
        List<string> Teachers_Surname = new List<string>();
        List<string> Teachers_FullName_AND_TeacherID = new List<string>();

        List<int> LessonBundle_BundleID = new List<int>();
        List<string> LessonBundle_Name = new List<string>();
        List<string> LessonBundle_Name_AND_BundleID = new List<string>();

        List<string> TimeList = new List<string>();

        List<int> ScheduledLessons_PurchaseID = new List<int>();
        List<int> purchasedLessons_IDs = new List<int>();

        List<int> EndDate_Calculatior_ID = new List<int>();
        List<DateTime> EndDate_Calculator_EndDate = new List<DateTime>();
        List<string> EndDate_Calculator_BookedWeeks = new List<string>();
        List<DateTime> EndDate_Calculator_Final = new List<DateTime>();
        List<DateTime> EndDate_Calculator_StartDate = new List<DateTime>();

        DateTime EndDateValue;

        int Desired_StudentID;

        List<string> ScheduleWeeks = new List<string>();

        int ValidationCount;
        bool Continue;
        int NumberOfWeeks;




        public frmAddField()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmAddField_Load(object sender, EventArgs e)
        {
            Hide_Additional();
            Hide_Errors();
            Store_StudentInformation();
            Store_TeacherInforamtion();
            Store_BundleInformation();
            Store_ScheduleInformation();
            Store_PurchaseInformation();

            TotalInstruments = 20;
            TotalGradeRange = 80;
            TotalBundleRange = 100;

            pictureBox4.Size = new Size(817, 68);
            pictureBox3.Size = new Size(827, 80);
            pictureBox7.Size = new Size(839, 91);

            btnAddRecord.Location = new Point(45, 123);
            btnReturn.Location = new Point(606, 123);

            Specialisation.Add("String");
            Specialisation.Add("Keyboard");
            Specialisation.Add("Brass");
            Specialisation.Add("WoodWind");
            Specialisation.Add("Percussion");
            Specialisation.Add("Vocal");
            Specialisation.Sort();

            RoomTypes.Add("Class Room");
            RoomTypes.Add("Hall");
            RoomTypes.Add("Practice Room");
            RoomTypes.Sort();

            TimeList.Add("13:00");
            TimeList.Add("13:30");
            TimeList.Add("14:00");
            TimeList.Add("14:30");
            TimeList.Add("15:00");
            TimeList.Add("15:30");
            TimeList.Add("16:00");
            TimeList.Add("16:30");
            TimeList.Add("17:00");
            TimeList.Add("17:30");
            TimeList.Add("18:00");
            TimeList.Add("18:30");
            TimeList.Add("19:00");
            TimeList.Add("19:30");
            TimeList.Add("20:00");
            TimeList.Add("20:30");

            ScheduleWeeks.Add("5 Weeks");
            ScheduleWeeks.Add("10 Weeks");
            ScheduleWeeks.Add("15 Weeks");
            ScheduleWeeks.Add("20 Weeks");
            ScheduleWeeks.Add("30 Weeks");

            if (GlobalVariables.Purpose == "Update")
            {
                UpdateField_Display();
            }

            DisplayDetails();
            AssignTotalFields();
            HideExcessInformation();

        }

        // DISPLAY COMPONENTS IN RELATION TO SELECTED TABLE
        public void DisplayDetails()
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                lblFieldData2.Text = "First Name:";
                lblFieldData3.Text = "Other Name(s):";
                lblFieldData4.Text = "Surname";
                lblFieldData5.Text = "Date Of Birth:";
                lblFieldData6.Text = "Address:";
                lblFieldData7.Text = "Town";
                lblFieldData8.Text = "PostCode";
                lblFieldData9.Text = "Contact Number:";
                lblFieldData10.Text = "Email Address";
                lblFieldData11.Text = "GradeID";
                lblFieldData12.Text = "InstrumentID";
                lblFieldData13.Text = "Tuition Fee Recieved:";

                TotalFields = 12;

                tbFieldInfo11.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 495);

                tbFieldInfo12.Hide();
                cbFieldInfo2.Show();
                cbFieldInfo2.Location = new Point(146, 527);

                tbFieldInfo13.Hide();
                CheckBox1.Show();
                CheckBox1.Location = new Point(152, 559);

                btnCalender.Show();
                btnCalender.Location = new Point(308, 297);

                tbFieldInfo2.MaxLength = 50;
                tbFieldInfo3.MaxLength = 50;
                tbFieldInfo4.MaxLength = 50;
                tbFieldInfo5.MaxLength = 10;
                tbFieldInfo6.MaxLength = 50;
                tbFieldInfo7.MaxLength = 50;
                tbFieldInfo8.MaxLength = 7;
                tbFieldInfo9.MaxLength = 11; // Without first 3 digits
                tbFieldInfo10.MaxLength = 50;

                // Grade ID
                // Fill Combo box
                // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT * FROM Grade", connection))
                    {
                        DataReader = Command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            // For each record, store the corrisponding peice of information.
                            Grade_ID.Add(DataReader.GetInt32(0));
                        }
                    }
                    connection.Close();
                }

                cbFieldInfo1.DataSource = Grade_ID;
                cbFieldInfo1.DropDownStyle = ComboBoxStyle.DropDownList;


                // Instrument ID
                // Fill Combo box
                // This fuunction will be used to store various peices of information from the schedule Table. This will be used to complete the schedule
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT * FROM Instruments", connection))
                    {
                        DataReader = Command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            // For each record, store the corrisponding peice of information.
                            Instrument_IDs.Add(DataReader.GetInt32(0));
                        }
                    }
                    connection.Close();
                }

                cbFieldInfo2.DataSource = Instrument_IDs;
                cbFieldInfo2.DropDownStyle = ComboBoxStyle.DropDownList;


                tbFieldInfo5.Enabled = false;


                lbMain.Text = "Add Student";
                btnAddRecord.Text = "Add New Student";
                btnReturn.Text = "Return to Students Table";

            }

            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                lblFieldData2.Text = "First Name:";
                lblFieldData3.Text = "Surname:";
                lblFieldData4.Text = "Address:";
                lblFieldData5.Text = "Town:";
                lblFieldData6.Text = "PostCode:";
                lblFieldData7.Text = "Email Address:";
                lblFieldData8.Text = "Contact Number:";
                lblFieldData9.Text = "Specialisation:";
                lblFieldData10.Text = "RoomID:";

                TotalFields = 9;

                tbFieldInfo10.Hide();
                tbFieldInfo9.Hide();
                cbFieldInfo2.Show();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 431);
                cbFieldInfo2.Location = new Point(146, 463);

                cbFieldInfo1.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo2.DropDownStyle = ComboBoxStyle.DropDownList;

                cbFieldInfo1.DataSource = Specialisation;

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT * FROM Room", connection))
                    {
                        DataReader = Command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            // For each record, store the corrisponding peice of information.
                            Room_IDs.Add(DataReader.GetInt32(0));
                        }
                    }
                    connection.Close();
                }

                cbFieldInfo2.DataSource = Room_IDs;


                tbFieldInfo2.MaxLength = 50;
                tbFieldInfo3.MaxLength = 50;
                tbFieldInfo4.MaxLength = 60;
                tbFieldInfo5.MaxLength = 60;
                tbFieldInfo6.MaxLength = 7;
                tbFieldInfo7.MaxLength = 60;
                tbFieldInfo8.MaxLength = 11;
                tbFieldInfo9.MaxLength = 40;

                lbMain.Text = "Add Teacher";
                btnAddRecord.Text = "Add New Teacher";
                btnReturn.Text = "Return to Teacher Table";

                Querystring = "INSERT INTO Teachers VALUES(@First_Name, @Surname, @Address, @Town, @PostCode, @Email_Address, @Contact_Number, @Specialisation, @RoomID";
            }

            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                lblFieldData2.Text = "Instrument Type:";
                lblFieldData3.Text = "Instrument Name:";
                lblFieldData4.Text = "Quantity:";

                TotalFields = 3;

                tbFieldInfo2.Hide();
                cbFieldInfo1.Show();
                cbFieldInfo1.Location = new Point(146, 207);

                cbFieldInfo1.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo1.DataSource = Specialisation;

                tbFieldInfo2.MaxLength = 50;
                tbFieldInfo3.MaxLength = 50;
                tbFieldInfo4.MaxLength = 2;

                lbMain.Text = "Add Instrument";
                btnAddRecord.Text = "Add New Instrument";
                btnReturn.Text = "Return to Instrument Table";

                Querystring = "INSERT INTO Instruments VALUES(@Instrument Type, @Instrument Name, @Quantity";
            }

            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                lblFieldData2.Text = "Room Type:";
                lblFieldData3.Text = "Specialisation:";

                TotalFields = 2;

                tbFieldInfo2.Hide();
                tbFieldInfo3.Hide();

                cbFieldInfo1.Show();
                cbFieldInfo2.Show();
                cbFieldInfo1.Location = new Point(146, 207);
                cbFieldInfo2.Location = new Point(146, 239);

                cbFieldInfo1.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo1.DataSource = RoomTypes;

                cbFieldInfo2.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo2.DataSource = Specialisation;

                tbFieldInfo2.MaxLength = 25;
                tbFieldInfo3.MaxLength = 50;

                lbMain.Text = "Add Room";
                btnAddRecord.Text = "Add New Room";
                btnReturn.Text = "Return to Room Table";

                Querystring = "INSERT INTO Room VALUES(@Room_Type, @Specialisation";
            }

            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                lblFieldData2.Text = "Grade Level:";
                lblFieldData3.Text = "GradeFee:";

                TotalFields = 2;

                tbFieldInfo2.MaxLength = 25;
                tbFieldInfo3.MaxLength = 3;

                lbMain.Text = "Add Grade";
                btnAddRecord.Text = "Add New Grade";
                btnReturn.Text = "Return to Grade Table";

                Querystring = "INSERT INTO Grade VALUES(@GradeLevel, @GradeFee";
            }

            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                lblFieldData2.Text = "Lesson Bundle:";
                lblFieldData3.Text = "Bundle Cost:";
                lblFieldData4.Text = "Multiplier:";

                TotalFields = 3;

                tbFieldInfo2.MaxLength = 40;
                tbFieldInfo3.MaxLength = 3;
                tbFieldInfo4.MaxLength = 3;

                lbMain.Text = "New Lesson Bundle:";
                btnAddRecord.Text = "Add New Lesson Bundle";
                btnReturn.Text = "Return to Lesson Bundles Table";

                Querystring = "INSERT INTO LessonBundles VALUES(@Lesson Bundle, Bundle Cost, Multiplier (Discount Rate))";
            }

            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                lblFieldData2.Text = "Student ID:";
                lblFieldData3.Text = "Teacher ID:";
                lblFieldData4.Text = "Purchased Lesson:";
                lblFieldData5.Text = "No. of weeks:";
                lblFieldData6.Text = "Start Date:";
                lblFieldData7.Text = "Booked Time:";
                lblFieldData8.Text = "Booked Day(s):";

                TotalFields = 8;

                tbFieldInfo2.Hide();
                tbFieldInfo3.Hide();
                //tbFieldInfo4.Hide();
                tbFieldInfo7.Hide();

                if (GlobalVariables.Purpose == "Add")
                {
                    tbFieldInfo9.Hide();
                }

                cbFieldInfo1.Show();
                cbFieldInfo2.Show();
                cbFieldInfo3.Show();
                cbFieldInfo4.Show();

                tbFieldInfo9.Enabled = false;
                tbFieldInfo6.Enabled = false;
                tbFieldInfo4.Enabled = false;

                btnCalender.Location = new Point(308, 325);
                btnDataGrid.Location = new Point(308, 265);
                btnCalender.Show();
                btnDataGrid.Show();

                btnTimeSelection.Location = new Point(308, 390);
                btnTimeSelection.Show();

                cbFieldInfo1.Location = new Point(146, 207);
                cbFieldInfo2.Location = new Point(146, 239);
                cbFieldInfo3.Location = new Point(146, 303);
                cbFieldInfo4.Location = new Point(146, 367);

                cbFieldInfo1.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo2.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo3.DropDownStyle = ComboBoxStyle.DropDownList;
                cbFieldInfo4.DropDownStyle = ComboBoxStyle.DropDownList;

                cbFieldInfo1.DataSource = Students_FullName_AND_StudentID;
                cbFieldInfo2.DataSource = Teachers_FullName_AND_TeacherID;
                cbFieldInfo3.DataSource = ScheduleWeeks;
                cbFieldInfo4.DataSource = TimeList;


                tbFieldInfo5.MaxLength = 20;
                tbFieldInfo6.MaxLength = 10;
                tbFieldInfo7.MaxLength = 100;
                tbFieldInfo8.MaxLength = 7;

                lbMain.Text = "Schedule New Lesson";
                btnAddRecord.Text = "Schedule New Lesson";
                btnReturn.Text = "Return to Scheduled Lessons Table";

                Querystring = "INSERT INTO Scheduled_Lessons VALUES(@StudentID, @TeacherID, @LessonBundleID, @Number_Of_Weeks, @Start_Date, @Booked_Day(s), @Booked_Time, @End-Date)";
            }

            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                lblFieldData2.Text = "Student ID:";
                lblFieldData3.Text = "Purchase ID:";
                lblFieldData4.Text = "Purchase Date:";
                lblFieldData5.Text = "Payment Method:";
                lblFieldData6.Text = "Payment Recieved:";
                lblFieldData7.Text = "payment Receival Date:";
                lblFieldData8.Text = "Bundle Cost:";

                TotalFields = 7;

                tbFieldInfo2.Hide();
                tbFieldInfo3.Hide();
                tbFieldInfo8.Hide();
                lblFieldData8.Hide();

                cbFieldInfo1.Show();
                cbFieldInfo2.Show();

                cbFieldInfo1.Location = new Point(146, 207);
                cbFieldInfo2.Location = new Point(146, 239);

                tbFieldInfo4.MaxLength = 10;
                tbFieldInfo5.MaxLength = 25;
                tbFieldInfo6.MaxLength = 1;
                tbFieldInfo7.MaxLength = 10;

                lbMain.Text = "New Lesson Purchased:";
                btnAddRecord.Text = "Purchase New Lesson";
                btnReturn.Text = "Return to Purchased Lessons Table";

                Querystring = "INSERT INTO Scheduled_Lessons VALUES(@StudentID, @LessonBundleID, @Purchase_Date, @Payment_Method, @Payment-Recieved, @Payment_Recieved Date, @Bundle_Cost(After_Discount))";
            }
        }

        public void Data_Validation()
        {
            ValidationCount = 0;
            Continue = false;
            for (int x = 0; x < ValidFields.Count(); x++)
            {
                if (ValidFields[x] == true)
                {
                    ValidationCount++;
                }
            }

            if (ValidationCount == ValidFields.Count())
            {
                AddNewInforamtion();

            }
        }

        public void AddNewInforamtion()
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {
                    Querystring = "INSERT INTO Students VALUES(@First_Name, @Other_Names, @Surname, @DOB, @Address, @Town, @post, @Contact, @Email, @Grade, @Instrument, @Tuition)";
                }
                else
                {
                    Querystring = "UPDATE Students SET First_Name=@First_Name, Other_Names=@Other_Names, Surname=@Surname, Date_Of_Birth=@DOB, Address=@Address, Town=@Town, PostCode=@post, Contact_Number=@Contact, Email_Address=@Email, GradeID=@Grade, InstrumentID=@Instrument, Tuition_Fee_Recieved=@Tuition WHERE StudentID=@StudentID";
                }

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand(Querystring, connection))
                    {
                        Command.Parameters.AddWithValue("@StudentID", tbFieldInfo14.Text);
                        Command.Parameters.AddWithValue("@First_Name", tbFieldInfo2.Text);
                        Command.Parameters.AddWithValue("@Other_Names", tbFieldInfo3.Text);
                        Command.Parameters.AddWithValue("@Surname", tbFieldInfo4.Text);
                        Command.Parameters.AddWithValue("@DOB", Convert.ToDateTime(tbFieldInfo5.Text));
                        Command.Parameters.AddWithValue("@Address", tbFieldInfo6.Text);
                        Command.Parameters.AddWithValue("@Town", tbFieldInfo7.Text);
                        Command.Parameters.AddWithValue("@post", tbFieldInfo8.Text);
                        Command.Parameters.AddWithValue("@Contact", tbFieldInfo9.Text);
                        Command.Parameters.AddWithValue("@Email", tbFieldInfo10.Text);
                        Command.Parameters.AddWithValue("@Grade", Convert.ToInt32(cbFieldInfo1.Text));
                        Command.Parameters.AddWithValue("@Instrument", Convert.ToInt32(cbFieldInfo2.Text));
                        Command.Parameters.AddWithValue("@Tuition", CheckBox1.Text);

                        Command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }

            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }

            }

            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }
            }

            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }
            }

            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }
            }

            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }
            }

            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                if (GlobalVariables.Purpose == "Add")
                {

                }
                else
                {

                }



            }

        }



        public void AssignTotalFields()
        {
            for (int x = 0; x < TotalFields; x++)
            {
                ValidFields.Add(false);
            }
        }

        public void Store_ScheduleInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Scheduled_Lessons", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        ScheduledLessons_PurchaseID.Add(DataReader.GetInt32(2));

                        EndDate_Calculatior_ID.Add(DataReader.GetInt32(0));
                        EndDate_Calculator_BookedWeeks.Add(DataReader.GetString(4));
                        EndDate_Calculator_EndDate.Add(DataReader.GetDateTime(8));
                        EndDate_Calculator_StartDate.Add(DataReader.GetDateTime(5));
                    }
                }
                connection.Close();
            }
        }

        public void Store_PurchaseInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM LessonsPurchased", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        purchasedLessons_IDs.Add(DataReader.GetInt32(0));
                    }
                    DataReader.Close();

                    using (SqlCommand Cmd2 = new SqlCommand("SELECT * FROM LessonsPurchased WHERE StudentID = @StudentID AND Scheduled = @Scheduled", connection))
                    {
                        Cmd2.Parameters.AddWithValue("@StudentID", Desired_StudentID);
                        Cmd2.Parameters.AddWithValue("@Scheduled", 0);

                        //Cmd2.Parameters.AddWithValue("@StudentID", Students_StudentID[cbFieldInfo1.SelectedIndex]);

                        using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                        {
                            DataTable PurchasedLessons = new DataTable();
                            Adaptor.SelectCommand = Cmd2;
                            Adaptor.Fill(PurchasedLessons);

                            DataGrid_PurchasedLessons.DataSource = PurchasedLessons;
                        }
                    }
                    connection.Close();
                }
            }
        }

        public void Store_StudentInformation()
        {
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
                Students_FullName_AND_StudentID.Add(Students_StudentID[x] + "    |    " + Students_FirstName[x] + " " + Students_Surname[x]);
            }
        }

        public void Store_TeacherInforamtion()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Teachers", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Teachers_TeacherID.Add(DataReader.GetInt32(0));
                        Teachers_FirstName.Add(DataReader.GetString(1));
                        Teachers_Surname.Add(DataReader.GetString(2));
                    }
                }
                connection.Close();
            }

            for (int x = 0; x < Teachers_TeacherID.Count(); x++)
            {
                Teachers_FullName_AND_TeacherID.Add(Teachers_TeacherID[x] + "    |    " + Teachers_FirstName[x] + " " + Teachers_Surname[x]);
            }
        }

        public void Store_BundleInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM LessonBundles", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        LessonBundle_ID.Add(DataReader.GetInt32(0));
                        LessonBundle_Name.Add(DataReader.GetString(1));
                    }
                }
                connection.Close();
            }

            for (int x = 0; x < LessonBundle_ID.Count(); x++)
            {
                LessonBundle_Name_AND_BundleID.Add(LessonBundle_ID[x] + "    |    " + LessonBundle_Name[x]);
            }
        }


        // DISPLAY UPDATE RECORD
        public void UpdateField_Display()
        {
            pictureBox4.Size = new Size(817, 40);
            pictureBox3.Size = new Size(827, 50);
            pictureBox7.Size = new Size(839, 60);

            btnAddRecord.Location = new Point(46, 107);
            btnReturn.Location = new Point(606, 107);

            lblFieldData14.Show();
            lblFieldData14.Location = new Point(25, 175);

            tbFieldInfo14.Show();
            tbFieldInfo14.Location = new Point(146, 174);

            tbFieldInfo14.Text = GlobalVariables.UpdateID.ToString();

            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                for (int x = 0; x < GlobalVariables.Student_PostCode.Length; x++)
                {
                    string test9 = GlobalVariables.Student_PostCode.Substring(x, 1);
                    if (test9 == " ")
                    {
                        string FirstHalf = GlobalVariables.Student_PostCode.Substring(0, x);
                        string SecondHalf = GlobalVariables.Student_PostCode.Substring(x + 1, (GlobalVariables.Student_PostCode.Length - (x + 1)));
                        GlobalVariables.Student_PostCode = String.Format("{0}{1}", FirstHalf, SecondHalf);
                        break;
                    }
                }

                lbMain.Text = "Update Student Record";
                lblFieldData14.Text = "Student ID:";
                tbFieldInfo2.Text = GlobalVariables.Student_FirstName;
                tbFieldInfo3.Text = GlobalVariables.Student_OtherNames;
                tbFieldInfo4.Text = GlobalVariables.Student_Surname;
                tbFieldInfo5.Text = GlobalVariables.Student_DOB;
                tbFieldInfo6.Text = GlobalVariables.Student_Address;
                tbFieldInfo7.Text = GlobalVariables.Student_Town;
                tbFieldInfo8.Text = GlobalVariables.Student_PostCode;
                tbFieldInfo9.Text = GlobalVariables.Student_ContactNumber.ToString();
                tbFieldInfo10.Text = GlobalVariables.Student_Email;
                cbFieldInfo1.Text = GlobalVariables.Student_GradeID.ToString();
                cbFieldInfo2.Text = GlobalVariables.Student_InstrumentID.ToString();
                if (GlobalVariables.Student_PaymentFee == "True")
                {
                    CheckBox1.CheckState = CheckState.Checked;
                }
                else
                {
                    CheckBox1.CheckState = CheckState.Unchecked;
                }
            }

            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                for (int x = 0; x < GlobalVariables.Teacher_PostCode.Length; x++)
                {
                    string test9 = GlobalVariables.Teacher_PostCode.Substring(x, 1);
                    if (test9 == " ")
                    {
                        string FirstHalf = GlobalVariables.Teacher_PostCode.Substring(0, x);
                        string SecondHalf = GlobalVariables.Teacher_PostCode.Substring(x + 1, (GlobalVariables.Teacher_PostCode.Length - (x + 1)));
                        GlobalVariables.Teacher_PostCode = String.Format("{0}{1}", FirstHalf, SecondHalf);
                        break;
                    }
                }

                lbMain.Text = "Update Teacher Recrod";
                lblFieldData14.Text = "Teacher ID";
                tbFieldInfo2.Text = GlobalVariables.Teacher_FirstName;
                tbFieldInfo3.Text = GlobalVariables.Teacher_Surname;
                tbFieldInfo4.Text = GlobalVariables.Teacher_Address;
                tbFieldInfo5.Text = GlobalVariables.Teacher_Town;
                tbFieldInfo6.Text = GlobalVariables.Teacher_PostCode;
                tbFieldInfo7.Text = GlobalVariables.Teacher_Email;
                tbFieldInfo8.Text = GlobalVariables.Teacher_ContactNumber;
                tbFieldInfo9.Text = GlobalVariables.Teacher_Specialisation;
                cbFieldInfo1.Text = GlobalVariables.Teacher_RoomID;
            }

            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                lbMain.Text = "Update Instrument Recrod";
                lblFieldData14.Text = "Instrument ID";
                cbFieldInfo1.Text = GlobalVariables.Instrument_Type;
                tbFieldInfo3.Text = GlobalVariables.Instrument_Name;
                tbFieldInfo4.Text = GlobalVariables.Instrument_Quantity;
            }

            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                lbMain.Text = "Update Room Recrod";
                lblFieldData14.Text = "Room ID";
                tbFieldInfo2.Text = GlobalVariables.Room_Type;
                cbFieldInfo1.Text = GlobalVariables.Room_Specialisation;
            }

            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                lbMain.Text = "Update Grade Recrod";
                lblFieldData14.Text = "Grade ID";
                tbFieldInfo2.Text = GlobalVariables.Grade_Level;
                tbFieldInfo3.Text = GlobalVariables.Grade_Fee;
            }

            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                lbMain.Text = "Update LessonBundle Recrod";
                lblFieldData14.Text = "Bundle ID";
                tbFieldInfo2.Text = GlobalVariables.Bundle_Name;
                tbFieldInfo3.Text = GlobalVariables.Bundle_Cost;
                tbFieldInfo4.Text = GlobalVariables.Bundle_Discount;
            }

            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {

                tbFieldInfo9.Show();
                lblFieldData9.Show();
                lblFieldData9.Text = "End Date:";

                btnCalendar2.Location = new Point(308, 421);

                lbMain.Text = "Update Scheduled Lesson Recrod";
                lblFieldData14.Text = "Schedule ID";
                cbFieldInfo1.Text = GlobalVariables.Schedule_StudentID;
                cbFieldInfo2.Text = GlobalVariables.Schedule_TeacherID;
                tbFieldInfo4.Text = GlobalVariables.Schedule_PurchaseID;
                tbFieldInfo5.Text = GlobalVariables.Schedule_Weeks;
                tbFieldInfo6.Text = GlobalVariables.Schedule_StartDate;
                tbFieldInfo8.Text = GlobalVariables.Schedule_BookedDays;
                cbFieldInfo4.Text = GlobalVariables.Schedule_BookedTime;
                tbFieldInfo9.Text = GlobalVariables.Schedule_EndDate;


            }

            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                lbMain.Text = "Update Purchased Lesson Recrod";
                lblFieldData14.Text = "Purchase ID";
                cbFieldInfo1.Text = GlobalVariables.Purchase_StudentID;
                cbFieldInfo2.Text = GlobalVariables.Purchase_BundleID;
                tbFieldInfo4.Text = GlobalVariables.Purchase_Date;
                tbFieldInfo5.Text = GlobalVariables.Purchase_Method;
                tbFieldInfo6.Text = GlobalVariables.Purchase_Recieved;
                tbFieldInfo7.Text = GlobalVariables.Purchase_ReceivedDate;
                tbFieldInfo8.Text = GlobalVariables.Purchase_BundleCosts;
            }
        }


        // RETURN FUNCTIONS
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                frmStudents StudentTable = new frmStudents();
                StudentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                frmTeachers TeacherTable = new frmTeachers();
                TeacherTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                frmInstrument InstrumentTable = new frmInstrument();
                InstrumentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                frmRoom RoomTable = new frmRoom();
                RoomTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                frmGrade GradeTable = new frmGrade();
                GradeTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                frmLessonBundle LessonBundleTable = new frmLessonBundle();
                LessonBundleTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                frmScheduleTable Scheduled_Lessons = new frmScheduleTable();
                Scheduled_Lessons.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                PurchasedLessonBundles Purchased_Lessons = new PurchasedLessonBundles();
                Purchased_Lessons.Show();
                this.Hide();
            }

            lblFieldData2.Show();
            lblFieldData3.Show();
            lblFieldData4.Show();
            lblFieldData5.Show();
            lblFieldData6.Show();
            lblFieldData7.Show();
            lblFieldData8.Show();
            lblFieldData9.Show();
            lblFieldData10.Show();
            lblFieldData11.Show();
            lblFieldData12.Show();
            lblFieldData13.Show();
        }

        // ADD FUNCTION
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            lblErrorPlaceholder2.Hide();
            lblErrorPlaceholder3.Hide();
            lblErrorPlaceholder4.Hide();
            lblErrorPlaceholder5.Hide();
            lblErrorPlaceholder6.Hide();
            lblErrorPlaceholder7.Hide();
            lblErrorPlaceholder8.Hide();
            lblErrorPlaceholder9.Hide();
            lblErrorPlaceholder10.Hide();
            lblErrorPlaceholder11.Hide();
            lblErrorPlaceholder12.Hide();
            lblErrorPlaceholder13.Hide();

            // Clear all lists in advance, as to reduce data reduency.
            AllScheduledLessonsIDs.Clear();
            AllScheduledLessonsStudentIDs.Clear();
            AllScheduledLessonsTeacherIDs.Clear();
            AllScheduledLessonsBundleIDs.Clear();
            AllScheduledBookedDays.Clear();
            AllScheduledLessonsStartDates.Clear();
            AllScheduledLessonsEndDates.Clear();
            AllStartWeekDays.Clear();
            AllLessonDatesScheduleIDs.Clear();
            PurchasedLesson_IDs.Clear();
            PurchasedLessons_StudentID.Clear();
            PurchasedLessons_LessonBundleID.Clear();
            Student_ID.Clear();
            Student_GradeID.Clear();
            LessonBundle_ID.Clear();
            LessonBundle_BundleCost.Clear();
            LessonBundle_Multiplier.Clear();
            Grade_ID.Clear();
            Grade_Cost.Clear();

            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                Validation_Student();
            }
            if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                Validation_Teacher();
            }
            if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                Validation_Instrument();
            }
            if (GlobalVariables.PreviousForm == "RoomTable")
            {
                Validation_Room();
            }
            if (GlobalVariables.PreviousForm == "GradeTable")
            {
                Validation_Grade();
            }
            if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                Validation_LessonBundle();
            }
            if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                StoreInformation_BundleCalculator();
                BundleCostCalculator();
            }
            if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                Validation_ScheduledLesson();

                Data_Validation();

                // Details are being stored locally.
                LocalInformationStorage();

                // This block of code is used to remove any schedules which have already been added.
                try
                {
                    for (int T = 0; T < AllScheduledLessonsIDs.Count(); T++)
                    {
                        for (int X = 0; X < AllLessonDatesScheduleIDs.Count(); X++)
                        {
                            if (AllScheduledLessonsIDs[T] == AllLessonDatesScheduleIDs[X])
                            {
                                AllScheduledLessonsBundleIDs.RemoveAt(x);
                                AllScheduledBookedDays.RemoveAt(x);
                                AllScheduledLessonsEndDates.RemoveAt(x);
                                AllScheduledLessonsIDs.RemoveAt(x);
                                AllScheduledLessonsStartDates.RemoveAt(x);
                                AllScheduledLessonsStudentIDs.RemoveAt(x);
                                AllScheduledLessonsTeacherIDs.RemoveAt(x);
                                x -= 1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }



                for (int x = 0; x < AllScheduledLessonsIDs.Count(); x++)
                {
                    for (int y = 0; y < LessonDates_Archive_ID.Count(); y++)
                    {
                        if (AllScheduledLessonsIDs[x] == LessonDates_Archive_ID[y])
                        {
                            AllScheduledLessonsBundleIDs.RemoveAt(x);
                            AllScheduledBookedDays.RemoveAt(x);
                            AllScheduledLessonsEndDates.RemoveAt(x);
                            AllScheduledLessonsIDs.RemoveAt(x);
                            AllScheduledLessonsStartDates.RemoveAt(x);
                            AllScheduledLessonsStudentIDs.RemoveAt(x);
                            AllScheduledLessonsTeacherIDs.RemoveAt(x);
                        }
                    }
                }


                // Identify Booked Days Against Dates
                for (int T = 0; T < AllScheduledLessonsIDs.Count(); T++)
                {
                    // This passess each booked lessons value into the method individually. This should identify booked days.
                    ScheduledDays(AllScheduledBookedDays[T]);
                    CurrentStartDate = AllScheduledLessonsStartDates[T];
                    CurrentStartDay = Convert.ToString(CurrentStartDate.DayOfWeek);

                    // This will identify if the user has booked two days.
                    if (NumberOfBookedDays == 2)
                    {
                        // If so, both this block of code will run twice, to handle each day individually.
                        for (int R = 0; R < 2; R++)
                        {
                            // This block of code will be used to identify the first booked day which has been selected.
                            if (WeekDays[0] == true)
                            {
                                SearchDay = "Monday"; // This assigns the value which will be compared.
                                WeekDays[0] = false; // The associated bool is then set to false, as to ensure that the next booked day will be used, on the next round.
                            }

                            if (WeekDays[1] == true)
                            {
                                SearchDay = "Tuesday";
                                WeekDays[1] = false;
                            }

                            if (WeekDays[2] == true)
                            {
                                SearchDay = "Wednesday";
                                WeekDays[2] = false;
                            }

                            if (WeekDays[3] == true)
                            {
                                SearchDay = "Thursday";
                                WeekDays[3] = false;
                            }

                            if (WeekDays[4] == true)
                            {
                                SearchDay = "Friday";
                                WeekDays[4] = false;
                            }

                            AppendID = AllScheduledLessonsIDs[T];
                            Day_Date_Comparision(SearchDay, CurrentStartDate, AllScheduledLessonsEndDates[T]);
                        }
                    }
                    // This block of code will run if the current record has one booked day.
                    else if (NumberOfBookedDays == 1)
                    {
                        // This nested if statement will identify the booked day, and assign the corriponding value.
                        if (WeekDays[0] == true)
                        {
                            SearchDay = "Monday"; // This assigns the value which will be compared.
                        }
                        else if (WeekDays[1] == true)
                        {
                            SearchDay = "Tuesday";
                        }
                        else if (WeekDays[2] == true)
                        {
                            SearchDay = "Wednesday";
                        }
                        else if (WeekDays[3] == true)
                        {
                            SearchDay = "Thursday";
                        }
                        else if (WeekDays[4] == true)
                        {
                            SearchDay = "Friday";
                        }
                        else
                        {
                            // In the off change that the value is not found within the nested if statement, this place holder error message should appear.
                            MessageBox.Show("Incorrect Value entered: BOOKED DAYS");
                        }

                        // Try was implimented due to the off chance that a value may not be located within the IF block, thus this is a precausion to ensure the system stays operational.
                        try
                        {
                            // Assign current Schedule ID value.
                            AppendID = AllScheduledLessonsIDs[T];
                            // Pass through booked day value, for comparision and eventaully appending.
                            Day_Date_Comparision(SearchDay, CurrentStartDate, AllScheduledLessonsEndDates[T]);
                        }
                        catch (Exception ex)
                        {
                            // If an error becomes apparent, simply break form the system, and display error message.
                            MessageBox.Show("Could not complete operation");
                            break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Too many days have been booked for a lesson");
                    }
                }


                for (int x = 0; x < EndDate_Calculatior_ID.Count(); x++)
                {
                    for (int y = 0; y < EndDate_Calculator_BookedWeeks[x].Length; y++)
                    {
                        string Sub = EndDate_Calculator_BookedWeeks[x].Substring(y, 1);
                        if (Sub == " ")
                        {
                            NumberOfWeeks = Convert.ToInt32(EndDate_Calculator_BookedWeeks[x].Substring(0, y));
                            break;
                        }
                    }

                    EndDateValue = EndDate_Calculator_StartDate[x];
                    for (int z = 0; z < NumberOfWeeks; z++)
                    {
                        EndDateValue = EndDateValue.AddDays(7);
                    }

                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand Command = new SqlCommand("UPDATE Scheduled_Lessons SET End_Date=@EndDate WHERE ScheduleID=@ID", connection))
                        {
                            Command.Parameters.AddWithValue("@EndDate", EndDateValue);
                            Command.Parameters.AddWithValue("@ID", EndDate_Calculatior_ID[x]);

                            Command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }
        }

    


        





        // DATA VALIDATION
        public void Validation_Student()
        {
            // Sets bool true if number is located.
            ContainsNumbers = tbFieldInfo2.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo2.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo2.Text.Any(char.IsSymbol);

            // FIRST NAME
            if (tbFieldInfo2.Text != "")
            {
                // If Field Contains a value. <Run If Statement>

                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {
                    // If Field does not contain a non-numeric or alphabetical character. <Run If Statement>
                    if (ContainsNumbers == true)
                    {
                        // If value contains numeric Characters. <Error Message>
                        ValidFields[0] = false;
                        lblErrorPlaceholder2.Show();
                        lblErrorPlaceholder2.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // Value Contains solely text. <Validate Field>
                        ValidFields[0] = true;
                    }
                }
                else
                {
                    // If field does contain non-Numeric or Alphabetical characters. <Error Message>
                    ValidFields[0] = false;
                    lblErrorPlaceholder2.Show();
                    lblErrorPlaceholder2.Text = "Please Remove Symbols or Punctuation.";
                }
            }
            else
            {
                // If Textbox contains no value.
                ValidFields[0] = false;
                lblErrorPlaceholder2.Show();
                lblErrorPlaceholder2.Text = "Data Required. Please Complete.";
            }




            // OTHER NAME(S)
            ContainsNumbers = tbFieldInfo3.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo3.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo3.Text.Any(char.IsSymbol);


            if (tbFieldInfo3.Text != "")
            {
                // If field contains a value. <Run If Statement>

                if (PresenceOfSymbols == false && PresenceOfPunctuation == false)
                {
                    // If value does not contain non-alphapetical or numerical values. <Run IF Statement>

                    if (ContainsNumbers == true)
                    {
                        // If Value Contains Numerical characters. <Error Message>
                        ValidFields[1] = false;
                        lblErrorPlaceholder3.Show();
                        lblErrorPlaceholder3.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // If value contains no numerical characters or symbols. <Validate Field>
                        ValidFields[1] = true;
                    }
                }
                else
                {
                    // If Value Contains symbol(s). <Error Message>
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please remove symbols or punctuation.";
                }
            }
            else
            {
                // If no value present. <Erro Message>
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. please Complete.";
            }





            // SURNAME
            ContainsNumbers = tbFieldInfo4.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo4.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo4.Text.Any(char.IsSymbol);


            if (tbFieldInfo4.Text != "")
            {
                // If field contains a value. <Run If Statement>

                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {
                    // Value does not contain symbols. <Run If Statement>

                    if (ContainsNumbers == true)
                    {
                        // Value Contains Numbers. <Error Message>

                        ValidFields[2] = false;
                        lblErrorPlaceholder4.Show();
                        lblErrorPlaceholder4.Text = "Please Remove Numerical Characters.";
                    }
                    else
                    {
                        // Value contains valid characters. <Validate Field>
                        ValidFields[2] = true;
                    }
                }
                else
                {
                    // Value contains symbols. <Error Message>
                    ValidFields[2] = false;
                    lblErrorPlaceholder4.Show();
                    lblErrorPlaceholder4.Text = "please Remove Symbols or punctuation.";
                }
            }
            else
            {
                // No Value Present. <Error Message>
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = "Data Required. Please Complete.";
            }




            // DATE OF BIRTH
            if (tbFieldInfo5.Text != "")
            {
                // Value is present. <Run IF Statement>

                EnteredDate = Convert.ToDateTime(tbFieldInfo5.Text);
                if (EnteredDate > DateTime.Today)
                {
                    // Entered Date > CurrentDate. <Error Message>
                    ValidFields[3] = false;
                    lblErrorPlaceholder5.Show();
                    lblErrorPlaceholder5.Text = "Please select prior date.";
                }
                else
                {
                    // Date is Valid. <Validate Field>.
                    ValidFields[3] = true;
                }
            }
            else
            {
                // No Value Present. <Error Message>
                ValidFields[3] = false;
                lblErrorPlaceholder5.Show();
                lblErrorPlaceholder5.Text = "Data Required. Please use Calender provided.";
            }



            // ADDRESS
            int y = 0;
            SpacePresent = false;
            Spacelocation = 0;
            containsLetters = true;
            ContainsNumbers = true;
            FirstSection = "";
            SecondSection = "";
            PresenceOfPunctuation = tbFieldInfo4.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo4.Text.Any(char.IsSymbol);

            if (tbFieldInfo6.Text != "")
            {
                SpacePresent = false;
                StringChracters = tbFieldInfo6.Text.ToCharArray();

                while (SpacePresent == false)
                {
                    while (y < StringChracters.Length)
                    {
                        if (StringChracters[y] == ' ')
                        {
                            Spacelocation = y;
                            break;
                        }
                        y++;
                    }
                    break;
                }


                if (Spacelocation > 0)
                {
                    SpacePresent = true;

                }
            }

            if (tbFieldInfo6.Text != "")
            {
                // If Value is present. <Run Statement>

                if (PresenceOfSymbols == false && PresenceOfPunctuation == false)
                {
                    // If No symbols present. <Run Statement>

                    if (SpacePresent == true)
                    {
                        // These lines of code segment the address number and the street.
                        FirstSection = tbFieldInfo6.Text.Substring(0, (y));
                        SecondSection = tbFieldInfo6.Text.Substring((y + 1), ((tbFieldInfo6.TextLength - FirstSection.Length) - 1));

                        // Test address number for text.
                        containsLetters = FirstSection.Any(Char.IsLetter);

                        // Test the address name for numbers.
                        ContainsNumbers = SecondSection.Any(Char.IsNumber);


                        if (FirstSection != "" && SecondSection != "")
                        {
                            if (containsLetters == false && ContainsNumbers == false)
                            {
                                // If both sections are validated. <Validate this field>
                                ValidFields[4] = true;
                            }
                            else if (containsLetters == true && ContainsNumbers == false)
                            {
                                // If first section invalid, yet second valid. <Error Message>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Please Remove alphametical Characters from street number.";

                            }
                            else if (containsLetters == false && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Please Remove Numerical Characters from street name.";
                            }
                            else if (containsLetters == true && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "Invalid Characters. Please Review.";
                            }
                        }
                    }
                    else
                    {
                        // Space not present, thus field does not contain proper format. <Error Message>
                        ValidFields[4] = false;
                        lblErrorPlaceholder6.Show();
                        lblErrorPlaceholder6.Text = "Space Neccessary between house Number and Street.";
                    }
                }
                else
                {
                    // Symbol present in value. <Error Message>
                    ValidFields[4] = false;
                    lblErrorPlaceholder6.Show();
                    lblErrorPlaceholder6.Text = "Please Remove Symbol or punctuation.";
                }
            }
            else
            {
                // Field does not contain text. <Error Message>
                ValidFields[4] = false;
                lblErrorPlaceholder6.Show();
                lblErrorPlaceholder6.Text = "Data Required. Please Complete.";
            }



            // TOWN
            ContainsNumbers = tbFieldInfo7.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo7.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo7.Text.Any(char.IsSymbol);


            if (tbFieldInfo7.Text != "")
            {

                // If Value is present within Textbox. <Run Statement>
                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {

                    // No invalid symbols present. <Run Statement>
                    if (ContainsNumbers == true)
                    {
                        // Value contains numbers. <Error Message>
                        ValidFields[5] = false;
                        lblErrorPlaceholder7.Show();
                        lblErrorPlaceholder7.Text = "Please remove numerical characters.";
                    }
                    else
                    {
                        // Value contains no invalid characters. <Validate Field>
                        ValidFields[5] = true;
                    }
                }
                else
                {
                    // Value contains symbols. <Error Message>
                    ValidFields[5] = false;
                    lblErrorPlaceholder7.Show();
                    lblErrorPlaceholder7.Text = "Please remove symbols and puctuation.";
                }
            }
            else
            {
                // No value present. <Error Message>
                ValidFields[5] = false;
                lblErrorPlaceholder7.Show();
                lblErrorPlaceholder7.Text = "Data Required. Please Complete.";
            }



            // POSTCODE
            if (tbFieldInfo8.Text != "")
            {
                if (tbFieldInfo8.TextLength == tbFieldInfo8.MaxLength)
                {
                    Postcode_Value = tbFieldInfo8.Text;
                    Postcode_BT = Postcode_Value.Substring(0, 2);
                    Postcode_Number = Postcode_Value.Substring(2, 3);
                    Postcode_Letters = Postcode_Value.Substring(5, 2);

                    // Checking if 'BT' is present at start.
                    if (Postcode_BT == "BT" || Postcode_BT == "bt" || Postcode_BT == "Bt" || Postcode_BT == "bT")
                    {
                        // check the next three digits
                        Presence_Punctuation = Postcode_Number.Any(Char.IsPunctuation);
                        Presence_Letter = Postcode_Number.Any(Char.IsLetter);
                        Presence_Symbol = Postcode_Number.Any(Char.IsSymbol);
                        if (Presence_Letter == false && PresenceOfPunctuation == false && Presence_Symbol == false)
                        {
                            // Check final 2 digits
                            Presence_Punctuation = Postcode_Letters.Any(Char.IsPunctuation);
                            Presence_Number = Postcode_Letters.Any(Char.IsNumber);
                            Presence_Symbol = Postcode_Letters.Any(Char.IsSymbol);
                            if (Presence_Number == false && Presence_Punctuation == false && Presence_Symbol == false)
                            {
                                // Field valid
                                ValidFields[6] = true;
                            }
                            else
                            {
                                // Invalid characters present within letter segment
                                ValidFields[6] = false;
                                lblErrorPlaceholder8.Show();
                                lblErrorPlaceholder8.Text = "[PostCode Format = LL000LL] Please Replace final digits with valid characters.";
                            }
                        }
                        else
                        {
                            // Invalid value present within number segment
                            ValidFields[6] = false;
                            lblErrorPlaceholder8.Show();
                            lblErrorPlaceholder8.Text = "[PostCode Format = LL000LL] Please Replace '000' section with valid characters";
                        }
                    }
                    else
                    {
                        // BT not present
                        ValidFields[6] = false;
                        lblErrorPlaceholder8.Show();
                        lblErrorPlaceholder8.Text = "[PostCode Format = LL000LL] First characters must be 'BT'.";
                    }
                }
                else
                {
                    // Box must contain 7 characters
                    ValidFields[6] = false;
                    lblErrorPlaceholder8.Show();
                    lblErrorPlaceholder8.Text = "[PostCode Format = LL000LL] Please use full format.";
                }
            }
            else
            {
                // No value present
                ValidFields[6] = false;
                lblErrorPlaceholder8.Show();
                lblErrorPlaceholder8.Text = "Data Required. Please Complete.";
            }



            // CONTACT NUMBER
            Presence_Letter = tbFieldInfo9.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo9.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo9.Text.Any(Char.IsSymbol);

            if (tbFieldInfo9.Text != "" && !string.IsNullOrWhiteSpace(tbFieldInfo9.Text))
            {
                if (Presence_Letter == false)
                {
                    if (Presence_Punctuation == false)
                    {
                        if (Presence_Symbol == false)
                        {
                            ValidFields[7] = true;
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[7] = false;
                            lblErrorPlaceholder9.Show();
                            lblErrorPlaceholder9.Text = "Please Remove symbols.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[7] = false;
                        lblErrorPlaceholder9.Show();
                        lblErrorPlaceholder9.Text = "Please remove punctuation.";
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[7] = false;
                    lblErrorPlaceholder9.Show();
                    lblErrorPlaceholder9.Text = "Please Remove Alphabetical Characters.";
                }
            }
            else
            {
                ValidFields[7] = false;
                lblErrorPlaceholder9.Show();
                lblErrorPlaceholder9.Text = "Data Required. Please Complete.";
            }



            // Email Address
            if (tbFieldInfo10 != null && !string.IsNullOrWhiteSpace(tbFieldInfo10.Text))
            {
                ATCount = 0;

                for (int x = 0; x < tbFieldInfo10.Text.Length; x++)
                {
                    SubstringTest = tbFieldInfo10.Text.Substring(x, 1);
                    if (SubstringTest == "@")
                    {
                        ATCount++;
                    }

                }

                if (ATCount == 1)
                {
                    // Valid Value
                    ValidFields[8] = true;
                }
                else if (ATCount < 1)
                {
                    // No @ Present <Error>
                    ValidFields[8] = false;
                    lblErrorPlaceholder10.Show();
                    lblErrorPlaceholder10.Text = "Email Must Contain '@'.";
                }
                else if (ATCount > 1)
                {
                    // No @ Present <Error>
                    ValidFields[8] = false;
                    lblErrorPlaceholder10.Show();
                    lblErrorPlaceholder10.Text = "Only one '@' may be present within Email.";
                }
            }
            else
            {
                // No value Present <Error>
                ValidFields[8] = false;
                lblErrorPlaceholder10.Show();
                lblErrorPlaceholder10.Text = "Data Required. Please Complete.";
            }



            // GRADE ID
            if (cbFieldInfo1.Text != null)
            {
                if (Convert.ToInt32(cbFieldInfo1.Text) > 0 || Convert.ToInt32(cbFieldInfo1.Text) < Grade_ID.Count())
                {
                    // Valio Value <Correct>
                    ValidFields[9] = true;
                }
                else
                {
                    // Invalid Value <Error>
                    ValidFields[9] = false;
                    lblErrorPlaceholder11.Show();
                    lblErrorPlaceholder11.Text = "Entered Value does not represent a Grade Record. Please select from provided list.";
                }
            }
            else
            {
                // No value Present <Error>
                ValidFields[9] = false;
                lblErrorPlaceholder11.Show();
                lblErrorPlaceholder11.Text = "Data Required. Please Complete.";
            }



            // Instrument ID
            if (cbFieldInfo2.Text != null)
            {
                ValidFields[10] = true;
            }

            // Tuition Fee
            ValidFields[11] = true;
        }

        public void Validation_Teacher()
        {
            // FIRST NAME
            if (tbFieldInfo2.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo2.Text))
            {
                Presence_Number = tbFieldInfo2.Text.Any(Char.IsNumber);
                Presence_Punctuation = tbFieldInfo2.Text.Any(Char.IsPunctuation);
                Presence_Symbol = tbFieldInfo2.Text.Any(Char.IsSymbol);

                if (Presence_Number == false && Presence_Punctuation == false && Presence_Symbol == false)
                {
                    // Valid Character Present
                    ValidFields[0] = true;
                }
                else
                {
                    // <Error> Invalid Characters
                    ValidFields[0] = false;
                    lblErrorPlaceholder2.Show();
                    lblErrorPlaceholder2.Text = "Please Remove Invalid Characters. Name should only contain Letters!";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[0] = false;
                lblErrorPlaceholder2.Show();
                lblErrorPlaceholder2.Text = "Data Required. Please Complete";
            }


            // SURNAME
            if (tbFieldInfo3.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo3.Text))
            {
                Presence_Number = tbFieldInfo3.Text.Any(Char.IsNumber);
                Presence_Punctuation = tbFieldInfo3.Text.Any(Char.IsPunctuation);
                Presence_Symbol = tbFieldInfo3.Text.Any(Char.IsSymbol);

                if (Presence_Number == false && Presence_Punctuation == false && Presence_Symbol == false)
                {
                    // Valid Character Present
                    ValidFields[1] = true;
                }
                else
                {
                    // <Error> Invalid Characters
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please Remove Invalid Characters. Name should only contain Letters!";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. Please Complete";
            }


            // ADDRESS
            int y = 0;
            SpacePresent = false;
            Spacelocation = 0;
            containsLetters = true;
            ContainsNumbers = true;
            FirstSection = "";
            SecondSection = "";
            PresenceOfPunctuation = tbFieldInfo4.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo4.Text.Any(char.IsSymbol);

            if (tbFieldInfo4.Text != "")
            {
                SpacePresent = false;
                StringChracters = tbFieldInfo4.Text.ToCharArray();

                while (SpacePresent == false)
                {
                    while (y < StringChracters.Length)
                    {
                        if (StringChracters[y] == ' ')
                        {
                            Spacelocation = y;
                            break;
                        }
                        y++;
                    }
                    break;
                }


                if (Spacelocation > 0)
                {
                    SpacePresent = true;

                }
            }

            if (tbFieldInfo4.Text != "")
            {
                // If Value is present. <Run Statement>

                if (PresenceOfSymbols == false && PresenceOfPunctuation == false)
                {
                    // If No symbols present. <Run Statement>

                    if (SpacePresent == true)
                    {
                        // These lines of code segment the address number and the street.
                        FirstSection = tbFieldInfo4.Text.Substring(0, (y));
                        SecondSection = tbFieldInfo4.Text.Substring((y + 1), ((tbFieldInfo4.TextLength - FirstSection.Length) - 1));

                        // Test address number for text.
                        containsLetters = FirstSection.Any(Char.IsLetter);

                        // Test the address name for numbers.
                        ContainsNumbers = SecondSection.Any(Char.IsNumber);


                        if (FirstSection != "" && SecondSection != "")
                        {
                            if (containsLetters == false && ContainsNumbers == false)
                            {
                                // If both sections are validated. <Validate this field>
                                ValidFields[2] = true;
                            }
                            else if (containsLetters == true && ContainsNumbers == false)
                            {
                                // If first section invalid, yet second valid. <Error Message>
                                ValidFields[2] = false;
                                lblErrorPlaceholder4.Show();
                                lblErrorPlaceholder4.Text = "Please Remove alphametical Characters from street number.";

                            }
                            else if (containsLetters == false && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[2] = false;
                                lblErrorPlaceholder4.Show();
                                lblErrorPlaceholder4.Text = "Please Remove Numerical Characters from street name.";
                            }
                            else if (containsLetters == true && ContainsNumbers == true)
                            {
                                // If first section valid, yet second invalid. <Error Messagae>
                                ValidFields[2] = false;
                                lblErrorPlaceholder4.Show();
                                lblErrorPlaceholder4.Text = "Invalid Characters. Please Review.";
                            }
                        }
                    }
                    else
                    {
                        // Space not present, thus field does not contain proper format. <Error Message>
                        ValidFields[2] = false;
                        lblErrorPlaceholder4.Show();
                        lblErrorPlaceholder4.Text = "Space Neccessary between house Number and Street.";
                    }
                }
                else
                {
                    // Symbol present in value. <Error Message>
                    ValidFields[2] = false;
                    lblErrorPlaceholder4.Show();
                    lblErrorPlaceholder4.Text = "Please Remove Symbol or punctuation.";
                }
            }
            else
            {
                // Field does not contain text. <Error Message>
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = "Data Required. Please Complete.";
            }







            // TOWN
            ContainsNumbers = tbFieldInfo5.Text.Any(char.IsDigit);
            PresenceOfPunctuation = tbFieldInfo5.Text.Any(char.IsPunctuation);
            PresenceOfSymbols = tbFieldInfo5.Text.Any(char.IsSymbol);


            if (tbFieldInfo5.Text != "")
            {

                // If Value is present within Textbox. <Run Statement>
                if (PresenceOfPunctuation == false && PresenceOfSymbols == false)
                {

                    // No invalid symbols present. <Run Statement>
                    if (ContainsNumbers == true)
                    {
                        // Value contains numbers. <Error Message>
                        ValidFields[3] = false;
                        lblErrorPlaceholder5.Show();
                        lblErrorPlaceholder5.Text = "Please remove numerical characters.";
                    }
                    else
                    {
                        // Value contains no invalid characters. <Validate Field>
                        ValidFields[3] = true;
                    }
                }
                else
                {
                    // Value contains symbols. <Error Message>
                    ValidFields[3] = false;
                    lblErrorPlaceholder5.Show();
                    lblErrorPlaceholder5.Text = "Please remove symbols and puctuation.";
                }
            }
            else
            {
                // No value present. <Error Message>
                ValidFields[3] = false;
                lblErrorPlaceholder5.Show();
                lblErrorPlaceholder5.Text = "Data Required. Please Complete.";
            }



            // POSTCODE
            if (tbFieldInfo6.Text != "")
            {
                if (tbFieldInfo6.TextLength == tbFieldInfo6.MaxLength)
                {
                    Postcode_Value = tbFieldInfo6.Text;
                    Postcode_BT = Postcode_Value.Substring(0, 2);
                    Postcode_Number = Postcode_Value.Substring(2, 3);
                    Postcode_Letters = Postcode_Value.Substring(5, 2);

                    // Checking if 'BT' is present at start.
                    if (Postcode_BT == "BT" || Postcode_BT == "bt" || Postcode_BT == "Bt" || Postcode_BT == "bT")
                    {
                        // check the next three digits
                        Presence_Punctuation = Postcode_Number.Any(Char.IsPunctuation);
                        Presence_Letter = Postcode_Number.Any(Char.IsLetter);
                        Presence_Symbol = Postcode_Number.Any(Char.IsSymbol);
                        if (Presence_Letter == false && PresenceOfPunctuation == false && Presence_Symbol == false)
                        {
                            // Check final 2 digits
                            Presence_Punctuation = Postcode_Letters.Any(Char.IsPunctuation);
                            Presence_Number = Postcode_Letters.Any(Char.IsNumber);
                            Presence_Symbol = Postcode_Letters.Any(Char.IsSymbol);
                            if (Presence_Number == false && Presence_Punctuation == false && Presence_Symbol == false)
                            {
                                // Field valid
                                ValidFields[4] = true;
                            }
                            else
                            {
                                // Invalid characters present within letter segment
                                ValidFields[4] = false;
                                lblErrorPlaceholder6.Show();
                                lblErrorPlaceholder6.Text = "[PostCode Format = LL000LL] Please Replace final digits with valid characters.";
                            }
                        }
                        else
                        {
                            // Invalid value present within number segment
                            ValidFields[4] = false;
                            lblErrorPlaceholder6.Show();
                            lblErrorPlaceholder6.Text = "[PostCode Format = LL000LL] Please Replace '000' section with valid characters";
                        }
                    }
                    else
                    {
                        // BT not present
                        ValidFields[4] = false;
                        lblErrorPlaceholder6.Show();
                        lblErrorPlaceholder6.Text = "[PostCode Format = LL000LL] First characters must be 'BT'.";
                    }
                }
                else
                {
                    // Box must contain 7 characters
                    ValidFields[4] = false;
                    lblErrorPlaceholder6.Show();
                    lblErrorPlaceholder6.Text = "[PostCode Format = LL000LL] Please use full format.";
                }
            }
            else
            {
                // No value present
                ValidFields[4] = false;
                lblErrorPlaceholder6.Show();
                lblErrorPlaceholder6.Text = "Data Required. Please Complete.";
            }





            // CONTACT NUMBER
            Presence_Letter = tbFieldInfo8.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo8.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo8.Text.Any(Char.IsSymbol);

            if (tbFieldInfo8.Text != "" && !string.IsNullOrWhiteSpace(tbFieldInfo8.Text))
            {
                if (Presence_Letter == false)
                {
                    if (Presence_Punctuation == false)
                    {
                        if (Presence_Symbol == false)
                        {
                            ValidFields[5] = true;
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[5] = false;
                            lblErrorPlaceholder8.Show();
                            lblErrorPlaceholder8.Text = "Please Remove symbols.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[5] = false;
                        lblErrorPlaceholder8.Show();
                        lblErrorPlaceholder8.Text = "Please remove punctuation.";
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[5] = false;
                    lblErrorPlaceholder8.Show();
                    lblErrorPlaceholder8.Text = "Please Remove Alphabetical Characters.";
                }
            }
            else
            {
                ValidFields[5] = false;
                lblErrorPlaceholder8.Show();
                lblErrorPlaceholder8.Text = "Data Required. Please Complete.";
            }






            // Email Address
            if (tbFieldInfo7 != null)
            {
                ATCount = 0;

                for (int x = 0; x < tbFieldInfo7.Text.Length; x++)
                {
                    SubstringTest = tbFieldInfo7.Text.Substring(x, 1);
                    if (SubstringTest == "@")
                    {
                        ATCount++;
                    }

                }

                if (ATCount == 1)
                {
                    // Valid Value
                    ValidFields[6] = true;
                }
                else if (ATCount < 1)
                {
                    // No @ Present <Error>
                    ValidFields[6] = false;
                    lblErrorPlaceholder7.Show();
                    lblErrorPlaceholder7.Text = "Email Must Contain '@'.";
                }
                else if (ATCount > 1)
                {
                    // No @ Present <Error>
                    ValidFields[6] = false;
                    lblErrorPlaceholder7.Show();
                    lblErrorPlaceholder7.Text = "Only one '@' may be present within Email.";
                }
            }
            else
            {
                // No value Present <Error>
                ValidFields[6] = false;
                lblErrorPlaceholder7.Show();
                lblErrorPlaceholder7.Text = "Data Required. Please Complete.";
            }



            // SPECIALISATION
            ValidFields[7] = true;


            // ROOM ID
            ValidFields[8] = true;


        }

        public void Validation_Instrument()
        {
            // TYPE
            ValidFields[0] = true;

            // NAME
            Presence_Number = tbFieldInfo3.Text.Any(Char.IsNumber);
            Presence_Punctuation = tbFieldInfo3.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo3.Text.Any(Char.IsSymbol);

            if (tbFieldInfo3.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo3.Text))
            {
                if (Presence_Number == false)
                {
                    if (Presence_Punctuation == false)
                    {
                        if (Presence_Symbol == false)
                        {
                            ValidFields[1] = true;
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[1] = false;
                            lblErrorPlaceholder3.Show();
                            lblErrorPlaceholder3.Text = "Please Remove Symbol Character.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[1] = false;
                        lblErrorPlaceholder3.Show();
                        lblErrorPlaceholder3.Text = "Please Remove Punctuation.";
                    }
                }
                else
                {
                    // <Error> Number Present
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please Remove Numeric Character.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. Please Complete.";
            }


            // QUANTITY
            Presence_Letter = tbFieldInfo4.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo4.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo4.Text.Any(Char.IsSymbol);

            if (tbFieldInfo4.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo4.Text))
            {
                if (Presence_Letter != true)
                {
                    if (Presence_Punctuation != true)
                    {
                        if (Presence_Symbol != true)
                        {
                            MessageBox.Show(Convert.ToInt32(tbFieldInfo4.Text).ToString());

                            if (Convert.ToInt32(tbFieldInfo4.Text) > 0 && Convert.ToInt32(tbFieldInfo4.Text) < TotalInstruments)
                            {
                                // Valid Value
                                ValidFields[2] = true;
                            }
                            else
                            {
                                // <Error> Value Exceeds limit
                                ValidFields[2] = false;
                                lblErrorPlaceholder4.Show();
                                lblErrorPlaceholder4.Text = String.Format("Value Excceds limit. Please stay within the range of (1 - {0})", TotalInstruments);
                            }
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[2] = false;
                            lblErrorPlaceholder4.Show();
                            lblErrorPlaceholder4.Text = "Please Remove Symbol Character.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[2] = false;
                        lblErrorPlaceholder4.Show();
                        lblErrorPlaceholder4.Text = "Please Remove Puntuation.";
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[2] = false;
                    lblErrorPlaceholder4.Show();
                    lblErrorPlaceholder4.Text = "Please Remove Alphabetical Characters.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = "Data Required. Please Complete.";
            }

        }

        public void Validation_Grade()
        {
            // Grade Level (Name)
            Presence_Number = tbFieldInfo2.Text.Any(Char.IsNumber);
            Presence_Punctuation = tbFieldInfo2.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo2.Text.Any(Char.IsSymbol);

            if (tbFieldInfo2.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo2.Text))
            {
                if (Presence_Number == false)
                {
                    if (Presence_Punctuation == false)
                    {
                        if (Presence_Symbol == false)
                        {
                            // <Valid> Information
                            ValidFields[0] = true;
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[0] = false;
                            lblErrorPlaceholder2.Show();
                            lblErrorPlaceholder2.Text = "Please Remove any Symbols.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[0] = false;
                        lblErrorPlaceholder2.Show();
                        lblErrorPlaceholder2.Text = "Please Remove Puncutal characters.";
                    }
                }
                else
                {
                    // <Error> Number Present
                    ValidFields[0] = false;
                    lblErrorPlaceholder2.Show();
                    lblErrorPlaceholder2.Text = "Please Remove Numerical characters.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[0] = false;
                lblErrorPlaceholder2.Show();
                lblErrorPlaceholder2.Text = "Data Required. Please Complete.";
            }


            // Grade Fee
            Presence_Letter = tbFieldInfo3.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo3.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo3.Text.Any(Char.IsSymbol);

            if (tbFieldInfo3.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo3.Text))
            {
                if (Presence_Letter != true)
                {
                    if (Presence_Punctuation != true)
                    {
                        if (Presence_Symbol != true)
                        {
                            if (Convert.ToInt32(tbFieldInfo3.Text) > 0 && Convert.ToInt32(tbFieldInfo3.Text) < TotalGradeRange)
                            {
                                // Valid Value
                                ValidFields[1] = true;
                            }
                            else
                            {
                                // <Error> Value Exceeds limit
                                ValidFields[1] = false;
                                lblErrorPlaceholder3.Show();
                                lblErrorPlaceholder3.Text = String.Format("Value Excceds limit. Please stay within the range of (1 - {0})", TotalInstruments);
                            }
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[1] = false;
                            lblErrorPlaceholder3.Show();
                            lblErrorPlaceholder3.Text = "Please Remove Symbol Character.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[1] = false;
                        lblErrorPlaceholder3.Show();
                        lblErrorPlaceholder3.Text = "Please Remove Puntuation.";
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please Remove Alphabetical Characters.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. Please Complete.";
            }

        }

        public void Validation_Room()
        {
            // Room Type
            ValidFields[0] = true;

            // Specialisation
            ValidFields[1] = true;


        }

        public void Validation_LessonBundle()
        {
            // Lesson Bundle
            Presence_Punctuation = tbFieldInfo2.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo2.Text.Any(Char.IsSymbol);

            if (tbFieldInfo2.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo2.Text))
            {
                if (Presence_Punctuation == false)
                {
                    if (Presence_Symbol == false)
                    {
                        // <Valid> Information
                        ValidFields[0] = true;
                    }
                    else
                    {
                        // <Error> Symbol Present
                        ValidFields[0] = false;
                        lblErrorPlaceholder2.Show();
                        lblErrorPlaceholder2.Text = "Please Remove any Symbols.";
                    }
                }
                else
                {
                    // <Error> Punctuation Present
                    ValidFields[0] = false;
                    lblErrorPlaceholder2.Show();
                    lblErrorPlaceholder2.Text = "Please Remove Puncutal characters.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[0] = false;
                lblErrorPlaceholder2.Show();
                lblErrorPlaceholder2.Text = "Data Required. Please Complete.";
            }




            // Bundle Cost
            Presence_Letter = tbFieldInfo3.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo3.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo3.Text.Any(Char.IsSymbol);

            if (tbFieldInfo3.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo3.Text))
            {
                if (Presence_Letter != true)
                {
                    if (Presence_Punctuation != true)
                    {
                        if (Presence_Symbol != true)
                        {
                            if (Convert.ToInt32(tbFieldInfo3.Text) > 0 && Convert.ToInt32(tbFieldInfo3.Text) < TotalBundleRange)
                            {
                                // Valid Value
                                ValidFields[1] = true;
                            }
                            else
                            {
                                // <Error> Value Exceeds limit
                                ValidFields[1] = false;
                                lblErrorPlaceholder3.Show();
                                lblErrorPlaceholder3.Text = String.Format("Value Excceds limit. Please stay within the range of (1 - {0})", TotalBundleRange);
                            }
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[1] = false;
                            lblErrorPlaceholder3.Show();
                            lblErrorPlaceholder3.Text = "Please Remove Symbol Character.";
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[1] = false;
                        lblErrorPlaceholder3.Show();
                        lblErrorPlaceholder3.Text = "Please Remove Puntuation.";
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[1] = false;
                    lblErrorPlaceholder3.Show();
                    lblErrorPlaceholder3.Text = "Please Remove Alphabetical Characters.";
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[1] = false;
                lblErrorPlaceholder3.Show();
                lblErrorPlaceholder3.Text = "Data Required. Please Complete.";
            }




            // Multiplier (Discount Rate)
            Presence_Letter = tbFieldInfo4.Text.Any(Char.IsLetter);
            Presence_Punctuation = tbFieldInfo4.Text.Any(Char.IsPunctuation);
            Presence_Symbol = tbFieldInfo4.Text.Any(Char.IsSymbol);

            if (tbFieldInfo4.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo4.Text))
            {
                if (Presence_Letter != true)
                {
                    if (Presence_Punctuation != true)
                    {
                        if (Presence_Symbol != true)
                        {
                            if (Convert.ToInt32(tbFieldInfo4.Text) > 0 && Convert.ToInt32(tbFieldInfo4.Text) <= 1)
                            {
                                // Valid Value
                                ValidFields[2] = true;
                            }
                            else
                            {
                                // <Error> Value Exceeds limit
                                ValidFields[2] = false;
                                lblErrorPlaceholder4.Show();
                                lblErrorPlaceholder4.Text = ("Value Excceds limit. Please stay within the range of (0 AND 1)");
                            }
                        }
                        else
                        {
                            // <Error> Symbol Present
                            ValidFields[2] = false;
                            lblErrorPlaceholder4.Show();
                            lblErrorPlaceholder4.Text = ("Please Remove Symbol Character.");
                        }
                    }
                    else
                    {
                        // <Error> Punctuation Present
                        ValidFields[2] = false;
                        lblErrorPlaceholder4.Show();
                        lblErrorPlaceholder4.Text = ("Please Remove Puntuation.");
                    }
                }
                else
                {
                    // <Error> Letter Present
                    ValidFields[2] = false;
                    lblErrorPlaceholder4.Show();
                    lblErrorPlaceholder4.Text = ("Please Remove Alphabetical Characters.");
                }
            }
            else
            {
                // <Error> No value present
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = ("Data Required. Please Complete.");
            }
        }

        public void Validation_ScheduledLesson()
        {
            // Student ID
            ValidFields[0] = true;

            // Teacher ID
            ValidFields[1] = true;

            // Purchased Lesson ID
            if (tbFieldInfo4.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo4.Text))
            {
                ValidFields[2] = true;
            }
            else
            {
                // <Error> No value present
                ValidFields[2] = false;
                lblErrorPlaceholder4.Show();
                lblErrorPlaceholder4.Text = "Please Select Purchased Lesson. If none exist, then this student must first make a purchase.";
            }

            // Number of Weeks
            ValidFields[3] = true;

            // Start_Date
            if (tbFieldInfo6.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo6.Text))
            {
                ValidFields[4] = true;
            }
            else
            {
                // <Error> No value present
                ValidFields[4] = false;
                lblErrorPlaceholder6.Show();
                lblErrorPlaceholder6.Text = "Please select a date through the associated button and thus calendar.";
            }

            // Booked Time
            ValidFields[5] = true;

            // End Date
            if (tbFieldInfo9.Text != null && !string.IsNullOrWhiteSpace(tbFieldInfo4.Text))
            {
                ValidFields[7] = true;
            }
            else
            {
                // <Error> No value present
                ValidFields[7] = false;
                lblErrorPlaceholder9.Show();
                lblErrorPlaceholder9.Text = "Please select a date through the associated button and thus calendar.";
            }

            // Booked Day(s)
            TotalSelectedDays = 0;

            if (checkDay_Monday.CheckState == CheckState.Checked)
            {
                TotalSelectedDays++;
            }
            if (checkDay_Tuesday.CheckState == CheckState.Checked)
            {
                TotalSelectedDays++;
            }
            if (checkDay_Wednesday.CheckState == CheckState.Checked)
            {
                TotalSelectedDays++;
            }
            if (checkDay_Thursday.CheckState == CheckState.Checked)
            {
                TotalSelectedDays++;
            }
            if (checkDay_Friday.CheckState == CheckState.Checked)
            {
                TotalSelectedDays++;
            }

            if (TotalSelectedDays > 2)
            {
                ValidFields[6] = false;
                lblErrorPlaceholder8.Show();
                lblErrorPlaceholder8.Text = "Too many days selected. Max = 2";
            }
        }

        public void Validation_PurchasedLesson()
        {

        }


        // HIDE ADDITIONAL COMPONENTS (OPERATION)
        public void HideExcessInformation()
        {
            if (lblFieldData2.Text == "[PlaceHolder]")
            {
                HidePlaceholder2();
                HidePlaceholder3();
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData3.Text == "[PlaceHolder]")
            {
                HidePlaceholder3();
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData4.Text == "[PlaceHolder]")
            {
                HidePlaceholder4();
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData5.Text == "[PlaceHolder]")
            {
                HidePlaceholder5();
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData6.Text == "[PlaceHolder]")
            {
                HidePlaceholder6();
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData7.Text == "[PlaceHolder]")
            {
                HidePlaceholder7();
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData8.Text == "[PlaceHolder]")
            {
                HidePlaceholder8();
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData9.Text == "[PlaceHolder]")
            {
                HidePlaceholder9();
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData10.Text == "[PlaceHolder]")
            {
                HidePlaceholder10();
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData11.Text == "[PlaceHolder]")
            {
                HidePlaceholder11();
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData12.Text == "[PlaceHolder]")
            {
                HidePlaceholder12();
                HidePlaceholder13();
            }
            if (lblFieldData12.Text == "[PlaceHolder]")
            {
                HidePlaceholder13();
            }
        }

        public void Hide_Additional()
        {
            cbFieldInfo1.Hide();
            cbFieldInfo2.Hide();
            cbFieldInfo3.Hide();
            cbFieldInfo4.Hide();
            CheckBox1.Hide();
            btnCalender.Hide();
            Calender1.Hide();
            lblFieldData14.Hide();
            tbFieldInfo14.Hide();
            btnCalendar2.Hide();
            btnDataGrid.Hide();
            btnTimeSelection.Hide();

            checkDay_Monday.Hide();
            checkDay_Tuesday.Hide();
            checkDay_Wednesday.Hide();
            checkDay_Thursday.Hide();
            checkDay_Friday.Hide();

            pbBackground_Day.Hide();
            pictureBox1.Hide();
        }

        public void Hide_Errors()
        {
            lblErrorPlaceholder2.Hide();
            lblErrorPlaceholder3.Hide();
            lblErrorPlaceholder4.Hide();
            lblErrorPlaceholder5.Hide();
            lblErrorPlaceholder6.Hide();
            lblErrorPlaceholder7.Hide();
            lblErrorPlaceholder8.Hide();
            lblErrorPlaceholder9.Hide();
            lblErrorPlaceholder10.Hide();
            lblErrorPlaceholder11.Hide();
            lblErrorPlaceholder12.Hide();
            lblErrorPlaceholder13.Hide();
        }


        // HIDE FUNCTIONS
        public void HidePlaceholder2()
        {
            lblFieldData2.Hide();
            tbFieldInfo2.Hide();
        }
        public void HidePlaceholder3()
        {
            lblFieldData3.Hide();
            tbFieldInfo3.Hide();
        }
        public void HidePlaceholder4()
        {
            lblFieldData4.Hide();
            tbFieldInfo4.Hide();
        }
        public void HidePlaceholder5()
        {
            lblFieldData5.Hide();
            tbFieldInfo5.Hide();
        }
        public void HidePlaceholder6()
        {
            lblFieldData6.Hide();
            tbFieldInfo6.Hide();
        }
        public void HidePlaceholder7()
        {
            lblFieldData7.Hide();
            tbFieldInfo7.Hide();
        }
        public void HidePlaceholder8()
        {
            lblFieldData8.Hide();
            tbFieldInfo8.Hide();
        }
        public void HidePlaceholder9()
        {
            lblFieldData9.Hide();
            tbFieldInfo9.Hide();
        }
        public void HidePlaceholder10()
        {
            lblFieldData10.Hide();
            tbFieldInfo10.Hide();
        }
        public void HidePlaceholder11()
        {
            lblFieldData11.Hide();
            tbFieldInfo11.Hide();
        }
        public void HidePlaceholder12()
        {
            lblFieldData12.Hide();
            tbFieldInfo12.Hide();
        }
        public void HidePlaceholder13()
        {
            lblFieldData13.Hide();
            tbFieldInfo13.Hide();
        }



        // CALENDAR DISPLAY
        private void btnCalender_Click(object sender, EventArgs e)
        {
            CalendarButton = 1;
            btnCalendar2.Enabled = false;

            btnCalender.Hide();
            Calender1.Show();
            Calender1.Location = new Point(308, 209);
        }

        // CALENDAR SELECT OUTCOME
        private void Calender1_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = Calender1.SelectionRange.Start.ToShortDateString();

            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                tbFieldInfo5.Text = SelectedDate;
                btnCalender.Show();
            }
            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {
                if (CalendarButton == 1)
                {
                    tbFieldInfo6.Text = SelectedDate;
                    btnCalender.Show();
                }
                else if (CalendarButton == 2)
                {
                    tbFieldInfo9.Text = SelectedDate;
                    btnCalendar2.Show();
                }
            }

            btnCalender.Enabled = true;
            btnCalendar2.Enabled = true;
            Calender1.Hide();
        }

        // STORE TABLE INFORMATION LOCALLY
        public void LocalInformationStorage()
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
                        AllScheduledLessonsIDs.Add(DataReader.GetInt32(0));
                        AllScheduledLessonsStudentIDs.Add(DataReader.GetInt32(1));
                        AllScheduledLessonsTeacherIDs.Add(DataReader.GetInt32(2));
                        AllScheduledLessonsBundleIDs.Add(DataReader.GetInt32(3));
                        AllScheduledBookedDays.Add(DataReader.GetString(6));
                        AllScheduledLessonsStartDates.Add(DataReader.GetDateTime(5));
                        AllScheduledLessonsEndDates.Add(DataReader.GetDateTime(8));
                    }
                }

                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("SELECT ScheduleID FROM LessonDates", connection))
                    {

                        DataReader = Command.ExecuteReader();
                        while (DataReader.Read())
                        {
                            // For each record, store the corrisponding peice of information.
                            AllLessonDatesScheduleIDs.Add(DataReader.GetInt32(0));
                        }
                    }
                    DataReader.Close();
                }

                using (connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM LessonDate_Archive", connection))
                    {
                        connection.Open();

                        DataReader = cmd.ExecuteReader();
                        while (DataReader.Read())
                        {
                            LessonDates_Archive_ID.Add(DataReader.GetInt32(2));
                        }
                    }
                }
            }
        }


        // STORE INFORMATION FOR TOTAL COST CALCULATION
        public void StoreInformation_BundleCalculator()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command4 = new SqlCommand("SELECT LessonsPurchasedID, StudentID, LessonBundleID FROM LessonsPurchased", connection))
                {

                    DataReader = Command4.ExecuteReader();
                    while (DataReader.Read())
                    {
                        PurchasedLessons_LessonBundleID.Add(DataReader.GetInt32(2));
                        PurchasedLessons_StudentID.Add(DataReader.GetInt32(1));
                        PurchasedLesson_IDs.Add(DataReader.GetInt32(0));

                    }
                }
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command5 = new SqlCommand("SELECT * FROM LessonBundles", connection))
                {

                    DataReader = Command5.ExecuteReader();
                    while (DataReader.Read())
                    {
                        LessonBundle_ID.Add(DataReader.GetInt32(0));
                        LessonBundle_BundleCost.Add(DataReader.GetInt32(2));
                        LessonBundle_Multiplier.Add(DataReader.GetDouble(3));
                    }
                }
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command5 = new SqlCommand("SELECT StudentID, GradeID FROM Students", connection))
                {

                    DataReader = Command5.ExecuteReader();
                    while (DataReader.Read())
                    {
                        Student_ID.Add(DataReader.GetInt32(0));
                        Student_GradeID.Add(DataReader.GetInt32(1));
                    }
                }
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command5 = new SqlCommand("SELECT * FROM Grade", connection))
                {

                    DataReader = Command5.ExecuteReader();
                    while (DataReader.Read())
                    {
                        Grade_ID.Add(DataReader.GetInt32(0));
                        Grade_Cost.Add(DataReader.GetInt32(2));
                    }
                }
            }
        }


        // CALCULATE TOTAL BUNDLE COSTS
        public void BundleCostCalculator()
        {
            try
            {
                // Selecting each purchased lesson record individually.
                for (int x = 0; x < PurchasedLesson_IDs.Count(); x++)
                {
                    // Storing the information
                    Desired_PurchasedLesson_ID = PurchasedLesson_IDs[x];
                    Desired_PurchasedLesson_StudentID = PurchasedLessons_StudentID[x];
                    Desired_PurchasedLessons_LessonBundleID = PurchasedLessons_LessonBundleID[x];

                    // Locating the associted student.
                    for (int y = 0; y < Student_ID.Count(); y++)
                    {
                        // Storing the associated grade ID
                        if (Desired_PurchasedLesson_StudentID == Student_ID[y])
                        {
                            Desired_Student_Grade = Student_GradeID[y];
                            break;
                        }
                    }

                    // Locate the associated grade information
                    for (int r = 0; r < Grade_ID.Count(); r++)
                    {
                        if (Desired_Student_Grade == Grade_ID[r])
                        {
                            Desired_Grade_GradeFee = Grade_Cost[r];
                            break;
                        }
                    }

                    // Locate the associated Lesson Bundle information
                    for (int z = 0; z < LessonBundle_ID.Count(); z++)
                    {
                        if (Desired_PurchasedLessons_LessonBundleID == LessonBundle_ID[z])
                        {
                            Desired_LessonBundle_Cost = LessonBundle_BundleCost[z];
                            Desired_LessonBundle_Multiplier = LessonBundle_Multiplier[z];
                            break;
                        }
                    }

                    // This will store all total cost values to a new list.
                    TotalBundleCost.Add((Desired_Grade_GradeFee * Desired_LessonBundle_Cost) * Desired_LessonBundle_Multiplier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }


            // UPDATE PURCHASEDLESSONS TABLE
            for (int x = 0; x < TotalBundleCost.Count(); x++)
            {
                // Running through the list, update all records accordingly.
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE LessonsPurchased SET Total_Bundle_Cost = @BundleCost WHERE LessonsPurchasedID = @PurchaseID", connection))
                    {
                        cmd.Parameters.AddWithValue("@BundleCost", TotalBundleCost[x]);
                        cmd.Parameters.AddWithValue("@PurchaseID", PurchasedLesson_IDs[x]);

                        // Run query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        // IDENTIFY SCHEDULED DAYS
        public void ScheduledDays(string BookedDays)
        {
            // Reset these values for new record.
            for (int I = 0; I < WeekDays.Count(); I++)
            {
                WeekDays[I] = false;
            }
            NumberOfBookedDays = 0;

            // This will identify booked day(s).

            if (BookedDays.Contains("Monday"))
            {
                WeekDays[0] = true;
                NumberOfBookedDays += 1;
            }
            if (BookedDays.Contains("Tuesday"))
            {
                WeekDays[1] = true;
                NumberOfBookedDays += 1;
            }
            if (BookedDays.Contains("Wednesday"))
            {
                WeekDays[2] = true;
                NumberOfBookedDays += 1;
            }
            if (BookedDays.Contains("Thursday"))
            {
                WeekDays[3] = true;
                NumberOfBookedDays += 1;
            }
            if (BookedDays.Contains("Friday"))
            {
                WeekDays[4] = true;
                NumberOfBookedDays += 1;
            }
        }


        // COMPARE SCHEDULE DAYS TO UPCOMING DATES
        public void Day_Date_Comparision(string SelectedDay, DateTime ComparedDate, DateTime Endate)
        {
            string DayofWeek = "";
            bool found = false;

            while (ComparedDate < Endate)
            {
                DayofWeek = ComparedDate.DayOfWeek.ToString();

                if (DayofWeek != SelectedDay && found == false)
                {
                    ComparedDate = ComparedDate.AddDays(1);
                }
                else
                {
                    found = true;
                    AppendDate = ComparedDate;
                    AppendScheduleInformation();
                    ComparedDate = ComparedDate.AddDays(7);
                }
            }
        }

        // APPEND DATE INFORMATION INTO LESSON DATES
        public void AppendScheduleInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("INSERT INTO LessonDates(ScheduleID, Date, Attended) VALUES(@Value1, @Value2, @Value3)", connection))
                {
                    Command.Parameters.AddWithValue("@Value1", AppendID);
                    Command.Parameters.AddWithValue("@Value2", AppendDate);
                    Command.Parameters.AddWithValue("@Value3", AppendAttend);
                    Command.ExecuteNonQuery();

                }
            }
        }



        private void btnCalendar2_Click(object sender, EventArgs e)
        {
            CalendarButton = 2;
            btnCalender.Enabled = false;

            btnCalendar2.Hide();
            Calender1.Show();
            Calender1.Location = new Point(314, 417);
        }

        private void btnTimeSelection_Click(object sender, EventArgs e)
        {
            checkDay_Monday.Show();
            checkDay_Tuesday.Show();
            checkDay_Wednesday.Show();
            checkDay_Thursday.Show();
            checkDay_Friday.Show();
            pbBackground_Day.Show();
            pictureBox1.Show();

            btnTimeSelection.Hide();
        }

        private void frmAddField_MouseEnter(object sender, EventArgs e)
        {
            checkDay_Monday.Hide();
            checkDay_Tuesday.Hide();
            checkDay_Wednesday.Hide();
            checkDay_Thursday.Hide();
            checkDay_Friday.Hide();
            pbBackground_Day.Hide();
            pictureBox1.Hide();
            DataGrid_PurchasedLessons.Hide();

            Calender1.Hide();

            if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender")
            {

                btnCalender.Show();
                btnDataGrid.Show();
                btnTimeSelection.Show();

                if (GlobalVariables.Purpose == "Update")
                {
                    btnCalendar2.Show();
                }
            }
            else if (GlobalVariables.PreviousForm == "StudentTable")
            {
                btnCalender.Show();
            }
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            DataGrid_PurchasedLessons.Show();
            DataGrid_PurchasedLessons.Location = new Point(308, 207);
            DataGrid_PurchasedLessons.Size = new Size(444, 109);
        }

        private void cbFieldInfo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalVariables.PreviousForm == "ScheduledLessonTable" || GlobalVariables.PreviousForm == "Calender" && GlobalVariables.Purpose == "Update")
            {
                Student_Search_Breakdown();
                tbFieldInfo4.Text = null;
            }
        }

        public void Student_Search_Breakdown()
        {
            string Sub;
            for (int x = 0; x < cbFieldInfo1.Text.Length; x++)
            {
                Sub = cbFieldInfo1.Text.Substring(x, 1);
                if (Sub == " ")
                {
                    Desired_StudentID = Convert.ToInt32(cbFieldInfo1.Text.Substring(0, x));
                    break;
                }
            }

            Store_PurchaseInformation();
        }

        private void DataGrid_PurchasedLessons_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid_PurchasedLessons.SelectedCells.Count > 0)
            {
                int selectedrowindex = DataGrid_PurchasedLessons.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = DataGrid_PurchasedLessons.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["LessonsPurchasedID"].Value);

                tbFieldInfo4.Text = a;
                DataGrid_PurchasedLessons.Hide();
                btnDataGrid.Show();
            }
        }


        private void DataGrid_PurchasedLessons_Click(object sender, EventArgs e)
        {
            if (DataGrid_PurchasedLessons.SelectedCells.Count > 0)
            {
                int selectedrowindex = DataGrid_PurchasedLessons.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = DataGrid_PurchasedLessons.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["LessonsPurchasedID"].Value);

                tbFieldInfo4.Text = a;
                DataGrid_PurchasedLessons.Hide();
                btnDataGrid.Show();
            }
        }
    }
}









