using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TeacherAttendanceDB
{
    class ConnectionDB
    {
        public static string connectionString = "datasource=localhost;port=3306; username=root; password=";
        public static MySqlConnection con = new MySqlConnection(connectionString);
        public static string query;
        public static DataTable FetchData(string q)
        {
            try
            {
                query = q;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void Query(string q) {
            try { 
                query = q;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
