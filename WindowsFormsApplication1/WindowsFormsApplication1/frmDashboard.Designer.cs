namespace WindowsFormsApplication1
{
    partial class frmDashboard
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
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.DSSPSH = new System.Windows.Forms.Label();
            this.dgvSapHet = new System.Windows.Forms.DataGridView();
            this.panelDT = new System.Windows.Forms.Panel();
            this.panelHD = new System.Windows.Forms.Panel();
            this.panelSP = new System.Windows.Forms.Panel();
            this.panelKH = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).BeginInit();
            this.panelDT.SuspendLayout();
            this.panelHD.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.panelKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(28, 17);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(223, 29);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh thu hôm nay:";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(26, 14);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(238, 29);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Số hóa đơn hôm nay:";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(38, 16);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(186, 29);
            this.lblSanPham.TabIndex = 2;
            this.lblSanPham.Text = "Tổng sản phẩm:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(44, 16);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(204, 29);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Tổng khách hàng:";
            // 
            // DSSPSH
            // 
            this.DSSPSH.AutoSize = true;
            this.DSSPSH.Location = new System.Drawing.Point(201, 217);
            this.DSSPSH.Name = "DSSPSH";
            this.DSSPSH.Size = new System.Drawing.Size(388, 29);
            this.DSSPSH.TabIndex = 4;
            this.DSSPSH.Text = "DANH SÁCH SẢN PHẨM SẮP HẾT";
            // 
            // dgvSapHet
            // 
            this.dgvSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSapHet.Location = new System.Drawing.Point(49, 273);
            this.dgvSapHet.Name = "dgvSapHet";
            this.dgvSapHet.RowTemplate.Height = 24;
            this.dgvSapHet.Size = new System.Drawing.Size(670, 188);
            this.dgvSapHet.TabIndex = 5;
            // 
            // panelDT
            // 
            this.panelDT.Controls.Add(this.lblDoanhThu);
            this.panelDT.Location = new System.Drawing.Point(77, 22);
            this.panelDT.Name = "panelDT";
            this.panelDT.Size = new System.Drawing.Size(282, 65);
            this.panelDT.TabIndex = 6;
            // 
            // panelHD
            // 
            this.panelHD.Controls.Add(this.lblHoaDon);
            this.panelHD.Location = new System.Drawing.Point(461, 22);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(282, 65);
            this.panelHD.TabIndex = 7;
            // 
            // panelSP
            // 
            this.panelSP.Controls.Add(this.lblSanPham);
            this.panelSP.Location = new System.Drawing.Point(77, 129);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(282, 65);
            this.panelSP.TabIndex = 8;
            // 
            // panelKH
            // 
            this.panelKH.Controls.Add(this.lblKhachHang);
            this.panelKH.Location = new System.Drawing.Point(461, 129);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(282, 65);
            this.panelKH.TabIndex = 9;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 512);
            this.Controls.Add(this.panelKH);
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.panelHD);
            this.Controls.Add(this.panelDT);
            this.Controls.Add(this.dgvSapHet);
            this.Controls.Add(this.DSSPSH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).EndInit();
            this.panelDT.ResumeLayout(false);
            this.panelDT.PerformLayout();
            this.panelHD.ResumeLayout(false);
            this.panelHD.PerformLayout();
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            this.panelKH.ResumeLayout(false);
            this.panelKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label DSSPSH;
        private System.Windows.Forms.DataGridView dgvSapHet;
        private System.Windows.Forms.Panel panelDT;
        private System.Windows.Forms.Panel panelHD;
        private System.Windows.Forms.Panel panelSP;
        private System.Windows.Forms.Panel panelKH;

    }
}