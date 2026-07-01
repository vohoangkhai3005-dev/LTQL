namespace WindowsFormsApplication1
{
    partial class frmReportCTHD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.INCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBHDataSet2 = new WindowsFormsApplication1.QLBHDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHoaDon = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.INCHITIETTableAdapter = new WindowsFormsApplication1.QLBHDataSet2TableAdapters.INCHITIETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // INCHITIETBindingSource
            // 
            this.INCHITIETBindingSource.DataMember = "INCHITIET";
            this.INCHITIETBindingSource.DataSource = this.QLBHDataSet2;
            // 
            // QLBHDataSet2
            // 
            this.QLBHDataSet2.DataSetName = "QLBHDataSet2";
            this.QLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hóa đơn";
            // 
            // cboHoaDon
            // 
            this.cboHoaDon.FormattingEnabled = true;
            this.cboHoaDon.Location = new System.Drawing.Point(150, 15);
            this.cboHoaDon.Name = "cboHoaDon";
            this.cboHoaDon.Size = new System.Drawing.Size(121, 37);
            this.cboHoaDon.TabIndex = 1;
            this.cboHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(499, 15);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(111, 34);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.INCHITIETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(618, 297);
            this.reportViewer1.TabIndex = 3;
            // 
            // INCHITIETTableAdapter
            // 
            this.INCHITIETTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 395);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cboHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReportCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportCTHD";
            this.Load += new System.EventHandler(this.frmReportCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHoaDon;
        private System.Windows.Forms.Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource INCHITIETBindingSource;
        private QLBHDataSet2 QLBHDataSet2;
        private QLBHDataSet2TableAdapters.INCHITIETTableAdapter INCHITIETTableAdapter;
    }
}