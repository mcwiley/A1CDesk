// ***********************************************************************
// Assembly         : A1CDesk
// Author           : m_c_w
// Created          : 10-05-2019
//
// Last Modified By : m_c_w
// Last Modified On : 10-10-2019
// ***********************************************************************
// <copyright file="frmMain.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace A1CDesk
{
    /// <summary>
    /// Class frmMain.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmMain : Form
    {
        /// <summary>
        /// The sqlcon
        /// </summary>
        public SqlConnection sqlcon = new SqlConnection();
        /// <summary>
        /// The selected column identifier
        /// </summary>
        public int Selected_Column_Id;
        /// <summary>
        /// The selected column date
        /// </summary>
        public DateTime Selected_Column_Date;
        /// <summary>
        /// The selected column value
        /// </summary>
        public int Selected_Column_Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the FrmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
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

            ReDataBind();

            Calc_Avg_A1C();

        }

        /// <summary>
        /// Calculates the average a1 c.
        /// </summary>
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

            DataSet ds3 = new DataSet();
            SqlDataAdapter da3 = new SqlDataAdapter(sSQL30, sqlcon);
            da3.Fill(ds3);
            double daAvg3 = Convert.ToDouble(ds3.Tables[0].Rows[0]["my30"]);
            Avg30 = (double)((46.7 + daAvg3) / 28.7) + 1;
            txt_30.Text = Avg30.ToString("##.##");

            DataSet ds6 = new DataSet();
            SqlDataAdapter da6 = new SqlDataAdapter(sSQL60, sqlcon);
            da6.Fill(ds6);
            double daAvg6 = Convert.ToDouble(ds6.Tables[0].Rows[0]["my60"]);
            Avg60 = (double)((46.7 + daAvg6) / 28.7) + 1;
            txt_60.Text = Avg60.ToString("##.##");

            DataSet ds9 = new DataSet();
            SqlDataAdapter da9 = new SqlDataAdapter(sSQL90, sqlcon);
            da9.Fill(ds9);
            double daAvg9 = Convert.ToDouble(ds9.Tables[0].Rows[0]["my90"]);
            Avg90 = (double)((46.7 + daAvg9) / 28.7) + 1;
            txt_90.Text = Avg90.ToString("##.##");

            DataSet dsO = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQLOver, sqlcon);
            da.Fill(dsO);
            double daAvgOvr = Convert.ToDouble(dsO.Tables[0].Rows[0]["myOVR"]);
            AvgOvr = (double)((46.7 + daAvgOvr) / 28.7) + 1;
            txt_Overall.Text = AvgOvr.ToString("##.##");
        }

        /// <summary>
        /// Handles the Click event of the Btn_AddUpdate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_AddUpdate_Click(object sender, EventArgs e)
        {
            DateTime mydate = Entry_Date.Value;
            mydate.ToString("yyyy/MM/dd");

            string sSQL = " ";

            sSQL = "Insert into dbo.tbl_A1C (userID,Reading_Date, Reading_TOD, Reading_Value, Comments) values ('MCWILEY', '" + mydate.ToString("yyyy/MM/dd") + "', '1', " + Entry_Value.Value + ", 'None')";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQL, sqlcon);
            da.Fill(ds);

            ReDataBind();

            Calc_Avg_A1C();

            ClearEntries();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the Btn_Clear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Entry_Date.Value = DateTime.Now;
            Entry_Value.Value = 0;

            btn_AddUpdate.Text = "Add";
            
            ReDataBind();

            dataGridView1.ClearSelection();

            lbl_TotalEntries.Text = dataGridView1.RowCount.ToString();

        }


        /// <summary>
        /// Clears the entries.
        /// </summary>
        public void ClearEntries()
        {
            Entry_Date.Value = DateTime.Now;
            Entry_Value.Value = 0;

            btn_AddUpdate.Text = "Add";
            
            //ReDataBind();

            dataGridView1.ClearSelection();

            lbl_TotalEntries.Text = dataGridView1.RowCount.ToString();


        }

        /// <summary>
        /// Res the data bind.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the Btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DateTime mydate = Entry_Date.Value;
            mydate.ToString("yyyy/MM/dd");

            string sSQL = "";
            sSQL = "Update dbo.tbl_A1C Set Reading_Date = " + "'" + mydate.ToString("yyyy/MM/dd") + "', " +
                                            "Reading_Value = " + Entry_Value.Value + " Where Id = " + Convert.ToString(Selected_Column_Id);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sSQL, sqlcon);
            da.Fill(ds);

            ReDataBind();

            Calc_Avg_A1C();

            ClearEntries();
        }

        /// <summary>
        /// Handles the CellClick event of the DataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Idx = e.RowIndex;
                dataGridView1.Rows[Idx].Selected = true;

                Selected_Column_Id = Convert.ToInt32(dataGridView1.Rows[Idx].Cells[0].Value);
                Selected_Column_Date = Convert.ToDateTime(dataGridView1.Rows[Idx].Cells[1].Value);
                Selected_Column_Value = Convert.ToInt32(dataGridView1.Rows[Idx].Cells[2].Value);

                Entry_Date.Value = (DateTime)dataGridView1.Rows[Idx].Cells[1].Value;

                Entry_Value.Value = Convert.ToInt32(Selected_Column_Value);
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            frmXLS frm = new frmXLS();
            frm.ShowDialog();
        }
    }
}
