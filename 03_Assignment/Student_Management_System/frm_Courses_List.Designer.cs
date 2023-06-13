
namespace Student_Management_System
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
           
           
            
           
           
        
         
           
           
           
            this.SuspendLayout();
            // 
            // lbl_Add_Course
            // 
          
            // 
            // dataGridView1
            // 
          
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
           
              
            // 
            // student_Management_SystemDataSet1
            // 
             
           
            // 
            // coursesDetailsBindingSource
            // 
           
           
            // 
            // courses_DetailsTableAdapter
            // 
         
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
           

          
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
           
            // 
            // frm_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(884, 536);
            this.ControlBox = false;
          
            this.Name = "frm_Courses_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Courses List";
            this.Load += new System.EventHandler(this.frm_Courses_List_Load);
           
           
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    }
}