using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MGT_SYSTEM
{
    public partial class frm_Courses_List : Form
    {
        public frm_Courses_List()
        {
            InitializeComponent();
        }

        private void frm_Courses_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MGT_SYSTEMDataSet2.Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this.sTUDENT_MGT_SYSTEMDataSet2.Course_Details);

        }
    }
}
