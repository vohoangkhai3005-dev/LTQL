namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnThemtk = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnqp = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDanhm = new System.Windows.Forms.ToolStripMenuItem();
            this.Mndmsp = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnmh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnkh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnnv = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnhd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnlhd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mncthd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntk = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkkh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkmh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkhd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnbc = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnlbc = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntg = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnbanhang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnHeThong,
            this.Mnbanhang,
            this.MnDanhm,
            this.Mnhd,
            this.Mntk,
            this.Mnbc,
            this.Mntg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MnHeThong
            // 
            this.MnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnThemtk,
            this.MnDoimk,
            this.Mnqp,
            this.thoátToolStripMenuItem});
            this.MnHeThong.Name = "MnHeThong";
            this.MnHeThong.Size = new System.Drawing.Size(69, 20);
            this.MnHeThong.Text = "Hệ thống";
            // 
            // MnThemtk
            // 
            this.MnThemtk.Enabled = false;
            this.MnThemtk.Name = "MnThemtk";
            this.MnThemtk.Size = new System.Drawing.Size(180, 22);
            this.MnThemtk.Text = "Thêm tài khoản";
            this.MnThemtk.Click += new System.EventHandler(this.MnThemtk_Click);
            // 
            // MnDoimk
            // 
            this.MnDoimk.Enabled = false;
            this.MnDoimk.Name = "MnDoimk";
            this.MnDoimk.Size = new System.Drawing.Size(180, 22);
            this.MnDoimk.Text = "Đổi mật khẩu";
            this.MnDoimk.Click += new System.EventHandler(this.đổiMậtToolStripMenuItem_Click);
            // 
            // Mnqp
            // 
            this.Mnqp.Enabled = false;
            this.Mnqp.Name = "Mnqp";
            this.Mnqp.Size = new System.Drawing.Size(180, 22);
            this.Mnqp.Text = "Phân quyền";
            this.Mnqp.Click += new System.EventHandler(this.Mnqp_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // MnDanhm
            // 
            this.MnDanhm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mndmsp,
            this.Mnmh,
            this.Mnkh,
            this.Mnnv});
            this.MnDanhm.Name = "MnDanhm";
            this.MnDanhm.Size = new System.Drawing.Size(77, 20);
            this.MnDanhm.Text = "Danh mục ";
            // 
            // Mndmsp
            // 
            this.Mndmsp.Enabled = false;
            this.Mndmsp.Name = "Mndmsp";
            this.Mndmsp.Size = new System.Drawing.Size(185, 22);
            this.Mndmsp.Text = "Danh mục Sản Phẩm";
            this.Mndmsp.Click += new System.EventHandler(this.Mncl_Click);
            // 
            // Mnmh
            // 
            this.Mnmh.Enabled = false;
            this.Mnmh.Name = "Mnmh";
            this.Mnmh.Size = new System.Drawing.Size(185, 22);
            this.Mnmh.Text = "Mặt hàng ";
            this.Mnmh.Click += new System.EventHandler(this.Mnmh_Click);
            // 
            // Mnkh
            // 
            this.Mnkh.Enabled = false;
            this.Mnkh.Name = "Mnkh";
            this.Mnkh.Size = new System.Drawing.Size(185, 22);
            this.Mnkh.Text = "Khách hàng";
            this.Mnkh.Click += new System.EventHandler(this.Mnkh_Click);
            // 
            // Mnnv
            // 
            this.Mnnv.Enabled = false;
            this.Mnnv.Name = "Mnnv";
            this.Mnnv.Size = new System.Drawing.Size(185, 22);
            this.Mnnv.Text = "Nhân viên";
            this.Mnnv.Click += new System.EventHandler(this.Mnnv_Click);
            // 
            // Mnhd
            // 
            this.Mnhd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnlhd,
            this.Mncthd,
            this.MnPhieuNhap,
            this.MnCTPN});
            this.Mnhd.Name = "Mnhd";
            this.Mnhd.Size = new System.Drawing.Size(65, 20);
            this.Mnhd.Text = "Hóa đơn";
            // 
            // Mnlhd
            // 
            this.Mnlhd.Enabled = false;
            this.Mnlhd.Name = "Mnlhd";
            this.Mnlhd.Size = new System.Drawing.Size(180, 22);
            this.Mnlhd.Text = "Lập hóa đơn";
            this.Mnlhd.Click += new System.EventHandler(this.Mnlhd_Click);
            // 
            // Mncthd
            // 
            this.Mncthd.Enabled = false;
            this.Mncthd.Name = "Mncthd";
            this.Mncthd.Size = new System.Drawing.Size(180, 22);
            this.Mncthd.Text = "Chi tiết hóa đơn";
            this.Mncthd.Click += new System.EventHandler(this.Mncthd_Click);
            // 
            // MnPhieuNhap
            // 
            this.MnPhieuNhap.Enabled = false;
            this.MnPhieuNhap.Name = "MnPhieuNhap";
            this.MnPhieuNhap.Size = new System.Drawing.Size(180, 22);
            this.MnPhieuNhap.Text = "Phiếu nhập kho";
            this.MnPhieuNhap.Click += new System.EventHandler(this.MnPhieuNhap_Click);
            // 
            // MnCTPN
            // 
            this.MnCTPN.Enabled = false;
            this.MnCTPN.Name = "MnCTPN";
            this.MnCTPN.Size = new System.Drawing.Size(180, 22);
            this.MnCTPN.Text = "Chi tiết phiếu nhập";
            this.MnCTPN.Click += new System.EventHandler(this.chiTiếtPhiếuNhậpToolStripMenuItem_Click);
            // 
            // Mntk
            // 
            this.Mntk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mntkkh,
            this.Mntkmh,
            this.Mntkhd});
            this.Mntk.Name = "Mntk";
            this.Mntk.Size = new System.Drawing.Size(69, 20);
            this.Mntk.Text = "Tìm kiếm";
            // 
            // Mntkkh
            // 
            this.Mntkkh.Enabled = false;
            this.Mntkkh.Name = "Mntkkh";
            this.Mntkkh.Size = new System.Drawing.Size(136, 22);
            this.Mntkkh.Text = "khách hàng";
            this.Mntkkh.Click += new System.EventHandler(this.Mntkkh_Click);
            // 
            // Mntkmh
            // 
            this.Mntkmh.Enabled = false;
            this.Mntkmh.Name = "Mntkmh";
            this.Mntkmh.Size = new System.Drawing.Size(136, 22);
            this.Mntkmh.Text = "Mặt hàng";
            this.Mntkmh.Click += new System.EventHandler(this.Mntkmh_Click);
            // 
            // Mntkhd
            // 
            this.Mntkhd.Enabled = false;
            this.Mntkhd.Name = "Mntkhd";
            this.Mntkhd.Size = new System.Drawing.Size(136, 22);
            this.Mntkhd.Text = "Hóa đơn";
            this.Mntkhd.Click += new System.EventHandler(this.Mntkhd_Click);
            // 
            // Mnbc
            // 
            this.Mnbc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnlbc});
            this.Mnbc.Name = "Mnbc";
            this.Mnbc.Size = new System.Drawing.Size(64, 20);
            this.Mnbc.Text = "Báo cáo ";
            this.Mnbc.Click += new System.EventHandler(this.Mnbc_Click);
            // 
            // Mnlbc
            // 
            this.Mnlbc.Enabled = false;
            this.Mnlbc.Name = "Mnlbc";
            this.Mnlbc.Size = new System.Drawing.Size(196, 22);
            this.Mnlbc.Text = "Lập báo cáo doanh thu";
            this.Mnlbc.Click += new System.EventHandler(this.lậpBáoCáoToolStripMenuItem_Click);
            // 
            // Mntg
            // 
            this.Mntg.Name = "Mntg";
            this.Mntg.Size = new System.Drawing.Size(63, 20);
            this.Mntg.Text = "Trợ giúp";
            this.Mntg.Click += new System.EventHandler(this.Mntg_Click);
            // 
            // Mnbanhang
            // 
            this.Mnbanhang.Enabled = false;
            this.Mnbanhang.Name = "Mnbanhang";
            this.Mnbanhang.Size = new System.Drawing.Size(69, 20);
            this.Mnbanhang.Text = "Bán hàng";
            this.Mnbanhang.Click += new System.EventHandler(this.Mnbanhang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnThemtk;
        private System.Windows.Forms.ToolStripMenuItem MnDoimk;
        private System.Windows.Forms.ToolStripMenuItem MnDanhm;
        private System.Windows.Forms.ToolStripMenuItem Mnhd;
        private System.Windows.Forms.ToolStripMenuItem Mntk;
        private System.Windows.Forms.ToolStripMenuItem Mnbc;
        private System.Windows.Forms.ToolStripMenuItem Mntg;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mndmsp;
        private System.Windows.Forms.ToolStripMenuItem Mnmh;
        private System.Windows.Forms.ToolStripMenuItem Mnkh;
        private System.Windows.Forms.ToolStripMenuItem Mnnv;
        private System.Windows.Forms.ToolStripMenuItem Mncthd;
        private System.Windows.Forms.ToolStripMenuItem Mntkkh;
        private System.Windows.Forms.ToolStripMenuItem Mntkmh;
        private System.Windows.Forms.ToolStripMenuItem Mntkhd;
        private System.Windows.Forms.ToolStripMenuItem Mnlbc;
        private System.Windows.Forms.ToolStripMenuItem Mnlhd;
        private System.Windows.Forms.ToolStripMenuItem Mnqp;
        private System.Windows.Forms.ToolStripMenuItem MnPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem MnCTPN;
        private System.Windows.Forms.ToolStripMenuItem Mnbanhang;
    }
}