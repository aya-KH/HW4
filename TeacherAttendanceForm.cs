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
        DataTable courseDT = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.course");
        DataTable teacherDT = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.teacher");
        DataTable roomDT = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.room");
        string id = "";

        public FrmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void FrmTeacherAttendance_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in courseDT.Rows)
               {
                 cBCourse.Items.Add(dr[1]);
               }  
            foreach (DataRow dr in teacherDT.Rows)
               {
                 cBTeacher.Items.Add(dr[1]);
               }
            foreach (DataRow dr in roomDT.Rows)
            {
                cBRoom.Items.Add(dr[1]);
            }
            dGVAttendance.DataSource = ConnectionDB.FetchData("SELECT attendance.Id , Date , course.course_name , teacher.teacher_name , room.room_name ,start_time , leave_time , comment FROM teacher_attendance.attendance,teacher_attendance.teacher , teacher_attendance.room , teacher_attendance.course WHERE attendance.teacher_id = teacher.id AND attendance.course_id = course.id AND attendance.room_id = room.id");
        }

        private void courseEdit_Click(object sender, EventArgs e)
        {
            CourseForm coursFm = new CourseForm();
            coursFm.Show();
        }

        private void teacherEdit_Click(object sender, EventArgs e)
        {
            TeacherForm teacherFm = new TeacherForm();
            teacherFm.Show();
        }

        private void roomEdit_Click(object sender, EventArgs e)
        {
            RoomForm roomFm = new RoomForm();
            roomFm.Show();
        }

        private void addAttendance_Click(object sender, EventArgs e)
        {
            DataRow teacherDR = teacherDT.Rows[cBTeacher.Items.IndexOf(cBTeacher.SelectedItem.ToString())];
            DataRow roomDR = roomDT.Rows[cBRoom.Items.IndexOf(cBRoom.SelectedItem.ToString())];
            DataRow courseDR = courseDT.Rows[cBCourse.Items.IndexOf(cBCourse.SelectedItem.ToString())];
            ConnectionDB.Query("INSERT INTO teacher_attendance.attendance (Date, start_time, leave_time, teacher_id , room_id , course_id , comment) VALUES ('" + dTPDate.Text + "','"+dTPStartTime.Value.ToString()+"','"+dTPLeaveTime.Value.ToString()+"',"+ teacherDR[0]+ ","+ roomDR[0] + ","+ courseDR[0] + ",'"+tBComment.Text+"')");
            dGVAttendance.DataSource = ConnectionDB.FetchData("SELECT attendance.Id , Date , course_name , teacher_name , room_name ,start_time , leave_time , comment FROM teacher_attendance.attendance,teacher_attendance.teacher , teacher_attendance.room , teacher_attendance.course WHERE attendance.teacher_id = teacher.id AND attendance.course_id = course.id AND attendance.room_id = room.id");
            deleteAttendance.Enabled = false; 
            modifyAttendance.Enabled = false;
        }

        private void modifyAttendance_Click(object sender, EventArgs e)
        {
            DataRow teacherDR = teacherDT.Rows[cBTeacher.Items.IndexOf(cBTeacher.SelectedItem.ToString())];
            DataRow roomDR = roomDT.Rows[cBRoom.Items.IndexOf(cBRoom.SelectedItem.ToString())];
            DataRow courseDR = courseDT.Rows[cBCourse.Items.IndexOf(cBCourse.SelectedItem.ToString())];
            ConnectionDB.Query("UPDATE teacher_attendance.attendance SET Date ='"+ dTPDate.Text + "', start_time='" + dTPStartTime.Value.ToString() + "', leave_time='" + dTPLeaveTime.Value.ToString() + "',teacher_id="+teacherDR[0]+",room_id="+roomDR[0]+",course_id="+courseDR[0]+",comment='"+tBComment.Text+"' WHERE Id="+id);
            dGVAttendance.DataSource = ConnectionDB.FetchData("SELECT attendance.Id , Date , course.course_name , teacher.teacher_name , room.room_name ,start_time , leave_time , comment FROM teacher_attendance.attendance,teacher_attendance.teacher , teacher_attendance.room , teacher_attendance.course WHERE attendance.teacher_id = teacher.id AND attendance.course_id = course.id AND attendance.room_id = room.id");
        }

        private void deleteAttendance_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("DELETE FROM teacher_attendance.attendance WHERE Id=" + id);
            dGVAttendance.DataSource = ConnectionDB.FetchData("SELECT attendance.Id , Date , course.course_name , teacher.teacher_name , room.room_name ,start_time , leave_time , comment FROM teacher_attendance.attendance,teacher_attendance.teacher , teacher_attendance.room , teacher_attendance.course WHERE attendance.teacher_id = teacher.id AND attendance.course_id = course.id AND attendance.room_id = room.id");
            cBCourse.SelectedIndex = -1;
            cBRoom.SelectedIndex =-1;
            cBTeacher.SelectedIndex = -1;
            tBComment.Clear();
        }

        private void dGVAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dGVAttendance.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            dTPDate.Text = dGVAttendance.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            dTPStartTime.Text = dGVAttendance.Rows[e.RowIndex].Cells["start_time"].Value.ToString();
            dTPLeaveTime.Text = dGVAttendance.Rows[e.RowIndex].Cells["leave_time"].Value.ToString();
            cBCourse.Text = dGVAttendance.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            cBTeacher.Text = dGVAttendance.Rows[e.RowIndex].Cells["teacher_name"].Value.ToString();
            cBRoom.Text = dGVAttendance.Rows[e.RowIndex].Cells["room_name"].Value.ToString();
            tBComment.Text = dGVAttendance.Rows[e.RowIndex].Cells["comment"].Value.ToString();
            deleteAttendance.Enabled = true;
            modifyAttendance.Enabled = true;
        }
    }
}
