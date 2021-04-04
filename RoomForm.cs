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
    public partial class RoomForm : Form
    {
        string id = "";
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            dGVRoom.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.room");
        }

        private void dGVRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dGVRoom.Rows[e.RowIndex].Cells["id"].Value.ToString();
            roomNameTB.Text = dGVRoom.Rows[e.RowIndex].Cells["room_name"].Value.ToString();
            deleteRoom.Enabled = true;
            modifyRoom.Enabled = true;
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("INSERT INTO teacher_attendance.room (room_name) VALUES ('" + roomNameTB.Text + "')");
            dGVRoom.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.room");
            deleteRoom.Enabled = false;
            modifyRoom.Enabled = false;
        }

        private void modifyRoom_Click(object sender, EventArgs e)
        {     
            ConnectionDB.Query("UPDATE teacher_attendance.room SET room_name='" + roomNameTB.Text + "' WHERE id=" + id);
            dGVRoom.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.room");
        }

        private void deleteRoom_Click(object sender, EventArgs e)
        {
            ConnectionDB.Query("DELETE FROM teacher_attendance.room WHERE id=" + id);
            dGVRoom.DataSource = ConnectionDB.FetchData("SELECT*FROM teacher_attendance.room");
            roomNameTB.Clear();
        }
    }
}
