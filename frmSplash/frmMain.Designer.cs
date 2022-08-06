namespace frmSplash
{
    partial class frmMain
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
            this.btnPrivateTuition = new System.Windows.Forms.Button();
            this.btnWeekendSchool = new System.Windows.Forms.Button();
            this.btnSummerSchool = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrivateTuition
            // 
            this.btnPrivateTuition.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrivateTuition.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateTuition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrivateTuition.Location = new System.Drawing.Point(203, 190);
            this.btnPrivateTuition.Name = "btnPrivateTuition";
            this.btnPrivateTuition.Size = new System.Drawing.Size(188, 48);
            this.btnPrivateTuition.TabIndex = 3;
            this.btnPrivateTuition.Text = "Private Tuition";
            this.btnPrivateTuition.UseVisualStyleBackColor = false;
            this.btnPrivateTuition.Click += new System.EventHandler(this.btnPrivateTuition_Click);
            // 
            // btnWeekendSchool
            // 
            this.btnWeekendSchool.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnWeekendSchool.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekendSchool.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWeekendSchool.Location = new System.Drawing.Point(203, 259);
            this.btnWeekendSchool.Name = "btnWeekendSchool";
            this.btnWeekendSchool.Size = new System.Drawing.Size(188, 65);
            this.btnWeekendSchool.TabIndex = 4;
            this.btnWeekendSchool.Text = "The Specialist Weekend School";
            this.btnWeekendSchool.UseVisualStyleBackColor = false;
            // 
            // btnSummerSchool
            // 
            this.btnSummerSchool.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSummerSchool.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummerSchool.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSummerSchool.Location = new System.Drawing.Point(203, 344);
            this.btnSummerSchool.Name = "btnSummerSchool";
            this.btnSummerSchool.Size = new System.Drawing.Size(188, 62);
            this.btnSummerSchool.TabIndex = 5;
            this.btnSummerSchool.Text = "The Specialist Summer School";
            this.btnSummerSchool.UseVisualStyleBackColor = false;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(167, 18);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(370, 85);
            this.lbMain.TabIndex = 6;
            this.lbMain.Text = "Selection Menu";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(12, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(139, 117);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(1, 0);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(585, 117);
            this.pbBorder2.TabIndex = 1;
            this.pbBorder2.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbBackground.BackgroundImage = global::frmSplash.Properties.Resources.Music_background_4;
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackground.Location = new System.Drawing.Point(1, 120);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(585, 382);
            this.pbBackground.TabIndex = 7;
            this.pbBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 492);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnSummerSchool);
            this.Controls.Add(this.btnWeekendSchool);
            this.Controls.Add(this.btnPrivateTuition);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.pbBackground);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnPrivateTuition;
        private System.Windows.Forms.Button btnWeekendSchool;
        private System.Windows.Forms.Button btnSummerSchool;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbBackground;
    }
}