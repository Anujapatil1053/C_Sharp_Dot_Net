﻿using System;
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
    public partial class frm_Courses_List_Details : Form
    {
        public frm_Courses_List_Details()
        {
            InitializeComponent();
        }

        private void frm_Courses_List_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_SystemDataSet1.Courses_Details' table. You can move, or remove it, as needed.
            this.courses_DetailsTableAdapter.Fill(this.student_Management_SystemDataSet1.Courses_Details);

        }
    }
}
