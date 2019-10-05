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

        private void Btn_AddUpdate_Click(object sender, EventArgs e)
        {
            DateTime mydate = Entry_Date.Value;
            mydate.ToString("yyyy/MM/dd");

            //string sTOD = "";
            //if (rbTODMorning.Checked) { sTOD = "Morning"; }
            //if (rbTODAfternoon.Checked) { sTOD = "Afternoon"; }
            //if (rbTODEvening.Checked) { sTOD = "Evening"; }

            string sSQL = "";

            if (btn_AddUpdate.Text == "Add")
            {
                sSQL = "Insert into dbo.tbl_A1C (Reading_Date, Reading_Value) values (" +
                       "'" + mydate.ToString("yyyy/MM/dd") + "', " +
                       Entry_Value.Value + ")";
            }
            else
            {
                sSQL = "Update dbo.tbl_A1C Set Reading_Date = " + "'" + mydate.ToString("yyyy/MM/dd") + "', " +
                                              "Reading_Value = " + Entry_Value.Value + "' Where Id = " + Convert.ToString(Selected_Column_Id);
            }

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQL, sqlcon);
            da.Fill(ds);

            ReDataBind();

            Calc_Avg_A1C();

            ClearEntries();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            string sSQL = "Delete From dbo.tbl_A1C Where Id = " + Convert.ToString(Selected_Column_Id);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQL, sqlcon);
            da.Fill(ds);

            ReDataBind();

            Calc_Avg_A1C();

            ClearEntries();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            //Entry_Comment.Text = "";
            Entry_Date.Value = DateTime.Now;
            Entry_Value.Value = 0;
            //rbTODMorning.Checked = true;

            btn_AddUpdate.Text = "Add";

            dataGridView1.ClearSelection();

            lbl_TotalEntries.Text = dataGridView1.RowCount.ToString();
        }


        public void ClearEntries()
        {
            //Entry_Comment.Text = "";
            Entry_Date.Value = DateTime.Now;
            Entry_Value.Value = 0;
            //rbTODMorning.Checked = true;

            btn_AddUpdate.Text = "Add";

            dataGridView1.ClearSelection();

            lbl_TotalEntries.Text = dataGridView1.RowCount.ToString();
        }

        public void ReDataBind()
        {
            string SQLSelect = "Select * From dbo.tbl_A1C Order By Reading_Date desc";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLSelect, sqlcon);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            tblA1CBindingSource.DataSource = ds.Tables[0];

            dataGridView1.DataSource = tblA1CBindingSource;
        }

    }
}
