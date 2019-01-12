namespace frmSplash
{
    partial class frmRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviousRoom = new System.Windows.Forms.Button();
            this.btnNextRoom = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbRoomID = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.ListBox();
            this.lblSpecilisation = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lbRoomSpecialisation = new System.Windows.Forms.ListBox();
            this.lbRoomType = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pbLastRecord = new System.Windows.Forms.PictureBox();
            this.pbFirstRecord = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLastRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousRoom
            // 
            this.btnPreviousRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousRoom.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousRoom.Location = new System.Drawing.Point(471, 150);
            this.btnPreviousRoom.Name = "btnPreviousRoom";
            this.btnPreviousRoom.Size = new System.Drawing.Size(194, 28);
            this.btnPreviousRoom.TabIndex = 99;
            this.btnPreviousRoom.Text = "previous Room Record";
            this.btnPreviousRoom.UseVisualStyleBackColor = false;
            this.btnPreviousRoom.Click += new System.EventHandler(this.btnPreviousRoom_Click);
            this.btnPreviousRoom.MouseEnter += new System.EventHandler(this.btnPreviousRoom_MouseEnter);
            this.btnPreviousRoom.MouseLeave += new System.EventHandler(this.btnPreviousRoom_MouseLeave);
            // 
            // btnNextRoom
            // 
            this.btnNextRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextRoom.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextRoom.Location = new System.Drawing.Point(682, 150);
            this.btnNextRoom.Name = "btnNextRoom";
            this.btnNextRoom.Size = new System.Drawing.Size(194, 28);
            this.btnNextRoom.TabIndex = 98;
            this.btnNextRoom.Text = "Next Room Record";
            this.btnNextRoom.UseVisualStyleBackColor = false;
            this.btnNextRoom.Click += new System.EventHandler(this.btnNextRoom_Click);
            this.btnNextRoom.MouseEnter += new System.EventHandler(this.btnNextRoom_MouseEnter);
            this.btnNextRoom.MouseLeave += new System.EventHandler(this.btnNextRoom_MouseLeave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(542, 123);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 21);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Search for Room:";
            // 
            // cbRoomID
            // 
            this.cbRoomID.FormattingEnabled = true;
            this.cbRoomID.Location = new System.Drawing.Point(679, 122);
            this.cbRoomID.Name = "cbRoomID";
            this.cbRoomID.Size = new System.Drawing.Size(121, 21);
            this.cbRoomID.TabIndex = 96;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(582, 341);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 28);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.MouseEnter += new System.EventHandler(this.btnReturn_MouseEnter);
            this.btnReturn.MouseLeave += new System.EventHandler(this.btnReturn_MouseLeave);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.BackColor = System.Drawing.Color.Azure;
            this.lblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(41, 113);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(56, 13);
            this.lblRoomID.TabIndex = 94;
            this.lblRoomID.Text = "RoomID:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.FormattingEnabled = true;
            this.lbRoomID.ItemHeight = 15;
            this.lbRoomID.Location = new System.Drawing.Point(186, 111);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(171, 19);
            this.lbRoomID.TabIndex = 93;
            // 
            // lblSpecilisation
            // 
            this.lblSpecilisation.AutoSize = true;
            this.lblSpecilisation.BackColor = System.Drawing.Color.Azure;
            this.lblSpecilisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecilisation.Location = new System.Drawing.Point(41, 187);
            this.lblSpecilisation.Name = "lblSpecilisation";
            this.lblSpecilisation.Size = new System.Drawing.Size(90, 13);
            this.lblSpecilisation.TabIndex = 86;
            this.lblSpecilisation.Text = "Specialisation:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Azure;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(41, 161);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(75, 13);
            this.lblRoomType.TabIndex = 85;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lbRoomSpecialisation
            // 
            this.lbRoomSpecialisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomSpecialisation.FormattingEnabled = true;
            this.lbRoomSpecialisation.ItemHeight = 15;
            this.lbRoomSpecialisation.Location = new System.Drawing.Point(186, 186);
            this.lbRoomSpecialisation.Name = "lbRoomSpecialisation";
            this.lbRoomSpecialisation.Size = new System.Drawing.Size(171, 19);
            this.lbRoomSpecialisation.TabIndex = 84;
            // 
            // lbRoomType
            // 
            this.lbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomType.FormattingEnabled = true;
            this.lbRoomType.ItemHeight = 15;
            this.lbRoomType.Location = new System.Drawing.Point(186, 161);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(171, 19);
            this.lbRoomType.TabIndex = 83;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(374, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(201, 63);
            this.lbMain.TabIndex = 80;
            this.lbMain.Text = "Room List";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(9, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 79;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(-2, -2);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(967, 85);
            this.pbBorder2.TabIndex = 78;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(538, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 26);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddRoom.Location = new System.Drawing.Point(513, 205);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(331, 29);
            this.btnAddRoom.TabIndex = 101;
            this.btnAddRoom.Text = "Add new Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            this.btnAddRoom.MouseEnter += new System.EventHandler(this.btnAddRoom_MouseEnter);
            this.btnAddRoom.MouseLeave += new System.EventHandler(this.btnAddRoom_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Location = new System.Drawing.Point(513, 286);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(331, 29);
            this.btnRemove.TabIndex = 102;
            this.btnRemove.Text = "Remove Room Record";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // pbLastRecord
            // 
            this.pbLastRecord.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbLastRecord.Image = global::frmSplash.Properties.Resources.Arrow2;
            this.pbLastRecord.Location = new System.Drawing.Point(882, 149);
            this.pbLastRecord.Name = "pbLastRecord";
            this.pbLastRecord.Size = new System.Drawing.Size(41, 29);
            this.pbLastRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLastRecord.TabIndex = 115;
            this.pbLastRecord.TabStop = false;
            this.pbLastRecord.Click += new System.EventHandler(this.pbLastRecord_Click);
            this.pbLastRecord.MouseEnter += new System.EventHandler(this.pbLastRecord_MouseEnter);
            this.pbLastRecord.MouseLeave += new System.EventHandler(this.pbLastRecord_MouseLeave);
            // 
            // pbFirstRecord
            // 
            this.pbFirstRecord.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbFirstRecord.Image = global::frmSplash.Properties.Resources.Arrow2;
            this.pbFirstRecord.Location = new System.Drawing.Point(424, 149);
            this.pbFirstRecord.Name = "pbFirstRecord";
            this.pbFirstRecord.Size = new System.Drawing.Size(41, 29);
            this.pbFirstRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstRecord.TabIndex = 114;
            this.pbFirstRecord.TabStop = false;
            this.pbFirstRecord.Click += new System.EventHandler(this.pbFirstRecord_Click);
            this.pbFirstRecord.MouseEnter += new System.EventHandler(this.pbFirstRecord_MouseEnter);
            this.pbFirstRecord.MouseLeave += new System.EventHandler(this.pbFirstRecord_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(414, 107);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(521, 83);
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(414, 332);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 48);
            this.pictureBox3.TabIndex = 113;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(414, 107);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(521, 239);
            this.pictureBox7.TabIndex = 108;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(408, 102);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(533, 284);
            this.pictureBox8.TabIndex = 116;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 67);
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(32, 104);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(332, 33);
            this.pictureBox9.TabIndex = 118;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(29, 148);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(338, 74);
            this.pictureBox10.TabIndex = 119;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(29, 102);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(337, 37);
            this.pictureBox11.TabIndex = 120;
            this.pictureBox11.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(513, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(331, 29);
            this.btnUpdate.TabIndex = 121;
            this.btnUpdate.Text = "Update Room Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(965, 416);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pbLastRecord);
            this.Controls.Add(this.pbFirstRecord);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnPreviousRoom);
            this.Controls.Add(this.btnNextRoom);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbRoomID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lblSpecilisation);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lbRoomSpecialisation);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLastRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousRoom;
        private System.Windows.Forms.Button btnNextRoom;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbRoomID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.ListBox lbRoomID;
        private System.Windows.Forms.Label lblSpecilisation;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ListBox lbRoomSpecialisation;
        private System.Windows.Forms.ListBox lbRoomType;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pbLastRecord;
        private System.Windows.Forms.PictureBox pbFirstRecord;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btnUpdate;
    }
}