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
    }
}
