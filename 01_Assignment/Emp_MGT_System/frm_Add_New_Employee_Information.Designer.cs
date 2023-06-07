
namespace Emp_MGT_System
{
    partial class frm_Add_New_Employe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Add_Employee_Information = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.btn_Employee_List = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Username.Location = new System.Drawing.Point(20, 162);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(0, 36);
            this.lbl_Username.TabIndex = 10;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Login.Location = new System.Drawing.Point(239, 41);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(0, 50);
            this.lbl_Login.TabIndex = 8;
            // 
            // lbl_Add_Employee_Information
            // 
            this.lbl_Add_Employee_Information.AutoSize = true;
            this.lbl_Add_Employee_Information.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Employee_Information.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Employee_Information.Location = new System.Drawing.Point(168, 9);
            this.lbl_Add_Employee_Information.Name = "lbl_Add_Employee_Information";
            this.lbl_Add_Employee_Information.Size = new System.Drawing.Size(556, 50);
            this.lbl_Add_Employee_Information.TabIndex = 16;
            this.lbl_Add_Employee_Information.Text = "Add Employee Information";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_ID.Location = new System.Drawing.Point(183, 101);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(44, 29);
            this.lbl_ID.TabIndex = 18;
            this.lbl_ID.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(524, 101);
            this.tb_ID.MaxLength = 4;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(204, 29);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Name.Location = new System.Drawing.Point(174, 167);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 29);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(524, 167);
            this.tb_Name.MaxLength = 10;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(204, 28);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(174, 228);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(129, 29);
            this.lbl_Mobile_No.TabIndex = 23;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(524, 228);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(204, 29);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_DOB.Location = new System.Drawing.Point(174, 293);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(81, 29);
            this.lbl_DOB.TabIndex = 25;
            this.lbl_DOB.Text = "D.O.B";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(524, 294);
            this.dtp_DOB.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(200, 29);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Designation.Location = new System.Drawing.Point(174, 360);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(146, 29);
            this.lbl_Designation.TabIndex = 27;
            this.lbl_Designation.Text = "Designation";
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Designer",
            "Tester",
            "Staff"});
            this.cmb_Designation.Location = new System.Drawing.Point(524, 360);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(204, 29);
            this.cmb_Designation.TabIndex = 5;
            // 
            // btn_Employee_List
            // 
            this.btn_Employee_List.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Employee_List.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Employee_List.Location = new System.Drawing.Point(551, 435);
            this.btn_Employee_List.Name = "btn_Employee_List";
            this.btn_Employee_List.Size = new System.Drawing.Size(289, 50);
            this.btn_Employee_List.TabIndex = 8;
            this.btn_Employee_List.Text = "Employee List";
            this.btn_Employee_List.UseVisualStyleBackColor = false;
            this.btn_Employee_List.Click += new System.EventHandler(this.btn_Employee_List_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Refresh.Location = new System.Drawing.Point(106, 435);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(139, 50);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(321, 435);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(167, 50);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.MistyRose;
            this.btn_LogOut.Font = new System.Drawing.Font("Myanmar Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_LogOut.Location = new System.Drawing.Point(825, 9);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(97, 32);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_Add_New_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.btn_Employee_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.cmb_Designation);
            this.Controls.Add(this.lbl_Designation);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Add_Employee_Information);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Employe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New  Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Add_Employee_Information;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.Button btn_Employee_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_LogOut;
    }
}