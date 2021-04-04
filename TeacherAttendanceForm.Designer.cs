namespace TeacherAttendanceDB
{
    partial class FrmTeacherAttendance
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
            this.dGVAttendance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBComment = new System.Windows.Forms.TextBox();
            this.courseEdit = new System.Windows.Forms.Button();
            this.teacherEdit = new System.Windows.Forms.Button();
            this.roomEdit = new System.Windows.Forms.Button();
            this.addAttendance = new System.Windows.Forms.Button();
            this.modifyAttendance = new System.Windows.Forms.Button();
            this.deleteAttendance = new System.Windows.Forms.Button();
            this.cBCourse = new System.Windows.Forms.ComboBox();
            this.cBTeacher = new System.Windows.Forms.ComboBox();
            this.cBRoom = new System.Windows.Forms.ComboBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.dTPLeaveTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVAttendance
            // 
            this.dGVAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAttendance.Location = new System.Drawing.Point(37, 230);
            this.dGVAttendance.Name = "dGVAttendance";
            this.dGVAttendance.Size = new System.Drawing.Size(843, 220);
            this.dGVAttendance.TabIndex = 0;
            this.dGVAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAttendance_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leave Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(463, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(463, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room/Lab";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(463, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teacher Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Comment";
            // 
            // tBComment
            // 
            this.tBComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBComment.Location = new System.Drawing.Point(120, 158);
            this.tBComment.Name = "tBComment";
            this.tBComment.Size = new System.Drawing.Size(760, 24);
            this.tBComment.TabIndex = 14;
            // 
            // courseEdit
            // 
            this.courseEdit.Location = new System.Drawing.Point(712, 34);
            this.courseEdit.Name = "courseEdit";
            this.courseEdit.Size = new System.Drawing.Size(75, 23);
            this.courseEdit.TabIndex = 16;
            this.courseEdit.Text = "Edit";
            this.courseEdit.UseVisualStyleBackColor = true;
            this.courseEdit.Click += new System.EventHandler(this.courseEdit_Click);
            // 
            // teacherEdit
            // 
            this.teacherEdit.Location = new System.Drawing.Point(714, 70);
            this.teacherEdit.Name = "teacherEdit";
            this.teacherEdit.Size = new System.Drawing.Size(75, 23);
            this.teacherEdit.TabIndex = 17;
            this.teacherEdit.Text = "Edit";
            this.teacherEdit.UseVisualStyleBackColor = true;
            this.teacherEdit.Click += new System.EventHandler(this.teacherEdit_Click);
            // 
            // roomEdit
            // 
            this.roomEdit.Location = new System.Drawing.Point(714, 111);
            this.roomEdit.Name = "roomEdit";
            this.roomEdit.Size = new System.Drawing.Size(75, 23);
            this.roomEdit.TabIndex = 18;
            this.roomEdit.Text = "Edit";
            this.roomEdit.UseVisualStyleBackColor = true;
            this.roomEdit.Click += new System.EventHandler(this.roomEdit_Click);
            // 
            // addAttendance
            // 
            this.addAttendance.Location = new System.Drawing.Point(639, 201);
            this.addAttendance.Name = "addAttendance";
            this.addAttendance.Size = new System.Drawing.Size(75, 23);
            this.addAttendance.TabIndex = 19;
            this.addAttendance.Text = "Add";
            this.addAttendance.UseVisualStyleBackColor = true;
            this.addAttendance.Click += new System.EventHandler(this.addAttendance_Click);
            // 
            // modifyAttendance
            // 
            this.modifyAttendance.Enabled = false;
            this.modifyAttendance.Location = new System.Drawing.Point(725, 201);
            this.modifyAttendance.Name = "modifyAttendance";
            this.modifyAttendance.Size = new System.Drawing.Size(75, 23);
            this.modifyAttendance.TabIndex = 20;
            this.modifyAttendance.Text = "Modify";
            this.modifyAttendance.UseVisualStyleBackColor = true;
            this.modifyAttendance.Click += new System.EventHandler(this.modifyAttendance_Click);
            // 
            // deleteAttendance
            // 
            this.deleteAttendance.Enabled = false;
            this.deleteAttendance.Location = new System.Drawing.Point(805, 201);
            this.deleteAttendance.Name = "deleteAttendance";
            this.deleteAttendance.Size = new System.Drawing.Size(75, 23);
            this.deleteAttendance.TabIndex = 21;
            this.deleteAttendance.Text = "Delete";
            this.deleteAttendance.UseVisualStyleBackColor = true;
            this.deleteAttendance.Click += new System.EventHandler(this.deleteAttendance_Click);
            // 
            // cBCourse
            // 
            this.cBCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCourse.FormattingEnabled = true;
            this.cBCourse.Location = new System.Drawing.Point(572, 32);
            this.cBCourse.Name = "cBCourse";
            this.cBCourse.Size = new System.Drawing.Size(134, 26);
            this.cBCourse.TabIndex = 22;
            // 
            // cBTeacher
            // 
            this.cBTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTeacher.FormattingEnabled = true;
            this.cBTeacher.Location = new System.Drawing.Point(573, 70);
            this.cBTeacher.Name = "cBTeacher";
            this.cBTeacher.Size = new System.Drawing.Size(134, 26);
            this.cBTeacher.TabIndex = 23;
            // 
            // cBRoom
            // 
            this.cBRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRoom.FormattingEnabled = true;
            this.cBRoom.Location = new System.Drawing.Point(573, 112);
            this.cBRoom.Name = "cBRoom";
            this.cBRoom.Size = new System.Drawing.Size(134, 26);
            this.cBRoom.TabIndex = 24;
            // 
            // dTPDate
            // 
            this.dTPDate.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F);
            this.dTPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDate.Location = new System.Drawing.Point(122, 33);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(134, 24);
            this.dTPDate.TabIndex = 25;
            // 
            // dTPStartTime
            // 
            this.dTPStartTime.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F);
            this.dTPStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStartTime.Location = new System.Drawing.Point(122, 72);
            this.dTPStartTime.Name = "dTPStartTime";
            this.dTPStartTime.Size = new System.Drawing.Size(134, 24);
            this.dTPStartTime.TabIndex = 26;
            // 
            // dTPLeaveTime
            // 
            this.dTPLeaveTime.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F);
            this.dTPLeaveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPLeaveTime.Location = new System.Drawing.Point(122, 113);
            this.dTPLeaveTime.Name = "dTPLeaveTime";
            this.dTPLeaveTime.Size = new System.Drawing.Size(134, 24);
            this.dTPLeaveTime.TabIndex = 27;
            // 
            // FrmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 470);
            this.Controls.Add(this.dTPLeaveTime);
            this.Controls.Add(this.dTPStartTime);
            this.Controls.Add(this.dTPDate);
            this.Controls.Add(this.cBRoom);
            this.Controls.Add(this.cBTeacher);
            this.Controls.Add(this.cBCourse);
            this.Controls.Add(this.deleteAttendance);
            this.Controls.Add(this.modifyAttendance);
            this.Controls.Add(this.addAttendance);
            this.Controls.Add(this.roomEdit);
            this.Controls.Add(this.teacherEdit);
            this.Controls.Add(this.courseEdit);
            this.Controls.Add(this.tBComment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVAttendance);
            this.Name = "FrmTeacherAttendance";
            this.Text = "Teacher Attendance";
            this.Load += new System.EventHandler(this.FrmTeacherAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBComment;
        private System.Windows.Forms.Button courseEdit;
        private System.Windows.Forms.Button teacherEdit;
        private System.Windows.Forms.Button roomEdit;
        private System.Windows.Forms.Button addAttendance;
        private System.Windows.Forms.Button modifyAttendance;
        private System.Windows.Forms.Button deleteAttendance;
        private System.Windows.Forms.ComboBox cBCourse;
        private System.Windows.Forms.ComboBox cBTeacher;
        private System.Windows.Forms.ComboBox cBRoom;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.DateTimePicker dTPStartTime;
        private System.Windows.Forms.DateTimePicker dTPLeaveTime;
    }
}

