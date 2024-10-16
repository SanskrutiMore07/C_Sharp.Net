﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class frm_Employee_Details : Form
    {
        public frm_Employee_Details()
        {
            InitializeComponent();
        }

        private void only_text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void frm_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = " ";
            bool flag = false;

            if (tb_Employee_Name.Text != " ")
            {
                Result = tb_Employee_Name.Text;

                if (cmb_Employee_Department.Text != " ")
                {
                    Result += " From " + cmb_Employee_Department.Text + " is ";

                    if (rb_male.Checked == true)
                    {
                        Result += rb_male.Text + " Candidate Prefers Shift Timing ";
                    }
                    else if (rb_female.Checked == true)
                    {
                        Result += rb_female.Text + " Candidate Prefers Shift Timing ";
                    }
                    else
                    {
                        MessageBox.Show(" Select Gender Of Employee ");
                    }


                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Timing");
                        flag = true;
                    }
                }

                else
                {
                    MessageBox.Show("Select Employee Department");
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Employee Name");
                flag = true;
            }
            if (flag == false)
            {
                tb_output.Text = Result;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_output.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_male.Checked = false;
            rb_female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;

            tb_Employee_Name.Focus();
        }

        
    }
}

