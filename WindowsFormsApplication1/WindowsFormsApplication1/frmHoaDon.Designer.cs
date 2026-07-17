namespace WindowsFormsApplication1
{
    partial class frmHoaDon
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
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Luoi_HOADON = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlbhDataSet = new WindowsFormsApplication1.qlbhDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.hOADONTableAdapter = new WindowsFormsApplication1.qlbhDataSetTableAdapters.HOADONTableAdapter();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.txtTongTien);
            this.panelHoaDon.Controls.Add(this.label5);
            this.panelHoaDon.Controls.Add(this.dtpNgayLap);
            this.panelHoaDon.Controls.Add(this.cboKH);
            this.panelHoaDon.Controls.Add(this.cboNV);
            this.panelHoaDon.Controls.Add(this.txtMHD);
            this.panelHoaDon.Controls.Add(this.label4);
            this.panelHoaDon.Controls.Add(this.label3);
            this.panelHoaDon.Controls.Add(this.label2);
            this.panelHoaDon.Controls.Add(this.label1);
            this.panelHoaDon.Location = new System.Drawing.Point(8, 11);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(749, 197);
            this.panelHoaDon.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(536, 120);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(174, 34);
            this.txtTongTien.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng Tiền";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(526, 78);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(184, 34);
            this.dtpNgayLap.TabIndex = 8;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(589, 28);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(121, 37);
            this.cboKH.TabIndex = 7;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(199, 115);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(121, 37);
            this.cboNV.TabIndex = 6;
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(189, 31);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(100, 34);
            this.txtMHD.TabIndex = 4;
            this.txtMHD.TextChanged += new System.EventHandler(this.txtMHD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // Luoi_HOADON
            // 
            this.Luoi_HOADON.AutoGenerateColumns = false;
            this.Luoi_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_HOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.nGAYLAPDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn});
            this.Luoi_HOADON.DataSource = this.hOADONBindingSource;
            this.Luoi_HOADON.Location = new System.Drawing.Point(9, 214);
            this.Luoi_HOADON.Name = "Luoi_HOADON";
            this.Luoi_HOADON.RowHeadersWidth = 51;
            this.Luoi_HOADON.RowTemplate.Height = 24;
            this.Luoi_HOADON.Size = new System.Drawing.Size(748, 186);
            this.Luoi_HOADON.TabIndex = 1;
            this.Luoi_HOADON.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_HOADON_CellClick);
            this.Luoi_HOADON.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_HOADON_CellDoubleClick);
            this.Luoi_HOADON.Click += new System.EventHandler(this.Luoi_HOADON_Click);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYLAPDataGridViewTextBoxColumn
            // 
            this.nGAYLAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.HeaderText = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYLAPDataGridViewTextBoxColumn.Name = "nGAYLAPDataGridViewTextBoxColumn";
            this.nGAYLAPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONGTIEN";
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "TONGTIEN";
            this.tONGTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            this.tONGTIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qlbhDataSet;
            // 
            // qlbhDataSet
            // 
            this.qlbhDataSet.DataSetName = "qlbhDataSet";
            this.qlbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(597, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Location = new System.Drawing.Point(402, 417);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(169, 42);
            this.btnXemCTHD.TabIndex = 8;
            this.btnXemCTHD.Text = "Xem Chi Tiết";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 417);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 42);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(289, 417);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 480);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.Luoi_HOADON);
            this.Controls.Add(this.panelHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panelHoaDon.ResumeLayout(false);
            this.panelHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Luoi_HOADON;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private qlbhDataSet qlbhDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private qlbhDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
    }
}