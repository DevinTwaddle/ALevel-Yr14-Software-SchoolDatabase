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
    public partial class frmTeachers : Form
    {
        SqlConnection connection;
        string connectionString;
        int CurrentTeacherID;
        int MaxTeacherID;
        int MinTeacherID;


        public frmTeachers()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        public void DisplayTeachers()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Teachers", connection))
            {
                DataTable TeacherTable = new DataTable();
                adaptor.Fill(TeacherTable);

                cbTeacherID.DisplayMember = "First_Name";
                cbTeacherID.ValueMember = "TeacherID";
                cbTeacherID.DataSource = TeacherTable;

                lbTeacherID.DisplayMember = "TeacherID";
                lbTeacherID.ValueMember = "TeacherID";
                lbTeacherID.DataSource = TeacherTable;

                lbFirstName.DisplayMember = "First_Name";
                lbFirstName.ValueMember = "TeacherID";
                lbFirstName.DataSource = TeacherTable;

                lbSurname.DisplayMember = "Surname";
                lbSurname.ValueMember = "TeacherID";
                lbSurname.DataSource = TeacherTable;

                lbAddress.DisplayMember = "Address";
                lbAddress.ValueMember = "TeacherID";
                lbAddress.DataSource = TeacherTable;

                lbTown.DisplayMember = "Town";
                lbTown.ValueMember = "TeacherID";
                lbTown.DataSource = TeacherTable;

                lbPostCode.DisplayMember = "PostCode";
                lbPostCode.ValueMember = "TeacherID";
                lbPostCode.DataSource = TeacherTable;

                lbContactNum.DisplayMember = "Contact_Number";
                lbContactNum.ValueMember = "TeacherID";
                lbContactNum.DataSource = TeacherTable;

                lbEmail.DisplayMember = "Email_Address";
                lbEmail.ValueMember = "TeacherID";
                lbEmail.DataSource = TeacherTable;

                lbSpecialisation.DisplayMember = "Specialisation";
                lbSpecialisation.ValueMember = "TeacherID";
                lbSpecialisation.DataSource = TeacherTable;

                lbRoomID.DisplayMember = "RoomID";
                lbRoomID.ValueMember = "TeacherID";
                lbRoomID.DataSource = TeacherTable;

                using (SqlCommand Max = new SqlCommand("SELECT MAX(TeacherID) FROM Teachers", connection))
                {
                    connection.Open();
                    MaxTeacherID = (int)Max.ExecuteScalar();
                }

                using (SqlCommand Min = new SqlCommand("Select Min(TeacherID) FROM Teachers", connection))
                {
                    MinTeacherID = (int)Min.ExecuteScalar();
                    connection.Close();
                }

            }
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            DisplayTeachers();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        private void btnPreviousStudent_Click(object sender, EventArgs e)
        {
            CurrentTeacherID = Convert.ToInt32(lbTeacherID.SelectedValue);

            if (CurrentTeacherID == MinTeacherID)
            {
                lbTeacherID.SelectedValue = MaxTeacherID;
            }
            else
            {
                CurrentTeacherID += -1;
                lbTeacherID.SelectedValue = CurrentTeacherID;
            }
        }

        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            CurrentTeacherID = Convert.ToInt32(lbTeacherID.SelectedValue);

            if (CurrentTeacherID == MaxTeacherID)
            {
                lbTeacherID.SelectedValue = MinTeacherID;
            }
            else
            {
                CurrentTeacherID += 1;
                lbTeacherID.SelectedValue = CurrentTeacherID;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "TeacherTable";

            frmAddField AddTeacher = new frmAddField();
            AddTeacher.Show();
            this.Hide();
        }
    }
}
