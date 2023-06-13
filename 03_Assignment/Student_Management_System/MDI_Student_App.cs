using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Student_App : Form
    {
       

        public MDI_Student_App()
        {
            InitializeComponent();
        }

        private void MDI_Student_App_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_UName;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           
            if(Res == DialogResult.Yes)
            {
                frm_Student_Login obj = new frm_Student_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course_Details obj = new frm_Add_Course_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void coursesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Courses_List_Details obj = new frm_Courses_List_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.Exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }
    }
}
