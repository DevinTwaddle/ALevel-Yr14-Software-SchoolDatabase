using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace frmSplash
{
    public partial class frmConfirmation : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmConfirmation()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;


            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                DeleteStudentRecord();
            }
            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                DeleteTeacherRecord();
            }
            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                DeleteInstrumentRecord();
            }
            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                DeleteRoomRecord();
            }
            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                DeleteGradeRecord();
            }
            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                DeleteLessonBundleRecord();
            }
            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable")
            {
                DeleteScheduledLessoRecord();
            }
            else if (GlobalVariables.PreviousForm == "PurchasedLessonsTable")
            {
                DeletePurchasedLessonRecord();
            }
        }



        public void DeleteStudentRecord()
        {
            lblPlaceholder1.Text = "Student ID:";
            lblPlaceholder2.Text = "Student Name:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeleteTeacherRecord()
        {
            lblPlaceholder1.Text = "Teacher ID:";
            lblPlaceholder2.Text = "Teacher Name:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }


        public void DeleteInstrumentRecord()
        {
            lblPlaceholder1.Text = "Instrument ID:";
            lblPlaceholder2.Text = "Instrument Type-Name:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeleteRoomRecord()
        {
            lblPlaceholder1.Text = "Room ID:";
            lblPlaceholder2.Text = "Room Specialisation:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeleteGradeRecord()
        {
            lblPlaceholder1.Text = "Grade ID:";
            lblPlaceholder2.Text = "Grade Level:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeleteLessonBundleRecord()
        {
            lblPlaceholder1.Text = "Lesson Bundle ID:";
            lblPlaceholder2.Text = "Lesson Bundle:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeleteScheduledLessoRecord()
        {
            lblPlaceholder1.Text = "Scheduled Lesson ID:";
            lblPlaceholder2.Text = "Student Name";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }

        public void DeletePurchasedLessonRecord()
        {
            lblPlaceholder1.Text = "Purchased Lesson ID:";
            lblPlaceholder2.Text = "Student Name:";

            tbFieldID.Text = GlobalVariables.TableID.ToString();
            tbFieldName.Text = GlobalVariables.FieldNames;
        }



        public void ReturnToPreviousForm()
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToPreviousForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Studentcmd = new SqlCommand("DELETE FROM LessonsPurchased WHERE StudentID = @Value", connection))
                {
                    connection.Open();
                    Studentcmd.Parameters.AddWithValue("@Value", Convert.ToInt32(tbFieldID.Text));
                    Studentcmd.ExecuteNonQuery();
                    connection.Close();
                }

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Studentcmd = new SqlCommand("DELETE FROM Scheduled_Lessons WHERE StudentID = @Value", connection))
                {
                    connection.Open();
                    Studentcmd.Parameters.AddWithValue("@Value", Convert.ToInt32(tbFieldID.Text));
                    Studentcmd.ExecuteNonQuery();
                    connection.Close();
                }

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Studentcmd = new SqlCommand("DELETE FROM Students WHERE StudentID = @Value", connection))
                {
                    connection.Open();
                    Studentcmd.Parameters.AddWithValue("@Value", Convert.ToInt32(tbFieldID.Text));
                    Studentcmd.ExecuteNonQuery();
                    connection.Close();
                }


                GlobalVariables.StudentForm.DisplayStudent();
                this.Hide();
            }
        }
    }
}
