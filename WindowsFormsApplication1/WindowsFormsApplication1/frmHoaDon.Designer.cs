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
            this.cboHD = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.Luoi_HOADON = new System.Windows.Forms.DataGridView();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HOADON)).BeginInit();
            
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.cboHD);
            this.panelHoaDon.Controls.Add(this.dtpNgayLap);
            this.panelHoaDon.Controls.Add(this.cboKH);
            this.panelHoaDon.Controls.Add(this.cboNV);
            this.panelHoaDon.Controls.Add(this.label4);
            this.panelHoaDon.Controls.Add(this.label3);
            this.panelHoaDon.Controls.Add(this.label2);
            this.panelHoaDon.Controls.Add(this.label1);
            this.panelHoaDon.Location = new System.Drawing.Point(8, 11);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(749, 225);
            this.panelHoaDon.TabIndex = 0;
            // 
            // cboHD
            // 
            this.cboHD.FormattingEnabled = true;
            this.cboHD.Location = new System.Drawing.Point(189, 33);
            this.cboHD.Name = "cboHD";
            this.cboHD.Size = new System.Drawing.Size(216, 30);
            this.cboHD.TabIndex = 12;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(508, 31);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(238, 28);
            this.dtpNgayLap.TabIndex = 8;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(189, 118);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(216, 30);
            this.cboKH.TabIndex = 7;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(189, 72);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(216, 30);
            this.cboNV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(116, 471);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 30);
            this.cboTrangThai.TabIndex = 10;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(11, 474);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(104, 24);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(116, 507);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(230, 28);
            this.txtTongTien.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(763, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 31);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Location = new System.Drawing.Point(686, 474);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(133, 31);
            this.btnXemCTHD.TabIndex = 8;
            this.btnXemCTHD.Text = "Xem Chi Tiết";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hủy hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(487, 474);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(193, 32);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(764, 129);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 31);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Location = new System.Drawing.Point(764, 89);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 31);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.Location = new System.Drawing.Point(764, 48);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 31);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(763, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 31);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(764, 166);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 31);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Luoi_HOADON
            // 
            this.Luoi_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_HOADON.Location = new System.Drawing.Point(12, 250);
            this.Luoi_HOADON.Name = "Luoi_HOADON";
            this.Luoi_HOADON.RowHeadersWidth = 51;
            this.Luoi_HOADON.RowTemplate.Height = 24;
            this.Luoi_HOADON.Size = new System.Drawing.Size(852, 212);
            this.Luoi_HOADON.TabIndex = 23;
            this.Luoi_HOADON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_HOADON_CellContentClick_2);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 569);
            this.Controls.Add(this.Luoi_HOADON);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.btnThoat);
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
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboHD;
        private System.Windows.Forms.DataGridView Luoi_HOADON;
    }
}