
namespace WindowsFormsApplication1
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
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBanHang = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlKHang = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXemHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlBanHang.SuspendLayout();
            this.pnlKHang.SuspendLayout();
            this.pnlThanhToan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colDonGia,
            this.colSoLuong,
            this.colGiamGia,
            this.colThanhTien,
            this.colXoa});
            this.dgvGioHang.Location = new System.Drawing.Point(12, 381);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(951, 144);
            this.dgvGioHang.TabIndex = 0;
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã Sản Phẩm";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 125;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colGiamGia
            // 
            this.colGiamGia.HeaderText = "Giảm Giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 125;
            // 
            // colXoa
            // 
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.MinimumWidth = 6;
            this.colXoa.Name = "colXoa";
            this.colXoa.Text = "Xóa";
            this.colXoa.UseColumnTextForButtonValue = true;
            this.colXoa.Width = 125;
            // 
            // pnlBanHang
            // 
            this.pnlBanHang.Controls.Add(this.lblNhanVien);
            this.pnlBanHang.Controls.Add(this.lblMaHD);
            this.pnlBanHang.Controls.Add(this.label3);
            this.pnlBanHang.Controls.Add(this.dtpNgayLap);
            this.pnlBanHang.Controls.Add(this.label2);
            this.pnlBanHang.Controls.Add(this.label1);
            this.pnlBanHang.Location = new System.Drawing.Point(13, 12);
            this.pnlBanHang.Name = "pnlBanHang";
            this.pnlBanHang.Size = new System.Drawing.Size(952, 57);
            this.pnlBanHang.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(726, 18);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(29, 22);
            this.lblNhanVien.TabIndex = 6;
            this.lblNhanVien.Text = "nv";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(142, 14);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(36, 22);
            this.lblMaHD.TabIndex = 5;
            this.lblMaHD.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân Viên:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Location = new System.Drawing.Point(392, 14);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thông Tin Khách Hàng";
            // 
            // pnlKHang
            // 
            this.pnlKHang.Controls.Add(this.txtEmail);
            this.pnlKHang.Controls.Add(this.txtSDT);
            this.pnlKHang.Controls.Add(this.txtHoTen);
            this.pnlKHang.Location = new System.Drawing.Point(14, 129);
            this.pnlKHang.Name = "pnlKHang";
            this.pnlKHang.Size = new System.Drawing.Size(951, 152);
            this.pnlKHang.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(285, 22);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(179, 30);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.Text = "SĐT:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(20, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(249, 30);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.Text = "Họ và Tên:";
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.Controls.Add(this.lblThanhTien);
            this.pnlThanhToan.Controls.Add(this.lblGiamGia);
            this.pnlThanhToan.Controls.Add(this.lblTamTinh);
            this.pnlThanhToan.Controls.Add(this.label7);
            this.pnlThanhToan.Controls.Add(this.label6);
            this.pnlThanhToan.Controls.Add(this.label5);
            this.pnlThanhToan.Location = new System.Drawing.Point(12, 545);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(951, 62);
            this.pnlThanhToan.TabIndex = 4;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(797, 19);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(71, 22);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "xxx-xxx";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(470, 19);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(37, 22);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "xxx";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Location = new System.Drawing.Point(114, 19);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(71, 22);
            this.lblTamTinh.TabIndex = 3;
            this.lblTamTinh.Text = "xxx-xxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thành Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giảm Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tạm Tính:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(197, 656);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(126, 30);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonSP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(14, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 67);
            this.panel1.TabIndex = 8;
            // 
            // btnChonSP
            // 
            this.btnChonSP.Location = new System.Drawing.Point(119, 15);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(150, 32);
            this.btnChonSP.TabIndex = 1;
            this.btnChonSP.Text = "Chọn Sản Phẩm";
            this.btnChonSP.UseVisualStyleBackColor = true;
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sản Phẩm:";
            // 
            // btnXemHD
            // 
            this.btnXemHD.Location = new System.Drawing.Point(639, 656);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(126, 30);
            this.btnXemHD.TabIndex = 9;
            this.btnXemHD.Text = "Xem hóa đơn";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 754);
            this.Controls.Add(this.btnXemHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.pnlKHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlBanHang);
            this.Controls.Add(this.dgvGioHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlBanHang.ResumeLayout(false);
            this.pnlBanHang.PerformLayout();
            this.pnlKHang.ResumeLayout(false);
            this.pnlKHang.PerformLayout();
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel pnlBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlKHang;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXemHD;
    }
}