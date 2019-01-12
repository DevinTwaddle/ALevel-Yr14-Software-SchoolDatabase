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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPrivateTuition_Click(object sender, EventArgs e)
        {
            frmPrivateTuition PrivateT = new frmPrivateTuition();
            PrivateT.Show();
            this.Close();
        }

        private void btnWeekendSchool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Is In Development. Please View 'Private Tuition'.");
        }

        private void btnSummerSchool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Is In Development. Please View 'Private Tuition'.");
        }



        // BUTTON FEEDBACK
        // Private Tuition
        private void btnPrivateTuition_MouseEnter(object sender, EventArgs e)
        {
            btnPrivateTuition.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnPrivateTuition_MouseLeave(object sender, EventArgs e)
        {
            btnPrivateTuition.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Weekend School
        private void btnWeekendSchool_MouseEnter(object sender, EventArgs e)
        {
            btnWeekendSchool.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnWeekendSchool_MouseLeave(object sender, EventArgs e)
        {
            btnWeekendSchool.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Summer School
        private void btnSummerSchool_MouseEnter(object sender, EventArgs e)
        {
            btnSummerSchool.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnSummerSchool_MouseLeave(object sender, EventArgs e)
        {
            btnSummerSchool.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }
    }
}
