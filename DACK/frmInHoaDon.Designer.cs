
namespace DACK
{
    partial class frmInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.qlbhDataSet2 = new DACK.qlbhDataSet2();
            this.INCHITIETHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INCHITIETHDTableAdapter = new DACK.qlbhDataSet2TableAdapters.INCHITIETHDTableAdapter();
            this.iNCHITIETHDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCHITIETHDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHoaDon
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.iNCHITIETHDBindingSource1;
            this.rpvHoaDon.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvHoaDon.LocalReport.ReportEmbeddedResource = "DACK.rptInCTHD.rdlc";
            this.rpvHoaDon.Location = new System.Drawing.Point(16, 69);
            this.rpvHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvHoaDon.Name = "rpvHoaDon";
            this.rpvHoaDon.ServerReport.BearerToken = null;
            this.rpvHoaDon.Size = new System.Drawing.Size(801, 338);
            this.rpvHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem hóa đơn";
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(131, 438);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(114, 38);
            this.btnInHD.TabIndex = 2;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(561, 438);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 38);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // qlbhDataSet2
            // 
            this.qlbhDataSet2.DataSetName = "qlbhDataSet2";
            this.qlbhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // INCHITIETHDBindingSource
            // 
            this.INCHITIETHDBindingSource.DataMember = "INCHITIETHD";
            this.INCHITIETHDBindingSource.DataSource = this.qlbhDataSet2;
            // 
            // INCHITIETHDTableAdapter
            // 
            this.INCHITIETHDTableAdapter.ClearBeforeFill = true;
            // 
            // iNCHITIETHDBindingSource1
            // 
            this.iNCHITIETHDBindingSource1.DataMember = "INCHITIETHD";
            this.iNCHITIETHDBindingSource1.DataSource = this.qlbhDataSet2;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 519);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvHoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInHoaDon";
            this.Text = "Xen Hóa Đơn";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INCHITIETHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCHITIETHDBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.BindingSource INCHITIETHDBindingSource;
        private qlbhDataSet2 qlbhDataSet2;
        private qlbhDataSet2TableAdapters.INCHITIETHDTableAdapter INCHITIETHDTableAdapter;
        private System.Windows.Forms.BindingSource iNCHITIETHDBindingSource1;
    }
}