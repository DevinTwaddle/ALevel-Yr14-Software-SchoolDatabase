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

        public frmGrade()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        public void Display_GradeDetails()
        {
            using (connection = new SqlConnection(connectionString))
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

        private void frmGrade_Load(object sender, EventArgs e)
        {
            Display_GradeDetails();
        }


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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition MainMenu = new frmPrivateTuition();
            MainMenu.Show();
            this.Hide();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "GradeTable";

            frmAddField AddGrade = new frmAddField();
            AddGrade.Show();
            this.Hide();
        }
    }
}
