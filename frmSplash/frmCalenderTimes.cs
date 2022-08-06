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
    public partial class frmCalenderTimes : Form
    {
        // Initalise class variables.
        int SelectedTime;
        string SelectedDatePlaceholder;

        public frmCalenderTimes()
        {
            InitializeComponent();
        }

        private void frmCalenderTimes_Load(object sender, EventArgs e)
        {
            GlobalVariables.scheduleErrorMessage = true;

            // This block of code should automatically update accordingly as to display the selected Date.
            GlobalVariables.SelectedScheduleDate = String.Format("{0}/{1}/{2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthInt, GlobalVariables.SelectedYear); // Establishes string format + Enters selected data in global string.
            label1.Text = GlobalVariables.SelectedScheduleDate; // This then writes the date string to a lable present within the form.

            // This block of code will check the selected date, and update the format accodingly for visual astetics.
            if (GlobalVariables.SelectedDay == 1 || GlobalVariables.SelectedDay == 21 || GlobalVariables.SelectedDay == 31)
               {
                 label1.Text = String.Format("{0} {1}st", GlobalVariables.SelectedMonthString, GlobalVariables.SelectedDay);
               }
            else if (GlobalVariables.SelectedDay == 2 || GlobalVariables.SelectedDay == 22)
               {
                  label1.Text = String.Format("{0} {1}nd", GlobalVariables.SelectedMonthString, GlobalVariables.SelectedDay);
               }
            else if(GlobalVariables.SelectedDay == 3 || GlobalVariables.SelectedDay == 23)
               {
                  label1.Text = String.Format("{0} {1}rd", GlobalVariables.SelectedMonthString, GlobalVariables.SelectedDay);
               }
            else
               {
                  label1.Text = String.Format("{0} {1}th", GlobalVariables.SelectedMonthString, GlobalVariables.SelectedDay);
               }


            if (GlobalVariables.SelectedDay == 1 || GlobalVariables.SelectedDay == 2 || GlobalVariables.SelectedDay == 3 || GlobalVariables.SelectedDay == 4 ||
                GlobalVariables.SelectedDay == 5 || GlobalVariables.SelectedDay == 6 || GlobalVariables.SelectedDay == 7 || GlobalVariables.SelectedDay == 8 ||
                GlobalVariables.SelectedDay == 9)
            {
                if (GlobalVariables.SelectedMonthInt != 12 || GlobalVariables.SelectedMonthInt != 11 || GlobalVariables.SelectedMonthInt != 10)
                {
                    GlobalVariables.SelectedScheduleDate = String.Format("0{0}/0{1}/{2}", GlobalVariables.SelectedDay, GlobalVariables.SelectedMonthInt, GlobalVariables.SelectedYear);
                }

            }
        }
            
        

        // Selecting one of the buttons below will set the selectedtime variable, and also load the next form.
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "13:00:00";
            LoadClasSchedule(); // This code is used to run the LoadClassSchedule Function.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "13:30:00";
            GlobalVariables.SelectedTimeTextFormat = "13:30 PM";
            LoadClasSchedule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "14:00:00";
            GlobalVariables.SelectedTimeTextFormat = "14:00 PM";
            LoadClasSchedule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "14:30:00";
            GlobalVariables.SelectedTimeTextFormat = "14:30 PM";
            LoadClasSchedule();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "15:00:00";
            LoadClasSchedule();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "15:30:00";
            LoadClasSchedule();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "16:00:00";
            LoadClasSchedule();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "16:30:00";
            LoadClasSchedule();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "17:00:00";
            LoadClasSchedule();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "17:30:00";
            LoadClasSchedule();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "18:00:00";
            LoadClasSchedule();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "18:30:00";
            LoadClasSchedule();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "19:00:00";
            LoadClasSchedule();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "19:30:00";
            LoadClasSchedule();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "20:00:00";
            LoadClasSchedule();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GlobalVariables.SelectedTime = "20:30:00";
            LoadClasSchedule();
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Resets all variables.
            GlobalVariables.Date1 = false;
            GlobalVariables.Date2 = false;
            GlobalVariables.Date3 = false;
            GlobalVariables.Date4 = false;
            GlobalVariables.Date5 = false;
            GlobalVariables.Date6 = false;
            GlobalVariables.Date7 = false;
            GlobalVariables.Date8 = false;
            GlobalVariables.Date9 = false;
            GlobalVariables.Date10 = false;
            GlobalVariables.Date11 = false;
            GlobalVariables.Date12 = false;
            GlobalVariables.Date13 = false;
            GlobalVariables.Date14 = false;
            GlobalVariables.Date15 = false;
            GlobalVariables.Date16 = false;
            GlobalVariables.Date17 = false;
            GlobalVariables.Date18 = false;
            GlobalVariables.Date19 = false;
            GlobalVariables.Date20 = false;
            GlobalVariables.Date21 = false;
            GlobalVariables.Date22 = false;
            GlobalVariables.Date23 = false;
            GlobalVariables.Date24 = false;
            GlobalVariables.Date25 = false;
            GlobalVariables.Date26 = false;
            GlobalVariables.Date27 = false;
            GlobalVariables.Date28 = false;
            GlobalVariables.Date29 = false;
            GlobalVariables.Date30 = false;
            GlobalVariables.Date31 = false;

            GlobalVariables.September = false;
            GlobalVariables.January = false;
            GlobalVariables.February = false;
            GlobalVariables.March = false;
            GlobalVariables.April = false;
            GlobalVariables.May = false;
            GlobalVariables.June = false;
            GlobalVariables.July = false;
            GlobalVariables.August = false;
            GlobalVariables.October = false;
            GlobalVariables.November = false;
            GlobalVariables.December = false;

            // Loads previous form.
            frmCalenderDates CalenderDates = new frmCalenderDates();
            CalenderDates.Show();
           this.Hide();
        }

        public void LoadClasSchedule()
        {
            GlobalVariables.SelectedTimeTextFormat = GlobalVariables.SelectedTime.Substring(0, 5) + " " + "PM";

            // Simplu loads Class Schedule form.
            frmClassSchedule ClassSchedule = new frmClassSchedule();
            ClassSchedule.Show();
            this.Hide();
        }
    }
}
