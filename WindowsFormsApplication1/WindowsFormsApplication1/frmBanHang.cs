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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private string MAHD = "";

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // Sinh mã HD mới khi load form
            MAHD = SinhMaHoaDon();
            lblMaHD.Text = MAHD;
        }

        private string SinhMaHoaDon()
        {
            string sql = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD ASC";

            object result = HAMXULY.ExecuteScalar(sql);

            if (result == null)
                return "HD001";

            string maCu = result.ToString();
            int soMoi = int.Parse(maCu.Substring(2)) + 1;

            return "HD" + soMoi.ToString("D6");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào!", "Thông báo");
                return;
            }

            // Code thanh toán + trừ tồn kho
            MessageBox.Show("Thanh toán thành công! (Đang trừ tồn kho)", "Thành công");

            // Reset form
            dgvGioHang.Rows.Clear();
            MAHD = SinhMaHoaDon();
            lblMaHD.Text = MAHD;
        }

        private void LamMoiForm()
        {
            dgvGioHang.Rows.Clear();
            MAHD = SinhMaHoaDon();
            lblMaHD.Text = MAHD;
            // Reset các label tiền, khách hàng...
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            frmMatHang f = new frmMatHang();
            f.Owner = this;
            f.ShowDialog();
        }

        public void ThemSanPhamVaoDon(string maSP, string tenSP, decimal donGia, int soLuong)
        {
            // Kiểm tra xem sản phẩm đã có trong giỏ chưa
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells["colMaSP"].Value.ToString() == maSP)
                {
                    // Tăng số lượng lên 1
                    int sl = Convert.ToInt32(row.Cells["colSoLuong"].Value) + 1;
                    row.Cells["colSoLuong"].Value = sl;
                    row.Cells["colThanhTien"].Value = sl * donGia;
                    TinhTien();
                    return;
                }
            }

            // Thêm mới 
            dgvGioHang.Rows.Add(maSP, tenSP, donGia, soLuong, donGia * soLuong);
            TinhTien();
        }

        private void TinhTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                tong += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }

            // lblTamTinh.Text = tong.ToString("N0");
            // lblThanhTien.Text = tong.ToString("N0");
        }

        internal void ThemSanPhamVaoDon(string maSP, string tenSP, decimal donGia)
        {
            throw new NotImplementedException();
        }
    }
}
