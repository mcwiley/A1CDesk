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
using System.Data.SqlClient;
using System.Configuration;

namespace A1CDesk
{
    public partial class frmXLS : Form
    {
        public SqlConnection sqlcon = new SqlConnection();

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

            if(rbtn_30Day.Checked)
            {
                sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -1, GETDATE()) and GETDATE() Order By Reading_Date desc";
            }
            if (rbtn_60Day.Checked)
            {
                sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -2, GETDATE()) and GETDATE() Order By Reading_Date desc";
            }
            if (rbtn_90Day.Checked)
            {
                sqlOutput = "Select * From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -3, GETDATE()) and GETDATE() Order By Reading_Date desc";
            }
            if (rbtn_AllDay.Checked)
            {
                sqlOutput = "Select * From dbo.tbl_A1C Order By Reading_Date desc";
            }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["A1CDesk.Properties.Settings.DB_103045_a1cdbConnectionString"].ConnectionString);

            ////Set the locale for each
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dt.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            ////Open a DB connection (in this example with OleDB)
            con.Open();

            SqlCommand cmd = new SqlCommand(sqlOutput, con);
            SqlDataAdapter adptr = new SqlDataAdapter();

            adptr.SelectCommand = cmd;
            adptr.Fill(dt);
            con.Close();

            ////Add the table to the data set
            ds.Tables.Add(dt);

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
