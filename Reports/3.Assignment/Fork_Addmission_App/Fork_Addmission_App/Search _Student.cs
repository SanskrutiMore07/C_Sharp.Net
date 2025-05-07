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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }
        SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-2RCOABL;Initial Catalog=Fork_Addmisssion_App_DB;Integrated Security=True");

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

        private void Btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form flf = new frm_Login_Form();
            flf.Show();
            this.Hide();

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Student_list_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click_1(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Text = Convert.ToString(AutoIncr());
        }

        int AutoIncr()
        {
            S_Con_Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = DBCon;
            cmd.CommandText = "Select Count(*) From Student_List";

            int No = Convert.ToInt32(cmd.ExecuteScalar());

            if(No>0)
            {
                cmd.Connection = DBCon;
                cmd.CommandText = "Select Max (Roll_No)From Student_List";

                No = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }
            else
            {
                No = 101;
            }
            S_Con_Close();
            return No;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(AutoIncr());
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
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
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

        private void btn_Search_Click_1(object sender, EventArgs e)
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
