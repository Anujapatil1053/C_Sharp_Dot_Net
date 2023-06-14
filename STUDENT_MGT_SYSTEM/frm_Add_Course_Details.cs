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
    public partial class frm_Add_Course_Details : Form
    {
        public frm_Add_Course_Details()
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

        void Clear_Controls()
        {
            tb_Course_ID.Clear();
            tb_Course_Name.Clear();
        }

        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Course_ID) from Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }
            tb_Course_ID.Text = Convert.ToString( Cnt );

            Con_Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_ID.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Course_Details Values(@ID,@CNm)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully!!!","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                Auto_Incr();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Feilds","Incomplete Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void frm_Add_Course_Details_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }
    }
}
