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
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }
        SqlConnection DBCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Fork_Addmission_App_DB;Integrated Security=True");

        void S_Con_Open()
        {
            if (DBCon.State != ConnectionState.Open)
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
        int AutoIncr()
        {
            S_Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = DBCon;
            Cmd.CommandText = "Select Count(*)From Course_Details";

            int No = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (No > 0)
            {
                Cmd.Connection = DBCon;
                Cmd.CommandText = "Select Max (Course_Id)From Course_Details";

                No = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                No = 101;
            }
            S_Con_Close();
            return No;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            S_Con_Open();
            if (tb_Course_ID.Text != "" && tb_Course_Name.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = DBCon;
                Cmd.CommandText = "Insert Into Course_Details (Course_Id,Course_Name)Values(@CID,@CName)";
                Cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("CName", SqlDbType.VarChar).Value = tb_Course_Name.Text;
              

                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            S_Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            tb_Course_ID.Text = Convert.ToString(AutoIncr());
        }
    }
}
