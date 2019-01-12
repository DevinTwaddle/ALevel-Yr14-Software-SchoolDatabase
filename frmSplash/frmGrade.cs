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
    public partial class frmGrade : Form
    {
        SqlConnection connection;
        string connectionString;
        int CurrentGradeID;
        int MaxGradeID;
        int MinGradeID;
        SqlDataReader DataReader;

        List<int> Grade_IDs = new List<int>();

        public frmGrade()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        // UPDATE INFORMATION DISPLAYS
        public void Display_GradeDetails()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Grade", connection))
                {
                    DataTable GradeTable = new DataTable();
                    adaptor.Fill(GradeTable);

                    cbGradeSearch.DisplayMember = "GradeLevel";
                    cbGradeSearch.ValueMember = "GradeID";
                    cbGradeSearch.DataSource = GradeTable;

                    lbGradeID.DisplayMember = "GradeID";
                    lbGradeID.ValueMember = "GradeID";
                    lbGradeID.DataSource = GradeTable;

                    lbGradeLevel.DisplayMember = "GradeLevel";
                    lbGradeLevel.ValueMember = "GradeID";
                    lbGradeLevel.DataSource = GradeTable;

                    lbGradeFee.DisplayMember = "Grade Fee";
                    lbGradeFee.ValueMember = "GradeID";
                    lbGradeFee.DataSource = GradeTable;

                    using (SqlCommand Max = new SqlCommand("SELECT MAX(GradeID) FROM Grade", connection))
                    {
                        connection.Open();
                        MaxGradeID = (int)Max.ExecuteScalar();
                    }

                    using (SqlCommand Min = new SqlCommand("Select Min(GradeID) FROM Grade", connection))
                    {
                        MinGradeID = (int)Min.ExecuteScalar();
                        connection.Close();
                    }
                }
            }

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Grade", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Grade_IDs.Add(DataReader.GetInt32(0));
                    }
                }
            }
            connection.Close();
        }


        private void frmGrade_Load(object sender, EventArgs e)
        {
            Display_GradeDetails();
        }

        // VIEW PREVIOUS GRADE RECORD
        private void btnPreviousGrade_Click(object sender, EventArgs e)
        {
            CurrentGradeID = Convert.ToInt32(lbGradeID.SelectedValue);

            if (CurrentGradeID == MinGradeID)
            {
                lbGradeID.SelectedValue = MaxGradeID;
            }
            else
            {
                CurrentGradeID += -1;
                lbGradeID.SelectedValue = CurrentGradeID;
            }
        }

        // VIEW NEXT GRADE RECORD
        private void btnNextGrade_Click(object sender, EventArgs e)
        {
            CurrentGradeID = Convert.ToInt32(lbGradeID.SelectedValue);

            if (CurrentGradeID == MaxGradeID)
            {
                lbGradeID.SelectedValue = MinGradeID;
            }
            else
            {
                CurrentGradeID += 1;
                lbGradeID.SelectedValue = CurrentGradeID;
            }
        }

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition MainMenu = new frmPrivateTuition();
            MainMenu.Show();
            this.Hide();
        }

        // ADD GRADE RECORD
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "GradeTable";
            GlobalVariables.Purpose = "Add";

            frmAddField AddGrade = new frmAddField();
            AddGrade.Show();
            this.Hide();
        }

        // REMOVE GRADE RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "GradeTable";

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
                GlobalVariables.TableID = Convert.ToInt32(lbGradeID.Text);
                GlobalVariables.FieldNames = lbGradeLevel.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }


        // BUTTON SELECT FEEDBACK
        // Previous grade
        private void btnPreviousGrade_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousGrade.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnPreviousGrade_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousGrade.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Next Grade
        private void btnNextGrade_MouseEnter(object sender, EventArgs e)
        {
            btnNextGrade.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnNextGrade_MouseLeave(object sender, EventArgs e)
        {
            btnNextGrade.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Add Grade
        private void btnAddGrade_MouseEnter(object sender, EventArgs e)
        {
            btnAddGrade.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnAddGrade_MouseLeave(object sender, EventArgs e)
        {
            btnAddGrade.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Remove Grade
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

        // Return to Main Menu
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

        // First Grade
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

        // Last Grade
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
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



        // UPDATE RECORD
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "GradeTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbGradeID.GetItemText(lbGradeID.SelectedItem);

            GlobalVariables.Grade_Level = lbGradeLevel.GetItemText(lbGradeLevel.SelectedItem);
            GlobalVariables.Grade_Fee = lbGradeFee.GetItemText(lbGradeFee.SelectedItem);

            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }

        // FIRST / LAST RECORD
        private void pbFirstRecord_Click(object sender, EventArgs e)
        {
            lbGradeID.SelectedValue = Grade_IDs[0];
        }
        private void pbLastRecord_Click(object sender, EventArgs e)
        {
            lbGradeID.SelectedValue = Grade_IDs[(Grade_IDs.Count() - 1)];
        }
    }
}
