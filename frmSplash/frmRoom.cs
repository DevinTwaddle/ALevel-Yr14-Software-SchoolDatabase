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
    public partial class frmRoom : Form
    {
        string connectionString;
        SqlConnection connection;
        int CurrentRoomID;
        int MaxRoomID;
        int MinRoomID;
        SqlDataReader DataReader;
        List<int> Room_IDs = new List<int>();

        public frmRoom()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            DisplayRooms();
        }

        // DISPLAY TABLE INFORMATION
        public void DisplayRooms()
        {
            using (connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Room", connection))
                {
                    DataTable RoomTable = new DataTable();
                    adaptor.Fill(RoomTable);

                    cbRoomID.DisplayMember = "RoomID";
                    cbRoomID.ValueMember = "RoomID";
                    cbRoomID.DataSource = RoomTable;

                    lbRoomID.DisplayMember = "RoomID";
                    lbRoomID.ValueMember = "RoomID";
                    lbRoomID.DataSource = RoomTable;

                    lbRoomType.DisplayMember = "Room_Type";
                    lbRoomType.ValueMember = "RoomID";
                    lbRoomType.DataSource = RoomTable;

                    lbRoomSpecialisation.DisplayMember = "specialisation";
                    lbRoomSpecialisation.ValueMember = "RoomID";
                    lbRoomSpecialisation.DataSource = RoomTable;

                    using (SqlCommand Max = new SqlCommand("SELECT MAX(RoomID) FROM Room", connection))
                    {
                        connection.Open();
                        MaxRoomID = (int)Max.ExecuteScalar();
                    }

                    using (SqlCommand Min = new SqlCommand("Select Min(RoomID) FROM Room", connection))
                    {
                        MinRoomID = (int)Min.ExecuteScalar();
                        connection.Close();
                    }
                }
            }
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand Command = new SqlCommand("SELECT * FROM Room", connection))
                {
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        // For each record, store the corrisponding peice of information.
                        Room_IDs.Add(DataReader.GetInt32(0));
                    }
                }
                connection.Close();
            }
        }

        // VIEW PREVIOUS RECORD
        private void btnPreviousRoom_Click(object sender, EventArgs e)
        {
            CurrentRoomID = Convert.ToInt32(lbRoomID.SelectedValue);

            if (CurrentRoomID == MinRoomID)
            {
                lbRoomID.SelectedValue = MaxRoomID;
            }
            else
            {
                CurrentRoomID += -1;
                lbRoomID.SelectedValue = CurrentRoomID;
            }
        }

        // VIEW NEXT RECORD
        private void btnNextRoom_Click(object sender, EventArgs e)
        {
            CurrentRoomID = Convert.ToInt32(lbRoomID.SelectedValue);

            if (CurrentRoomID == MaxRoomID)
            {
                lbRoomID.SelectedValue = MinRoomID;
            }
            else
            {
                CurrentRoomID += 1;
                lbRoomID.SelectedValue = CurrentRoomID;
            }
        }

        // RETURN TO MAIN MENU
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        // ADD RECORD
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "RoomTable";
            GlobalVariables.Purpose = "Add";

            frmAddField AddRoom = new frmAddField();
            AddRoom.Show();
            this.Hide();
        }

        // REMOVE RECORD
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Set associated field.
            GlobalVariables.PreviousForm = "RoomTable";

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
                GlobalVariables.TableID = Convert.ToInt32(lbRoomID.Text);
                GlobalVariables.FieldNames = lbRoomSpecialisation.Text;

                frmConfirmation Confirmation = new frmConfirmation();
                Confirmation.Show();
            }
        }

        // BUTTON SELECT MODIFCATIONS
        // Previous Record
        private void btnPreviousRoom_MouseEnter(object sender, EventArgs e)
        {
            btnPreviousRoom.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnPreviousRoom_MouseLeave(object sender, EventArgs e)
        {
            btnPreviousRoom.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Next Record
        private void btnNextRoom_MouseEnter(object sender, EventArgs e)
        {
            btnNextRoom.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnNextRoom_MouseLeave(object sender, EventArgs e)
        {
            btnNextRoom.BackColor = Color.MidnightBlue;
            this.Cursor = Cursors.Arrow;
        }

        // Add New Record
        private void btnAddRoom_MouseEnter(object sender, EventArgs e)
        {
            btnAddRoom.BackColor = Color.LightSlateGray;
            this.Cursor = Cursors.Hand;
        }
        private void btnAddRoom_MouseLeave(object sender, EventArgs e)
        {
            btnAddRoom.BackColor = Color.SeaGreen;
            this.Cursor = Cursors.Arrow;
        }

        // Remove Record
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

        // Return to Main Mennu
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
        private void pbFirstRecord_MouseEnter(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2_GreyScale1_;
            this.Cursor = Cursors.Hand;
        }
        private void pbFirstRecord_MouseLeave(object sender, EventArgs e)
        {
            pbFirstRecord.Image = Properties.Resources.Arrow2;
            this.Cursor = Cursors.Arrow;
        }

        // Last Record
        private void pbLastRecord_MouseEnter(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted__GreyScale1_;
            this.Cursor = Cursors.Hand;
        }
        private void pbLastRecord_MouseLeave(object sender, EventArgs e)
        {
            pbLastRecord.Image = Properties.Resources.Arrow2_Inverted_;
            this.Cursor = Cursors.Arrow;
        }

        // Update Record
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "RoomTable";
            GlobalVariables.Purpose = "Update";
            GlobalVariables.UpdateID = lbRoomID.GetItemText(lbRoomID.SelectedItem);

            GlobalVariables.Room_Type = lbRoomType.GetItemText(lbRoomType.SelectedItem);
            GlobalVariables.Room_Specialisation = lbRoomSpecialisation.GetItemText(lbRoomSpecialisation.SelectedItem);

            frmAddField UpdateRecord = new frmAddField();
            UpdateRecord.Show();
            this.Hide();
        }

        // FIRST / LAST RECORD
        private void pbFirstRecord_Click(object sender, EventArgs e)
        {
            lbRoomID.SelectedValue = Room_IDs[0];
        }
        private void pbLastRecord_Click(object sender, EventArgs e)
        {
            lbRoomID.SelectedValue = Room_IDs[(Room_IDs.Count() - 1)];
        }
    }
}
