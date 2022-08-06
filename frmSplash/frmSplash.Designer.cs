namespace frmSplash
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.tLoad = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSchoolName.Location = new System.Drawing.Point(81, 214);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(517, 63);
            this.lblSchoolName.TabIndex = 1;
            this.lblSchoolName.Text = "The Mitchell School of Music";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoading.Location = new System.Drawing.Point(228, 307);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(232, 13);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "The database is currently loading. Please wait...";
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.AutoSize = true;
            this.lblLoadingProgress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLoadingProgress.Location = new System.Drawing.Point(285, 320);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(94, 13);
            this.lblLoadingProgress.TabIndex = 3;
            this.lblLoadingProgress.Text = "[Update Message]";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(107, 346);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(476, 30);
            this.LoadingBar.TabIndex = 4;
            // 
            // tLoad
            // 
            this.tLoad.Tick += new System.EventHandler(this.tLoad_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo;
            this.pbLogo.Location = new System.Drawing.Point(260, 32);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(176, 172);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(504, 32);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(145, 29);
            this.btnIndex.TabIndex = 5;
            this.btnIndex.Text = "Index Menu";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashscreen";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblLoadingProgress;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer tLoad;
        private System.Windows.Forms.Button btnIndex;
    }
}

