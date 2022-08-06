namespace frmSplash
{
    partial class frmIndexMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLessonBundle = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnInstrument = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.pbBackground1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Record Tables";
            // 
            // btnLessonBundle
            // 
            this.btnLessonBundle.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessonBundle.Location = new System.Drawing.Point(30, 384);
            this.btnLessonBundle.Name = "btnLessonBundle";
            this.btnLessonBundle.Size = new System.Drawing.Size(461, 32);
            this.btnLessonBundle.TabIndex = 21;
            this.btnLessonBundle.Text = "View Lesson Bundle Table";
            this.btnLessonBundle.UseVisualStyleBackColor = true;
            // 
            // btnGrade
            // 
            this.btnGrade.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.Location = new System.Drawing.Point(30, 346);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(461, 32);
            this.btnGrade.TabIndex = 20;
            this.btnGrade.Text = "View Grade Table";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(30, 308);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(461, 32);
            this.btnRoom.TabIndex = 19;
            this.btnRoom.Text = "View Room Table";
            this.btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnInstrument
            // 
            this.btnInstrument.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrument.Location = new System.Drawing.Point(30, 270);
            this.btnInstrument.Name = "btnInstrument";
            this.btnInstrument.Size = new System.Drawing.Size(461, 32);
            this.btnInstrument.TabIndex = 18;
            this.btnInstrument.Text = "View Instrument Table";
            this.btnInstrument.UseVisualStyleBackColor = true;
            // 
            // btnTeachers
            // 
            this.btnTeachers.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(30, 232);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(461, 32);
            this.btnTeachers.TabIndex = 17;
            this.btnTeachers.Text = "View Teacher Table";
            this.btnTeachers.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(30, 194);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(461, 32);
            this.btnStudents.TabIndex = 16;
            this.btnStudents.Text = "View Student Table";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // pbBackground1
            // 
            this.pbBackground1.BackColor = System.Drawing.Color.White;
            this.pbBackground1.Location = new System.Drawing.Point(12, 151);
            this.pbBackground1.Name = "pbBackground1";
            this.pbBackground1.Size = new System.Drawing.Size(502, 280);
            this.pbBackground1.TabIndex = 15;
            this.pbBackground1.TabStop = false;
            // 
            // frmIndexMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLessonBundle);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnInstrument);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.pbBackground1);
            this.Name = "frmIndexMenu";
            this.Text = "IndexMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLessonBundle;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnInstrument;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.PictureBox pbBackground1;
    }
}