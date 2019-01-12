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
        SqlDataReader DataReader;
        List<int> Instrument_IDs = new List<int>();

        public frmInstrument()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmInstrument_Load(object sender, EventArgs e)
        {
            DisplayInstruments();
        }

        // STORE INSTRUMENT DETIALS
        public void DisplayInstruments()
        {
            using (connection = new SqlConnection(connectionString))
            {
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

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Instruments", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Instrument_IDs.Add(DataReader.GetInt32(0));
                    }
                }
            }
            connection.Close();
        }
    

        // VIEW PREVIOUS INSTRUMENT
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

        // VIEW NEXT INSTRUMENT
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

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        // REMOVE INSTRUMENT
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "InstrumentTable";

            // To remove a record, the user needs to login.
            if (GlobalVariables.UserLoggedIn == false)
            {
                // If no user is currently logged in, load login form.
                frmUserLogin Login = new frmUserLogin();
                Login.Show();
                this.Hide();
            }
            else
            {
                // If a user is logged in, load confirmation page.
                GlobalVariables.TableID = Convert.ToInt32(lbInstrumentID.Text);
                GlobalVariables.FieldNames = lbInstrumentName.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }

        // ADD NEW INSTRUMENT
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "InstrumentTable";
            GlobalVariables.Purpose = "Add";

            frmAddField AddField = new frmAddField();
            AddField.Show();
            this.Hide();
        }

        // BUTTON SELECTED MODIFICATIONS
        // Previous Instrument
        private void btnPreviousInstrument_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousInstrument.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnPreviousInstrument_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousInstrument.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Next Instrument
        private void btnNextInstrument_MouseEnter(object sender, EventArgs e)
        {
            btnNextInstrument.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnNextInstrument_MouseLeave(object sender, EventArgs e)
        {
            btnNextInstrument.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Add new Instrument
        private void btnAddGrade_MouseEnter(object sender, EventArgs e)
        {
            btnAddInstrument.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnAddGrade_MouseLeave(object sender, EventArgs e)
        {
            btnAddInstrument.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Remove Instrument
        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.Firebrick;
            this.Cursor = Cursors.Arrow;
        }

        // Return to Main Menu
        private void btnReturn_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.Firebrick;
            this.Cursor = Cursors.Arrow;
        }

        // First Record
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2;
            this.Cursor = Cursors.Arrow;
        }

        // Last Record
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted_;
            this.Cursor = Cursors.Arrow;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "InstrumentTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbInstrumentID.GetItemText(lbInstrumentID.SelectedItem);

            GlobalVariables.Instrument_Type = lbInstrumentType.GetItemText(lbInstrumentType.SelectedItem);
            GlobalVariables.Instrument_Name = lbInstrumentName.GetItemText(lbInstrumentName.SelectedItem);
            GlobalVariables.Instrument_Quantity = lbQuantity.GetItemText(lbQuantity.SelectedItem);

            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }

        // FIRST / LAST RECORD
        private void pbFirstRecord_Click(object sender, EventArgs e)
        {
            lbInstrumentID.SelectedValue = Instrument_IDs[0];
        }
        private void pbLastRecord_Click(object sender, EventArgs e)
        {
            lbInstrumentID.SelectedValue = Instrument_IDs[(Instrument_IDs.Count() - 1)];
        }

        // UPDATE BUTTON
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Chocolate;
            this.Cursor = Cursors.Arrow;
        }
    }
}
