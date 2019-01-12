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
    public partial class PurchasedLessonBundles : Form
    {
        SqlConnection connection;
        string connectionString;
        int CurrentStudentID;
        int MinStudentID;
        int MaxStudentID;
        SqlDataReader DataReader;
        List<int> AllScheduleLessonBundleIDs = new List<int>();
        List<int> AllLessonBundleIDs = new List<int>();
        List<int> AllLessonCosts = new List<int>();
        List<double> ALlLessonDiscounts = new List<double>();
        List<int> AllPurchase_StudentID = new List<int>();
        List<int> AllStudnetGradeID = new List<int>();
        List<int> AllGradeFee = new List<int>();

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

        List<int> PurchasedLessons_StudentID = new List<int>();
        List<int> PurchasedLessons_LessonBundleID = new List<int>();
        List<DateTime> PurchasedLessons_PaymentDate = new List<DateTime>();
        List<string> PurchasedLessons_Method = new List<string>();
        List<bool> PurchasedLessons_Recieved = new List<bool>();
        List<string> PurchsedLessons_RecievedDate = new List<string>();
        List<decimal> PurchasedLessons_BundleCost = new List<decimal>();


        public PurchasedLessonBundles()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void PurchasedLessonBundles_Load(object sender, EventArgs e)
        {
            StoreAllStudentIDs();
            Fill_StudentSearchBox();
            StorePurchasedInformation();
            DisplayStudentDetails();
            DisplayPurchaseDetails();
            DisplayBundleDetails();
            DisplayGradeDetails();
            DataGridPurchasedLessons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public void DisplayPurchaseDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM LessonsPurchased WHERE StudentID = @Value", connection))
            {
                command.Parameters.Add(new SqlParameter("@value", lbStudentID.Text));

                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable PurchaseDetails = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(PurchaseDetails);

                    lbBundleID.DisplayMember = "LessonBundleID";
                    lbBundleID.ValueMember = "LessonsPurchasedID";
                    lbBundleID.DataSource = PurchaseDetails;

                    lbPurchaseID.DisplayMember = "LessonsPurchasedID";
                    lbPurchaseID.ValueMember = "LessonsPurchasedID";
                    lbPurchaseID.DataSource = PurchaseDetails;

                    DataGridPurchasedLessons.DataSource = PurchaseDetails;
                }
            }
        }

             public void StorePurchasedInformation()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * FROM LessonsPurchased", connection))
                {
                    connection.Open();
                    DataReader = cmd.ExecuteReader();

                    while (DataReader.Read())
                    {
                        PurchasedLessons_StudentID.Add(DataReader.GetInt32(1));
                        PurchasedLessons_LessonBundleID.Add(DataReader.GetInt32(2));
                        PurchasedLessons_PaymentDate.Add(DataReader.GetDateTime(3));
                        PurchasedLessons_Method.Add(DataReader.GetString(4));
                        PurchasedLessons_Recieved.Add(DataReader.GetBoolean(5));
                        PurchsedLessons_RecievedDate.Add(DataReader.GetString(6));
                        PurchasedLessons_BundleCost.Add(DataReader.GetDecimal(7));
                    }

                    connection.Close();
                }
            }

        }

        public void DisplayStudentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students", connection))
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
                using (SqlCommand Max = new SqlCommand("SELECT MAX(StudentID) FROM Students", connection))
                {
                    connection.Open();
                    MaxStudentID = (int)Max.ExecuteScalar();
                    connection.Close();
                }

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Min = new SqlCommand("Select Min(StudentID) FROM Students", connection))
                {
                    connection.Open();
                    MinStudentID = (int)Min.ExecuteScalar();
                    connection.Close();
                }
            }

          
        }


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


        public void DisplayBundleDetails()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM LessonBundles WHERE LessonBundleID = @Value", connection))
            {
                command.Parameters.Add(new SqlParameter("@value", lbBundleID.Text));
                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable BundleDetails = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(BundleDetails);

                    lbLessonBundle.DisplayMember = "Lesson Bundle";
                    lbLessonBundle.ValueMember = "LessonsPurchasedID";
                    lbLessonBundle.DataSource = BundleDetails;

                    lbBundleCost.DisplayMember = "Bundle Cost";
                    lbBundleCost.ValueMember = "LessonsPurchasedID";
                    lbBundleCost.DataSource = BundleDetails;

                    lbCostMultiplier.DisplayMember = "Multiplier (Discount Rate)";
                    lbCostMultiplier.ValueMember = "LessonsPurchasedID";
                    lbCostMultiplier.DataSource = BundleDetails;
                }
            }

        }

        private void lbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPurchaseDetails();
            DisplayBundleDetails();
            DisplayGradeDetails();
        }


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

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "PurchasedLessonBundleTable";

            frmAddField AddPurchase = new frmAddField();
            AddPurchase.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Menu = new frmPrivateTuition();
            Menu.Show();
            this.Hide();
        }

        private void lbPurchaseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBundleDetails();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "PurchasedLessonsTable";

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
                // If a user is logged in, load confirmation page.
                if (lbPurchaseID != null && !string.IsNullOrWhiteSpace(lbPurchaseID.Text))
                {
                    GlobalVariables.TableID = Convert.ToInt32(lbPurchaseID.Text);
                    GlobalVariables.FieldNames = lbFirstName.Text + " " + lbSurname.Text;

                    frmConfirmation Confirmation = new frmConfirmation();
                    Confirmation.Show();
                }
                else
                {
                    MessageBox.Show("Please select a Lesson from the menu below. If none are present, then this student has not purchased any lessons.");
                }
                
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
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

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
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

            // Add Record
        private void btnAddPurchase_MouseEnter(object sender, EventArgs e)
        {
            btnAddPurchase.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnAddPurchase_MouseLeave(object sender, EventArgs e)
        {
            btnAddPurchase.BackColor = Color.SeaGreen;
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

            // Return To Main Menu
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbPurchaseID != null && !string.IsNullOrWhiteSpace(lbPurchaseID.Text))
            {
                for (int x = 0; x < PurchasedLessons_StudentID.Count(); x++)
                {
                    if (PurchasedLessons_StudentID[x].ToString() == lbStudentID.Text)
                    {
                        GlobalVariables.PreviousForm = "PurchasedLessonBundleTable";
                        GlobalVariables.Purpose = "Update";
                        GlobalVariables.UpdateID = lbPurchaseID.GetItemText(lbPurchaseID.SelectedItem);

                        GlobalVariables.Purchase_StudentID = PurchasedLessons_StudentID[x].ToString();
                        GlobalVariables.Purchase_BundleID = PurchasedLessons_LessonBundleID[x].ToString();
                        GlobalVariables.Purchase_Date = PurchasedLessons_PaymentDate[x].ToShortDateString();
                        GlobalVariables.Purchase_Method = PurchasedLessons_Method[x];
                        GlobalVariables.Purchase_Recieved = PurchasedLessons_Recieved[x].ToString();
                        GlobalVariables.Purchase_ReceivedDate = PurchsedLessons_RecievedDate[x];
                        GlobalVariables.Purchase_BundleCosts = PurchasedLessons_BundleCost[x].ToString();

                        frmAddField Add = new frmAddField();
                        Add.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a Purchased Lesson Record.");
            }
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


