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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        private void ShowDoanhThu()
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
                    @"SELECT HD.MAHD,
                             HD.NGAYLAP,
                             NV.TENNV,
                             KH.TENKH,
                             HD.TONGTIEN
                    FROM HOADON HD
                    INNER JOIN NHANVIEN NV
                    ON HD.MANV = NV.MANV
                    INNER JOIN KHACHHANG KH
                    ON HD.MAKH = KH.MAKH";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvDoanhThu.DataSource = dt;

                dgvDoanhThu.Columns[0].HeaderText = "Mã HĐ";
                dgvDoanhThu.Columns[1].HeaderText = "Ngày lập";
                dgvDoanhThu.Columns[2].HeaderText = "Nhân viên";
                dgvDoanhThu.Columns[3].HeaderText = "Khách hàng";
                dgvDoanhThu.Columns[4].HeaderText = "Tổng tiền";

                dgvDoanhThu.EnableHeadersVisualStyles = false;
                dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

                TinhTongDoanhThu();
            }
        }
        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
                @"SELECT HD.MAHD,
                         HD.NGAYLAP,
                         NV.TENNV,
                         KH.TENKH,
                         HD.TONGTIEN
                FROM HOADON HD
                INNER JOIN NHANVIEN NV
                ON HD.MANV = NV.MANV
                INNER JOIN KHACHHANG KH
                ON HD.MAKH = KH.MAKH
                WHERE HD.NGAYLAP BETWEEN '" +
                dtpTuNgay.Value.ToString("yyyy-MM-dd") +
                "' AND '" +
                dtpDenNgay.Value.ToString("yyyy-MM-dd") + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvDoanhThu.DataSource = dt;
                TinhTongDoanhThu();

            }
        }
        private void TinhTongDoanhThu()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvDoanhThu.Rows)
            {
                if (r.Cells["TONGTIEN"].Value != null &&
                    r.Cells["TONGTIEN"].Value != DBNull.Value)
                {
                    tong += Convert.ToDecimal(r.Cells["TONGTIEN"].Value);
                }
            }

            lblTongDoanhThu.Text = "Tổng doanh thu: " +
                                   tong.ToString("N0") + " VNĐ";
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            cboTop.Items.Add("5");
            cboTop.Items.Add("10");
            cboTop.Items.Add("20");

            cboTop.SelectedIndex = 0;

            ShowDoanhThu();
            ShowTopSanPham();
        }
        private void ShowTopSanPham()
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
            @"SELECT TOP 5
        SP.MASP,
        SP.TENSP,
        SUM(CT.SOLUONG) AS SOLUONGBAN,
        SUM(CT.THANHTIEN) AS DOANHTHU
      FROM CHITIETHOADON CT
      INNER JOIN SANPHAM SP
      ON CT.MASP = SP.MASP
      GROUP BY SP.MASP, SP.TENSP
      ORDER BY SOLUONGBAN DESC";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTopSanPham.DataSource = dt;

                dgvTopSanPham.Columns[0].HeaderText = "Mã SP";
                dgvTopSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                dgvTopSanPham.Columns[2].HeaderText = "Số lượng bán";
                dgvTopSanPham.Columns[3].HeaderText = "Doanh thu";

                dgvTopSanPham.EnableHeadersVisualStyles = false;
                dgvTopSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
            @"SELECT TOP " + cboTop.Text + @"
        SP.MASP,
        SP.TENSP,
        SUM(CT.SOLUONG) AS SOLUONGBAN,
        SUM(CT.THANHTIEN) AS DOANHTHU
      FROM CHITIETHOADON CT
      INNER JOIN SANPHAM SP
      ON CT.MASP = SP.MASP
      INNER JOIN HOADON HD
      ON CT.MAHD = HD.MAHD
      WHERE HD.NGAYLAP BETWEEN '" +
              dtpTuNgayTop.Value.ToString("yyyy-MM-dd") +
              "' AND '" +
              dtpDenNgayTop.Value.ToString("yyyy-MM-dd") +
              @"'
      GROUP BY SP.MASP, SP.TENSP
      ORDER BY SOLUONGBAN DESC";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTopSanPham.DataSource = dt;
            }
        }
    }
}
