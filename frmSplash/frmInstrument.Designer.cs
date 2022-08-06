namespace frmSplash
{
    partial class frmInstrument
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
            this.btnPreviousInstrument = new System.Windows.Forms.Button();
            this.btnNextInstrument = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbInstrumentSearch = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblInstrumentID = new System.Windows.Forms.Label();
            this.lbInstrumentID = new System.Windows.Forms.ListBox();
            this.lbQuantity = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblInstrumentName = new System.Windows.Forms.Label();
            this.lblInstrumentType = new System.Windows.Forms.Label();
            this.lbInstrumentName = new System.Windows.Forms.ListBox();
            this.lbInstrumentType = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousInstrument
            // 
            this.btnPreviousInstrument.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousInstrument.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousInstrument.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousInstrument.Location = new System.Drawing.Point(332, 132);
            this.btnPreviousInstrument.Name = "btnPreviousInstrument";
            this.btnPreviousInstrument.Size = new System.Drawing.Size(199, 28);
            this.btnPreviousInstrument.TabIndex = 99;
            this.btnPreviousInstrument.Text = "previous Instrument Record";
            this.btnPreviousInstrument.UseVisualStyleBackColor = false;
            this.btnPreviousInstrument.Click += new System.EventHandler(this.btnPreviousStudent_Click);
            // 
            // btnNextInstrument
            // 
            this.btnNextInstrument.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextInstrument.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextInstrument.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextInstrument.Location = new System.Drawing.Point(542, 132);
            this.btnNextInstrument.Name = "btnNextInstrument";
            this.btnNextInstrument.Size = new System.Drawing.Size(199, 28);
            this.btnNextInstrument.TabIndex = 98;
            this.btnNextInstrument.Text = "Next Instrument Record";
            this.btnNextInstrument.UseVisualStyleBackColor = false;
            this.btnNextInstrument.Click += new System.EventHandler(this.btnNextStudent_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(397, 101);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(148, 21);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Search for Instrument:";
            // 
            // cbInstrumentSearch
            // 
            this.cbInstrumentSearch.FormattingEnabled = true;
            this.cbInstrumentSearch.Location = new System.Drawing.Point(551, 100);
            this.cbInstrumentSearch.Name = "cbInstrumentSearch";
            this.cbInstrumentSearch.Size = new System.Drawing.Size(121, 21);
            this.cbInstrumentSearch.TabIndex = 96;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(649, 295);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 53);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblInstrumentID
            // 
            this.lblInstrumentID.AutoSize = true;
            this.lblInstrumentID.Location = new System.Drawing.Point(9, 98);
            this.lblInstrumentID.Name = "lblInstrumentID";
            this.lblInstrumentID.Size = new System.Drawing.Size(70, 13);
            this.lblInstrumentID.TabIndex = 94;
            this.lblInstrumentID.Text = "InstrumentID:";
            // 
            // lbInstrumentID
            // 
            this.lbInstrumentID.FormattingEnabled = true;
            this.lbInstrumentID.Location = new System.Drawing.Point(128, 98);
            this.lbInstrumentID.Name = "lbInstrumentID";
            this.lbInstrumentID.Size = new System.Drawing.Size(171, 17);
            this.lbInstrumentID.TabIndex = 93;
            // 
            // lbQuantity
            // 
            this.lbQuantity.FormattingEnabled = true;
            this.lbQuantity.Location = new System.Drawing.Point(128, 166);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(171, 17);
            this.lbQuantity.TabIndex = 90;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 166);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 87;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblInstrumentName
            // 
            this.lblInstrumentName.AutoSize = true;
            this.lblInstrumentName.Location = new System.Drawing.Point(9, 143);
            this.lblInstrumentName.Name = "lblInstrumentName";
            this.lblInstrumentName.Size = new System.Drawing.Size(90, 13);
            this.lblInstrumentName.TabIndex = 86;
            this.lblInstrumentName.Text = "Instrument Name:";
            // 
            // lblInstrumentType
            // 
            this.lblInstrumentType.AutoSize = true;
            this.lblInstrumentType.Location = new System.Drawing.Point(9, 120);
            this.lblInstrumentType.Name = "lblInstrumentType";
            this.lblInstrumentType.Size = new System.Drawing.Size(86, 13);
            this.lblInstrumentType.TabIndex = 85;
            this.lblInstrumentType.Text = "Instrument Type:";
            // 
            // lbInstrumentName
            // 
            this.lbInstrumentName.FormattingEnabled = true;
            this.lbInstrumentName.Location = new System.Drawing.Point(128, 143);
            this.lbInstrumentName.Name = "lbInstrumentName";
            this.lbInstrumentName.Size = new System.Drawing.Size(171, 17);
            this.lbInstrumentName.TabIndex = 84;
            // 
            // lbInstrumentType
            // 
            this.lbInstrumentType.FormattingEnabled = true;
            this.lbInstrumentType.Location = new System.Drawing.Point(128, 120);
            this.lbInstrumentType.Name = "lbInstrumentType";
            this.lbInstrumentType.Size = new System.Drawing.Size(171, 17);
            this.lbInstrumentType.TabIndex = 83;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(265, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(293, 63);
            this.lbMain.TabIndex = 80;
            this.lbMain.Text = "Instruments List";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(10, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 79;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(-1, -2);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(751, 85);
            this.pbBorder2.TabIndex = 78;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(317, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(433, 40);
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmSplash.Properties.Resources.Music_background_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 247);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(393, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 26);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // frmInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(748, 355);
            this.Controls.Add(this.btnPreviousInstrument);
            this.Controls.Add(this.btnNextInstrument);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbInstrumentSearch);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblInstrumentID);
            this.Controls.Add(this.lbInstrumentID);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblInstrumentName);
            this.Controls.Add(this.lblInstrumentType);
            this.Controls.Add(this.lbInstrumentName);
            this.Controls.Add(this.lbInstrumentType);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInstrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInstrument";
            this.Load += new System.EventHandler(this.frmInstrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousInstrument;
        private System.Windows.Forms.Button btnNextInstrument;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbInstrumentSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInstrumentID;
        private System.Windows.Forms.ListBox lbInstrumentID;
        private System.Windows.Forms.ListBox lbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblInstrumentName;
        private System.Windows.Forms.Label lblInstrumentType;
        private System.Windows.Forms.ListBox lbInstrumentName;
        private System.Windows.Forms.ListBox lbInstrumentType;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}