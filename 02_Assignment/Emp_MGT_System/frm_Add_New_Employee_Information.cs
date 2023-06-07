using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emp_MGT_System
{
    public partial class frm_Add_New_Employee_Information : Form
    {
        public frm_Add_New_Employee_Information()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EMP_MGT_System.db;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_ID.Text = Convert.ToString(Cnt);

            Con_Close();
        }
        void Clear_Controls()
        {
            tb_Mob_No.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "31-Dec-10";
            cmb_Designation.SelectedIndex = -1;
            tb_ID.Focus();
        }
        private void frm_Add_New_Employee_Information_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_UName;

            Auto_Incr();
            tb_ID.Focus();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List obj = new frm_View_Employee_List();
            obj.Show();
            this.Hide();
        }
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_DOB.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@Id,@Nm,@MobNo,@Dob,@Des)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted Record Suceesful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Auto_Incr();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
