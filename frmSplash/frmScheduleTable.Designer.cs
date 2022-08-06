namespace frmSplash
{
    partial class frmScheduleTable
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lbScheduledLessons = new System.Windows.Forms.ListBox();
            this.lbSpecialisation = new System.Windows.Forms.ListBox();
            this.lbRoomID = new System.Windows.Forms.ListBox();
            this.lbTeacherFirst_Name = new System.Windows.Forms.ListBox();
            this.lbContactNumber = new System.Windows.Forms.ListBox();
            this.lbGrade = new System.Windows.Forms.ListBox();
            this.lblTeacherSurname = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblTeacherSpecialisation = new System.Windows.Forms.Label();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.ListBox();
            this.lbTeacherID = new System.Windows.Forms.ListBox();
            this.lbFirstName = new System.Windows.Forms.ListBox();
            this.lbStudentID = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.btnPreviousStudent = new System.Windows.Forms.Button();
            this.btnNextStudent = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTeacherFirst_Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTeacherSurname = new System.Windows.Forms.ListBox();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lbGradeID = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbBorder2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(742, 328);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(198, 36);
            this.btnReturn.TabIndex = 98;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(757, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 28);
            this.button1.TabIndex = 99;
            this.button1.Text = "Add new Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(10, 373);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(66, 13);
            this.lblStudentID.TabIndex = 125;
            this.lblStudentID.Text = "ScheduleID:";
            // 
            // lbScheduledLessons
            // 
            this.lbScheduledLessons.FormattingEnabled = true;
            this.lbScheduledLessons.Location = new System.Drawing.Point(94, 373);
            this.lbScheduledLessons.Name = "lbScheduledLessons";
            this.lbScheduledLessons.Size = new System.Drawing.Size(171, 17);
            this.lbScheduledLessons.TabIndex = 124;
            // 
            // lbSpecialisation
            // 
            this.lbSpecialisation.FormattingEnabled = true;
            this.lbSpecialisation.Location = new System.Drawing.Point(389, 178);
            this.lbSpecialisation.Name = "lbSpecialisation";
            this.lbSpecialisation.Size = new System.Drawing.Size(171, 17);
            this.lbSpecialisation.TabIndex = 120;
            // 
            // lbRoomID
            // 
            this.lbRoomID.FormattingEnabled = true;
            this.lbRoomID.Location = new System.Drawing.Point(389, 203);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(171, 17);
            this.lbRoomID.TabIndex = 119;
            // 
            // lbTeacherFirst_Name
            // 
            this.lbTeacherFirst_Name.FormattingEnabled = true;
            this.lbTeacherFirst_Name.Location = new System.Drawing.Point(389, 127);
            this.lbTeacherFirst_Name.Name = "lbTeacherFirst_Name";
            this.lbTeacherFirst_Name.Size = new System.Drawing.Size(171, 17);
            this.lbTeacherFirst_Name.TabIndex = 118;
            // 
            // lbContactNumber
            // 
            this.lbContactNumber.FormattingEnabled = true;
            this.lbContactNumber.Location = new System.Drawing.Point(103, 178);
            this.lbContactNumber.Name = "lbContactNumber";
            this.lbContactNumber.Size = new System.Drawing.Size(171, 17);
            this.lbContactNumber.TabIndex = 117;
            // 
            // lbGrade
            // 
            this.lbGrade.FormattingEnabled = true;
            this.lbGrade.Location = new System.Drawing.Point(101, 251);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(171, 17);
            this.lbGrade.TabIndex = 116;
            // 
            // lblTeacherSurname
            // 
            this.lblTeacherSurname.AutoSize = true;
            this.lblTeacherSurname.Location = new System.Drawing.Point(299, 156);
            this.lblTeacherSurname.Name = "lblTeacherSurname";
            this.lblTeacherSurname.Size = new System.Drawing.Size(52, 13);
            this.lblTeacherSurname.TabIndex = 111;
            this.lblTeacherSurname.Text = "Surname:";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(299, 207);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(38, 13);
            this.lblRoomID.TabIndex = 109;
            this.lblRoomID.Text = "Room:";
            // 
            // lblTeacherSpecialisation
            // 
            this.lblTeacherSpecialisation.AutoSize = true;
            this.lblTeacherSpecialisation.Location = new System.Drawing.Point(298, 182);
            this.lblTeacherSpecialisation.Name = "lblTeacherSpecialisation";
            this.lblTeacherSpecialisation.Size = new System.Drawing.Size(75, 13);
            this.lblTeacherSpecialisation.TabIndex = 108;
            this.lblTeacherSpecialisation.Text = "Specialisation:";
            // 
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(298, 110);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(61, 13);
            this.lblOtherNames.TabIndex = 106;
            this.lblOtherNames.Text = "TeacherID:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(10, 110);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(58, 13);
            this.lblFirstname.TabIndex = 104;
            this.lblFirstname.Text = "StudentID:";
            // 
            // lbSurname
            // 
            this.lbSurname.FormattingEnabled = true;
            this.lbSurname.Location = new System.Drawing.Point(103, 152);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(171, 17);
            this.lbSurname.TabIndex = 103;
            // 
            // lbTeacherID
            // 
            this.lbTeacherID.FormattingEnabled = true;
            this.lbTeacherID.Location = new System.Drawing.Point(389, 104);
            this.lbTeacherID.Name = "lbTeacherID";
            this.lbTeacherID.Size = new System.Drawing.Size(171, 17);
            this.lbTeacherID.TabIndex = 102;
            // 
            // lbFirstName
            // 
            this.lbFirstName.FormattingEnabled = true;
            this.lbFirstName.Location = new System.Drawing.Point(103, 127);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(171, 17);
            this.lbFirstName.TabIndex = 101;
            // 
            // lbStudentID
            // 
            this.lbStudentID.FormattingEnabled = true;
            this.lbStudentID.Location = new System.Drawing.Point(103, 104);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(171, 17);
            this.lbStudentID.TabIndex = 100;
            this.lbStudentID.SelectedIndexChanged += new System.EventHandler(this.lbStudentID_SelectedIndexChanged);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbMain.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMain.Location = new System.Drawing.Point(332, 12);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(393, 63);
            this.lbMain.TabIndex = 128;
            this.lbMain.Text = "Scheduled Lessons List";
            // 
            // btnPreviousStudent
            // 
            this.btnPreviousStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPreviousStudent.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreviousStudent.Location = new System.Drawing.Point(646, 140);
            this.btnPreviousStudent.Name = "btnPreviousStudent";
            this.btnPreviousStudent.Size = new System.Drawing.Size(194, 28);
            this.btnPreviousStudent.TabIndex = 134;
            this.btnPreviousStudent.Text = "previous Student Record";
            this.btnPreviousStudent.UseVisualStyleBackColor = false;
            this.btnPreviousStudent.Click += new System.EventHandler(this.btnPreviousStudent_Click);
            // 
            // btnNextStudent
            // 
            this.btnNextStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNextStudent.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNextStudent.Location = new System.Drawing.Point(850, 140);
            this.btnNextStudent.Name = "btnNextStudent";
            this.btnNextStudent.Size = new System.Drawing.Size(194, 28);
            this.btnNextStudent.TabIndex = 133;
            this.btnNextStudent.Text = "Next Student Record";
            this.btnNextStudent.UseVisualStyleBackColor = false;
            this.btnNextStudent.Click += new System.EventHandler(this.btnNextStudent_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(722, 107);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(129, 21);
            this.lblSearch.TabIndex = 132;
            this.lblSearch.Text = "Search for Student:";
            // 
            // cbStudentID
            // 
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(855, 106);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(121, 21);
            this.cbStudentID.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 138;
            this.label3.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 139;
            this.label4.Text = "Grade:";
            // 
            // lblTeacherFirst_Name
            // 
            this.lblTeacherFirst_Name.AutoSize = true;
            this.lblTeacherFirst_Name.Location = new System.Drawing.Point(299, 131);
            this.lblTeacherFirst_Name.Name = "lblTeacherFirst_Name";
            this.lblTeacherFirst_Name.Size = new System.Drawing.Size(60, 13);
            this.lblTeacherFirst_Name.TabIndex = 140;
            this.lblTeacherFirst_Name.Text = "First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1030, 255);
            this.dataGridView1.TabIndex = 141;
            // 
            // lbTeacherSurname
            // 
            this.lbTeacherSurname.FormattingEnabled = true;
            this.lbTeacherSurname.Location = new System.Drawing.Point(389, 152);
            this.lbTeacherSurname.Name = "lbTeacherSurname";
            this.lbTeacherSurname.Size = new System.Drawing.Size(171, 17);
            this.lbTeacherSurname.TabIndex = 142;
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.Location = new System.Drawing.Point(10, 231);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(50, 13);
            this.lblGradeID.TabIndex = 143;
            this.lblGradeID.Text = "GradeID:";
            // 
            // lbGradeID
            // 
            this.lbGradeID.FormattingEnabled = true;
            this.lbGradeID.Location = new System.Drawing.Point(101, 227);
            this.lbGradeID.Name = "lbGradeID";
            this.lbGradeID.Size = new System.Drawing.Size(171, 17);
            this.lbGradeID.TabIndex = 145;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(715, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 26);
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::frmSplash.Properties.Resources.GuitarLogo_with_name;
            this.pbLogo.Location = new System.Drawing.Point(9, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 85);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 127;
            this.pbLogo.TabStop = false;
            // 
            // pbBorder2
            // 
            this.pbBorder2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbBorder2.Location = new System.Drawing.Point(-2, 0);
            this.pbBorder2.Name = "pbBorder2";
            this.pbBorder2.Size = new System.Drawing.Size(1059, 85);
            this.pbBorder2.TabIndex = 126;
            this.pbBorder2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frmSplash.Properties.Resources.Music_background_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(592, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 305);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(590, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(467, 308);
            this.pictureBox3.TabIndex = 130;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(706, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 30);
            this.button2.TabIndex = 184;
            this.button2.Text = "Return to Calender [Placeholder]";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmScheduleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1051, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbGradeID);
            this.Controls.Add(this.lblGradeID);
            this.Controls.Add(this.lbTeacherSurname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTeacherFirst_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousStudent);
            this.Controls.Add(this.btnNextStudent);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cbStudentID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBorder2);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lbScheduledLessons);
            this.Controls.Add(this.lbSpecialisation);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.lbTeacherFirst_Name);
            this.Controls.Add(this.lbContactNumber);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lblTeacherSurname);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblTeacherSpecialisation);
            this.Controls.Add(this.lblOtherNames);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbTeacherID);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmScheduleTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScheduleTable";
            this.Load += new System.EventHandler(this.frmScheduleTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ListBox lbScheduledLessons;
        private System.Windows.Forms.ListBox lbSpecialisation;
        private System.Windows.Forms.ListBox lbRoomID;
        private System.Windows.Forms.ListBox lbTeacherFirst_Name;
        private System.Windows.Forms.ListBox lbContactNumber;
        private System.Windows.Forms.ListBox lbGrade;
        private System.Windows.Forms.Label lblTeacherSurname;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblTeacherSpecialisation;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.ListBox lbSurname;
        private System.Windows.Forms.ListBox lbTeacherID;
        private System.Windows.Forms.ListBox lbFirstName;
        private System.Windows.Forms.ListBox lbStudentID;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbBorder2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPreviousStudent;
        private System.Windows.Forms.Button btnNextStudent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTeacherFirst_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbTeacherSurname;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.ListBox lbGradeID;
        private System.Windows.Forms.Button button2;
    }
}