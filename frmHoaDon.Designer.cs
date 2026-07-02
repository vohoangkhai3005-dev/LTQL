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
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Luoi_HOADON = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_HOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
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
            this.label4.Location = new System.Drawing.Point(405, 115);
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
            this.Luoi_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(426, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(526, 113);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(184, 34);
            this.dtpNgayLap.TabIndex = 8;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Location = new System.Drawing.Point(179, 417);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(169, 42);
            this.btnXemCTHD.TabIndex = 8;
            this.btnXemCTHD.Text = "Xem Chi Tiết";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 480);
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
    }
}