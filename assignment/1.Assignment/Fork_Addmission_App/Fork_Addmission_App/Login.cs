using System;
using System.Windows.Forms;

namespace Fork_Addmission_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            if (tb_Username.Text == "Admin" && tb_Passward.Text == "12345")
            {
                MessageBox.Show("Login Successfull", "Wellcome");
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login Failed", "Enter Correct Username or Password");
            }
            tb_Username.Clear();
            tb_Passward.Clear();
            tb_Username.Focus();
        }
    }
}
