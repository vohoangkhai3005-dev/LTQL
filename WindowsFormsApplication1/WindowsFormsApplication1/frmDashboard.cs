using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            ShowDoanhThuHomNay();
            ShowHoaDonHomNay();
            ShowTongSanPham();
            ShowTongKhachHang();

            ShowSanPhamSapHet();

            // Màu nền form
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Panel thống kê
            panelDT.BackColor = Color.White;
            panelHD.BackColor = Color.White;
            panelSP.BackColor = Color.White;
            panelKH.BackColor = Color.White;

            panelDT.BorderStyle = BorderStyle.FixedSingle;
            panelHD.BorderStyle = BorderStyle.FixedSingle;
            panelSP.BorderStyle = BorderStyle.FixedSingle;
            panelKH.BorderStyle = BorderStyle.FixedSingle;


            //
            DSSPSH.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            DSSPSH.ForeColor = Color.FromArgb(40, 40, 40);

            // DataGridView đẹp hơn
            dgvSapHet.BackgroundColor = Color.White;
            dgvSapHet.BorderStyle = BorderStyle.None;

            dgvSapHet.EnableHeadersVisualStyles = false;

            dgvSapHet.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.None;

            dgvSapHet.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(0, 120, 215);

            dgvSapHet.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dgvSapHet.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSapHet.DefaultCellStyle.Font =
            new Font("Segoe UI", 10);

            dgvSapHet.RowHeadersVisible = false;

            dgvSapHet.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dgvSapHet.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvSapHet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSapHet.GridColor = Color.Gainsboro;

            dgvSapHet.ColumnHeadersHeight = 40;
            dgvSapHet.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvSapHet.RowTemplate.Height = 35;

            dgvSapHet.DefaultCellStyle.SelectionBackColor =
    Color.FromArgb(230, 240, 255);

            dgvSapHet.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvSapHet.AllowUserToAddRows = false;
            dgvSapHet.AllowUserToResizeColumns = false;
            dgvSapHet.AllowUserToResizeRows = false;

            dgvSapHet.ColumnHeadersDefaultCellStyle.Alignment =
    DataGridViewContentAlignment.MiddleCenter;

            dgvSapHet.Columns["MASP"].DefaultCellStyle.Alignment =
    DataGridViewContentAlignment.MiddleCenter;

            dgvSapHet.Columns["SOLUONGTON"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void BoGocPanel(Panel p)
{
    GraphicsPath path = new GraphicsPath();
    int r = 15;

    path.AddArc(0, 0, r, r, 180, 90);
    path.AddArc(p.Width - r, 0, r, r, 270, 90);
    path.AddArc(p.Width - r, p.Height - r, r, r, 0, 90);
    path.AddArc(0, p.Height - r, r, r, 90, 90);

    path.CloseFigure();

    p.Region = new Region(path);
}
        private void ShowDoanhThuHomNay()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT ISNULL(SUM(TONGTIEN),0) AS DOANHTHU
      FROM HOADON
      WHERE CAST(NGAYLAP AS DATE)=CAST(GETDATE() AS DATE)";

            if (HAMXULY.Truyvan(sql, dt))
            {
                lblDoanhThu.Text =
                    "Doanh thu hôm nay: \n " +
                    Convert.ToDecimal(dt.Rows[0][0]).ToString("N0") +
                    " VNĐ";
            }
        }
        private void ShowHoaDonHomNay()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT COUNT(*) AS SOHD
      FROM HOADON
      WHERE CAST(NGAYLAP AS DATE)=CAST(GETDATE() AS DATE)";

            HAMXULY.Truyvan(sql, dt);

            lblHoaDon.Text =
                "Số hóa đơn hôm nay: \n " +
                dt.Rows[0][0].ToString();
        }
        private void ShowTongSanPham()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT COUNT(*) FROM SANPHAM";

            HAMXULY.Truyvan(sql, dt);

            lblSanPham.Text =
                "Tổng sản phẩm: \n" +
                dt.Rows[0][0].ToString();
        }
        private void ShowTongKhachHang()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT COUNT(*) FROM KHACHHANG";

            HAMXULY.Truyvan(sql, dt);

            lblKhachHang.Text =
                "Tổng khách hàng: \n " +
                dt.Rows[0][0].ToString();
        }
        private void ShowSanPhamSapHet()
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
            @"SELECT MaSP,
             TenSP,
             SoLuongTon
      FROM SANPHAM
      WHERE SoLuongTon <= 5
      ORDER BY SoLuongTon ASC";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvSapHet.DataSource = dt;

                dgvSapHet.Columns[0].HeaderText = "Mã SP";
                dgvSapHet.Columns[1].HeaderText = "Tên sản phẩm";
                dgvSapHet.Columns[2].HeaderText = "Số lượng tồn";

                dgvSapHet.Columns[0].Width = 100;
                dgvSapHet.Columns[1].Width = 220;
                dgvSapHet.Columns[2].Width = 120;

                dgvSapHet.EnableHeadersVisualStyles = false;
                dgvSapHet.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
            else
            {
                dgvSapHet.DataSource = null;

                MessageBox.Show("Hiện tại không có sản phẩm nào sắp hết hàng!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        
    }
}
