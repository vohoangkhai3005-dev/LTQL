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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        private int MaKH_DangChon = 0;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qlbhDataSet.KHACHHANG);
            LoadDanhSachKhachHang();
            ResetForm();
        }

        private void LoadDanhSachKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaKH, TenKH, SDT, DiaChi, Email, DiemTichLuy FROM KhachHang ORDER BY TenKH";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKhachHang.DataSource = dt;

                // Ẩn cột nếu cần
                if (dgvKhachHang.Columns["MaKH"] != null)
                    dgvKhachHang.Columns["MaKH"].Visible = false;
            }
        }

        private void ResetForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtDiem.Clear();

            MaKH_DangChon = 0;
            btnLuu.Text = "Lưu (Thêm mới)";
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MaKH_DangChon = Convert.ToInt32(dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value);

                txtMaKH.Text = MaKH_DangChon.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString() ?? "";
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? "";
                txtDiem.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiemTichLuy"].Value.ToString();

                btnSua.Enabled = true;        // Bật nút Sửa
                btnLuu.Text = "Lưu (Thêm mới)"; // Giữ nguyên nút Lưu là thêm mới
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaKH_DangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo");
                return;
            }

            btnLuu.Text = "Lưu (Cập nhật)";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaKH_DangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM KhachHang WHERE MaKH = @makh";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@makh", MaKH_DangChon);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công!");
                LoadDanhSachKhachHang();
                ResetForm();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Tên khách hàng và SĐT không được để trống!", "Cảnh báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (MaKH_DangChon == 0) // === THÊM MỚI ===
                {
                    string sql = @"INSERT INTO KhachHang (TenKH, SDT, DiaChi, Email, DiemTichLuy) 
                                   VALUES (@ten, @sdt, @diachi, @email, @diem)";
                    cmd = new SqlCommand(sql, conn);
                }
                else // === CẬP NHẬT ===
                {
                    string sql = @"UPDATE KhachHang 
                                   SET TenKH = @ten, SDT = @sdt, DiaChi = @diachi, 
                                       Email = @email, DiemTichLuy = @diem 
                                   WHERE MaKH = @makh";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@makh", MaKH_DangChon);
                }

                cmd.Parameters.AddWithValue("@ten", txtTenKH.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@diem", string.IsNullOrEmpty(txtDiem.Text) ? 0 : Convert.ToInt32(txtDiem.Text));

                cmd.ExecuteNonQuery();
            }

            string message = (MaKH_DangChon == 0) ? "Thêm khách hàng thành công!" : "Cập nhật thành công!";
            MessageBox.Show(message);

            LoadDanhSachKhachHang();
            ResetForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
            ResetForm();
        }
    }
}
