using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK
{
    public partial class frmHoaDon : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet1.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qlbhDataSet1.HOADON);
            dtpNgayLap.Value = DateTime.Now;
            LoadComboKhachHang();
            LoadDanhSachHoaDon();
        }

        private void LoadComboKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["MaKH"] = DBNull.Value;
                row["TenKH"] = "Tất cả khách hàng";
                dt.Rows.InsertAt(row, 0);

                cmbKhachHang.DataSource = dt;
                cmbKhachHang.DisplayMember = "TenKH";
                cmbKhachHang.ValueMember = "MaKH";
            }
        }

        private void LoadDanhSachHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT 
                        h.MaHD as [Mã HD],
                        h.NgayLap as [Ngày lập],
                        ISNULL(k.TenKH, N'Khách lẻ') as [Khách hàng],
                        h.NhanVien as [Nhân viên],
                        h.TongTien as [Tổng tiền],
                        h.GiamGia as [Giảm giá],
                        h.ThanhTien as [Thành tiền]
                    FROM HoaDon h
                    LEFT JOIN KhachHang k ON h.MaKH = k.MaKH
                    WHERE CAST(h.NgayLap AS DATE) = CAST(@ngayLap AS DATE)
                      AND (@maKH IS NULL OR h.MaKH = @maKH)
                      AND (@maHD = '' OR CAST(h.MaHD AS NVARCHAR) LIKE '%' + @maHD + '%')
                    ORDER BY h.MaHD DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ngayLap", dtpNgayLap.Value.Date);
                cmd.Parameters.AddWithValue("@maKH", cmbKhachHang.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@maHD", txtMaHD.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHoaDon.DataSource = dt;

                // Định dạng cột tiền
                if (dgvHoaDon.Columns["Tổng tiền"] != null)
                    dgvHoaDon.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
                if (dgvHoaDon.Columns["Giảm giá"] != null)
                    dgvHoaDon.Columns["Giảm giá"].DefaultCellStyle.Format = "N0";
                if (dgvHoaDon.Columns["Thành tiền"] != null)
                    dgvHoaDon.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
            }

            TinhThongKe();
        }

        private void TinhThongKe()
        {
            decimal tongDoanhThu = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["Thành tiền"].Value != null)
                    tongDoanhThu += Convert.ToDecimal(row.Cells["Thành tiền"].Value);
            }

            lblSoHoaDon.Text = $"Tổng số hóa đơn: {dgvHoaDon.Rows.Count}";
            lblDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} ₫";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            cmbKhachHang.SelectedIndex = 0;
            dtpNgayLap.Value = DateTime.Now;
            LoadDanhSachHoaDon();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click vào dòng để xem / in hóa đơn
            if (e.RowIndex >= 0)
            {
                int maHD = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["Mã HD"].Value);

                frmInHoaDon f = new frmInHoaDon(maHD);
                f.ShowDialog();
            }
        }
    }
}
