using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fork_Addmission_App
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection DBCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Fork_Addmission_App_DB;Integrated Security=True");

        void S_Con_Open()
        {
            if(DBCon.State != ConnectionState.Open)
            {
                DBCon.Open();
            }
        }
        void S_Con_Close()
        {
            if (DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }
        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text=Convert.ToString(AutoIncr());
            tb_Name.Clear();
            tb_Mob.Clear();
            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = -1;

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Student_list_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            S_Con_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != "" && tb_Mob.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = DBCon;
                Cmd.CommandText = "Insert Into Student_List (Roll_No,Name,Date_Of_Birth,Mobile_No,Course)Values(@RNo,@Nm,@Dob,@MNo,@Course)";
                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("MNo",SqlDbType.Decimal).Value = tb_Mob.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            S_Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back)||(e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        int AutoIncr()
        {
            S_Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = DBCon;
            Cmd.CommandText = "Select Count(*)From Student_List";

            int No = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(No>0)
            {
                Cmd.Connection = DBCon;
                Cmd.CommandText = "Select Max (Roll_No)From Student_List";

                No = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                No = 101;
            }
            S_Con_Close();
            return No;
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = "Welcome " + Shared_Content.LoggedInUser;
            tb_Roll_No.Text = Convert.ToString(AutoIncr());
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.Show();
            this.Hide();
        }

        
    }
}
