using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherAttendanceDB
{
    public partial class TeacherForm : Form
    {
        string id = "";

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dGVTeacher.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.teacher");
        }

        private void dGVTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dGVTeacher.Rows[e.RowIndex].Cells["id"].Value.ToString();
            teacherNameTB.Text = dGVTeacher.Rows[e.RowIndex].Cells["teacher_name"].Value.ToString();
            deleteTeacher.Enabled = true;
            modifyTeacher.Enabled = true;
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("INSERT INTO teacher_attendance.teacher (teacher_name) VALUES ('" + teacherNameTB.Text + "')");
            dGVTeacher.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.teacher");
        }

        private void modifyTeacher_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("UPDATE teacher_attendance.teacher SET teacher_name='" + teacherNameTB.Text + "' WHERE id=" + id);
            dGVTeacher.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.teacher");
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("DELETE FROM teacher_attendance.teacher WHERE id=" + id);
            dGVTeacher.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.teacher");
            teacherNameTB.Clear();
        }
    }
}
