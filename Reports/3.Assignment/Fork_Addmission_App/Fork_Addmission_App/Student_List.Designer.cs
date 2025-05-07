
namespace Fork_Addmission_App
{
    partial class frm_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student_List));
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.dgv_Grid = new System.Windows.Forms.DataGridView();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_UName = new System.Windows.Forms.Label();
            this.fork_Addmisssion_App_DBDataSet = new Fork_Addmission_App.Fork_Addmisssion_App_DBDataSet();
            this.studentListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter = new Fork_Addmission_App.Fork_Addmisssion_App_DBDataSetTableAdapters.Student_ListTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmisssion_App_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(1113, 2);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(167, 50);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.AutoSize = true;
            this.lbl_Student_List.BackColor = System.Drawing.Color.Wheat;
            this.lbl_Student_List.Font = new System.Drawing.Font("Times New Roman", 50F);
            this.lbl_Student_List.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Student_List.Location = new System.Drawing.Point(384, 32);
            this.lbl_Student_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(425, 90);
            this.lbl_Student_List.TabIndex = 2;
            this.lbl_Student_List.Text = "Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(472, 521);
            this.btn_Add_New_Student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(307, 52);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // dgv_Grid
            // 
            this.dgv_Grid.AllowUserToAddRows = false;
            this.dgv_Grid.AllowUserToDeleteRows = false;
            this.dgv_Grid.AutoGenerateColumns = false;
            this.dgv_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Grid.DataSource = this.studentListBindingSource1;
            this.dgv_Grid.Location = new System.Drawing.Point(33, 156);
            this.dgv_Grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Grid.Name = "dgv_Grid";
            this.dgv_Grid.ReadOnly = true;
            this.dgv_Grid.RowHeadersWidth = 49;
            this.dgv_Grid.Size = new System.Drawing.Size(1213, 345);
            this.dgv_Grid.TabIndex = 3;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.Location = new System.Drawing.Point(16, 6);
            this.lbl_UName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(208, 37);
            this.lbl_UName.TabIndex = 4;
            this.lbl_UName.Text = "Logging User";
            // 
            // fork_Addmisssion_App_DBDataSet
            // 
            this.fork_Addmisssion_App_DBDataSet.DataSetName = "Fork_Addmisssion_App_DBDataSet";
            this.fork_Addmisssion_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource1
            // 
            this.studentListBindingSource1.DataMember = "Student_List";
            this.studentListBindingSource1.DataSource = this.fork_Addmisssion_App_DBDataSet;
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll_No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_Of_Birth";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mobile_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mobile_No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn5.HeaderText = "Course";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1280, 587);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.dgv_Grid);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_Student_List);
            this.Controls.Add(this.btn_Log_Out);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Addmisssion_App_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.DataGridView dgv_Grid;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_UName;
        private Fork_Addmisssion_App_DBDataSet fork_Addmisssion_App_DBDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource1;
        private Fork_Addmisssion_App_DBDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}