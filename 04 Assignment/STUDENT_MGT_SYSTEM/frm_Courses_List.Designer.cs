
namespace STUDENT_MGT_SYSTEM
{
    partial class frm_Courses_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.dgv_Courses_List = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENT_MGT_SYSTEMDataSet2 = new STUDENT_MGT_SYSTEM.STUDENT_MGT_SYSTEMDataSet2();
            this.course_DetailsTableAdapter = new STUDENT_MGT_SYSTEM.STUDENT_MGT_SYSTEMDataSet2TableAdapters.Course_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MGT_SYSTEMDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course_List.Location = new System.Drawing.Point(239, 40);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(259, 50);
            this.lbl_Course_List.TabIndex = 73;
            this.lbl_Course_List.Text = "Courses List";
            // 
            // dgv_Courses_List
            // 
            this.dgv_Courses_List.AllowUserToAddRows = false;
            this.dgv_Courses_List.AllowUserToDeleteRows = false;
            this.dgv_Courses_List.AutoGenerateColumns = false;
            this.dgv_Courses_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Courses_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Courses_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Courses_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Courses_List.DataSource = this.courseDetailsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Courses_List.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Courses_List.Location = new System.Drawing.Point(61, 124);
            this.dgv_Courses_List.Name = "dgv_Courses_List";
            this.dgv_Courses_List.ReadOnly = true;
            this.dgv_Courses_List.Size = new System.Drawing.Size(674, 258);
            this.dgv_Courses_List.TabIndex = 74;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "Course_Details";
            this.courseDetailsBindingSource.DataSource = this.sTUDENT_MGT_SYSTEMDataSet2;
            // 
            // sTUDENT_MGT_SYSTEMDataSet2
            // 
            this.sTUDENT_MGT_SYSTEMDataSet2.DataSetName = "STUDENT_MGT_SYSTEMDataSet2";
            this.sTUDENT_MGT_SYSTEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Courses_List);
            this.Controls.Add(this.lbl_Course_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Courses_List";
            this.Text = "frm_Courses_List";
            this.Load += new System.EventHandler(this.frm_Courses_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MGT_SYSTEMDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course_List;
        private System.Windows.Forms.DataGridView dgv_Courses_List;
        private STUDENT_MGT_SYSTEMDataSet2 sTUDENT_MGT_SYSTEMDataSet2;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private STUDENT_MGT_SYSTEMDataSet2TableAdapters.Course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}