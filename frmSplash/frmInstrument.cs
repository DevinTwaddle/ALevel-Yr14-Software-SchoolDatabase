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
    public partial class frmInstrument : Form
    {
        SqlConnection connection;
        string connectionString;
        int MaxInstruments;
        int MinInstruments;
        int currentInstrumentID;

        public frmInstrument()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        public void DisplayInstruments()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Instruments", connection))
            {
                DataTable InstrumentTable = new DataTable();
                adaptor.Fill(InstrumentTable);


                cbInstrumentSearch.DisplayMember = "Instrument Name";
                cbInstrumentSearch.ValueMember = "InstrumentID";
                cbInstrumentSearch.DataSource = InstrumentTable;

                lbInstrumentID.DisplayMember = "InstrumentID";
                lbInstrumentID.ValueMember = "InstrumentID";
                lbInstrumentID.DataSource = InstrumentTable;

                lbInstrumentType.DisplayMember = "Instrument Type";
                lbInstrumentType.ValueMember = "InstrumentID";
                lbInstrumentType.DataSource = InstrumentTable;

                lbInstrumentName.DisplayMember = "Instrument Name";
                lbInstrumentName.ValueMember = "InstrumentID";
                lbInstrumentName.DataSource = InstrumentTable;

                lbQuantity.DisplayMember = "Quantity";
                lbQuantity.ValueMember = "InstrumentID";
                lbQuantity.DataSource = InstrumentTable;

                using (SqlCommand Max = new SqlCommand("SELECT MAX(InstrumentID) FROM Instruments", connection))
                {
                    connection.Open();
                    MaxInstruments = (int)Max.ExecuteScalar();
                }

                using (SqlCommand Min = new SqlCommand("Select Min(InstrumentID) FROM Instruments", connection))
                {
                    MinInstruments = (int)Min.ExecuteScalar();
                    connection.Close();
                }
            }
        }

        private void btnPreviousStudent_Click(object sender, EventArgs e)
        {
            currentInstrumentID = Convert.ToInt32(lbInstrumentID.SelectedValue);

            if (currentInstrumentID == MinInstruments)
            {
                lbInstrumentID.SelectedValue = MaxInstruments;
            }
            else
            {
                currentInstrumentID += -1;
                lbInstrumentID.SelectedValue = currentInstrumentID;
            }
        }

        private void btnNextStudent_Click(object sender, EventArgs e)
        {
            currentInstrumentID = Convert.ToInt32(lbInstrumentID.SelectedValue);

            if (currentInstrumentID == MaxInstruments)
            {
                lbInstrumentID.SelectedValue = MinInstruments;
            }
            else
            {
                currentInstrumentID += 1;
                lbInstrumentID.SelectedValue = currentInstrumentID;
            }
        }

        private void frmInstrument_Load(object sender, EventArgs e)
        {
            DisplayInstruments();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }
    }
}
