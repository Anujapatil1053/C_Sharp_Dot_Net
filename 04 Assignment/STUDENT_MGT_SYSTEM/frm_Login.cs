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

namespace STUDENT_MGT_SYSTEM
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=STUDENT_MGT_SYSTEM;Integrated Security=True");

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
        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Login_Details where Username = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                
                 Common_Content.Log_UName = tb_Username.Text;

                 MDI_STUDENT_APP obj = new MDI_STUDENT_APP();
              
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password";
                lbl_Note.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();

            Con_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Note.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
