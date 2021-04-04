namespace TeacherAttendanceDB
{
    partial class TeacherForm
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
            this.deleteTeacher = new System.Windows.Forms.Button();
            this.modifyTeacher = new System.Windows.Forms.Button();
            this.addTeacher = new System.Windows.Forms.Button();
            this.teacherNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteTeacher
            // 
            this.deleteTeacher.Enabled = false;
            this.deleteTeacher.Location = new System.Drawing.Point(273, 81);
            this.deleteTeacher.Name = "deleteTeacher";
            this.deleteTeacher.Size = new System.Drawing.Size(58, 23);
            this.deleteTeacher.TabIndex = 11;
            this.deleteTeacher.Text = "Delete";
            this.deleteTeacher.UseVisualStyleBackColor = true;
            this.deleteTeacher.Click += new System.EventHandler(this.deleteTeacher_Click);
            // 
            // modifyTeacher
            // 
            this.modifyTeacher.Enabled = false;
            this.modifyTeacher.Location = new System.Drawing.Point(209, 81);
            this.modifyTeacher.Name = "modifyTeacher";
            this.modifyTeacher.Size = new System.Drawing.Size(58, 23);
            this.modifyTeacher.TabIndex = 10;
            this.modifyTeacher.Text = "Modify";
            this.modifyTeacher.UseVisualStyleBackColor = true;
            this.modifyTeacher.Click += new System.EventHandler(this.modifyTeacher_Click);
            // 
            // addTeacher
            // 
            this.addTeacher.Location = new System.Drawing.Point(145, 81);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(58, 23);
            this.addTeacher.TabIndex = 9;
            this.addTeacher.Text = "Add";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // teacherNameTB
            // 
            this.teacherNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameTB.Location = new System.Drawing.Point(135, 40);
            this.teacherNameTB.Name = "teacherNameTB";
            this.teacherNameTB.Size = new System.Drawing.Size(144, 24);
            this.teacherNameTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher Name";
            // 
            // dGVTeacher
            // 
            this.dGVTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTeacher.Location = new System.Drawing.Point(24, 111);
            this.dGVTeacher.Name = "dGVTeacher";
            this.dGVTeacher.Size = new System.Drawing.Size(309, 173);
            this.dGVTeacher.TabIndex = 6;
            this.dGVTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTeacher_CellClick);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 295);
            this.Controls.Add(this.deleteTeacher);
            this.Controls.Add(this.modifyTeacher);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.teacherNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVTeacher);
            this.Name = "TeacherForm";
            this.Text = "Teacher Form";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteTeacher;
        private System.Windows.Forms.Button modifyTeacher;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.TextBox teacherNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVTeacher;
    }
}