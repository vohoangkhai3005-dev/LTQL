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
            string sql = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";

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

            // TODO: Thêm code lưu hóa đơn vào DB sau

            MessageBox.Show($"Thanh toán thành công!\nMã hóa đơn: {MAHD}", "Thành công");

            // Mở frmHoaDon để xem
            if (MessageBox.Show("Bạn có muốn xem hóa đơn ngay không?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmHoaDon f = new frmHoaDon();
                f.Show();
            }

            // Reset form để bán tiếp
            LamMoiForm();
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
    }
}
