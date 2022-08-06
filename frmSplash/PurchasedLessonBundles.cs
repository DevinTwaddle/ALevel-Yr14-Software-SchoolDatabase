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

        public PurchasedLessonBundles()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void PurchasedLessonBundles_Load(object sender, EventArgs e)
        {
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

        public void DisplayStudentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students", connection))
            {
                DataTable StudentTable = new DataTable();
                adaptor.Fill(StudentTable);

                cbStudentID.DisplayMember = "StudentID";
                cbStudentID.ValueMember = "StudentID";
                cbStudentID.DataSource = StudentTable;

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
            GlobalVariables.PreviousForm = "PurchasedLessonsTable";

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
    }
}
