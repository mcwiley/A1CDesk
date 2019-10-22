using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmXLS()
        {
            InitializeComponent();
        }

        private void frmXLS_Load(object sender, EventArgs e)
        {
            //Create the data set and table
            DataSet ds = new DataSet("New_DataSet");
            DataTable dt = new DataTable("New_DataTable");

            //Set the locale for each
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dt.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            //Open a DB connection (in this example with OleDB)
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["A1CDesk.Properties.Settings.DB_103045_a1cdbConnectionString"].ConnectionString);
            con.Open();

            //Create a query and fill the data table with the data from the DB
            string sql = "Select * From dbo.tbl_A1C Order By Reading_Date desc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adptr = new SqlDataAdapter();

            adptr.SelectCommand = cmd;
            adptr.Fill(dt);
            con.Close();

            //Add the table to the data set
            ds.Tables.Add(dt);

            //Here's the easy part. Create the Excel worksheet from the data set
            ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile.xls", ds);
        }
    }
}
