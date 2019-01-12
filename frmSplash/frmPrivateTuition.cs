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
    public partial class frmPrivateTuition : Form
    {
        public frmPrivateTuition()
        {
            InitializeComponent();
            if (GlobalVariables.UserLoggedIn == true)
            {
                lblUserLoginDetail.Text = "Current User: " + GlobalVariables.Username;
                btnLogin.Text = "Logout";
            }
            else
            {
                lblUserLoginDetail.Text = "No Current Admin";
            }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain MainForm = new frmMain(); // Assigning the form to a referencable value within this class.
            MainForm.Show(); // Then calling this value, showing the form.
            this.Hide(); // Then hiding this form.
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            GlobalVariables.StudentForm.Show();
            this.Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            GlobalVariables.TeacherForm.Show();
            this.Hide();
        }

        private void btnInstrument_Click(object sender, EventArgs e)
        {
            GlobalVariables.InstrumentForm.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            GlobalVariables.RoomForm.Show();
            this.Hide();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            GlobalVariables.GradeForm.Show();
            this.Hide();
        }

        private void btnLessonBundle_Click(object sender, EventArgs e)
        {
            GlobalVariables.LessonBundleForm.Show();
            this.Hide();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            GlobalVariables.Calendar.Show();
            this.Hide();
        }

        private void btnScheduledLessons_Click(object sender, EventArgs e)
        {
            GlobalVariables.ScheduledLessonForm.Show();
            this.Hide();
        }

        private void btnPurchasedLessons_Click(object sender, EventArgs e)
        {
            GlobalVariables.PurchasedLessonForm.Show();
            this.Hide();
        }

        private void frmPrivateTuition_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "Menu";

            if (GlobalVariables.UserLoggedIn == true)
            {
                GlobalVariables.Username = "";
                GlobalVariables.UserLoggedIn = false;
                btnLogin.Text = "Login";
                lblUserLoginDetail.Text = "No Current Admin";
            }
            else
            {
                frmUserLogin Login = new frmUserLogin();
                Login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmViewUpcomingLessons upcomingLessons = new frmViewUpcomingLessons();
            upcomingLessons.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmArchiveSchedule Archive = new frmArchiveSchedule();
            Archive.Show();
            this.Hide();
        }

        // BUTTON FEEDBACK
        // Student Button
        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {
            btnStudents.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            btnStudents.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Teacher Button
        private void btnTeachers_MouseEnter(object sender, EventArgs e)
        {
            btnTeachers.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnTeachers_MouseLeave(object sender, EventArgs e)
        {
            btnTeachers.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Instrument Button
        private void btnInstrument_MouseEnter(object sender, EventArgs e)
        {
            btnInstrument.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnInstrument_MouseLeave(object sender, EventArgs e)
        {
            btnInstrument.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Room Button
        private void btnRoom_MouseEnter(object sender, EventArgs e)
        {
            btnRoom.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnRoom_MouseLeave(object sender, EventArgs e)
        {
            btnRoom.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Grade Button
        private void btnGrade_MouseEnter(object sender, EventArgs e)
        {
            btnGrade.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnGrade_MouseLeave(object sender, EventArgs e)
        {
            btnGrade.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // LessonBundle Button
        private void btnLessonBundle_MouseEnter(object sender, EventArgs e)
        {
            btnLessonBundle.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnLessonBundle_MouseLeave(object sender, EventArgs e)
        {
            btnLessonBundle.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Upcoming Lesson Bundles Button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Calendar Button
        private void btnCalender_MouseEnter(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnCalender_MouseLeave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Scheduled Lessons Button
        private void btnScheduledLessons_MouseEnter(object sender, EventArgs e)
        {
            btnScheduledLessons.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnScheduledLessons_MouseLeave(object sender, EventArgs e)
        {
            btnScheduledLessons.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Purchased Lessons Button
        private void btnPurchasedLessons_MouseEnter(object sender, EventArgs e)
        {
            btnPurchasedLessons.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnPurchasedLessons_MouseLeave(object sender, EventArgs e)
        {
            btnPurchasedLessons.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

        // Login button
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightCyan;
            this.Cursor = Cursors.Arrow;
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            frmInvoiceStudentSelection Selection = new frmInvoiceStudentSelection();
            Selection.Show();
            this.Hide();
        }
    }
}
