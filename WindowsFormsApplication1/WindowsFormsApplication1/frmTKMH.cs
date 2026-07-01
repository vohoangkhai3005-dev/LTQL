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
    public partial class frmTKMH : Form
    {
        public frmTKMH()
        {
            InitializeComponent();
        }

        private void frmTKMH_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            ShowSanPham();

            // DataGridView đẹp
            dgvTKMH.BackgroundColor = Color.White;
            dgvTKMH.BorderStyle = BorderStyle.None;

            dgvTKMH.EnableHeadersVisualStyles = false;

            dgvTKMH.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTKMH.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvTKMH.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTKMH.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTKMH.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTKMH.RowHeadersVisible = false;

            dgvTKMH.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTKMH.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKMH.AllowUserToAddRows = false;
            dgvTKMH.ReadOnly = true;
        }
        private void ShowSanPham()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT
                SP.MaSP,
                SP.TenSP,
                DM.TenDanhMuc,
                NCC.TenNCC,
                SP.PhanLoai,
                SP.GiaBan,
                SP.SoLuongTon,
                SP.HanSuDung,
                SP.HinhAnh,
                SP.MoTa
            FROM SANPHAM SP
            INNER JOIN DANHMUC DM
                ON SP.MaDanhMuc = DM.MaDanhMuc
            INNER JOIN NHACUNGCAP NCC
                ON SP.MaNCC = NCC.MaNCC";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTKMH.DataSource = dt;

                dgvTKMH.Columns["MaSP"].HeaderText = "Mã SP";
                dgvTKMH.Columns["TenSP"].HeaderText = "Tên sản phẩm";
                dgvTKMH.Columns["TenDanhMuc"].HeaderText = "Danh mục";
                dgvTKMH.Columns["TenNCC"].HeaderText = "Nhà cung cấp";
                dgvTKMH.Columns["PhanLoai"].HeaderText = "Phân loại";
                dgvTKMH.Columns["GiaBan"].HeaderText = "Giá bán";
                dgvTKMH.Columns["SoLuongTon"].HeaderText = "Tồn kho";
                dgvTKMH.Columns["HanSuDung"].HeaderText = "Hạn SD";
                dgvTKMH.Columns["HinhAnh"].HeaderText = "Tên ảnh";
                dgvTKMH.Columns["MoTa"].HeaderText = "Mô tả";

                dgvTKMH.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

                dgvTKMH.ClearSelection();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string tk = txtTimKiem.Text.Trim();

            string sql =
                    @"SELECT
                        SP.MaSP,
                        SP.TenSP,
                        DM.TenDanhMuc,
                        NCC.TenNCC,
                        SP.PhanLoai,
                        SP.GiaBan,
                        SP.SoLuongTon,
                        SP.HanSuDung,
                        SP.HinhAnh,
                        SP.MoTa
                    FROM SANPHAM SP
                    INNER JOIN DANHMUC DM
                        ON SP.MaDanhMuc = DM.MaDanhMuc
                    INNER JOIN NHACUNGCAP NCC
                        ON SP.MaNCC = NCC.MaNCC
                    WHERE
                        SP.MaSP LIKE N'%" + tk + @"%'
                     OR SP.TenSP LIKE N'%" + tk + @"%'
                     OR SP.MaDanhMuc LIKE N'%" + tk + @"%'
                     OR DM.TenDanhMuc LIKE N'%" + tk + @"%'
                     OR SP.MaNCC LIKE N'%" + tk + @"%'
                     OR NCC.TenNCC LIKE N'%" + tk + @"%'
                     OR SP.PhanLoai LIKE N'%" + tk + @"%'
                     OR SP.MoTa LIKE N'%" + tk + @"%'
                     OR CONVERT(NVARCHAR,SP.GiaBan) LIKE '%" + tk + @"%'";

            HAMXULY.Truyvan(sql, dt);

            dgvTKMH.DataSource = dt;

            dgvTKMH.ClearSelection();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            ShowSanPham();

            txtTimKiem.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
