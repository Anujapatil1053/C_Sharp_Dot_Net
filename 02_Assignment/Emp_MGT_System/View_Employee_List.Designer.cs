
namespace Emp_MGT_System
{
    partial class frm_View_Employee_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Employee_Details_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._EMP_MGT_System_dbDataSet = new Emp_MGT_System._EMP_MGT_System_dbDataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_MGT_SystemDataSet = new Emp_MGT_System.Emp_MGT_SystemDataSet();
            this.employee_DetailsTableAdapter = new Emp_MGT_System.Emp_MGT_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter1 = new Emp_MGT_System._EMP_MGT_System_dbDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.lbl_UName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EMP_MGT_System_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_MGT_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(205, 9);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(453, 50);
            this.lbl_Employee_Details_List.TabIndex = 39;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.Pink;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(288, 398);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(289, 51);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AllowUserToAddRows = false;
            this.dgv_Employee_List.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_Employee_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_List.AutoGenerateColumns = false;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_List.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_List.DataSource = this.employeeDetailsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee_List.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Employee_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_Employee_List.Location = new System.Drawing.Point(45, 77);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Employee_List.Size = new System.Drawing.Size(804, 297);
            this.dgv_Employee_List.TabIndex = 41;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this._EMP_MGT_System_dbDataSet;
            // 
            // _EMP_MGT_System_dbDataSet
            // 
            this._EMP_MGT_System_dbDataSet.DataSetName = "_EMP_MGT_System_dbDataSet";
            this._EMP_MGT_System_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.emp_MGT_SystemDataSet;
            // 
            // emp_MGT_SystemDataSet
            // 
            this.emp_MGT_SystemDataSet.DataSetName = "Emp_MGT_SystemDataSet";
            this.emp_MGT_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(805, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(95, 36);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_UName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_UName.Location = new System.Drawing.Point(12, 12);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(148, 25);
            this.lbl_UName.TabIndex = 45;
            this.lbl_UName.Text = "LoggedInUser";
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(912, 511);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.dgv_Employee_List);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee List";
            this.Load += new System.EventHandler(this.lbl_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EMP_MGT_System_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_MGT_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private Emp_MGT_SystemDataSet emp_MGT_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Emp_MGT_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_LogOut;
        private _EMP_MGT_System_dbDataSet _EMP_MGT_System_dbDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private _EMP_MGT_System_dbDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
        private System.Windows.Forms.Label lbl_UName;
    }
}