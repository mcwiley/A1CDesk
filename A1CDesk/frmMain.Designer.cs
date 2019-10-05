namespace A1CDesk
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_103045_a1cdbDataSet = new A1CDesk.DB_103045_a1cdbDataSet();
            this.tblA1CBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_A1CTableAdapter = new A1CDesk.DB_103045_a1cdbDataSetTableAdapters.tbl_A1CTableAdapter();
            this.lbl_TotalEntries = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Overall = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_90 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_60 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_30 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Entry_Value = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Entry_Date = new System.Windows.Forms.DateTimePicker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddUpdate = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_103045_a1cdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblA1CBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entry_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.readingDateDataGridViewTextBoxColumn,
            this.readingValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblA1CBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(282, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_103045_a1cdbDataSet
            // 
            this.dB_103045_a1cdbDataSet.DataSetName = "DB_103045_a1cdbDataSet";
            this.dB_103045_a1cdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblA1CBindingSource
            // 
            this.tblA1CBindingSource.DataMember = "tbl_A1C";
            this.tblA1CBindingSource.DataSource = this.dB_103045_a1cdbDataSet;
            // 
            // tbl_A1CTableAdapter
            // 
            this.tbl_A1CTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_TotalEntries
            // 
            this.lbl_TotalEntries.AutoSize = true;
            this.lbl_TotalEntries.Location = new System.Drawing.Point(146, 309);
            this.lbl_TotalEntries.Name = "lbl_TotalEntries";
            this.lbl_TotalEntries.Size = new System.Drawing.Size(16, 17);
            this.lbl_TotalEntries.TabIndex = 21;
            this.lbl_TotalEntries.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Entries:";
            // 
            // txt_Overall
            // 
            this.txt_Overall.Enabled = false;
            this.txt_Overall.Location = new System.Drawing.Point(701, 77);
            this.txt_Overall.Name = "txt_Overall";
            this.txt_Overall.Size = new System.Drawing.Size(68, 23);
            this.txt_Overall.TabIndex = 30;
            this.txt_Overall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Overall:";
            // 
            // txt_90
            // 
            this.txt_90.Enabled = false;
            this.txt_90.Location = new System.Drawing.Point(568, 77);
            this.txt_90.Name = "txt_90";
            this.txt_90.Size = new System.Drawing.Size(68, 23);
            this.txt_90.TabIndex = 28;
            this.txt_90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "90 Day:";
            // 
            // txt_60
            // 
            this.txt_60.Enabled = false;
            this.txt_60.Location = new System.Drawing.Point(701, 32);
            this.txt_60.Name = "txt_60";
            this.txt_60.Size = new System.Drawing.Size(68, 23);
            this.txt_60.TabIndex = 26;
            this.txt_60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "60 Day:";
            // 
            // txt_30
            // 
            this.txt_30.Enabled = false;
            this.txt_30.Location = new System.Drawing.Point(568, 32);
            this.txt_30.Name = "txt_30";
            this.txt_30.Size = new System.Drawing.Size(68, 23);
            this.txt_30.TabIndex = 24;
            this.txt_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "30 Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Calculated A1C:";
            // 
            // Entry_Value
            // 
            this.Entry_Value.Location = new System.Drawing.Point(496, 195);
            this.Entry_Value.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Entry_Value.Name = "Entry_Value";
            this.Entry_Value.Size = new System.Drawing.Size(63, 23);
            this.Entry_Value.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(390, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Entry Value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(390, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Entry Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Entry_Date
            // 
            this.Entry_Date.CustomFormat = "yyyy/MM/dd";
            this.Entry_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Entry_Date.Location = new System.Drawing.Point(496, 157);
            this.Entry_Date.Name = "Entry_Date";
            this.Entry_Date.Size = new System.Drawing.Size(88, 23);
            this.Entry_Date.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readingDateDataGridViewTextBoxColumn
            // 
            this.readingDateDataGridViewTextBoxColumn.DataPropertyName = "Reading_Date";
            this.readingDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.readingDateDataGridViewTextBoxColumn.Name = "readingDateDataGridViewTextBoxColumn";
            this.readingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readingValueDataGridViewTextBoxColumn
            // 
            this.readingValueDataGridViewTextBoxColumn.DataPropertyName = "Reading_Value";
            this.readingValueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.readingValueDataGridViewTextBoxColumn.Name = "readingValueDataGridViewTextBoxColumn";
            this.readingValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_AddUpdate
            // 
            this.btn_AddUpdate.Location = new System.Drawing.Point(414, 279);
            this.btn_AddUpdate.Name = "btn_AddUpdate";
            this.btn_AddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_AddUpdate.TabIndex = 39;
            this.btn_AddUpdate.Text = "Add";
            this.btn_AddUpdate.UseVisualStyleBackColor = true;
            this.btn_AddUpdate.Click += new System.EventHandler(this.Btn_AddUpdate_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(524, 279);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(637, 279);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 41;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 359);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AddUpdate);
            this.Controls.Add(this.lbl_TotalEntries);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Overall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_90);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_60);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_30);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Entry_Value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entry_Date);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A1CDesk";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_103045_a1cdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblA1CBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entry_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_103045_a1cdbDataSet dB_103045_a1cdbDataSet;
        private System.Windows.Forms.BindingSource tblA1CBindingSource;
        private DB_103045_a1cdbDataSetTableAdapters.tbl_A1CTableAdapter tbl_A1CTableAdapter;
        private System.Windows.Forms.Label lbl_TotalEntries;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Overall;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_90;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_60;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Entry_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Entry_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AddUpdate;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
    }
}

