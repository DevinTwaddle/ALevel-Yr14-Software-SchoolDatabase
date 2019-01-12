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
    public partial class frmStudents : Form
    {
        SqlConnection connection;
        string connectionString;
        int MaxStudentID;
        int MinStudentID;
        int CurrentStudentID;
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


        public frmStudents()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            DisplayStudent();
        }

        // DISPLAY STUDENT INFORMATION
        public void DisplayStudent()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students", connection))
            {
                connection.Open();

                DataTable StudentTable = new DataTable();
                adaptor.Fill(StudentTable);

                lbFirstName.DisplayMember = "First_Name";
                lbFirstName.ValueMember = "StudentID";
                lbFirstName.DataSource = StudentTable;

                lbStudentID.DisplayMember = "StudentID";
                lbStudentID.ValueMember = "StudentID";
                lbStudentID.DataSource = StudentTable;

                lbSurname.DisplayMember = "Surname";
                lbSurname.ValueMember = "StudentID";
                lbSurname.DataSource = StudentTable;

                lbOtherNames.DisplayMember = "Other_Names";
                lbOtherNames.ValueMember = "StudentID";
                lbOtherNames.DataSource = StudentTable;

                lbDOB.DisplayMember = "Date_Of_Birth";
                lbDOB.ValueMember = "StudentID";
                lbDOB.DataSource = StudentTable;

                lbAddress.DisplayMember = "Address";
                lbAddress.ValueMember = "StudentID";
                lbAddress.DataSource = StudentTable;

                lbTown.DisplayMember = "Town";
                lbTown.ValueMember = "StudentID";
                lbTown.DataSource = StudentTable;

                lbPostCode.DisplayMember = "PostCode";
                lbPostCode.ValueMember = "StudentID";
                lbPostCode.DataSource = StudentTable;

                lbContactNum.DisplayMember = "Contact_Number";
                lbContactNum.ValueMember = "StudentID";
                lbContactNum.DataSource = StudentTable;

                lbEmail.DisplayMember = "Email_Address";
                lbEmail.ValueMember = "StudentID";
                lbEmail.DataSource = StudentTable;

                lbGradeID.DisplayMember = "GradeID";
                lbGradeID.ValueMember = "StudentID";
                lbGradeID.DataSource = StudentTable;

                lbInstrumentID.DisplayMember = "InstrumentID";
                lbInstrumentID.ValueMember = "StudentID";
                lbInstrumentID.DataSource = StudentTable;

                lbTuition.DisplayMember = "Tuition_Fee_Recieved";
                lbTuition.ValueMember = "StudentID";
                lbTuition.DataSource = StudentTable;

                connection.Close();

                using (SqlCommand Max = new SqlCommand("SELECT MAX(StudentID) FROM Students", connection))
                {
                    connection.Open();
                    MaxStudentID = (int)Max.ExecuteScalar();
                    connection.Close();
                }

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

        // NAVIGATE POSITIVELY THROUGH STUDENT RECORDS
        private void NextStudent_Click(object sender, EventArgs e)
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

        // NAVIGATE NEGATIVELY THROUGH STUDENT RECORDS
        private void PreviousStudnet_Click(object sender, EventArgs e)
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

        // RETUIRN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        // REMOVE STUDENT RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "StudentTable";

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
                GlobalVariables.TableID = Convert.ToInt32(lbStudentID.Text);
                GlobalVariables.FieldNames = lbFirstName.Text + " " + lbSurname.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }

        // ADD STUDENT FIELD
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "StudentTable";
            GlobalVariables.Purpose = "Add";

            frmAddField AddGrade = new frmAddField();
            AddGrade.Show();
            this.Hide();
        }

        // FIRST AND LAST RECORD DISPLAY
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lbStudentID.SelectedValue = AllStudentIDs[0];
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lbStudentID.SelectedValue = AllStudentIDs[(AllStudentIDs.Count() - 1)];
        }


        // BUTTON MODIFICATIONS
        // Previous Student button
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

        // Next Student Button
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
        // Student Delete button
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

        // Student Add button
        private void btnStudentAdd_MouseEnter(object sender, EventArgs e)
        {
            btnStudentAdd.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnStudentAdd_MouseLeave(object sender, EventArgs e)
        {
            btnStudentAdd.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Close form button
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

        // First and last buttons
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Arrow2;
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.Arrow2_Inverted_;
            this.Cursor = Cursors.Arrow;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "StudentTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbStudentID.GetItemText(lbStudentID.SelectedItem);

            GlobalVariables.Student_FirstName = lbFirstName.GetItemText(lbFirstName.SelectedItem);
            GlobalVariables.Student_OtherNames = lbOtherNames.GetItemText(lbOtherNames.SelectedItem);
            GlobalVariables.Student_Surname = lbSurname.GetItemText(lbSurname.SelectedItem);
            GlobalVariables.Student_DOB = lbDOB.GetItemText(lbDOB.SelectedItem);
            GlobalVariables.Student_Address = lbAddress.GetItemText(lbAddress.SelectedItem);
            GlobalVariables.Student_Town = lbTown.GetItemText(lbTown.SelectedItem);
            GlobalVariables.Student_PostCode = lbPostCode.GetItemText(lbPostCode.SelectedItem);
            GlobalVariables.Student_ContactNumber = lbContactNum.GetItemText(lbContactNum.SelectedItem);
            GlobalVariables.Student_Email = lbEmail.GetItemText(lbEmail.SelectedItem);
            GlobalVariables.Student_GradeID = lbGradeID.GetItemText(lbGradeID.SelectedItem);
            GlobalVariables.Student_InstrumentID = lbInstrumentID.GetItemText(lbInstrumentID.SelectedItem);
            GlobalVariables.Student_PaymentFee = lbTuition.GetItemText(lbTuition.SelectedItem);

            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }


    }
}

