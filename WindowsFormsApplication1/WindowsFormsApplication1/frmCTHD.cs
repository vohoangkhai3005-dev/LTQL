using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class frmCTHD : Form
    {
        private bool isAdding = false;
        public string MaHD { get; set; }

        public frmCTHD()
        {
            InitializeComponent();
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            txtMCTHD.ReadOnly = true;


            txtSL.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtTT.ReadOnly = true;

            dgvCTHD.ReadOnly = true;
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.MultiSelect = false;

            cboMHD.Enabled = false;

            dgvCTHD.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            //thao tác các nút CRUD
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            button4.Enabled = false;
            btnHuy.Enabled = false;

            //Khóa Panel

            panelCTHD.Enabled = false;
            if (string.IsNullOrEmpty(MaHD))
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn");

                Close();
                return;
            }

            //lấy dữ liệu lên cbo

            string sqlSP = "SELECT MASP, TenSP FROM SANPHAM";
            HAMXULY.FillCombo(sqlSP, cboMH, "MASP", "TenSP");

            cboMHD.Text = MaHD;

            ShowCTHD(MaHD);
        }

        private void ShowCTHD(string maHD)
        {
            DataTable dtCTHD = new DataTable();

            string sql = @"
        SELECT
            C.MACHITIET AS MACHITIET,
            C.MAHD AS MAHD,
            C.MASP AS MASP,
            S.TENSP AS TENSP,
            C.SOLUONG AS SOLUONG,
            C.DONGIA AS DONGIA,
            C.SOLUONG * C.DONGIA AS THANHTIEN
        FROM CHITIETHOADON C
        INNER JOIN SANPHAM S
            ON C.MASP = S.MASP
        WHERE C.MAHD = N'" + maHD + @"'
        ORDER BY C.MACHITIET";

            if (HAMXULY.Truyvan(sql, dtCTHD))
            {
                dgvCTHD.DataSource = dtCTHD;

                DinhDangLuoi();
            }
        }

        private void DinhDangLuoi()
        {
            if (dgvCTHD.Columns.Count == 0)
            {
                return;
            }

            dgvCTHD.Columns["MACHITIET"].HeaderText =
                "Mã chi tiết";

            dgvCTHD.Columns["MACHITIET"].Width = 100;

            dgvCTHD.Columns["MAHD"].HeaderText =
                "Mã hóa đơn";

            dgvCTHD.Columns["MAHD"].Width = 110;

            dgvCTHD.Columns["MASP"].Visible = false;

            dgvCTHD.Columns["TenSP"].HeaderText =
                "Tên sản phẩm";

            dgvCTHD.Columns["TenSP"].Width = 200;

            dgvCTHD.Columns["SOLUONG"].HeaderText =
                "Số lượng";

            dgvCTHD.Columns["SOLUONG"].Width = 90;

            dgvCTHD.Columns["DONGIA"].HeaderText =
                "Đơn giá";

            dgvCTHD.Columns["DONGIA"].Width = 120;

            dgvCTHD.Columns["THANHTIEN"].HeaderText =
                "Thành tiền";

            dgvCTHD.Columns["THANHTIEN"].Width = 140;

            dgvCTHD.Columns["DONGIA"]
                .DefaultCellStyle.Format = "N0";

            dgvCTHD.Columns["THANHTIEN"]
                .DefaultCellStyle.Format = "N0";

            dgvCTHD.Columns["DONGIA"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            dgvCTHD.Columns["THANHTIEN"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            dgvCTHD.EnableHeadersVisualStyles = false;

            // Màu nền chung
            dgvCTHD.BackgroundColor = Color.White;
            dgvCTHD.BorderStyle = BorderStyle.None;

            // Màu dòng thường
            dgvCTHD.RowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvCTHD.RowsDefaultCellStyle.ForeColor =
                Color.FromArgb(30, 41, 59);

            // Màu dòng xen kẽ
            dgvCTHD.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(226, 232, 240);

            // Màu khi chọn dòng
            dgvCTHD.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(59, 130, 246);

            dgvCTHD.DefaultCellStyle.SelectionForeColor =
                Color.White;

            // Màu tiêu đề
            dgvCTHD.EnableHeadersVisualStyles = false;

            dgvCTHD.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(15, 23, 42);

            dgvCTHD.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvCTHD.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(15, 23, 42);

            // Font và chiều cao
            dgvCTHD.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvCTHD.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvCTHD.RowTemplate.Height = 34;
            dgvCTHD.ColumnHeadersHeight = 40;

            // Đường kẻ nhẹ
            dgvCTHD.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvCTHD.GridColor =
                Color.FromArgb(203, 213, 225);

            // Căn giữa tiêu đề
            dgvCTHD.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Không hiện cột trống bên trái
            dgvCTHD.RowHeadersVisible = false;
                

            dgvCTHD.RowTemplate.Height = 32;

            dgvCTHD.ClearSelection();
        } 

        private void Luoi_CTHD_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];

            txtMCTHD.Text = Convert.ToString(
                row.Cells["MACHITIET"].Value
            ).Trim();

            cboMHD.Text = Convert.ToString(
                row.Cells["MAHD"].Value
            ).Trim();

            string maSP = Convert.ToString(
                row.Cells["MASP"].Value
            ).Trim();

            string tenSP = Convert.ToString(
                row.Cells["TENSP"].Value
            ).Trim();

            // Chọn sản phẩm theo mã.
            cboMH.SelectedValue = maSP;

            // Trường hợp MaSP trong database bị dư khoảng trắng.
            if (cboMH.SelectedIndex == -1)
            {
                cboMH.Text = tenSP;
            }

            txtSL.Text = Convert.ToString(
                row.Cells["SOLUONG"].Value
            );

            decimal donGia = Convert.ToDecimal(
                row.Cells["DONGIA"].Value
            );

            txtDG.Text = donGia.ToString("N0");

            decimal thanhTien = Convert.ToDecimal(
                row.Cells["THANHTIEN"].Value
            );

            txtTT.Text = thanhTien.ToString("N0") + " đ";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Bạn có muốn thoát không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                Close();
            }
        }
        private bool KiemTraThongTin()
        {
            if (txtMCTHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã chi tiết");
                txtMCTHD.Focus();
                return false;
            }

            if (cboMH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                cboMH.Focus();
                return false;
            }

            int soLuong;

            if (!int.TryParse(txtSL.Text.Trim(), out soLuong) ||
                soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                txtSL.Focus();
                return false;
            }

            return true;
        }
        private bool MaChiTietDaTonTai(string maChiTiet)
        {
            DataTable dt = new DataTable();

            string sql =
                "SELECT MaChiTiet FROM CHITIETHOADON " +
                "WHERE MaChiTiet = '" + maChiTiet + "'";

            HAMXULY.Truyvan(sql, dt);

            return dt.Rows.Count > 0;
        }
        private bool HoaDonDaThanhToan()
        {
            string sql =
                "SELECT TrangThai FROM HOADON " +
                "WHERE MaHD = '" + MaHD + "'";

            string trangThai = HAMXULY.GetFieldValues(sql);

            return trangThai == "Đã thanh toán";
        }
        private void TinhThanhTien()
        {
            int soLuong;
            decimal donGia;

            string gia = txtDG.Text
                .Replace(",", "")
                .Replace(".", "")
                .Replace(" đ", "")
                .Trim();

            if (!int.TryParse(txtSL.Text.Trim(), out soLuong))
            {
                txtTT.Text = "0 đ";
                return;
            }

            if (!decimal.TryParse(gia, out donGia))
            {
                txtTT.Text = "0 đ";
                return;
            }

            decimal thanhTien = soLuong * donGia;

            txtTT.Text = thanhTien.ToString("N0") + " đ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (HoaDonDaThanhToan())
            {
                MessageBox.Show(
                    "Hóa đơn đã thanh toán, không thể thêm sản phẩm"
                );

                return;
            }

            isAdding = true;

            panelCTHD.Enabled = true;

            txtMCTHD.ReadOnly = false;
            txtSL.ReadOnly = false;
            txtDG.ReadOnly = true;
            txtTT.ReadOnly = true;

            txtMCTHD.Text = "";
            cboMHD.Text = MaHD;
            cboMH.SelectedIndex = -1;

            txtSL.Text = "";
            txtDG.Text = "";
            txtTT.Text = "0 đ";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            button4.Enabled = true;
            btnHuy.Enabled = true;

            txtMCTHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMCTHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần sửa");
                return;
            }

            if (HoaDonDaThanhToan())
            {
                MessageBox.Show(
                    "Hóa đơn đã thanh toán, không thể sửa"
                );

                return;
            }

            isAdding = false;

            panelCTHD.Enabled = true;

            txtMCTHD.ReadOnly = true;
            txtSL.ReadOnly = false;
            txtDG.ReadOnly = true;
            txtTT.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            button4.Enabled = true;
            btnHuy.Enabled = true;

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMCTHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
                return;
            }

            if (HoaDonDaThanhToan())
            {
                MessageBox.Show("Hóa đơn đã thanh toán, không thể xóa sản phẩm");

                return;
            }
            string maChiTiet = txtMCTHD.Text.Trim();

            string sql =
                "DELETE FROM CHITIETHOADON " +
                "WHERE MaChiTiet = '" + maChiTiet + "' " +
                "AND MaHD = '" + MaHD + "'";

            HAMXULY.RunSQL(sql);

            CapNhatTongTienHoaDon();

            MessageBox.Show("Xóa chi tiết hóa đơn thành công");

            ShowCTHD(MaHD);
            ResetForm();
        }

            private void button4_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                return;
            }

            string maChiTiet = txtMCTHD.Text.Trim();
            string maSP = cboMH.SelectedValue.ToString();

            int soLuong = Convert.ToInt32(txtSL.Text.Trim());

            string gia = txtDG.Text
                .Replace(",", "")
                .Replace(".", "")
                .Replace(" đ", "")
                .Trim();

            decimal donGia = Convert.ToDecimal(gia);
            decimal thanhTien = soLuong * donGia;

            string donGiaSQL =
                donGia.ToString(CultureInfo.InvariantCulture);

            string thanhTienSQL =
                thanhTien.ToString(CultureInfo.InvariantCulture);

            if (isAdding)
            {
                if (MaChiTietDaTonTai(maChiTiet))
                {
                    MessageBox.Show("Mã chi tiết đã tồn tại");

                    txtMCTHD.Focus();
                    txtMCTHD.SelectAll();

                    return;
                }

                string sql =
                    "INSERT INTO CHITIETHOADON " +
                    "(MaChiTiet, MaHD, MaSP, SoLuong, DonGia, ThanhTien) " +
                    "VALUES (" +
                    "'" + maChiTiet + "', " +
                    "'" + MaHD + "', " +
                    "'" + maSP + "', " +
                    soLuong + ", " +
                    donGiaSQL + ", " +
                    thanhTienSQL + ")";

                HAMXULY.RunSQL(sql);

                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
            }
            else
            {
                string sql =
                    "UPDATE CHITIETHOADON SET " +
                    "MaSP = '" + maSP + "', " +
                    "SoLuong = " + soLuong + ", " +
                    "DonGia = " + donGiaSQL + ", " +
                    "ThanhTien = " + thanhTienSQL + " " +
                    "WHERE MaChiTiet = '" + maChiTiet + "' " +
                    "AND MaHD = '" + MaHD + "'";

                HAMXULY.RunSQL(sql);

                MessageBox.Show("Cập nhật chi tiết thành công");
            }

            CapNhatTongTienHoaDon();

            ShowCTHD(MaHD);
            ResetForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
           "Bạn có muốn hủy thao tác không?",
           "Xác nhận",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
       ) == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void CapNhatTongTienHoaDon()
        {
            string sql ="UPDATE HOADON SET TongTien = (" +
                "SELECT ISNULL(SUM(ThanhTien), 0) " +
                "FROM CHITIETHOADON " +
                "WHERE MaHD = '" + MaHD + "') " +
                "WHERE MaHD = '" + MaHD + "'";

            HAMXULY.RunSQL(sql);
        }

        private void ResetForm()
        {
            txtMCTHD.Text = "";
            cboMHD.Text = MaHD;
            txtSL.Text = "";
            txtDG.Text = "";
            txtTT.Text = "0 đ";

            cboMH.SelectedIndex = -1;

            panelCTHD.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            button4.Enabled = false;
            btnHuy.Enabled = false;

            txtMCTHD.Enabled = true;

            isAdding = false;

            dgvCTHD.ClearSelection();
        }

        private void cboMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMH.SelectedIndex == -1 ||
       cboMH.SelectedValue == null)
            {
                txtDG.Text = "";
                txtTT.Text = "0 đ";
                return;
            }

            DataRowView rowView =
                cboMH.SelectedItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            string maSP = rowView["MaSP"].ToString();

            string sql =
                "SELECT GiaBan FROM SANPHAM " +
                "WHERE MaSP = '" + maSP + "'";

            string giaBan = HAMXULY.GetFieldValues(sql);

            decimal donGia;

            if (decimal.TryParse(giaBan, out donGia))
            {
                txtDG.Text = donGia.ToString("N0");
                TinhThanhTien();
            }
            else
            {
                txtDG.Text = "0";
                txtTT.Text = "0 đ";
            }
        }
    }
}