using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;


namespace Fork_Addmission_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection DBCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Fork_Addmission_App_DB;Integrated Security=True");

        void S_Con_Open()
        {
            if (DBCon.State!=ConnectionState.Open) 
            {
                DBCon.Open();
            }
        }
        void S_Con_Close()
        {
            if (DBCon.State!=ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            S_Con_Open();
       
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = DBCon;
            Cmd.CommandText = "Select Count(*)From Login_Details Where Username =@Urn And Password =@Pwd";

            Cmd.Parameters.Add("Urn",SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Passward.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt>0)

            {
                MessageBox.Show("Login Successful", "Wellcome");

                Shared_Content.LoggedInUser = tb_Username.Text;

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

            S_Con_Close();
        }

    }
}
