
namespace Fork_Addmission_App
{
    partial class frm_Search_Student_Details
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.tb_Mob = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.Lbl_Course = new System.Windows.Forms.Label();
            this.Lbl_Mobile_Number = new System.Windows.Forms.Label();
            this.Lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Roll_No = new System.Windows.Forms.Label();
            this.Lbl_Search_Student_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Search.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(556, 405);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(123, 44);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(198, 405);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(134, 45);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BCOM IT",
            "BSC CS "});
            this.cmb_Course.Location = new System.Drawing.Point(450, 359);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(320, 33);
            this.cmb_Course.TabIndex = 20;
            // 
            // tb_Mob
            // 
            this.tb_Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob.Location = new System.Drawing.Point(450, 307);
            this.tb_Mob.Name = "tb_Mob";
            this.tb_Mob.Size = new System.Drawing.Size(320, 30);
            this.tb_Mob.TabIndex = 4;
            this.tb_Mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(450, 247);
            this.dtp_DOB.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(320, 30);
            this.dtp_DOB.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(450, 188);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(320, 30);
            this.tb_Name.TabIndex = 5;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(450, 143);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(320, 30);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // Lbl_Course
            // 
            this.Lbl_Course.AutoSize = true;
            this.Lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Course.Location = new System.Drawing.Point(126, 350);
            this.Lbl_Course.Name = "Lbl_Course";
            this.Lbl_Course.Size = new System.Drawing.Size(97, 32);
            this.Lbl_Course.TabIndex = 21;
            this.Lbl_Course.Text = "Course";
            // 
            // Lbl_Mobile_Number
            // 
            this.Lbl_Mobile_Number.AutoSize = true;
            this.Lbl_Mobile_Number.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobile_Number.Location = new System.Drawing.Point(126, 298);
            this.Lbl_Mobile_Number.Name = "Lbl_Mobile_Number";
            this.Lbl_Mobile_Number.Size = new System.Drawing.Size(212, 32);
            this.Lbl_Mobile_Number.TabIndex = 19;
            this.Lbl_Mobile_Number.Text = "Mobile Number";
            // 
            // Lbl_Date_Of_Birth
            // 
            this.Lbl_Date_Of_Birth.AutoSize = true;
            this.Lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date_Of_Birth.Location = new System.Drawing.Point(126, 241);
            this.Lbl_Date_Of_Birth.Name = "Lbl_Date_Of_Birth";
            this.Lbl_Date_Of_Birth.Size = new System.Drawing.Size(192, 32);
            this.Lbl_Date_Of_Birth.TabIndex = 17;
            this.Lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(126, 188);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(87, 32);
            this.Lbl_Name.TabIndex = 15;
            this.Lbl_Name.Text = "Name";
            // 
            // Lbl_Roll_No
            // 
            this.Lbl_Roll_No.AutoSize = true;
            this.Lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Roll_No.Location = new System.Drawing.Point(126, 134);
            this.Lbl_Roll_No.Name = "Lbl_Roll_No";
            this.Lbl_Roll_No.Size = new System.Drawing.Size(114, 32);
            this.Lbl_Roll_No.TabIndex = 13;
            this.Lbl_Roll_No.Text = "Roll No";
            // 
            // Lbl_Search_Student_Details
            // 
            this.Lbl_Search_Student_Details.AutoSize = true;
            this.Lbl_Search_Student_Details.BackColor = System.Drawing.Color.Wheat;
            this.Lbl_Search_Student_Details.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Search_Student_Details.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_Search_Student_Details.Location = new System.Drawing.Point(117, 40);
            this.Lbl_Search_Student_Details.Name = "Lbl_Search_Student_Details";
            this.Lbl_Search_Student_Details.Size = new System.Drawing.Size(578, 68);
            this.Lbl_Search_Student_Details.TabIndex = 11;
            this.Lbl_Search_Student_Details.Text = "Search Student Details";
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Mob);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.Lbl_Course);
            this.Controls.Add(this.Lbl_Mobile_Number);
            this.Controls.Add(this.Lbl_Date_Of_Birth);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_Roll_No);
            this.Controls.Add(this.Lbl_Search_Student_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.TextBox tb_Mob;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label Lbl_Course;
        private System.Windows.Forms.Label Lbl_Mobile_Number;
        private System.Windows.Forms.Label Lbl_Date_Of_Birth;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Roll_No;
        private System.Windows.Forms.Label Lbl_Search_Student_Details;
    }
}