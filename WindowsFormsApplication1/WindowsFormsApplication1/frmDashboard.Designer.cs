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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.DSSPSH = new System.Windows.Forms.Label();
            this.dgvSapHet = new System.Windows.Forms.DataGridView();
            this.panelDT = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHD = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSP = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelKH = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).BeginInit();
            this.panelDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(119, 14);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(180, 24);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh thu hôm nay:";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(104, 14);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(192, 24);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Số hóa đơn hôm nay:";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(119, 10);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(148, 24);
            this.lblSanPham.TabIndex = 2;
            this.lblSanPham.Text = "Tổng sản phẩm:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(104, 10);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(164, 24);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Tổng khách hàng:";
            // 
            // DSSPSH
            // 
            this.DSSPSH.AutoSize = true;
            this.DSSPSH.Location = new System.Drawing.Point(246, 225);
            this.DSSPSH.Name = "DSSPSH";
            this.DSSPSH.Size = new System.Drawing.Size(311, 24);
            this.DSSPSH.TabIndex = 4;
            this.DSSPSH.Text = "DANH SÁCH SẢN PHẨM SẮP HẾT";
            // 
            // dgvSapHet
            // 
            this.dgvSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSapHet.Location = new System.Drawing.Point(49, 266);
            this.dgvSapHet.Name = "dgvSapHet";
            this.dgvSapHet.RowTemplate.Height = 24;
            this.dgvSapHet.Size = new System.Drawing.Size(721, 188);
            this.dgvSapHet.TabIndex = 5;
            // 
            // panelDT
            // 
            this.panelDT.Controls.Add(this.pictureBox1);
            this.panelDT.Controls.Add(this.lblDoanhThu);
            this.panelDT.Location = new System.Drawing.Point(49, 22);
            this.panelDT.Name = "panelDT";
            this.panelDT.Size = new System.Drawing.Size(379, 65);
            this.panelDT.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHD
            // 
            this.panelHD.Controls.Add(this.pictureBox3);
            this.panelHD.Controls.Add(this.lblHoaDon);
            this.panelHD.Location = new System.Drawing.Point(461, 22);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(309, 65);
            this.panelHD.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 65);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panelSP
            // 
            this.panelSP.Controls.Add(this.pictureBox2);
            this.panelSP.Controls.Add(this.lblSanPham);
            this.panelSP.Location = new System.Drawing.Point(49, 129);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(379, 65);
            this.panelSP.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 65);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelKH
            // 
            this.panelKH.Controls.Add(this.pictureBox4);
            this.panelKH.Controls.Add(this.lblKhachHang);
            this.panelKH.Location = new System.Drawing.Point(461, 129);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(309, 65);
            this.panelKH.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 65);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSapHet)).EndInit();
            this.panelDT.ResumeLayout(false);
            this.panelDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHD.ResumeLayout(false);
            this.panelHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelKH.ResumeLayout(false);
            this.panelKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ImageList imageList1;
    }
}