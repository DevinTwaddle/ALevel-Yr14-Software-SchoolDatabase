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

        public frmStudents()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            DisplayStudent();

        }

        public void DisplayStudent()
        {
            using (connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students",connection))
            {
                DataTable StudentTable = new DataTable();
                adaptor.Fill(StudentTable);

                lbFirstName.DisplayMember = "First_Name";
                lbFirstName.ValueMember = "StudentID";
                lbFirstName.DataSource = StudentTable;

                lbStudentID.DisplayMember = "StudentID";
                lbStudentID.ValueMember = "StudentID";
                lbStudentID.DataSource = StudentTable;

                cbStudentID.DisplayMember = "First_Name";
                cbStudentID.ValueMember = "StudentID";
                cbStudentID.DataSource = StudentTable;

                lbSurname.DisplayMember = "Surname";
                lbSurname.ValueMember = "StudentID";
                lbSurname.DataSource = StudentTable;

                lbOtherNames.DisplayMember = "Other_Name(s)";
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


                using (SqlCommand Max = new SqlCommand("SELECT MAX(StudentID) FROM Students", connection))
                {
                    connection.Open();
                    MaxStudentID = (int)Max.ExecuteScalar();
                }

                using (SqlCommand Min = new SqlCommand("Select Min(StudentID) FROM Students", connection))
                {
                    MinStudentID = (int)Min.ExecuteScalar();
                    connection.Close();
                }

                connection.Close();
            }
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "StudentTable";

            frmAddField Addfield = new frmAddField();
            Addfield.Show();
            this.Hide();
        }
    }
}
