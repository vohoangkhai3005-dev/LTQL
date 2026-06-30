
namespace DACK
{
    partial class frmBanHang
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
            this.txtSP = new System.Windows.Forms.TextBox();
            this.cboPLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblTHieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.cboFlavor = new System.Windows.Forms.ComboBox();
            this.lblFlavor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.btnCheckSDT = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qlbhDataSet = new DACK.qlbhDataSet();
            this.qlbhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlbhDataSet1 = new DACK.qlbhDataSet1();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new DACK.qlbhDataSet1TableAdapters.SANPHAMTableAdapter();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDanhMucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(28, 110);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(182, 34);
            this.txtSP.TabIndex = 0;
            this.txtSP.TextChanged += new System.EventHandler(this.txtSP_TextChanged);
            // 
            // cboPLoaiSP
            // 
            this.cboPLoaiSP.FormattingEnabled = true;
            this.cboPLoaiSP.Location = new System.Drawing.Point(28, 219);
            this.cboPLoaiSP.Name = "cboPLoaiSP";
            this.cboPLoaiSP.Size = new System.Drawing.Size(182, 34);
            this.cboPLoaiSP.TabIndex = 1;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(23, 27);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(103, 27);
            this.lblTim.TabIndex = 2;
            this.lblTim.Text = "Tìm kiếm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.maDanhMucDataGridViewTextBoxColumn,
            this.phanLoaiDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.hanSuDungDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn});
            this.dgvSanPham.DataSource = this.sANPHAMBindingSource;
            this.dgvSanPham.Location = new System.Drawing.Point(5, 138);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(391, 483);
            this.dgvSanPham.TabIndex = 4;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            this.dgvSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellDoubleClick);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 94);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(360, 205);
            this.dgvGioHang.TabIndex = 6;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(23, 80);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(152, 27);
            this.lblTenSP.TabIndex = 7;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblTHieu
            // 
            this.lblTHieu.AutoSize = true;
            this.lblTHieu.Location = new System.Drawing.Point(28, 189);
            this.lblTHieu.Name = "lblTHieu";
            this.lblTHieu.Size = new System.Drawing.Size(108, 27);
            this.lblTHieu.TabIndex = 8;
            this.lblTHieu.Text = "Phân loại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudTo);
            this.panel1.Controls.Add(this.nudFrom);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.cboFlavor);
            this.panel1.Controls.Add(this.lblFlavor);
            this.panel1.Controls.Add(this.lblTim);
            this.panel1.Controls.Add(this.txtSP);
            this.panel1.Controls.Add(this.lblTHieu);
            this.panel1.Controls.Add(this.lblTenSP);
            this.panel1.Controls.Add(this.cboPLoaiSP);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 636);
            this.panel1.TabIndex = 10;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(132, 24);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(87, 33);
            this.btnLoc.TabIndex = 16;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(108, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // nudTo
            // 
            this.nudTo.Location = new System.Drawing.Point(166, 413);
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(120, 34);
            this.nudTo.TabIndex = 13;
            // 
            // nudFrom
            // 
            this.nudFrom.Location = new System.Drawing.Point(28, 413);
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(120, 34);
            this.nudFrom.TabIndex = 12;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(28, 382);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(78, 27);
            this.lblGia.TabIndex = 11;
            this.lblGia.Text = "Giá từ:";
            // 
            // cboFlavor
            // 
            this.cboFlavor.FormattingEnabled = true;
            this.cboFlavor.Location = new System.Drawing.Point(28, 317);
            this.cboFlavor.Name = "cboFlavor";
            this.cboFlavor.Size = new System.Drawing.Size(182, 34);
            this.cboFlavor.TabIndex = 10;
            // 
            // lblFlavor
            // 
            this.lblFlavor.AutoSize = true;
            this.lblFlavor.Location = new System.Drawing.Point(28, 286);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(108, 27);
            this.lblFlavor.TabIndex = 9;
            this.lblFlavor.Text = "Hương vị:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnInHD);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.lblVAT);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblTamTinh);
            this.panel2.Controls.Add(this.btnCheckSDT);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.lblSDT);
            this.panel2.Controls.Add(this.lblKhachHang);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgvGioHang);
            this.panel2.Location = new System.Drawing.Point(738, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 635);
            this.panel2.TabIndex = 11;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(123, 417);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(203, 34);
            this.txtGiamGia.TabIndex = 19;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(133, 586);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 35);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(202, 546);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(124, 34);
            this.btnInHD.TabIndex = 17;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(44, 546);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(131, 34);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(13, 485);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(109, 27);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(13, 454);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(58, 27);
            this.lblVAT.TabIndex = 14;
            this.lblVAT.Text = "VAT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giảm giá:";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Location = new System.Drawing.Point(13, 393);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(104, 27);
            this.lblTamTinh.TabIndex = 12;
            this.lblTamTinh.Text = "Tạm tính:";
            // 
            // btnCheckSDT
            // 
            this.btnCheckSDT.Location = new System.Drawing.Point(231, 341);
            this.btnCheckSDT.Name = "btnCheckSDT";
            this.btnCheckSDT.Size = new System.Drawing.Size(119, 34);
            this.btnCheckSDT.TabIndex = 11;
            this.btnCheckSDT.Text = "Kiểm tra";
            this.btnCheckSDT.UseVisualStyleBackColor = true;
            this.btnCheckSDT.Click += new System.EventHandler(this.btnCheckSDT_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(79, 341);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(135, 34);
            this.txtSDT.TabIndex = 10;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(13, 344);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(60, 27);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(13, 313);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(127, 27);
            this.lblKhachHang.TabIndex = 8;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpSearch);
            this.panel3.Controls.Add(this.dgvSanPham);
            this.panel3.Location = new System.Drawing.Point(334, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 635);
            this.panel3.TabIndex = 12;
            // 
            // grpSearch
            // 
            this.grpSearch.Location = new System.Drawing.Point(30, 23);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(341, 95);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // qlbhDataSet
            // 
            this.qlbhDataSet.DataSetName = "qlbhDataSet";
            this.qlbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlbhDataSetBindingSource
            // 
            this.qlbhDataSetBindingSource.DataSource = this.qlbhDataSet;
            this.qlbhDataSetBindingSource.Position = 0;
            // 
            // qlbhDataSet1
            // 
            this.qlbhDataSet1.DataSetName = "qlbhDataSet1";
            this.qlbhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qlbhDataSet1;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // maDanhMucDataGridViewTextBoxColumn
            // 
            this.maDanhMucDataGridViewTextBoxColumn.DataPropertyName = "MaDanhMuc";
            this.maDanhMucDataGridViewTextBoxColumn.HeaderText = "MaDanhMuc";
            this.maDanhMucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDanhMucDataGridViewTextBoxColumn.Name = "maDanhMucDataGridViewTextBoxColumn";
            this.maDanhMucDataGridViewTextBoxColumn.Width = 125;
            // 
            // phanLoaiDataGridViewTextBoxColumn
            // 
            this.phanLoaiDataGridViewTextBoxColumn.DataPropertyName = "PhanLoai";
            this.phanLoaiDataGridViewTextBoxColumn.HeaderText = "PhanLoai";
            this.phanLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phanLoaiDataGridViewTextBoxColumn.Name = "phanLoaiDataGridViewTextBoxColumn";
            this.phanLoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.Width = 125;
            // 
            // hanSuDungDataGridViewTextBoxColumn
            // 
            this.hanSuDungDataGridViewTextBoxColumn.DataPropertyName = "HanSuDung";
            this.hanSuDungDataGridViewTextBoxColumn.HeaderText = "HanSuDung";
            this.hanSuDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hanSuDungDataGridViewTextBoxColumn.Name = "hanSuDungDataGridViewTextBoxColumn";
            this.hanSuDungDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            this.hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            this.hinhAnhDataGridViewTextBoxColumn.Width = 125;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            this.trangThaiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 898);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.ComboBox cboPLoaiSP;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblTHieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cboFlavor;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Button btnCheckSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private qlbhDataSet qlbhDataSet;
        private System.Windows.Forms.BindingSource qlbhDataSetBindingSource;
        private qlbhDataSet1 qlbhDataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private qlbhDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDanhMucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
    }
}

