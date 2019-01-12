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
    public partial class frmInvoiceStudentSelection : Form
    {
        SqlDataReader DataReader;

        SqlConnection connection;
        string connectionString;

        List<int> Students_StudentID = new List<int>();
        List<string> Students_FirstName = new List<string>();
        List<string> Students_Surname = new List<string>();
        List<string> Students_FullName_AND_StudentID = new List<string>();

        public frmInvoiceStudentSelection()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
            Store_StudentInforamtion();
            SelectedStudentName();
        }

        public void Store_StudentInforamtion()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Students", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Students_StudentID.Add(DataReader.GetInt32(0));
                        Students_FirstName.Add(DataReader.GetString(1));
                        Students_Surname.Add(DataReader.GetString(3));
                    }
                }
                connection.Close();
            }

            for (int x = 0; x < Students_StudentID.Count(); x++)
            {
                Students_FullName_AND_StudentID.Add(Students_StudentID[x] + "    |    " + Students_FirstName[x] + " " + Students_Surname[x]);
            }
            comboBox1.DataSource = Students_FullName_AND_StudentID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Sub;
            for (int x = 0; x < comboBox1.Text.Length; x++)
            {
                Sub = comboBox1.Text.Substring(x, 1);
                if (Sub == " ")
                {
                    GlobalVariables.Invoice_SelectedStudentID = Convert.ToInt32(comboBox1.Text.Substring(0, x));
                    break;
                }
            }
        }

        public void SelectedStudentName()
        {
            for (int x = 0; x < Students_StudentID.Count(); x++)
            {
                if (GlobalVariables.Invoice_SelectedStudentID == Students_StudentID[x])
                {
                    GlobalVariables.StudentName = Students_FirstName[x] + " " + Students_Surname[x];
                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmInvoiceReport Report = new frmInvoiceReport();
            Report.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Menu = new frmPrivateTuition();
            Menu.Show();
            this.Hide();
        }
    }
}
