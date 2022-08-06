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
    public partial class frmPrivateTuition : Form
    {
        public frmPrivateTuition()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain MainForm = new frmMain(); // Assigning the form to a referencable value within this class.
            MainForm.Show(); // Then calling this value, showing the form.
            this.Hide(); // Then hiding this form.
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents StudentTable = new frmStudents();
            StudentTable.Show();
            this.Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers TeacherTable = new frmTeachers();
            TeacherTable.Show();
            this.Hide();
        }

        private void btnInstrument_Click(object sender, EventArgs e)
        {
            frmInstrument InstrumentTable = new frmInstrument();
            InstrumentTable.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom RoomTable = new frmRoom();
            RoomTable.Show();
            this.Hide();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmGrade GradeTable = new frmGrade();
            GradeTable.Show();
            this.Hide();
        }

        private void btnLessonBundle_Click(object sender, EventArgs e)
        {
            frmLessonBundle LessonBundleTable = new frmLessonBundle();
            LessonBundleTable.Show();
            this.Hide();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            frmCalenderDates CalenderDates = new frmCalenderDates();
            CalenderDates.Show();
            this.Hide();
        }

        private void btnScheduledLessons_Click(object sender, EventArgs e)
        {
            frmScheduleTable ScheduleTable = new frmScheduleTable();
            ScheduleTable.Show();
            this.Hide();
        }

        private void btnPurchasedLessons_Click(object sender, EventArgs e)
        {
            PurchasedLessonBundles PurchasedLessons = new PurchasedLessonBundles();
            PurchasedLessons.Show();
            this.Hide();
        }
    }
}
