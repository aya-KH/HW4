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
            // TODO: This line of code loads data into the 'dataSet1.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dataSet1.course);
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
