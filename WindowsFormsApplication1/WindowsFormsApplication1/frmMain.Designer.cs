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
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDanhm = new System.Windows.Forms.ToolStripMenuItem();
            this.Mncl = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnmh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnkh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnnv = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnhd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mncthd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntk = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkkh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkmh = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntkhd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnbc = new System.Windows.Forms.ToolStripMenuItem();
            this.Mntg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnHeThong,
            this.MnDanhm,
            this.Mnhd,
            this.Mntk,
            this.Mnbc,
            this.Mntg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnHeThong
            // 
            this.MnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnThemtk,
            this.MnDoimk,
            this.thoátToolStripMenuItem});
            this.MnHeThong.Enabled = false;
            this.MnHeThong.Name = "MnHeThong";
            this.MnHeThong.Size = new System.Drawing.Size(83, 24);
            this.MnHeThong.Text = "Hệ thống";
            // 
            // MnThemtk
            // 
            this.MnThemtk.Enabled = false;
            this.MnThemtk.Name = "MnThemtk";
            this.MnThemtk.Size = new System.Drawing.Size(186, 26);
            this.MnThemtk.Text = "Thêm tài khoản";
            // 
            // MnDoimk
            // 
            this.MnDoimk.Enabled = false;
            this.MnDoimk.Name = "MnDoimk";
            this.MnDoimk.Size = new System.Drawing.Size(186, 26);
            this.MnDoimk.Text = "Đổi mật khẩu";
            this.MnDoimk.Click += new System.EventHandler(this.đổiMậtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // MnDanhm
            // 
            this.MnDanhm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mncl,
            this.Mnmh,
            this.Mnkh,
            this.Mnnv});
            this.MnDanhm.Enabled = false;
            this.MnDanhm.Name = "MnDanhm";
            this.MnDanhm.Size = new System.Drawing.Size(92, 24);
            this.MnDanhm.Text = "Danh mục ";
            // 
            // Mncl
            // 
            this.Mncl.Enabled = false;
            this.Mncl.Name = "Mncl";
            this.Mncl.Size = new System.Drawing.Size(181, 26);
            this.Mncl.Text = "Chất liệu";
            // 
            // Mnmh
            // 
            this.Mnmh.Enabled = false;
            this.Mnmh.Name = "Mnmh";
            this.Mnmh.Size = new System.Drawing.Size(181, 26);
            this.Mnmh.Text = "Mặt hàng ";
            // 
            // Mnkh
            // 
            this.Mnkh.Enabled = false;
            this.Mnkh.Name = "Mnkh";
            this.Mnkh.Size = new System.Drawing.Size(181, 26);
            this.Mnkh.Text = "Khách hàng";
            // 
            // Mnnv
            // 
            this.Mnnv.Enabled = false;
            this.Mnnv.Name = "Mnnv";
            this.Mnnv.Size = new System.Drawing.Size(181, 26);
            this.Mnnv.Text = "Nhân viên";
            // 
            // Mnhd
            // 
            this.Mnhd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mncthd});
            this.Mnhd.Enabled = false;
            this.Mnhd.Name = "Mnhd";
            this.Mnhd.Size = new System.Drawing.Size(79, 24);
            this.Mnhd.Text = "Hóa đơn";
            // 
            // Mncthd
            // 
            this.Mncthd.Enabled = false;
            this.Mncthd.Name = "Mncthd";
            this.Mncthd.Size = new System.Drawing.Size(190, 26);
            this.Mncthd.Text = "Chi tiết hóa đơn";
            // 
            // Mntk
            // 
            this.Mntk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mntkkh,
            this.Mntkmh,
            this.Mntkhd});
            this.Mntk.Enabled = false;
            this.Mntk.Name = "Mntk";
            this.Mntk.Size = new System.Drawing.Size(82, 24);
            this.Mntk.Text = "Tìm kiếm";
            // 
            // Mntkkh
            // 
            this.Mntkkh.Enabled = false;
            this.Mntkkh.Name = "Mntkkh";
            this.Mntkkh.Size = new System.Drawing.Size(181, 26);
            this.Mntkkh.Text = "khách hàng";
            // 
            // Mntkmh
            // 
            this.Mntkmh.Enabled = false;
            this.Mntkmh.Name = "Mntkmh";
            this.Mntkmh.Size = new System.Drawing.Size(181, 26);
            this.Mntkmh.Text = "Mặt hàng";
            // 
            // Mntkhd
            // 
            this.Mntkhd.Enabled = false;
            this.Mntkhd.Name = "Mntkhd";
            this.Mntkhd.Size = new System.Drawing.Size(181, 26);
            this.Mntkhd.Text = "Hóa đơn";
            // 
            // Mnbc
            // 
            this.Mnbc.Enabled = false;
            this.Mnbc.Name = "Mnbc";
            this.Mnbc.Size = new System.Drawing.Size(79, 24);
            this.Mnbc.Text = "Báo cáo ";
            // 
            // Mntg
            // 
            this.Mntg.Enabled = false;
            this.Mntg.Name = "Mntg";
            this.Mntg.Size = new System.Drawing.Size(76, 24);
            this.Mntg.Text = "Trợ giúp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 332);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.Text = "frmMain";
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
        private System.Windows.Forms.ToolStripMenuItem Mncl;
        private System.Windows.Forms.ToolStripMenuItem Mnmh;
        private System.Windows.Forms.ToolStripMenuItem Mnkh;
        private System.Windows.Forms.ToolStripMenuItem Mnnv;
        private System.Windows.Forms.ToolStripMenuItem Mncthd;
        private System.Windows.Forms.ToolStripMenuItem Mntkkh;
        private System.Windows.Forms.ToolStripMenuItem Mntkmh;
        private System.Windows.Forms.ToolStripMenuItem Mntkhd;
    }
}