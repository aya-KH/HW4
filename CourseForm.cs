using System.Windows.Forms;
using System.Data;

namespace TeacherAttendanceDB
{
    public partial class CourseForm : Form
    {
        string id = "";
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, System.EventArgs e)
        {
            dGVCourse.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.course");
        }

        private void addCouse_Click(object sender, System.EventArgs e)
        {
            ConnectionDB.Query("INSERT INTO teacher_attendance.course (course_name) VALUES ('"+courseNameTB.Text+"')");
            dGVCourse.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.course");
            deleteCourse.Enabled = false;
            modifyCourse.Enabled = false;
        }

        private void modifyCourse_Click(object sender, System.EventArgs e)
        {
            ConnectionDB.Query("UPDATE teacher_attendance.course SET course_name='"+courseNameTB.Text+"' WHERE id=" + id);
            dGVCourse.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.course");

        }

        private void deleteCourse_Click(object sender, System.EventArgs e)
        {
            ConnectionDB.Query("DELETE FROM teacher_attendance.course WHERE id="+id);
            dGVCourse.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.course");
            courseNameTB.Clear();
        }

        private void dGVCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dGVCourse.Rows[e.RowIndex].Cells["id"].Value.ToString();
            courseNameTB.Text = dGVCourse.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            deleteCourse.Enabled = true;
            modifyCourse.Enabled = true;
        }
    }
}
