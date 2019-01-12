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
    public partial class frmLessonBundle : Form
    {
        SqlConnection connection;
        string connectionString;
        int MaxBundleID;
        int MinBundleID;
        int CurrentBundleID;
        SqlDataReader DataReader;
        List<int> LessonBundle_IDs = new List<int>();

        public frmLessonBundle()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmLessonBundle_Load(object sender, EventArgs e)
        {
            Display_BundleDetails();
        }

        // DISPLAY LESSON BUNDLE INFORMATION
        public void Display_BundleDetails()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM LessonBundles", connection))
                {
                    DataTable BundleTable = new DataTable();
                    adaptor.Fill(BundleTable);


                    cbBundleSearch.DisplayMember = "Lesson Bundle";
                    cbBundleSearch.ValueMember = "LessonBundleID";
                    cbBundleSearch.DataSource = BundleTable;

                    lbLessonBundleID.DisplayMember = "LessonBundleID";
                    lbLessonBundleID.ValueMember = "LessonBundleID";
                    lbLessonBundleID.DataSource = BundleTable;

                    lbLessonBundleName.DisplayMember = "Lesson Bundle";
                    lbLessonBundleName.ValueMember = "LessonBundleID";
                    lbLessonBundleName.DataSource = BundleTable;

                    lbBundleCost.DisplayMember = "Bundle Cost";
                    lbBundleCost.ValueMember = "LessonBundleID";
                    lbBundleCost.DataSource = BundleTable;

                    lbDiscount.DisplayMember = "Multiplier (Discount Rate)";
                    lbDiscount.ValueMember = "LessonBundleID";
                    lbDiscount.DataSource = BundleTable;

                    using (SqlCommand Max = new SqlCommand("SELECT MAX(LessonBundleID) FROM LessonBundles", connection))
                    {
                        connection.Open();
                        MaxBundleID = (int)Max.ExecuteScalar();
                    }

                    using (SqlCommand Min = new SqlCommand("Select Min(LessonBundleID) FROM LessonBundles", connection))
                    {
                        MinBundleID = (int)Min.ExecuteScalar();
                        connection.Close();
                    }

                }
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM LessonBundles", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        LessonBundle_IDs.Add(DataReader.GetInt32(0));
                    }
                }
                connection.Close();
            }
        }

        // VIEW PREVIOUS LESSON BUNDLE
        private void btnPreviousIBundle_Click(object sender, EventArgs e)
        {
            CurrentBundleID = Convert.ToInt32(lbLessonBundleID.SelectedValue);

            if (CurrentBundleID == MinBundleID)
            {
                lbLessonBundleID.SelectedValue = MaxBundleID;
            }
            else
            {
                CurrentBundleID += -1;
                lbLessonBundleID.SelectedValue = CurrentBundleID;
            }
        }

        // VIEW NEXT LESSON BUNDLE
        private void btnNextLessonBundle_Click(object sender, EventArgs e)
        {
            CurrentBundleID = Convert.ToInt32(lbLessonBundleID.SelectedValue);

            if (CurrentBundleID == MaxBundleID)
            {
                lbLessonBundleID.SelectedValue = MinBundleID;
            }
            else
            {
                CurrentBundleID += 1;
                lbLessonBundleID.SelectedValue = CurrentBundleID;
            }
        }

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition MainMenu = new frmPrivateTuition();
            MainMenu.Show();
            this.Hide();
        }

        // ADD NEW RECORD
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "LessonBundleTable";
            GlobalVariables.Purpose = "Add";

            frmAddField Addscheudle = new frmAddField();
            Addscheudle.Show();
            this.Hide();
        }

        // REMOVE RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "LessonBundleTable";

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
                GlobalVariables.TableID = Convert.ToInt32(lbLessonBundleID.Text);
                GlobalVariables.FieldNames = lbLessonBundleName.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }

        // BUTTON SELECT MODIFCATIONS
        // Previous bundle
        private void btnPreviousIBundle_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousIBundle.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnPreviousIBundle_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousIBundle.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Next Bundle
        private void btnNextLessonBundle_MouseEnter(object sender, EventArgs e)
        {
            btnNextLessonBundle.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnNextLessonBundle_MouseLeave(object sender, EventArgs e)
        {
            btnNextLessonBundle.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Add new Bundle
        private void btnAddBundle_MouseEnter(object sender, EventArgs e)
        {
            btnAddBundle.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnAddBundle_MouseLeave(object sender, EventArgs e)
        {
            btnAddBundle.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Remove Bundle
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

        // First Bundle
        private void pbFirstBundle_MouseEnter(object sender, EventArgs e)
        {
            pbFirstBundle.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pbFirstBundle_MouseLeave(object sender, EventArgs e)
        {
            pbFirstBundle.Image = Properties.Resources.Arrow2;
            this.Cursor = Cursors.Arrow;
        }

        // Last Bundle
        private void pbLastBundle_MouseEnter(object sender, EventArgs e)
        {
            pbLastBundle.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pbLastBundle_MouseLeave(object sender, EventArgs e)
        {
            pbLastBundle.Image = Properties.Resources.Arrow2_Inverted_;
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
            GlobalVariables.PreviousForm = "LessonBundleTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbLessonBundleID.GetItemText(lbLessonBundleID.SelectedItem);

            GlobalVariables.Bundle_Name = lbLessonBundleName.GetItemText(lbLessonBundleName.SelectedItem);
            GlobalVariables.Bundle_Cost = lbBundleCost.GetItemText(lbBundleCost.SelectedItem);
            GlobalVariables.Bundle_Discount = lbDiscount.GetItemText(lbDiscount.SelectedItem);

            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }

        // FIRST / LAST RECORD
        private void pbFirstBundle_Click(object sender, EventArgs e)
        {
            lbLessonBundleID.SelectedValue = LessonBundle_IDs[0];
        }
        private void pbLastBundle_Click(object sender, EventArgs e)
        {
            lbLessonBundleID.SelectedValue = LessonBundle_IDs[(LessonBundle_IDs.Count() - 1)];
        }
    }
}
