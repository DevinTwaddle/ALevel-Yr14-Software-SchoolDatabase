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

        public frmLessonBundle()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        public void Display_BundleDetails()
        {
            using (connection = new SqlConnection(connectionString))
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

        private void frmLessonBundle_Load(object sender, EventArgs e)
        {
            Display_BundleDetails();
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition MainMenu = new frmPrivateTuition();
            MainMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "LessonBundleTable";

            frmAddField Addscheudle = new frmAddField();
            Addscheudle.Show();
            this.Hide();
        }
    }
}
