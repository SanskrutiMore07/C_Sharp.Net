
namespace Fork_Addmission_App.Report.Report_Form
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
            this.crv_Student_List = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Student_List
            // 
            this.crv_Student_List.ActiveViewIndex = -1;
            this.crv_Student_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Student_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Student_List.DisplayStatusBar = false;
            this.crv_Student_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Student_List.Location = new System.Drawing.Point(0, 159);
            this.crv_Student_List.Name = "crv_Student_List";
            this.crv_Student_List.Size = new System.Drawing.Size(1280, 575);
            this.crv_Student_List.TabIndex = 0;
            this.crv_Student_List.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.AutoSize = true;
            this.lbl_Student_List.BackColor = System.Drawing.Color.Linen;
            this.lbl_Student_List.Font = new System.Drawing.Font("Times New Roman", 50F);
            this.lbl_Student_List.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Student_List.Location = new System.Drawing.Point(436, 34);
            this.lbl_Student_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(425, 90);
            this.lbl_Student_List.TabIndex = 3;
            this.lbl_Student_List.Text = "Student List";
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1280, 734);
            this.Controls.Add(this.lbl_Student_List);
            this.Controls.Add(this.crv_Student_List);
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Student_List;
        private System.Windows.Forms.Label lbl_Student_List;
    }
}