namespace frmSplash
{
    partial class frmLessonBundle
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
            this.btnPreviousIBundle = new System.Windows.Forms.Button();
            this.btnNextLessonBundle = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbBundleSearch = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBundleID = new System.Windows.Forms.Label();
            this.lbLessonBundleID = new System.Windows.Forms.ListBox();
            this.lbDiscount = new System.Windows.Forms.ListBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblBundleCost = new System.Windows.Forms.Label();
            this.lblBundle = new System.Windows.Forms.Label();
            this.lbBundleCost = new System.Windows.Forms.ListBox();
            this.lbLessonBundleName = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousIBundle
            // 
            this.btnPreviousIBundle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousIBundle.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousIBundle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousIBundle.Location = new System.Drawing.Point(375, 132);
            this.btnPreviousIBundle.Name = "btnPreviousIBundle";
            this.btnPreviousIBundle.Size = new System.Drawing.Size(162, 28);
            this.btnPreviousIBundle.TabIndex = 117;
            this.btnPreviousIBundle.Text = "previous Lesson Bundle";
            this.btnPreviousIBundle.UseVisualStyleBackColor = false;
            this.btnPreviousIBundle.Click += new System.EventHandler(this.btnPreviousIBundle_Click);
            // 
            // btnNextLessonBundle
            // 
            this.btnNextLessonBundle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextLessonBundle.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLessonBundle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextLessonBundle.Location = new System.Drawing.Point(549, 132);
            this.btnNextLessonBundle.Name = "btnNextLessonBundle";
            this.btnNextLessonBundle.Size = new System.Drawing.Size(166, 28);
            this.btnNextLessonBundle.TabIndex = 116;
            this.btnNextLessonBundle.Text = "Next Lesson Bundle";
            this.btnNextLessonBundle.UseVisualStyleBackColor = false;
            this.btnNextLessonBundle.Click += new System.EventHandler(this.btnNextLessonBundle_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(412, 102);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(122, 21);
            this.lblSearch.TabIndex = 115;
            this.lblSearch.Text = "Search for Bundle:";
            // 
            // cbBundleSearch
            // 
            this.cbBundleSearch.FormattingEnabled = true;
            this.cbBundleSearch.Location = new System.Drawing.Point(544, 102);
            this.cbBundleSearch.Name = "cbBundleSearch";
            this.cbBundleSearch.Size = new System.Drawing.Size(126, 21);
            this.cbBundleSearch.TabIndex = 114;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(649, 295);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 53);
            this.btnReturn.TabIndex = 113;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBundleID
            // 
            this.lblBundleID.AutoSize = true;
            this.lblBundleID.Location = new System.Drawing.Point(9, 98);
            this.lblBundleID.Name = "lblBundleID";
            this.lblBundleID.Size = new System.Drawing.Size(91, 13);
            this.lblBundleID.TabIndex = 112;
            this.lblBundleID.Text = "Lesson BundleID:";
            // 
            // lbLessonBundleID
            // 
            this.lbLessonBundleID.FormattingEnabled = true;
            this.lbLessonBundleID.Location = new System.Drawing.Point(128, 98);
            this.lbLessonBundleID.Name = "lbLessonBundleID";
            this.lbLessonBundleID.Size = new System.Drawing.Size(171, 17);
            this.lbLessonBundleID.TabIndex = 111;
            // 
            // lbDiscount
            // 
            this.lbDiscount.FormattingEnabled = true;
            this.lbDiscount.Location = new System.Drawing.Point(128, 166);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(171, 17);
            this.lbDiscount.TabIndex = 110;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(10, 166);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(99, 13);
            this.lblDiscount.TabIndex = 109;
            this.lblDiscount.Text = "Multiplier(Discount):";
            // 
            // lblBundleCost
            // 
            this.lblBundleCost.AutoSize = true;
            this.lblBundleCost.Location = new System.Drawing.Point(9, 143);
            this.lblBundleCost.Name = "lblBundleCost";
            this.lblBundleCost.Size = new System.Drawing.Size(67, 13);
            this.lblBundleCost.TabIndex = 108;
            this.lblBundleCost.Text = "Bundle Cost:";
            // 
            // lblBundle
            // 
            this.lblBundle.AutoSize = true;
            this.lblBundle.Location = new System.Drawing.Point(9, 120);
            this.lblBundle.Name = "lblBundle";
            this.lblBundle.Size = new System.Drawing.Size(80, 13);
            this.lblBundle.TabIndex = 107;
            this.lblBundle.Text = "Lesson Bundle:";
            // 
            // lbBundleCost
            // 
            this.lbBundleCost.FormattingEnabled = true;
            this.lbBundleCost.Location = new System.Drawing.Point(128, 143);
            this.lbBundleCost.Name = "lbBundleCost";
            this.lbBundleCost.Size = new System.Drawing.Size(171, 17);
            this.lbBundleCost.TabIndex = 106;
            // 
            // lbLessonBundleName
            // 
            this.lbLessonBundleName.FormattingEnabled = true;
            this.lbLessonBundleName.Location = new System.Drawing.Point(128, 120);
            this.lbLessonBundleName.Name = "lbLessonBundleName";
            this.lbLessonBundleName.Size = new System.Drawing.Size(171, 17);
            this.lbLessonBundleName.TabIndex = 105;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(247, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(332, 63);
            this.lbMain.TabIndex = 102;
            this.lbMain.Text = "Lesson Bundle List";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(10, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 101;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(-1, -2);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(751, 85);
            this.pbBorder2.TabIndex = 100;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(317, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(433, 40);
            this.pictureBox4.TabIndex = 104;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmSplash.Properties.Resources.Music_background_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 247);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(408, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 26);
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(453, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 28);
            this.button1.TabIndex = 119;
            this.button1.Text = "Add new Bundle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLessonBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPreviousIBundle);
            this.Controls.Add(this.btnNextLessonBundle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbBundleSearch);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblBundleID);
            this.Controls.Add(this.lbLessonBundleID);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblBundleCost);
            this.Controls.Add(this.lblBundle);
            this.Controls.Add(this.lbBundleCost);
            this.Controls.Add(this.lbLessonBundleName);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLessonBundle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLessonBundle";
            this.Load += new System.EventHandler(this.frmLessonBundle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousIBundle;
        private System.Windows.Forms.Button btnNextLessonBundle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbBundleSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBundleID;
        private System.Windows.Forms.ListBox lbLessonBundleID;
        private System.Windows.Forms.ListBox lbDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblBundleCost;
        private System.Windows.Forms.Label lblBundle;
        private System.Windows.Forms.ListBox lbBundleCost;
        private System.Windows.Forms.ListBox lbLessonBundleName;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}