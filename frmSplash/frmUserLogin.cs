using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class frmUserLogin : Form
    {
        
        public frmUserLogin()
        {
            InitializeComponent();
            lblError.Hide();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Admin" && tbPassword.Text == "Admin")
            {
                GlobalVariables.UserLoggedIn = true;
                GlobalVariables.Username = "Admin";
                CheckPreviousForm();
            }
            else
            {
                lblError.Show();
                lblError.Text = "Incorrect Details.";
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            CheckPreviousForm();
        }



        public void CheckPreviousForm()
        {
            if (GlobalVariables.PreviousForm == "StudentTable")
            {
                frmStudents StudentTable = new frmStudents();
                StudentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "TeacherTable")
            {
                frmTeachers TeacherTable = new frmTeachers();
                TeacherTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "InstrumentTable")
            {
                frmInstrument InstrumentTable = new frmInstrument();
                InstrumentTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "RoomTable")
            {
                frmRoom RoomTable = new frmRoom();
                RoomTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "GradeTable")
            {
                frmGrade GradeTable = new frmGrade();
                GradeTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "LessonBundleTable")
            {
                frmLessonBundle LessonBundleTable = new frmLessonBundle();
                LessonBundleTable.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "Menu")
            {
                frmPrivateTuition Menu = new frmPrivateTuition();
                Menu.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "ScheduledLessonTable")
            {
                frmScheduleTable Schedule = new frmScheduleTable();
                Schedule.Show();
                this.Hide();
            }
            else if (GlobalVariables.PreviousForm == "PurchasedLessonBundleTable")
            {
                PurchasedLessonBundles Purchase = new PurchasedLessonBundles();
                Purchase.Show();
                this.Hide();
            }
        }
    }
}
