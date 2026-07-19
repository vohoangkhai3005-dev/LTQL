using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public ToolStripMenuItem MnHethong
        {
            get { return MnHeThong; }
            set {MnHeThong = value; }
        }
        
         public ToolStripMenuItem MnThemTK
        {
            get { return MnThemtk; }
            set {MnThemtk = value; }
        }
         public ToolStripMenuItem MnDoiMK
         {
             get { return MnDoimk; }
             set { MnDoimk = value; }
         }
         public ToolStripMenuItem MnDanhM
         {
             get { return MnDanhm; }
             set { MnDanhm = value; }
         }
         public ToolStripMenuItem MnDMSP
         {
             get { return Mndmsp; }
             set { Mndmsp = value; }
         }
         public ToolStripMenuItem MnCL
         {
             get { return Mndmsp; }
             set { Mndmsp = value; }
         }
         public ToolStripMenuItem MnMH
         {
             get { return Mnmh; }
             set { Mnmh = value; }
         }
         public ToolStripMenuItem MnKH
         {
             get { return Mnkh; }
             set { Mnkh = value; }
         }
         public ToolStripMenuItem MnNV
         {
             get { return Mnnv; }
             set { Mnnv = value; }
         }
         public ToolStripMenuItem MnHD
         {
             get { return Mnhd; }
             set { Mnhd = value; }
         }
         public ToolStripMenuItem MnLHD
         {
             get { return Mnlhd; }
             set { Mnlhd = value; }
         }
         
         public ToolStripMenuItem MnTK
         {
             get { return Mntk; }
             set { Mntk = value; }
         }
         public ToolStripMenuItem MnTKKH
         {
             get { return Mntkkh; }
             set { Mntkkh = value; }
         }
         public ToolStripMenuItem MnTKMH
         {
             get { return Mntkmh; }
             set { Mntkmh = value; }
         }
         public ToolStripMenuItem MnTKHD
         {
             get { return Mntkhd; }
             set { Mntkhd = value; }
         }
         public ToolStripMenuItem MnBC
         {
             get { return Mnbc; }
             set { Mnbc = value; }
         }
         public ToolStripMenuItem MnLBC
         {
             get { return Mnlbc; }
             set { Mnlbc = value; }
         }
         public ToolStripMenuItem MnTG
         {
             get { return Mntg; }
             set { Mntg = value; }
         }
         public ToolStripMenuItem MnQP
         {
             get { return Mnqp; }
             set { Mnqp = value; }
         }
          public ToolStripMenuItem MnPNK
        {
            get { return MnPhieuNhap; }
            set { MnPhieuNhap = value; }
        }
          public ToolStripMenuItem MnCTPN
          {
              get { return MnChitietPhieuNhap; }
              set { MnChitietPhieuNhap = value; }
          }
        private void đổiMậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK f = new frmDoiMK();

            f.Show();
        }

        private void Mnnv_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            
            f.Show();
        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();

            f.Show();
        }

        private void topSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mnbc_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();

            frm.MdiParent = this;

            frm.WindowState = FormWindowState.Maximized;

            frm.Show();

            //Đổi màu MenuStrip
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.FromArgb(45, 45, 45);

            menuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.BackColor = Color.FromArgb(245, 247, 250);

            //Tăng chiều cao menu
            menuStrip1.Padding = new Padding(10, 8, 10, 8);

            // Tăng khoảng cách chữ Font
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            new Font("Segoe UI", 10, FontStyle.Bold);


            
        }
        // danh mục san phẩm
        private void Mncl_Click(object sender, EventArgs e)
        {
            frmDanhMuc f = new frmDanhMuc();

            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
        "Bạn có muốn đăng xuất không?",
        "Thông báo",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();

                this.Hide();    // Ẩn frmMain
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
           
        }

        private void Mnlhd_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();

            f.Show();
        }

        private void Mnkh_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();

            f.Show();
        }

        private void Mncthd_Click(object sender, EventArgs e)
        {
            
        }

        private void Mnqp_Click(object sender, EventArgs e)
        {
            frmPhanQuyen f = new frmPhanQuyen();

            f.Show();
        }

        private void MnThemtk_Click(object sender, EventArgs e)
        {
            frmThemTK f = new frmThemTK();

            f.Show();
        }

        private void Mnmh_Click(object sender, EventArgs e)
        {
            frmMatHang f = new frmMatHang();

            f.Show();
        }

        private void Mntkkh_Click(object sender, EventArgs e)
        {
            frmTKKH f = new frmTKKH();

            f.Show();
        }

        private void Mntg_Click(object sender, EventArgs e)
        {
            frmTroGiup f = new frmTroGiup();

            f.Show();
        }

        private void Mntkhd_Click(object sender, EventArgs e)
        {
            frmTKHD f = new frmTKHD();

            f.Show();
        }

        private void Mntkmh_Click(object sender, EventArgs e)
        {
            frmTKMH f = new frmTKMH();

            f.Show();
        }

        private void MnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhapKho f = new frmPhieuNhapKho();
            f.Show();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap f = new ChiTietPhieuNhap();
            f.Show();
        }
    }
}
