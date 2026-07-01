namespace WindowsFormsApplication1
{
    partial class frmMatHang
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
            this.panelMH = new System.Windows.Forms.Panel();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.cboPL = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboMNCC = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Luoi_MatHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_MatHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMH
            // 
            this.panelMH.Controls.Add(this.picSP);
            this.panelMH.Controls.Add(this.btnChonAnh);
            this.panelMH.Controls.Add(this.cboTrangThai);
            this.panelMH.Controls.Add(this.dtpHanSuDung);
            this.panelMH.Controls.Add(this.cboPL);
            this.panelMH.Controls.Add(this.label13);
            this.panelMH.Controls.Add(this.cboMNCC);
            this.panelMH.Controls.Add(this.label12);
            this.panelMH.Controls.Add(this.txtMoTa);
            this.panelMH.Controls.Add(this.textbox2);
            this.panelMH.Controls.Add(this.txtbox1);
            this.panelMH.Controls.Add(this.label5);
            this.panelMH.Controls.Add(this.cboMaChatLieu);
            this.panelMH.Controls.Add(this.txtDonGiaBan);
            this.panelMH.Controls.Add(this.txtSoLuong);
            this.panelMH.Controls.Add(this.txtTenHang);
            this.panelMH.Controls.Add(this.txtMaHang);
            this.panelMH.Controls.Add(this.label7);
            this.panelMH.Controls.Add(this.label6);
            this.panelMH.Controls.Add(this.label4);
            this.panelMH.Controls.Add(this.label3);
            this.panelMH.Controls.Add(this.label2);
            this.panelMH.Controls.Add(this.label1);
            this.panelMH.Location = new System.Drawing.Point(24, 60);
            this.panelMH.Margin = new System.Windows.Forms.Padding(4);
            this.panelMH.Name = "panelMH";
            this.panelMH.Size = new System.Drawing.Size(330, 498);
            this.panelMH.TabIndex = 0;
            this.panelMH.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picSP
            // 
            this.picSP.Location = new System.Drawing.Point(126, 322);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(109, 104);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSP.TabIndex = 15;
            this.picSP.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(21, 394);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(74, 23);
            this.btnChonAnh.TabIndex = 26;
            this.btnChonAnh.Text = "chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(117, 463);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(173, 28);
            this.cboTrangThai.TabIndex = 25;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.Location = new System.Drawing.Point(124, 278);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(174, 26);
            this.dtpHanSuDung.TabIndex = 24;
            // 
            // cboPL
            // 
            this.cboPL.FormattingEnabled = true;
            this.cboPL.Location = new System.Drawing.Point(126, 215);
            this.cboPL.Name = "cboPL";
            this.cboPL.Size = new System.Drawing.Size(172, 28);
            this.cboPL.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Phân loại";
            // 
            // cboMNCC
            // 
            this.cboMNCC.FormattingEnabled = true;
            this.cboMNCC.Location = new System.Drawing.Point(126, 107);
            this.cboMNCC.Name = "cboMNCC";
            this.cboMNCC.Size = new System.Drawing.Size(173, 28);
            this.cboMNCC.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nhà cung cấp";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(118, 433);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(173, 26);
            this.txtMoTa.TabIndex = 18;
            // 
            // textbox2
            // 
            this.textbox2.AutoSize = true;
            this.textbox2.Location = new System.Drawing.Point(27, 469);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(84, 20);
            this.textbox2.TabIndex = 17;
            this.textbox2.Text = "Trạng thái";
            // 
            // txtbox1
            // 
            this.txtbox1.AutoSize = true;
            this.txtbox1.Location = new System.Drawing.Point(32, 433);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(51, 20);
            this.txtbox1.TabIndex = 16;
            this.txtbox1.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hình ảnh";
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Location = new System.Drawing.Point(126, 143);
            this.cboMaChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(173, 28);
            this.cboMaChatLieu.TabIndex = 13;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(124, 244);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(174, 26);
            this.txtDonGiaBan.TabIndex = 11;
            this.txtDonGiaBan.TextChanged += new System.EventHandler(this.txtDonGiaBan_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(124, 183);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(175, 26);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(125, 70);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(174, 26);
            this.txtTenHang.TabIndex = 8;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(125, 32);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(174, 26);
            this.txtMaHang.TabIndex = 7;
            this.txtMaHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hạn sử dụng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá bán";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng tồn";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Luoi_MatHang
            // 
            this.Luoi_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_MatHang.Location = new System.Drawing.Point(365, 60);
            this.Luoi_MatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Luoi_MatHang.Name = "Luoi_MatHang";
            this.Luoi_MatHang.RowTemplate.Height = 24;
            this.Luoi_MatHang.Size = new System.Drawing.Size(629, 498);
            this.Luoi_MatHang.TabIndex = 1;
            this.Luoi_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_MatHang_CellClick);
            this.Luoi_MatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_MatHang_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(107, 17);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(208, 17);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 40);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(312, 17);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(417, 17);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(523, 17);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Location = new System.Drawing.Point(18, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 78);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, -19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "THAO TÁC";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "THAO TÁC";
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 673);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Luoi_MatHang);
            this.Controls.Add(this.panelMH);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatHang";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.panelMH.ResumeLayout(false);
            this.panelMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_MatHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.ComboBox cboMaChatLieu;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.DataGridView Luoi_MatHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label textbox2;
        private System.Windows.Forms.Label txtbox1;
        private System.Windows.Forms.ComboBox cboMNCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboPL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnChonAnh;
    }
}