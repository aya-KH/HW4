using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherAttendanceDB;

namespace TeacherAttendanceDB
{
    public partial class FrmTeacherAttendance : Form
    {
        string id = "";

        public FrmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void FrmTeacherAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dataSet1.room);
            // TODO: This line of code loads data into the 'dataSet1.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dataSet1.course);
            // TODO: This line of code loads data into the 'dataSet1.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.teacher);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);

        }


        private void bTeacher_Click(object sender, EventArgs e)
        {
            new TeacherForm().ShowDialog();
            this.teacherTableAdapter.Fill(this.dataSet1.teacher);
        }

        private void bCourse_Click(object sender, EventArgs e)
        {
            new CourseForm().ShowDialog();
            this.courseTableAdapter.Fill(this.dataSet1.course);
        }

        private void bRoom_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
            this.roomTableAdapter.Fill(this.dataSet1.room);
        }
    }
}
