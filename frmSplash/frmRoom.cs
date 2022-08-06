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

        public frmRoom()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["frmSplash.Properties.Settings.PrivateTuitionConnectionString"].ConnectionString;
        }

        public void DisplayRooms()
        {
            using (connection = new SqlConnection(connectionString))
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

        private void frmRoom_Load(object sender, EventArgs e)
        {
            DisplayRooms();
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPrivateTuition Mainmenu = new frmPrivateTuition();
            Mainmenu.Show();
            this.Hide();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            GlobalVariables.PreviousForm = "RoomTable";

            frmAddField AddRoom = new frmAddField();
            AddRoom.Show();
            this.Hide();
        }
    }
}
