using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary;
using System.Configuration;

namespace A1CDesk
{
    public partial class frmXLS : Form
    {
        //public SqlConnection sqlcon = new SqlConnection();
        public OleDbConnection sqlcon = new OleDbConnection();

        public frmXLS()
        {
            InitializeComponent();
        }

        private void frmXLS_Load(object sender, EventArgs e)
        {
        }

        private void btn_BuildExport_Click(object sender, EventArgs e)
        {
            string sqlOutput = "";

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            DateTime todayDate = new DateTime();

            todayDate = DateTime.Now;

            string last30 = "";
            string last60 = "";
            string last90 = "";

            last30 = todayDate.AddMonths(-1).ToString("d");
            last60 = todayDate.AddMonths(-2).ToString("d");
            last90 = todayDate.AddMonths(-3).ToString("d");

            //string sSQL30 = "Select AVG(Reading_Value) as my30 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -1, GETDATE()) and GETDATE()";
            //string sSQL60 = "Select AVG(Reading_Value) as my60 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -2, GETDATE()) and GETDATE()";
            //string sSQL90 = "Select AVG(Reading_Value) as my90 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -3, GETDATE()) and GETDATE()";
            //string sSQLOver = "Select AVG(Reading_Value) as myOVR From dbo.tbl_A1C";

            string sSQL30 = "Select Reading_Date, Reading_Value From dbo_tbl_A1C where Reading_Date between '" + last30 + "' and '" + todayDate.ToString("d") + "' Order By Reading_Date desc";
            string sSQL60 = "Select Reading_Date, Reading_Value From dbo_tbl_A1C where Reading_Date between '" + last60 + "' and '" + todayDate.ToString("d") + "' Order By Reading_Date desc";
            string sSQL90 = "Select Reading_Date, Reading_Value From dbo_tbl_A1C where Reading_Date between '" + last90 + "' and '" + todayDate.ToString("d") + "' Order By Reading_Date desc";

            if (rbtn_30Day.Checked)
            {
                //sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -1, GETDATE()) and GETDATE() Order By Reading_Date desc";
                sqlOutput = sSQL30; 
            }
            if (rbtn_60Day.Checked)
            {
                //sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -2, GETDATE()) and GETDATE() Order By Reading_Date desc";
                sqlOutput = sSQL60; 
            }
            if (rbtn_90Day.Checked)
            {
                //sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -3, GETDATE()) and GETDATE() Order By Reading_Date desc";
                sqlOutput = sSQL90; 
            }
            if (rbtn_AllDay.Checked)
            {
                //sqlOutput = "Select * From dbo.tbl_A1C Order By Reading_Date desc";
                sqlOutput = "Select Reading_Date, Reading_Value From dbo_tbl_A1C Order By Reading_Date Order By Reading_Date desc";
            }

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["A1CDesk.Properties.Settings.DB_103045_a1cdbConnectionString"].ConnectionString);
            OleDbConnection acccon = new OleDbConnection(ConfigurationManager.ConnectionStrings["myAccessA1C"].ConnectionString);
            
            ////Set the locale for each
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dt.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            ////Open a DB connection (in this example with OleDB)
            //con.Open();
            acccon.Open();
            
            //SqlCommand cmd = new SqlCommand(sqlOutput, con);
            //SqlDataAdapter adptr = new SqlDataAdapter();
            OleDbCommand cmd = new OleDbCommand(sqlOutput, acccon);
            OleDbDataAdapter adptr = new OleDbDataAdapter();

            adptr.SelectCommand = cmd;
            adptr.Fill(ds);
            
            //con.Close();
            acccon.Close();

            string strOutMessage = "";

            if (txt_OutFileName.Text.Length > 0)
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderName = folderBrowserDialog1.SelectedPath;

                    ExcelLibrary.DataSetHelper.CreateWorkbook(folderName + "\\" + txt_OutFileName.Text + ".xls", ds);

                    strOutMessage = folderName + "\\" + txt_OutFileName.Text + ".xls";

                    MessageBox.Show("The Requested Output '" + strOutMessage + "' Has been Created!");

                    txt_OutFileName.Text = "";
                }
                else
                {
                    MessageBox.Show("Output Folder not selected.");
                }
            }
            else
            {
                MessageBox.Show("Output Filename not entered.");
            }
        }
    }
}
