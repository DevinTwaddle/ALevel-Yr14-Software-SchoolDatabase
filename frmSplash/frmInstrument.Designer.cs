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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddInstrument = new System.Windows.Forms.Button();
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
            // btnPreviousInstrument
            // 
            this.btnPreviousInstrument.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousInstrument.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousInstrument.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousInstrument.Location = new System.Drawing.Point(457, 152);
            this.btnPreviousInstrument.Name = "btnPreviousInstrument";
            this.btnPreviousInstrument.Size = new System.Drawing.Size(194, 28);
            this.btnPreviousInstrument.TabIndex = 99;
            this.btnPreviousInstrument.Text = "previous Instrument Record";
            this.btnPreviousInstrument.UseVisualStyleBackColor = false;
            this.btnPreviousInstrument.Click += new System.EventHandler(this.btnPreviousStudent_Click);
            this.btnPreviousInstrument.MouseEnter += new System.EventHandler(this.btnPreviousInstrument_MouseEnter);
            this.btnPreviousInstrument.MouseLeave += new System.EventHandler(this.btnPreviousInstrument_MouseLeave);
            // 
            // btnNextInstrument
            // 
            this.btnNextInstrument.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextInstrument.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextInstrument.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextInstrument.Location = new System.Drawing.Point(668, 152);
            this.btnNextInstrument.Name = "btnNextInstrument";
            this.btnNextInstrument.Size = new System.Drawing.Size(194, 28);
            this.btnNextInstrument.TabIndex = 98;
            this.btnNextInstrument.Text = "Next Instrument Record";
            this.btnNextInstrument.UseVisualStyleBackColor = false;
            this.btnNextInstrument.Click += new System.EventHandler(this.btnNextStudent_Click);
            this.btnNextInstrument.MouseEnter += new System.EventHandler(this.btnNextInstrument_MouseEnter);
            this.btnNextInstrument.MouseLeave += new System.EventHandler(this.btnNextInstrument_MouseLeave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(522, 121);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(139, 21);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Search for Instrument:";
            // 
            // cbInstrumentSearch
            // 
            this.cbInstrumentSearch.FormattingEnabled = true;
            this.cbInstrumentSearch.Location = new System.Drawing.Point(676, 120);
            this.cbInstrumentSearch.Name = "cbInstrumentSearch";
            this.cbInstrumentSearch.Size = new System.Drawing.Size(121, 21);
            this.cbInstrumentSearch.TabIndex = 96;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(568, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 28);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.MouseEnter += new System.EventHandler(this.btnReturn_MouseEnter);
            this.btnReturn.MouseLeave += new System.EventHandler(this.btnReturn_MouseLeave);
            // 
            // lblInstrumentID
            // 
            this.lblInstrumentID.AutoSize = true;
            this.lblInstrumentID.BackColor = System.Drawing.Color.Azure;
            this.lblInstrumentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentID.Location = new System.Drawing.Point(38, 117);
            this.lblInstrumentID.Name = "lblInstrumentID";
            this.lblInstrumentID.Size = new System.Drawing.Size(83, 13);
            this.lblInstrumentID.TabIndex = 94;
            this.lblInstrumentID.Text = "InstrumentID:";
            // 
            // lbInstrumentID
            // 
            this.lbInstrumentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrumentID.FormattingEnabled = true;
            this.lbInstrumentID.ItemHeight = 15;
            this.lbInstrumentID.Location = new System.Drawing.Point(184, 117);
            this.lbInstrumentID.Name = "lbInstrumentID";
            this.lbInstrumentID.Size = new System.Drawing.Size(171, 19);
            this.lbInstrumentID.TabIndex = 93;
            // 
            // lbQuantity
            // 
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.FormattingEnabled = true;
            this.lbQuantity.ItemHeight = 15;
            this.lbQuantity.Location = new System.Drawing.Point(184, 213);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(171, 19);
            this.lbQuantity.TabIndex = 90;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Azure;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(38, 213);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblQuantity.TabIndex = 87;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblInstrumentName
            // 
            this.lblInstrumentName.AutoSize = true;
            this.lblInstrumentName.BackColor = System.Drawing.Color.Azure;
            this.lblInstrumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentName.Location = new System.Drawing.Point(37, 188);
            this.lblInstrumentName.Name = "lblInstrumentName";
            this.lblInstrumentName.Size = new System.Drawing.Size(106, 13);
            this.lblInstrumentName.TabIndex = 86;
            this.lblInstrumentName.Text = "Instrument Name:";
            // 
            // lblInstrumentType
            // 
            this.lblInstrumentType.AutoSize = true;
            this.lblInstrumentType.BackColor = System.Drawing.Color.Azure;
            this.lblInstrumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumentType.Location = new System.Drawing.Point(37, 163);
            this.lblInstrumentType.Name = "lblInstrumentType";
            this.lblInstrumentType.Size = new System.Drawing.Size(102, 13);
            this.lblInstrumentType.TabIndex = 85;
            this.lblInstrumentType.Text = "Instrument Type:";
            // 
            // lbInstrumentName
            // 
            this.lbInstrumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrumentName.FormattingEnabled = true;
            this.lbInstrumentName.ItemHeight = 15;
            this.lbInstrumentName.Location = new System.Drawing.Point(184, 188);
            this.lbInstrumentName.Name = "lbInstrumentName";
            this.lbInstrumentName.Size = new System.Drawing.Size(171, 19);
            this.lbInstrumentName.TabIndex = 84;
            // 
            // lbInstrumentType
            // 
            this.lbInstrumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrumentType.FormattingEnabled = true;
            this.lbInstrumentType.ItemHeight = 15;
            this.lbInstrumentType.Location = new System.Drawing.Point(184, 163);
            this.lbInstrumentType.Name = "lbInstrumentType";
            this.lbInstrumentType.Size = new System.Drawing.Size(171, 19);
            this.lbInstrumentType.TabIndex = 83;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(299, 9);
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
            this.pbBorder2.Size = new System.Drawing.Size(950, 85);
            this.pbBorder2.TabIndex = 78;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(518, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 26);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemove.Location = new System.Drawing.Point(499, 288);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(331, 29);
            this.btnRemove.TabIndex = 101;
            this.btnRemove.Text = "Remove Instrument Record";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // btnAddInstrument
            // 
            this.btnAddInstrument.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddInstrument.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstrument.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddInstrument.Location = new System.Drawing.Point(499, 209);
            this.btnAddInstrument.Name = "btnAddInstrument";
            this.btnAddInstrument.Size = new System.Drawing.Size(331, 29);
            this.btnAddInstrument.TabIndex = 102;
            this.btnAddInstrument.Text = "Add new Instrument";
            this.btnAddInstrument.UseVisualStyleBackColor = false;
            this.btnAddInstrument.Click += new System.EventHandler(this.btnAddGrade_Click);
            this.btnAddInstrument.MouseEnter += new System.EventHandler(this.btnAddGrade_MouseEnter);
            this.btnAddInstrument.MouseLeave += new System.EventHandler(this.btnAddGrade_MouseLeave);
            // 
            // pbLastRecord
            // 
            this.pbLastRecord.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbLastRecord.Image = global::frmSplash.Properties.Resources.Arrow2;
            this.pbLastRecord.Location = new System.Drawing.Point(868, 151);
            this.pbLastRecord.Name = "pbLastRecord";
            this.pbLastRecord.Size = new System.Drawing.Size(41, 29);
            this.pbLastRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLastRecord.TabIndex = 115;
            this.pbLastRecord.TabStop = false;
            this.pbLastRecord.Click += new System.EventHandler(this.pbLastRecord_Click);
            this.pbLastRecord.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pbLastRecord.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // pbFirstRecord
            // 
            this.pbFirstRecord.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbFirstRecord.Image = global::frmSplash.Properties.Resources.Arrow2;
            this.pbFirstRecord.Location = new System.Drawing.Point(410, 151);
            this.pbFirstRecord.Name = "pbFirstRecord";
            this.pbFirstRecord.Size = new System.Drawing.Size(41, 29);
            this.pbFirstRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstRecord.TabIndex = 114;
            this.pbFirstRecord.TabStop = false;
            this.pbFirstRecord.Click += new System.EventHandler(this.pbFirstRecord_Click);
            this.pbFirstRecord.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pbFirstRecord.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(400, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(521, 83);
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(400, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 48);
            this.pictureBox3.TabIndex = 113;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(400, 109);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(521, 239);
            this.pictureBox7.TabIndex = 108;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(394, 104);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(533, 284);
            this.pictureBox8.TabIndex = 116;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 82);
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(32, 109);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(332, 33);
            this.pictureBox9.TabIndex = 118;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(29, 153);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(338, 89);
            this.pictureBox10.TabIndex = 119;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(29, 107);
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
            this.btnUpdate.Location = new System.Drawing.Point(499, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(331, 29);
            this.btnUpdate.TabIndex = 141;
            this.btnUpdate.Text = "Update Bundle Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // frmInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(946, 444);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbInstrumentSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbLastRecord);
            this.Controls.Add(this.pbFirstRecord);
            this.Controls.Add(this.btnAddInstrument);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPreviousInstrument);
            this.Controls.Add(this.btnNextInstrument);
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
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Name = "frmInstrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInstrument";
            this.Load += new System.EventHandler(this.frmInstrument_Load);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddInstrument;
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