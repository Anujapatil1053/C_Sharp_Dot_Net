
namespace STUDENT_MGT_SYSTEM
{
    partial class frm_Add_Course_Details
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.lbl_Add_Course = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(322, 403);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 50);
            this.btn_Save.TabIndex = 80;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(436, 233);
            this.tb_Course_Name.MaxLength = 140;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(255, 29);
            this.tb_Course_Name.TabIndex = 76;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course_Name.Location = new System.Drawing.Point(137, 233);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(184, 34);
            this.lbl_Course_Name.TabIndex = 79;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Enabled = false;
            this.tb_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(436, 167);
            this.tb_Course_ID.MaxLength = 4;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(255, 29);
            this.tb_Course_ID.TabIndex = 75;
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course_ID.Location = new System.Drawing.Point(137, 167);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(146, 34);
            this.lbl_Course_ID.TabIndex = 78;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // lbl_Add_Course
            // 
            this.lbl_Add_Course.AutoSize = true;
            this.lbl_Add_Course.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_Course.Location = new System.Drawing.Point(258, 36);
            this.lbl_Add_Course.Name = "lbl_Add_Course";
            this.lbl_Add_Course.Size = new System.Drawing.Size(243, 50);
            this.lbl_Add_Course.TabIndex = 77;
            this.lbl_Add_Course.Text = "Add Course";
            // 
            // frm_Add_Course_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lbl_Add_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Course_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course Details";
            this.Load += new System.EventHandler(this.frm_Add_Course_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.Label lbl_Add_Course;
    }
}