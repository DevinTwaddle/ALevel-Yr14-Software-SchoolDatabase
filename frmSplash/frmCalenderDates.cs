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
    public partial class frmCalenderDates : Form
    {
        string SelectedDate;
        DateTime SearchDate;
        DateTime CurrentDate;
        int CurrentYear;
        int SelectedMonth;
        int SelectedDay;
        int SelectedYear;
        string DatePlaceholder;
        string CurrentDatePlaceholder;


        public frmCalenderDates()
        {
            InitializeComponent();

        }

        private void frmCalenderDates_Load(object sender, EventArgs e)
        {
            CurrentDate = DateTime.Today;
            CurrentDatePlaceholder = Convert.ToString(CurrentDate);
            CurrentYear = Convert.ToInt32(CurrentDatePlaceholder.Substring(6, 4));
        } 


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // This block of code is used to individually store data from the selected date variable.
            SelectedDate = ScheduleCalendar.SelectionRange.Start.ToShortDateString(); // This identifies the selected date and assigns it to the selectedate variable.
            DatePlaceholder = Convert.ToString(SelectedDate); // This also converts the date to a string for simple use.

            // Then with the use of sunstrings, it is possible to individually assign values to global variables.
            GlobalVariables.SelectedDay = Convert.ToInt32(DatePlaceholder.Substring(0, 2)); 
            GlobalVariables.SelectedMonthInt = Convert.ToInt32(DatePlaceholder.Substring(3, 2));
            GlobalVariables.SelectedYear = Convert.ToInt32(DatePlaceholder.Substring(6, 4));

           

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will provide the user with the ability to quickly access any month.
            if (comboBox1.Text == "January")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/01/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "February")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/02/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "March")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/03/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "April")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/04/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "May")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/05/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "June")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/06/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "July")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/07/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "August")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/08/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "September")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/09/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "October")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/10/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "November")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/11/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }
            else if (comboBox1.Text == "December")
            {
                SearchDate = Convert.ToDateTime(String.Format("01/12/{0}", CurrentYear));
                ScheduleCalendar.SetDate(SearchDate);
            }

        }

        private void ScheduleCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime SelectedDate = new DateTime(GlobalVariables.SelectedYear, GlobalVariables.SelectedMonthInt, GlobalVariables.SelectedDay);
            GlobalVariables.DayName = SelectedDate.ToString("dddd");

            // This if statement will provide an error message should July or August be selected.
            if (GlobalVariables.SelectedMonthInt == 07 || GlobalVariables.SelectedMonthInt == 08)
            {
                MessageBox.Show("Private classes are unavaliable during Summer Months");
            }
            // This statement will provide an error should a weekend be selected.
            else if (GlobalVariables.DayName == "Saturday" || GlobalVariables.DayName == "Sunday")
            {
                MessageBox.Show("Weekends are reserved for specialised classes");
            }
            // Otherwise the selected month will be saved, and the next form will load.
            else
            {
                if (GlobalVariables.SelectedMonthInt == 09)
                {
                    GlobalVariables.SelectedMonthString = "September";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 10)
                {
                    GlobalVariables.SelectedMonthString = "October";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 11)
                {
                    GlobalVariables.SelectedMonthString = "november";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 12)
                {
                    GlobalVariables.SelectedMonthString = "December";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 01)
                {
                    GlobalVariables.SelectedMonthString = "January";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 02)
                {
                    GlobalVariables.SelectedMonthString = "Februray";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 03)
                {
                    GlobalVariables.SelectedMonthString = "March";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 04)
                {
                    GlobalVariables.SelectedMonthString = "April";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 05)
                {
                    GlobalVariables.SelectedMonthString = "May";

                    LoadCalenderTimes();
                }

                if (GlobalVariables.SelectedMonthInt == 06)
                {
                    GlobalVariables.SelectedMonthString = "June";

                    LoadCalenderTimes();
                }
            }

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition PrivateTuition = new frmPrivateTuition();
            PrivateTuition.Show();
            this.Hide();
        }

        private void LoadCalenderTimes()
        {
         
            frmCalenderTimes CalenderTimes = new frmCalenderTimes();
            CalenderTimes.Show();
            this.Hide();
        }
    }
}
