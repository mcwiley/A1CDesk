using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace A1CDesk
{
    public partial class frmMain : Form
    {
        public SqlConnection sqlcon = new SqlConnection();
        public int Selected_Column_Id;
        public DateTime Selected_Column_Date;
        //public string Selected_Column_TOD;
        public int Selected_Column_Value;
        //public string Selected_Column_Comment;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_103045_a1cdbDataSet.tbl_A1C' table. You can move, or remove it, as needed.
            this.tbl_A1CTableAdapter.Fill(this.dB_103045_a1cdbDataSet.tbl_A1C);

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 60;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lbl_TotalEntries.Text = dataGridView1.RowCount.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["A1CDesk.Properties.Settings.DB_103045_a1cdbConnectionString"].ConnectionString;

            sqlcon.ConnectionString = connectionString;

            Calc_Avg_A1C();

        }

        public void Calc_Avg_A1C()
        {
            double AvgOvr = 0;
            double Avg30 = 0;
            double Avg60 = 0;
            double Avg90 = 0;

            string sSQL30 = "Select AVG(Reading_Value) as my30 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -1, GETDATE()) and GETDATE()";
            string sSQL60 = "Select AVG(Reading_Value) as my60 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -2, GETDATE()) and GETDATE()";
            string sSQL90 = "Select AVG(Reading_Value) as my90 From dbo.tbl_A1C where Reading_Date between DATEADD(MONTH, -3, GETDATE()) and GETDATE()";
            string sSQLOver = "Select AVG(Reading_Value) as myOVR From dbo.tbl_A1C";

            //DataSet ds3 = new DataSet();
            //SqlDataAdapter da3 = new SqlDataAdapter(sSQL30, sqlcon);
            //da3.Fill(ds3);
            //double daAvg3 = Convert.ToDouble(ds3.Tables[0].Rows[0]["my30"]);
            //Avg30 = (double)((46.7 + daAvg3) / 28.7) + 1;
            //txt_30.Text = Avg30.ToString("##.##");

            //DataSet ds6 = new DataSet();
            //SqlDataAdapter da6 = new SqlDataAdapter(sSQL60, sqlcon);
            //da6.Fill(ds6);
            //double daAvg6 = Convert.ToDouble(ds6.Tables[0].Rows[0]["my60"]);
            //Avg60 = (double)((46.7 + daAvg6) / 28.7) + 1;
            //txt_60.Text = Avg60.ToString("##.##");

            //DataSet ds9 = new DataSet();
            //SqlDataAdapter da9 = new SqlDataAdapter(sSQL90, sqlcon);
            //da9.Fill(ds9);
            //double daAvg9 = Convert.ToDouble(ds9.Tables[0].Rows[0]["my90"]);
            //Avg90 = (double)((46.7 + daAvg9) / 28.7) + 1;
            //txt_90.Text = Avg90.ToString("##.##");

            DataSet dsO = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQLOver, sqlcon);
            da.Fill(dsO);
            double daAvgOvr = Convert.ToDouble(dsO.Tables[0].Rows[0]["myOVR"]);
            AvgOvr = (double)((46.7 + daAvgOvr) / 28.7) + 1;
            txt_Overall.Text = AvgOvr.ToString("##.##");
        }



    }
}
