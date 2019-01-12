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
        SqlDataReader DataReader;
        List<int> Teacher_IDs = new List<int>();
        List<string> Teachers_FirstName = new List<string>();
        List<string> Teachers_Surname = new List<string>();


        public frmTeachers()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;

        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            DisplayTeachers();
        }

        // DISPLAY TEACHER INFORMATION
        public void DisplayTeachers()
        {
            using (connection = new SqlConnection(connectionString))
            {
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

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Teachers", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Teacher_IDs.Add(DataReader.GetInt32(0));
                        Teachers_FirstName.Add(DataReader.GetString(1));
                        Teachers_Surname.Add(DataReader.GetString(2));
                    }
                }
                connection.Close();
            }
        }

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        // VIEW PREVIOUS TEACHER RECORD
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

        // VIEW NEXT TEACHER RECORD
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

        // ADD NEW RECORD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "TeacherTable";

            frmAddField AddTeacher = new frmAddField();
            AddTeacher.Show();
            this.Hide();
        }

        // REMOVE RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "TeacherTable";

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
                GlobalVariables.TableID = Convert.ToInt32(lbTeacherID.Text);
                GlobalVariables.FieldNames = lbFirstName.Text + " " + lbSurname.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }


        // BUTTON SELECT MODIFICATIONS
             // Previous Record
        private void btnPreviousTeacher_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousTeacher.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnPreviousTeacher_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousTeacher.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

              // Next Record
        private void btnNextTeacher_MouseEnter(object sender, EventArgs e)
        {
            btnNextTeacher.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnNextTeacher_MouseLeave(object sender, EventArgs e)
        {
            btnNextTeacher.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

             // Add Record
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaGreen;
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
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
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
            GlobalVariables.PreviousForm = "TeacherTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbTeacherID.GetItemText(lbTeacherID.SelectedValue);

            GlobalVariables.Teacher_FirstName = lbFirstName.GetItemText(lbFirstName.SelectedItem);
            GlobalVariables.Teacher_Surname = lbSurname.GetItemText(lbSurname.SelectedItem);
            GlobalVariables.Teacher_Address = lbAddress.GetItemText(lbAddress.SelectedItem);
            GlobalVariables.Teacher_Town = lbTown.GetItemText(lbTown.SelectedItem);
            GlobalVariables.Teacher_PostCode = lbPostCode.GetItemText(lbPostCode.SelectedItem);
            GlobalVariables.Teacher_ContactNumber = lbContactNum.GetItemText(lbContactNum.SelectedItem);
            GlobalVariables.Teacher_Email = lbEmail.GetItemText(lbEmail.SelectedItem);
            GlobalVariables.Teacher_Specialisation = lbSpecialisation.GetItemText(lbSpecialisation.SelectedItem);
            GlobalVariables.Teacher_RoomID = lbRoomID.GetItemText(lbRoomID.SelectedItem);


            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }

        private void pbLastRecord_Click(object sender, EventArgs e)
        {
            lbTeacherID.SelectedValue = Teacher_IDs[(Teacher_IDs.Count() - 1)];
        }

        private void pbFirstRecord_Click(object sender, EventArgs e)
        {
            lbTeacherID.SelectedValue = Teacher_IDs[0];
        }
    }
}
