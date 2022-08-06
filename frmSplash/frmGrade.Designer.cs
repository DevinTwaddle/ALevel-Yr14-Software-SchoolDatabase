namespace frmSplash
{
    partial class frmGrade
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
            this.btnPreviousGrade = new System.Windows.Forms.Button();
            this.btnNextGrade = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbGradeSearch = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lbGradeID = new System.Windows.Forms.ListBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lbGradeFee = new System.Windows.Forms.ListBox();
            this.lbGradeLevel = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousGrade
            // 
            this.btnPreviousGrade.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousGrade.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousGrade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousGrade.Location = new System.Drawing.Point(380, 136);
            this.btnPreviousGrade.Name = "btnPreviousGrade";
            this.btnPreviousGrade.Size = new System.Drawing.Size(162, 28);
            this.btnPreviousGrade.TabIndex = 99;
            this.btnPreviousGrade.Text = "previous Grade Record";
            this.btnPreviousGrade.UseVisualStyleBackColor = false;
            this.btnPreviousGrade.Click += new System.EventHandler(this.btnPreviousGrade_Click);
            // 
            // btnNextGrade
            // 
            this.btnNextGrade.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextGrade.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextGrade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextGrade.Location = new System.Drawing.Point(552, 136);
            this.btnNextGrade.Name = "btnNextGrade";
            this.btnNextGrade.Size = new System.Drawing.Size(166, 28);
            this.btnNextGrade.TabIndex = 98;
            this.btnNextGrade.Text = "Next Grade Record";
            this.btnNextGrade.UseVisualStyleBackColor = false;
            this.btnNextGrade.Click += new System.EventHandler(this.btnNextGrade_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(417, 100);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 21);
            this.lblSearch.TabIndex = 97;
            this.lblSearch.Text = "Search for Teacher:";
            // 
            // cbGradeSearch
            // 
            this.cbGradeSearch.FormattingEnabled = true;
            this.cbGradeSearch.Location = new System.Drawing.Point(556, 100);
            this.cbGradeSearch.Name = "cbGradeSearch";
            this.cbGradeSearch.Size = new System.Drawing.Size(121, 21);
            this.cbGradeSearch.TabIndex = 96;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(646, 303);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 53);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Location = new System.Drawing.Point(11, 98);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(50, 13);
            this.lblTeacherID.TabIndex = 94;
            this.lblTeacherID.Text = "GradeID:";
            // 
            // lbGradeID
            // 
            this.lbGradeID.FormattingEnabled = true;
            this.lbGradeID.Location = new System.Drawing.Point(128, 98);
            this.lbGradeID.Name = "lbGradeID";
            this.lbGradeID.Size = new System.Drawing.Size(171, 17);
            this.lbGradeID.TabIndex = 93;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(10, 143);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(60, 13);
            this.LblSurname.TabIndex = 86;
            this.LblSurname.Text = "Grade Fee:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(10, 121);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(68, 13);
            this.lblFirstname.TabIndex = 85;
            this.lblFirstname.Text = "Grade Level:";
            // 
            // lbGradeFee
            // 
            this.lbGradeFee.FormattingEnabled = true;
            this.lbGradeFee.Location = new System.Drawing.Point(128, 143);
            this.lbGradeFee.Name = "lbGradeFee";
            this.lbGradeFee.Size = new System.Drawing.Size(171, 17);
            this.lbGradeFee.TabIndex = 84;
            // 
            // lbGradeLevel
            // 
            this.lbGradeLevel.FormattingEnabled = true;
            this.lbGradeLevel.Location = new System.Drawing.Point(128, 121);
            this.lbGradeLevel.Name = "lbGradeLevel";
            this.lbGradeLevel.Size = new System.Drawing.Size(171, 17);
            this.lbGradeLevel.TabIndex = 83;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(290, 12);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(200, 63);
            this.lbMain.TabIndex = 80;
            this.lbMain.Text = "Grade List";
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
            this.pictureBox1.Size = new System.Drawing.Size(433, 251);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(414, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 26);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddGrade.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddGrade.Location = new System.Drawing.Point(465, 170);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(172, 28);
            this.btnAddGrade.TabIndex = 101;
            this.btnAddGrade.Text = "Add new Grade";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 365);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.btnPreviousGrade);
            this.Controls.Add(this.btnNextGrade);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbGradeSearch);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lbGradeID);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lbGradeFee);
            this.Controls.Add(this.lbGradeLevel);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrade";
            this.Load += new System.EventHandler(this.frmGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousGrade;
        private System.Windows.Forms.Button btnNextGrade;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbGradeSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.ListBox lbGradeID;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.ListBox lbGradeFee;
        private System.Windows.Forms.ListBox lbGradeLevel;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddGrade;
    }
}