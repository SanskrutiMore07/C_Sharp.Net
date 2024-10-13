
namespace Employee_Details
{
    partial class frm_Employee_Details
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
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.cmb_Employee_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.gb_Gender.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Miriam", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(313, 16);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(385, 53);
            this.lbl_Employee_Details.TabIndex = 0;
            this.lbl_Employee_Details.Text = "Employee Details";
            this.lbl_Employee_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Uighur", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(132, 97);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(242, 61);
            this.lbl_Employee_Name.TabIndex = 1;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Microsoft Uighur", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(132, 158);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(323, 61);
            this.lbl_Employee_Department.TabIndex = 2;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Uighur", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Gender.Location = new System.Drawing.Point(132, 229);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(126, 61);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Microsoft Uighur", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Shift_Time.Location = new System.Drawing.Point(132, 308);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(166, 61);
            this.lbl_Shift_Time.TabIndex = 4;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(486, 120);
            this.tb_Employee_Name.MaxLength = 30;
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(370, 27);
            this.tb_Employee_Name.TabIndex = 5;
            this.tb_Employee_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.only_text);
            // 
            // cmb_Employee_Department
            // 
            this.cmb_Employee_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Department.FormattingEnabled = true;
            this.cmb_Employee_Department.Items.AddRange(new object[] {
            "Department of Computer",
            "Deparment of Physics",
            "Deparment of Chemistry",
            "Deparment of Biology"});
            this.cmb_Employee_Department.Location = new System.Drawing.Point(486, 176);
            this.cmb_Employee_Department.Name = "cmb_Employee_Department";
            this.cmb_Employee_Department.Size = new System.Drawing.Size(298, 28);
            this.cmb_Employee_Department.TabIndex = 6;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gb_Gender.Controls.Add(this.rb_female);
            this.gb_Gender.Controls.Add(this.rb_male);
            this.gb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(486, 238);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(370, 52);
            this.gb_Gender.TabIndex = 7;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(225, 18);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(72, 21);
            this.rb_female.TabIndex = 1;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(49, 18);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(56, 21);
            this.rb_male.TabIndex = 0;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.Color.FloralWhite;
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Controls.Add(this.rb_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Morning);
            this.gb_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shift_Time.Location = new System.Drawing.Point(486, 318);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(457, 51);
            this.gb_Shift_Time.TabIndex = 8;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Shift Time";
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Location = new System.Drawing.Point(318, 22);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(59, 21);
            this.rb_Night.TabIndex = 2;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Location = new System.Drawing.Point(170, 22);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(77, 21);
            this.rb_Evening.TabIndex = 1;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Location = new System.Drawing.Point(20, 22);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(77, 21);
            this.rb_Morning.TabIndex = 0;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Reset.Font = new System.Drawing.Font("Miriam", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Reset.Location = new System.Drawing.Point(283, 394);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(133, 33);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Submit.Font = new System.Drawing.Font("Miriam", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Submit.Location = new System.Drawing.Point(636, 394);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(127, 33);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.ForeColor = System.Drawing.Color.Red;
            this.lbl_output.Location = new System.Drawing.Point(49, 440);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(112, 35);
            this.lbl_output.TabIndex = 11;
            this.lbl_output.Text = "Output";
            // 
            // tb_output
            // 
            this.tb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_output.Location = new System.Drawing.Point(239, 451);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(745, 23);
            this.tb_output.TabIndex = 12;
            // 
            // frm_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1007, 499);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Employee_Department);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Employee_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_Details";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frm_Employee_Details_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.ComboBox cmb_Employee_Department;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.TextBox tb_output;
    }
}

