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
    public partial class frmSplash : Form
    {
        string LoadMessage; // String will contain text.


        public frmSplash()
        {
            InitializeComponent();

            // This initalises the clock present within the form.
            tLoad.Start();
        }

        private void tLoad_Tick(object sender, EventArgs e)
        {
            LoadingBar.Increment(2); // This will cause the loading bar to increase each time the clock ticks.
            UpdateLoadMessage(); // This line of code will run the updateLoadMessage function, each tick.
        }

        public void UpdateLoadMessage()
        {
            // This function will be used to identify the progress of the loading bar,
            // and will update the loading message accoridnly.

            if(LoadingBar.Value > 0 && LoadingBar.Value < 25)
            {
                LoadMessage = "Initalising program...";
            }
            else if(LoadingBar.Value > 25 && LoadingBar.Value < 75)
            {
                LoadMessage = "Organising files...";
            }
            else
            {
                LoadMessage = "Finalsing program...";
                OpenMenu(); // This line of code is used to run the OpenMenu function.
            }

            lblLoadingProgress.Text = LoadMessage; // Update the label accordinly.
        }

        public void OpenMenu()
        {
            // This function will attempt to open the Main menu.
            if(LoadingBar.Value == 100) // Checks the progress bar.
            {
                tLoad.Stop(); // Disables timer.
                frmMain MainMenu = new frmMain(); // Assigns local value to main form.
                MainMenu.Show(); // Opens Main form.
                this.Hide(); // Closes this form.


            }
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            // This is merely a testing program.
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
            tLoad.Stop();
        }
    }
}
