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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối - thay bằng chuỗi của bạn
        string connectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        // Giỏ hàng
        private List<CartItem> gioHang = new List<CartItem>();
        private int MaKH_HienTai = 0;

        public class CartItem
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string PhanLoai { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuong { get; set; }
            public decimal ThanhTien => SoLuong * DonGia;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qlbhDataSet1.SANPHAM);
            LoadDanhSachSanPham("");
            LoadComboBoxFilters();
            CapNhatThanhTien();
        }

        private void LoadDanhSachSanPham(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT MaSP, TenSP, ThuongHieu, HuongVi, GiaBan, TonKho, TrongLuong 
                       FROM SanPham 
                       WHERE (TenSP LIKE @kw OR ThuongHieu LIKE @kw) 
                       ORDER BY TenSP";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;

                // Ẩn cột không cần thiết
                if (dgvSanPham.Columns["MaSP"] != null)
                    dgvSanPham.Columns["MaSP"].Visible = false;
            }
        }

        private void txtSP_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachSanPham(txtSP.Text.Trim());
        }

        private DataTable GetDistinct(string column)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"SELECT DISTINCT {column} FROM SanPham WHERE {column} IS NOT NULL";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void LoadComboBoxFilters()
        {
            // Load Phan Loai
            cboPLoaiSP.DataSource = GetDistinct("PhanLoai");
            cboPLoaiSP.DisplayMember = "PhanLoai";

            //Load Huongw vi
            cboFlavor.DataSource = GetDistinct("HuongVi");
            cboFlavor.DisplayMember = "HuongVi";
        }

        private void btnCheckSDT_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaKH, TenKH FROM KhachHang WHERE SDT = @sdt";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaKH_HienTai = Convert.ToInt32(reader["MaKH"]);
                    MessageBox.Show($"Tìm thấy khách: {reader["TenKH"]}", "Thành công");
                }
                else
                {
                    MessageBox.Show("Khách hàng chưa tồn tại!", "Thông báo");
                    MaKH_HienTai = 0;
                }
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int maSP = Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value);
            string tenSP = dgvSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
            decimal gia = Convert.ToDecimal(dgvSanPham.Rows[e.RowIndex].Cells["GiaBan"].Value);

            // Hỏi số lượng
            string slInput = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Số lượng", "1");
            if (!int.TryParse(slInput, out int soLuong) || soLuong <= 0) return;

            var item = gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (item != null)
                item.SoLuong += soLuong;
            else
                gioHang.Add(new CartItem { MaSP = maSP, TenSP = tenSP, DonGia = gia, SoLuong = soLuong });

            LoadGioHang();
        }

        private void LoadGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang.Select(x => new {
                x.MaSP,
                x.TenSP,
                x.SoLuong,
                DonGia = x.DonGia.ToString("N0"),
                ThanhTien = x.ThanhTien.ToString("N0")
            }).ToList();

            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            decimal tamTinh = gioHang.Sum(x => x.ThanhTien);
            lblTamTinh.Text = tamTinh.ToString("N0") + " ₫";

            decimal giamGia = 0;
            if (decimal.TryParse(txtGiamGia.Text, out decimal gg))
                giamGia = tamTinh * (gg / 100);

            decimal tongTien = tamTinh - giamGia;
            lblTongTien.Text = tongTien.ToString("N0") + " ₫";
        }
    }
}
