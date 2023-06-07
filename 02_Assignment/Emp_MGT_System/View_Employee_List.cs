﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emp_MGT_System
{
    public partial class frm_View_Employee_List : Form
    {
        public frm_View_Employee_List()
        {
            InitializeComponent();
        }
        private void lbl_View_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_EMP_MGT_System_dbDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter1.Fill(this._EMP_MGT_System_dbDataSet.Employee_Details);
            // TODO: This line of code loads data into the 'emp_MGT_SystemDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.emp_MGT_SystemDataSet.Employee_Details);

            lbl_UName.Text = Common_Content.Log_UName;

        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee_Information obj = new frm_Add_New_Employee_Information();
            obj.Show();
            this.Hide();
        }
    }
}
