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
    public partial class frmScheduleTable : Form
    {
        SqlConnection connection;
        string connectionString;
        int CurrentStudentID;
        int MinStudentID;
        int MaxStudentID;


        public frmScheduleTable()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmScheduleTable_Load(object sender, EventArgs e)
        {
            DisplayStudentDetails();
            DisplayTeacherDetails();
            DisplayScheduleDetails();
            DisplayGradeDetails();

            if (GlobalVariables.CalenderStudentID != 0)
            {
                lbStudentID.Text = GlobalVariables.CalenderStudentID.ToString();
                lbScheduledLessons.Text = GlobalVariables.CalenderScheduledID.ToString();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition PrivateTuition = new frmPrivateTuition();
            PrivateTuition.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "ScheduledLessonTable";

            frmAddField Addscheudle = new frmAddField();
            Addscheudle.Show();
            this.Hide();
        }


        public void DisplayScheduleDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Scheduled_Lessons WHERE StudentID = @Value", connection))
            {
                command.Parameters.Add(new SqlParameter("@value", lbStudentID.Text));

                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable ScheduledDetails = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(ScheduledDetails);

                    lbTeacherID.DisplayMember = "TeacherID";
                    lbTeacherID.ValueMember = "ScheduleID";
                    lbTeacherID.DataSource = ScheduledDetails;

                    lbScheduledLessons.DisplayMember = "ScheduleID";
                    lbScheduledLessons.ValueMember = "ScheduleID";
                    lbScheduledLessons.DataSource = ScheduledDetails;

                    dataGridView1.DataSource = ScheduledDetails;
                }
            }

            }


        public void DisplayStudentDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Students ORDER BY First_Name", connection))
            {
                DataTable StudentTable = new DataTable();
                adaptor.Fill(StudentTable);

                cbStudentID.DisplayMember = "First_Name";
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


        public void DisplayTeacherDetails()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Teachers WHERE TeacherID = @ID", connection))
            {
                command.Parameters.Add(new SqlParameter("@ID", lbTeacherID.Text));

                using (SqlDataAdapter Adaptor = new SqlDataAdapter())
                {
                    DataTable TeacherTable = new DataTable();
                    Adaptor.SelectCommand = command;
                    Adaptor.Fill(TeacherTable);


                    lbTeacherFirst_Name.DisplayMember = "First_Name";
                    lbTeacherFirst_Name.ValueMember = "TeacherID";
                    lbTeacherFirst_Name.DataSource = TeacherTable;

                    lbTeacherSurname.DisplayMember = "Surname";
                    lbTeacherSurname.ValueMember = "TeacherID";
                    lbTeacherSurname.DataSource = TeacherTable;

                    lbSpecialisation.DisplayMember = "Specialisation";
                    lbSpecialisation.ValueMember = "TeacherID";
                    lbSpecialisation.DataSource = TeacherTable;

                    lbRoomID.DisplayMember = "RoomID";
                    lbRoomID.ValueMember = "TeacherID";
                    lbRoomID.DataSource = TeacherTable;
                }
            }
        }


        private void lbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayScheduleDetails();
            DisplayTeacherDetails();
            DisplayGradeDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariables.scheduleErrorMessage = false;
            frmClassSchedule ClassSchedule = new frmClassSchedule();
            ClassSchedule.Show();
            this.Hide();
        }
    }
}
