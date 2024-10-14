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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Text ="";
            tb_Name.Clear();
            tb_Mob.Clear();
            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = -1;

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
              Clear_Controls();
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
       

        private void btn_Update_Click(object sender, EventArgs e)
        {
            S_Con_Open();
            {
                if (tb_Name.Text != "" && tb_Mob.Text != "" && cmb_Course.Text != "")
                {
                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = DBCon;
                    Cmd.CommandText = "Update Student_List Set Name=@Nm,Date_Of_Birth=@Dob,Mobile_No=@MNo,Course=@Course Where Roll_No=@RNo ";
                    Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                    Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                    Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                    Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob.Text;
                    Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("1st Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                S_Con_Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                S_Con_Open();
                SqlCommand Cmd = new SqlCommand("Select * From Student_List Where Roll_No = @RNo", DBCon);

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mob.Text = (Dr["Mobile_No"].ToString());
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                    dtp_DOB.Text = (Dr["Date_Of_Birth"].ToString());
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No", MessageBoxButtons.OK);
                    tb_Roll_No.Clear();
                }
                S_Con_Close();
            }
        }
    }
}
