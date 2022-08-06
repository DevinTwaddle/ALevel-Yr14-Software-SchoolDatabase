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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousRoom
            // 
            this.btnPreviousRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousRoom.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousRoom.Location = new System.Drawing.Point(380, 133);
            this.btnPreviousRoom.Name = "btnPreviousRoom";
            this.btnPreviousRoom.Size = new System.Drawing.Size(162, 28);
            this.btnPreviousRoom.TabIndex = 99;
            this.btnPreviousRoom.Text = "previous Teacher Record";
            this.btnPreviousRoom.UseVisualStyleBackColor = false;
            this.btnPreviousRoom.Click += new System.EventHandler(this.btnPreviousRoom_Click);
            // 
            // btnNextRoom
            // 
            this.btnNextRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextRoom.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextRoom.Location = new System.Drawing.Point(554, 133);
            this.btnNextRoom.Name = "btnNextRoom";
            this.btnNextRoom.Size = new System.Drawing.Size(166, 28);
            this.btnNextRoom.TabIndex = 98;
            this.btnNextRoom.Text = "Next Teacher Record";
            this.btnNextRoom.UseVisualStyleBackColor = false;
            this.btnNextRoom.Click += new System.EventHandler(this.btnNextRoom_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(418, 103);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 21);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Search for Room:";
            // 
            // cbRoomID
            // 
            this.cbRoomID.FormattingEnabled = true;
            this.cbRoomID.Location = new System.Drawing.Point(555, 102);
            this.cbRoomID.Name = "cbRoomID";
            this.cbRoomID.Size = new System.Drawing.Size(121, 21);
            this.cbRoomID.TabIndex = 96;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(648, 282);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 53);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(8, 98);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 94;
            this.lblRoomID.Text = "RoomID:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.FormattingEnabled = true;
            this.lbRoomID.Location = new System.Drawing.Point(127, 98);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(171, 17);
            this.lbRoomID.TabIndex = 93;
            // 
            // lblSpecilisation
            // 
            this.lblSpecilisation.AutoSize = true;
            this.lblSpecilisation.Location = new System.Drawing.Point(9, 143);
            this.lblSpecilisation.Name = "lblSpecilisation";
            this.lblSpecilisation.Size = new System.Drawing.Size(75, 13);
            this.lblSpecilisation.TabIndex = 86;
            this.lblSpecilisation.Text = "Specialisation:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(9, 121);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(65, 13);
            this.lblRoomType.TabIndex = 85;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lbRoomSpecialisation
            // 
            this.lbRoomSpecialisation.FormattingEnabled = true;
            this.lbRoomSpecialisation.Location = new System.Drawing.Point(127, 143);
            this.lbRoomSpecialisation.Name = "lbRoomSpecialisation";
            this.lbRoomSpecialisation.Size = new System.Drawing.Size(171, 17);
            this.lbRoomSpecialisation.TabIndex = 84;
            // 
            // lbRoomType
            // 
            this.lbRoomType.FormattingEnabled = true;
            this.lbRoomType.Location = new System.Drawing.Point(127, 121);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(171, 17);
            this.lbRoomType.TabIndex = 83;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(290, 9);
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
            this.pbBorder2.Size = new System.Drawing.Size(751, 85);
            this.pbBorder2.TabIndex = 78;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(316, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(433, 40);
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmSplash.Properties.Resources.Music_background_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(316, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 230);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(414, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 26);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddRoom.Location = new System.Drawing.Point(457, 167);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(172, 28);
            this.btnAddRoom.TabIndex = 101;
            this.btnAddRoom.Text = "Add new Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(746, 344);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddRoom;
    }
}