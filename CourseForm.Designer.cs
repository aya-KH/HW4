namespace TeacherAttendanceDB
{
    partial class CourseForm
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
            this.dGVCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.addCouse = new System.Windows.Forms.Button();
            this.modifyCourse = new System.Windows.Forms.Button();
            this.deleteCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCourse
            // 
            this.dGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCourse.Location = new System.Drawing.Point(32, 116);
            this.dGVCourse.Name = "dGVCourse";
            this.dGVCourse.Size = new System.Drawing.Size(284, 187);
            this.dGVCourse.TabIndex = 0;
            this.dGVCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCourse_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // courseNameTB
            // 
            this.courseNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameTB.Location = new System.Drawing.Point(138, 43);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(144, 24);
            this.courseNameTB.TabIndex = 2;
            // 
            // addCouse
            // 
            this.addCouse.Location = new System.Drawing.Point(129, 86);
            this.addCouse.Name = "addCouse";
            this.addCouse.Size = new System.Drawing.Size(58, 23);
            this.addCouse.TabIndex = 3;
            this.addCouse.Text = "Add";
            this.addCouse.UseVisualStyleBackColor = true;
            this.addCouse.Click += new System.EventHandler(this.addCouse_Click);
            // 
            // modifyCourse
            // 
            this.modifyCourse.Enabled = false;
            this.modifyCourse.Location = new System.Drawing.Point(193, 86);
            this.modifyCourse.Name = "modifyCourse";
            this.modifyCourse.Size = new System.Drawing.Size(58, 23);
            this.modifyCourse.TabIndex = 4;
            this.modifyCourse.Text = "Modify";
            this.modifyCourse.UseVisualStyleBackColor = true;
            this.modifyCourse.Click += new System.EventHandler(this.modifyCourse_Click);
            // 
            // deleteCourse
            // 
            this.deleteCourse.Enabled = false;
            this.deleteCourse.Location = new System.Drawing.Point(257, 86);
            this.deleteCourse.Name = "deleteCourse";
            this.deleteCourse.Size = new System.Drawing.Size(58, 23);
            this.deleteCourse.TabIndex = 5;
            this.deleteCourse.Text = "Delete";
            this.deleteCourse.UseVisualStyleBackColor = true;
            this.deleteCourse.Click += new System.EventHandler(this.deleteCourse_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 315);
            this.Controls.Add(this.deleteCourse);
            this.Controls.Add(this.modifyCourse);
            this.Controls.Add(this.addCouse);
            this.Controls.Add(this.courseNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVCourse);
            this.Name = "CourseForm";
            this.Text = "Course Form";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.Button addCouse;
        private System.Windows.Forms.Button modifyCourse;
        private System.Windows.Forms.Button deleteCourse;
    }
}