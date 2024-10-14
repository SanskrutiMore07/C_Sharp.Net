using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_General_Details
{
    public partial class frm_Employee_General_Details : Form
    {
        public frm_Employee_General_Details()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = true, Lflag = true;

            if(tb_Name.Text !="")
            {
                Result += tb_Name.Text + "Is From ";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Text = "Enter Employee Name";
                lbl_Name_Error.Visible = true;
                flag = false;
            }
            if(cmb_Dept.Text!="")
            {
                Result += cmb_Dept.Text;
                lbl_Dept_Error.Visible = false;
            }
            else
            {
                lbl_Dept_Error.Text = "Select Department";
                lbl_Dept_Error.Visible = true;
                flag = false;
            }
            if(rb_Male.Checked==true)
            {
                Result += ", Is " + rb_Male.Text + " And He Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else if(rb_Female.Checked==true)
            {
                Result += ", Is " + rb_Female.Text + " And She Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Gender";
                lbl_Gender_Error.Visible = true;
                flag = false;
            }
            if(chb_English.Checked ==true)
            {
                Result += chb_English.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;

            }
            if(chb_Hindi.Checked ==true)
            {
                Result += chb_Hindi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;

            }
            if(chb_Marathi.Checked ==true)
            {
                Result += chb_Marathi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;
            }
            if(chb_French.Checked ==true)
            {
                Result += chb_French.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;
            }
            if(Lflag==true)
            {
                lbl_Lang_Error.Text = "Select Known Lang";
                lbl_Lang_Error.Visible = true;
                flag = false;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;
            if (Cnt > 0) 
            {
                lbl_Hobby_Error.Visible = false;
                Result += "And Has Hobbies As ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++) 
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + ",";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;

                        }
                        Cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobby_Error.Text = "Select Atleast One Hobby";
                lbl_Hobby_Error.Visible = true;
                flag = false;
            }
            if(flag==false)
            {
                lbl_Result.Visible = false;
            }
            else
            {
                lbl_Result.Text = Result;
                lbl_Result.Visible = true;
            }


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Dept.SelectedIndex = -1;

            rb_Female.Checked = false;
            rb_Male.Checked = false;

            chb_English.Checked = false;
            chb_French.Checked = false;
            chb_Hindi.Checked = false;
            chb_Marathi.Checked = false;

            for(int i =0;i<clb_Hobbies.Items.Count;i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            lbl_Result.Visible = false;
        }
    }
}
