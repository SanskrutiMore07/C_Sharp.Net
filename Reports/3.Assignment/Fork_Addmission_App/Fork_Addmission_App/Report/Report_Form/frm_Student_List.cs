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

namespace Fork_Addmission_App.Report.Report_Form
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
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
        private void frm_Student_List_Load(object sender, EventArgs e)
        {

            S_Con_Open();
            

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Student_List", DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            S_Con_Close();

            Report.CrystalReport.crpt_Student_List cr_Student_List = new CrystalReport.crpt_Student_List();
            cr_Student_List.Database.Tables["SP_Student_List"].SetDataSource(dtbl);

            crv_Student_List.ReportSource = null;
            crv_Student_List.ReportSource = cr_Student_List;

        }
    }
}
