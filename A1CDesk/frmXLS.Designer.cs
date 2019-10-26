namespace A1CDesk
{
    partial class frmXLS
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
            this.lbl_ExportOptions = new System.Windows.Forms.Label();
            this.rbtn_30Day = new System.Windows.Forms.RadioButton();
            this.rbtn_60Day = new System.Windows.Forms.RadioButton();
            this.rbtn_90Day = new System.Windows.Forms.RadioButton();
            this.rbtn_AllDay = new System.Windows.Forms.RadioButton();
            this.btn_BuildExport = new System.Windows.Forms.Button();
            this.txt_OutFileName = new System.Windows.Forms.TextBox();
            this.lbl_OutputFile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ExportOptions
            // 
            this.lbl_ExportOptions.AutoSize = true;
            this.lbl_ExportOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExportOptions.Location = new System.Drawing.Point(23, 21);
            this.lbl_ExportOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ExportOptions.Name = "lbl_ExportOptions";
            this.lbl_ExportOptions.Size = new System.Drawing.Size(140, 24);
            this.lbl_ExportOptions.TabIndex = 0;
            this.lbl_ExportOptions.Text = "Export Options:";
            // 
            // rbtn_30Day
            // 
            this.rbtn_30Day.AutoSize = true;
            this.rbtn_30Day.Checked = true;
            this.rbtn_30Day.Location = new System.Drawing.Point(65, 62);
            this.rbtn_30Day.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_30Day.Name = "rbtn_30Day";
            this.rbtn_30Day.Size = new System.Drawing.Size(109, 21);
            this.rbtn_30Day.TabIndex = 1;
            this.rbtn_30Day.TabStop = true;
            this.rbtn_30Day.Text = "Last 30 Days";
            this.rbtn_30Day.UseVisualStyleBackColor = true;
            // 
            // rbtn_60Day
            // 
            this.rbtn_60Day.AutoSize = true;
            this.rbtn_60Day.Location = new System.Drawing.Point(65, 90);
            this.rbtn_60Day.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_60Day.Name = "rbtn_60Day";
            this.rbtn_60Day.Size = new System.Drawing.Size(109, 21);
            this.rbtn_60Day.TabIndex = 2;
            this.rbtn_60Day.Text = "Last 60 Days";
            this.rbtn_60Day.UseVisualStyleBackColor = true;
            // 
            // rbtn_90Day
            // 
            this.rbtn_90Day.AutoSize = true;
            this.rbtn_90Day.Location = new System.Drawing.Point(65, 118);
            this.rbtn_90Day.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_90Day.Name = "rbtn_90Day";
            this.rbtn_90Day.Size = new System.Drawing.Size(109, 21);
            this.rbtn_90Day.TabIndex = 3;
            this.rbtn_90Day.Text = "Last 90 Days";
            this.rbtn_90Day.UseVisualStyleBackColor = true;
            // 
            // rbtn_AllDay
            // 
            this.rbtn_AllDay.AutoSize = true;
            this.rbtn_AllDay.Location = new System.Drawing.Point(65, 146);
            this.rbtn_AllDay.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_AllDay.Name = "rbtn_AllDay";
            this.rbtn_AllDay.Size = new System.Drawing.Size(105, 21);
            this.rbtn_AllDay.TabIndex = 4;
            this.rbtn_AllDay.Text = "All Readings";
            this.rbtn_AllDay.UseVisualStyleBackColor = true;
            // 
            // btn_BuildExport
            // 
            this.btn_BuildExport.Location = new System.Drawing.Point(159, 234);
            this.btn_BuildExport.Name = "btn_BuildExport";
            this.btn_BuildExport.Size = new System.Drawing.Size(75, 23);
            this.btn_BuildExport.TabIndex = 5;
            this.btn_BuildExport.Text = "Export";
            this.btn_BuildExport.UseVisualStyleBackColor = true;
            this.btn_BuildExport.Click += new System.EventHandler(this.btn_BuildExport_Click);
            // 
            // txt_OutFileName
            // 
            this.txt_OutFileName.Location = new System.Drawing.Point(149, 187);
            this.txt_OutFileName.Name = "txt_OutFileName";
            this.txt_OutFileName.Size = new System.Drawing.Size(107, 23);
            this.txt_OutFileName.TabIndex = 6;
            // 
            // lbl_OutputFile
            // 
            this.lbl_OutputFile.AutoSize = true;
            this.lbl_OutputFile.Location = new System.Drawing.Point(62, 190);
            this.lbl_OutputFile.Name = "lbl_OutputFile";
            this.lbl_OutputFile.Size = new System.Drawing.Size(81, 17);
            this.lbl_OutputFile.TabIndex = 7;
            this.lbl_OutputFile.Text = "Output File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(262, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "(ie:  testoutput)";
            // 
            // frmXLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_OutputFile);
            this.Controls.Add(this.txt_OutFileName);
            this.Controls.Add(this.btn_BuildExport);
            this.Controls.Add(this.rbtn_AllDay);
            this.Controls.Add(this.rbtn_90Day);
            this.Controls.Add(this.rbtn_60Day);
            this.Controls.Add(this.rbtn_30Day);
            this.Controls.Add(this.lbl_ExportOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A1CDesk - Export Reading to an Excel Spreadsheet";
            this.Load += new System.EventHandler(this.frmXLS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExportOptions;
        private System.Windows.Forms.RadioButton rbtn_30Day;
        private System.Windows.Forms.RadioButton rbtn_60Day;
        private System.Windows.Forms.RadioButton rbtn_90Day;
        private System.Windows.Forms.RadioButton rbtn_AllDay;
        private System.Windows.Forms.Button btn_BuildExport;
        private System.Windows.Forms.TextBox txt_OutFileName;
        private System.Windows.Forms.Label lbl_OutputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
    }
}