namespace frmSplash
{
    partial class frmConfirmation
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.lblPlaceholder1 = new System.Windows.Forms.Label();
            this.tbFieldName = new System.Windows.Forms.TextBox();
            this.lblPlaceholder2 = new System.Windows.Forms.Label();
            this.tbFieldID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(14, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(114, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(355, 63);
            this.lbMain.TabIndex = 15;
            this.lbMain.Text = "Delete Confirmation";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(10, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(-1, -2);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(486, 85);
            this.pbBorder2.TabIndex = 13;
            this.pbBorder2.TabStop = false;
            // 
            // lblPlaceholder1
            // 
            this.lblPlaceholder1.AutoSize = true;
            this.lblPlaceholder1.Location = new System.Drawing.Point(12, 100);
            this.lblPlaceholder1.Name = "lblPlaceholder1";
            this.lblPlaceholder1.Size = new System.Drawing.Size(69, 13);
            this.lblPlaceholder1.TabIndex = 16;
            this.lblPlaceholder1.Text = "[Placeholder]";
            // 
            // tbFieldName
            // 
            this.tbFieldName.Enabled = false;
            this.tbFieldName.Location = new System.Drawing.Point(139, 129);
            this.tbFieldName.Name = "tbFieldName";
            this.tbFieldName.Size = new System.Drawing.Size(144, 20);
            this.tbFieldName.TabIndex = 17;
            // 
            // lblPlaceholder2
            // 
            this.lblPlaceholder2.AutoSize = true;
            this.lblPlaceholder2.Location = new System.Drawing.Point(12, 132);
            this.lblPlaceholder2.Name = "lblPlaceholder2";
            this.lblPlaceholder2.Size = new System.Drawing.Size(69, 13);
            this.lblPlaceholder2.TabIndex = 18;
            this.lblPlaceholder2.Text = "[Placeholder]";
            // 
            // tbFieldID
            // 
            this.tbFieldID.Enabled = false;
            this.tbFieldID.Location = new System.Drawing.Point(139, 97);
            this.tbFieldID.Name = "tbFieldID";
            this.tbFieldID.Size = new System.Drawing.Size(83, 20);
            this.tbFieldID.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(377, 195);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 34);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(483, 238);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbFieldID);
            this.Controls.Add(this.lblPlaceholder2);
            this.Controls.Add(this.tbFieldName);
            this.Controls.Add(this.lblPlaceholder1);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmation";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.Label lblPlaceholder1;
        private System.Windows.Forms.TextBox tbFieldName;
        private System.Windows.Forms.Label lblPlaceholder2;
        private System.Windows.Forms.TextBox tbFieldID;
        private System.Windows.Forms.Button btnConfirm;
    }
}