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
    public partial class frmInvoiceReport : Form
    {
        SqlDataReader DataReader;

        SqlConnection connection;
        string connectionString;
        List<int> Purchase_IDs = new List<int>();
        List<int> Purchase_LessonBundle = new List<int>();
        List<DateTime> Purchase_PurchasedDate = new List<DateTime>();
        List<decimal> Purchase_BundleCost = new List<decimal>();
        List<bool> Displays = new List<bool>();
        double Total;

        Bitmap bmp;

        public frmInvoiceReport()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmInvoiceReport_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 6; x++)
            {
                Displays.Add(false);
            }

            lblErrorMessage.Hide();
            label3.Text = GlobalVariables.StudentName;

            Search();
            FIll_Display();
            Hide_ExcessInformation();
        }

        public void Search()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM LessonsPurchased WHERE StudentID = @StudentID AND Payment_Recieved = @Payment", connection))
                {
                    Command.Parameters.AddWithValue("@StudentID", GlobalVariables.Invoice_SelectedStudentID);
                    Command.Parameters.AddWithValue("@Payment", 0);

                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Purchase_IDs.Add(DataReader.GetInt32(0));
                        Purchase_LessonBundle.Add(DataReader.GetInt32(2));
                        Purchase_PurchasedDate.Add(DataReader.GetDateTime(3));
                        Purchase_BundleCost.Add(DataReader.GetDecimal(7));
                    }
                }
                connection.Close();
            }
        }

        public void FIll_Display()
        {
            for (int x = 0; x < Purchase_IDs.Count(); x++)
            {
                if (Displays[0] == false)
                {
                    lblPurchasedLessonID1.Text = Purchase_IDs[x].ToString();
                    lblStartDate1.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays1.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime1.Text = Purchase_BundleCost[x].ToString();
                    Displays[0] = true;
                }
                else if (Displays[1] == false)
                {
                    lblPurchasedLessonID2.Text = Purchase_IDs[x].ToString();
                    lblStartDate2.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays2.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime2.Text = Purchase_BundleCost[x].ToString();
                    Displays[1] = true;
                }
                else if (Displays[2] == false)
                {
                    lblPurchasedLessonID3.Text = Purchase_IDs[x].ToString();
                    lblStartDate3.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays3.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime3.Text = Purchase_BundleCost[x].ToString();
                    Displays[2] = true;
                }
                else if (Displays[3] == false)
                {
                    lblPurchasedLessonID4.Text = Purchase_IDs[x].ToString();
                    lblStartDate4.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays4.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime4.Text = Purchase_BundleCost[x].ToString();
                    Displays[3] = true;
                }
                else if (Displays[4] == false)
                {
                    lblPurchasedLessonID5.Text = Purchase_IDs[x].ToString();
                    lblStartDate5.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays5.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime5.Text = Purchase_BundleCost[x].ToString();
                    Displays[4] = true;
                }
                else if (Displays[5] == false)
                {
                    lblPurchasedLessonID6.Text = Purchase_IDs[x].ToString();
                    lblStartDate6.Text = Purchase_LessonBundle[x].ToString();
                    lblBookedDays6.Text = Purchase_PurchasedDate[x].ToShortDateString();
                    lblBookedTime6.Text = Purchase_BundleCost[x].ToString();
                    Displays[5] = true;
                }

                Total = Total + Convert.ToInt32(Purchase_BundleCost[x]);
                lblTotal.Text = Total.ToString();
            }

        }

        public void Hide_ExcessInformation()
        {
            if (Displays[0] == false)
            {
                lblPurchasedLessonID1.Hide();
                lblStartDate1.Hide();
                lblBookedDays1.Hide();
                lblBookedTime1.Hide();
                pbDisplay1.Hide();
            }
            if (Displays[1] == false)
            {
                lblPurchasedLessonID2.Hide();
                lblStartDate2.Hide();
                lblBookedDays2.Hide();
                lblBookedTime2.Hide();
                pbDisplay2.Hide();
            }
            if (Displays[2] == false)
            {
                lblPurchasedLessonID3.Hide();
                lblStartDate3.Hide();
                lblBookedDays3.Hide();
                lblBookedTime3.Hide();
                pbDisplay3.Hide();
            }
            if (Displays[3] == false)
            {
                lblPurchasedLessonID4.Hide();
                lblStartDate4.Hide();
                lblBookedDays4.Hide();
                lblBookedTime4.Hide();
                pbDisplay4.Hide();
            }
            if (Displays[4] == false)
            {
                lblPurchasedLessonID5.Hide();
                lblStartDate5.Hide();
                lblBookedDays5.Hide();
                lblBookedTime5.Hide();
                pbDisplay5.Hide();
            }
            if (Displays[5] == false)
            {
                lblPurchasedLessonID6.Hide();
                lblStartDate6.Hide();
                lblBookedDays6.Hide();
                lblBookedTime6.Hide();
                pbDisplay6.Hide();
            }

            if (Displays[0] == false && Displays[1] == false && Displays[2] == false && Displays[3] == false && Displays[4] == false && Displays[5] == false)
            {
                lblErrorMessage.Show();
                lblErrorMessage.Text = "This Student currently possess no outstanding purchased lesson records.";
                lblErrorMessage.Location = new Point(46, 269);
            }
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Menu = new frmPrivateTuition();
            Menu.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        // Print Button
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
            this.Cursor = Cursors.Hand;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.PaleGreen;
            this.Cursor = Cursors.Arrow;
        }
    }
}
