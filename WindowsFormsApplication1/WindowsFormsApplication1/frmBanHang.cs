using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            KhoiTaoBangTam();
            

            txtMaHD.Text = TaoMaHoaDon();
            dtpNgayLap.Value = DateTime.Now;

            txtMaHD.ReadOnly = true;
            txtTonKho.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtSoMatHang.ReadOnly = true;
            txtTienThua.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            dtpNgayLap.Enabled = false;

            pnlThanhToan.Enabled = false;
            

            numSoLuong.Minimum = 1;
            numSoLuong.Value = 1;

            

            cboPhuongThuc.Items.Clear();
            cboPhuongThuc.Items.Add("Tiền mặt");
            cboPhuongThuc.Items.Add("Chuyển khoản");
            cboPhuongThuc.SelectedIndex = 0;

            txtTongTien.Text = "0 đ";
            txtThanhTien.Text = "0 đ";
            txtTienThua.Text = "0 đ";
            txtSoMatHang.Text = "0";


            //load dữ liệu lên cbo
            string sqlKH =
                "SELECT MaKH, TenKH FROM KHACHHANG " +
                "ORDER BY CASE WHEN MaKH = 'KHLE' " +
                "THEN 0 ELSE 1 END, TenKH";
            HAMXULY.FillCombo(sqlKH, cboKH,"MaKH","TenKH" );

            string sqlSP ="SELECT MaSP, TenSP FROM SANPHAM " +
                "WHERE SoLuongTon > 0";
            HAMXULY.FillCombo( sqlSP, cboSP,"MaSP", "TenSP");

            string sqlNV = "SELECT MaNV,TenNV FROM NHANVIEN";
            HAMXULY.FillCombo(sqlNV, cboNV, "MaNV", "TenNV");
           
            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;
            cboSP.SelectedIndex = -1;
        }
        private DataTable dtChiTiet;
        private void KhoiTaoBangTam()
        {
            dtChiTiet = new DataTable();

            dtChiTiet.Columns.Add(
                "MaSP",
                typeof(string)
            );

            dtChiTiet.Columns.Add(
                "TenSP",
                typeof(string)
            );

            dtChiTiet.Columns.Add(
                "SoLuong",
                typeof(int)
            );

            dtChiTiet.Columns.Add(
                "DonGia",
                typeof(decimal)
            );

            dtChiTiet.Columns.Add(
                "ThanhTien",
                typeof(decimal)
            );

            dgvBanHang.DataSource = dtChiTiet;

            dgvBanHang.Columns["MaSP"].Visible = false;

            dgvBanHang.Columns["TenSP"].HeaderText =
                "Tên sản phẩm";

            dgvBanHang.Columns["SoLuong"].HeaderText =
                "Số lượng";

            dgvBanHang.Columns["DonGia"].HeaderText =
                "Đơn giá";

            dgvBanHang.Columns["ThanhTien"].HeaderText =
                "Thành tiền";

            dgvBanHang.Columns["DonGia"]
                .DefaultCellStyle.Format = "N0";

            dgvBanHang.Columns["ThanhTien"]
                .DefaultCellStyle.Format = "N0";

            dgvBanHang.ReadOnly = true;
            dgvBanHang.AllowUserToAddRows = false;
            dgvBanHang.MultiSelect = false;

            dgvBanHang.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBanHang.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBanHang.RowHeadersVisible = false;

            dgvBanHang.RowsDefaultCellStyle.BackColor =
                Color.White;

            dgvBanHang.AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(224, 242, 254);

            dgvBanHang.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(14, 165, 233);

            dgvBanHang.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvBanHang.EnableHeadersVisualStyles = false;

            dgvBanHang.ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(15, 23, 42);

            dgvBanHang.ColumnHeadersDefaultCellStyle
                .ForeColor = Color.White;

            dgvBanHang.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvBanHang.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            dgvBanHang.RowTemplate.Height = 32;
        }
        private void HienThongTinSanPham()
        {
            if (cboSP.SelectedIndex == -1 ||
                cboSP.SelectedValue == null)
            {
                txtTonKho.Text = "";
                txtDonGia.Text = "";
                txtThanhTien.Text = "0 đ";
                return;
            }

            string maSP =
                cboSP.SelectedValue.ToString();

            DataTable dt = new DataTable();

            string sql =
                "SELECT GiaBan, SoLuongTon " +
                "FROM SANPHAM " +
                "WHERE MaSP = '" + maSP + "'";

            if (HAMXULY.Truyvan(sql, dt) &&
                dt.Rows.Count > 0)
            {
                decimal giaBan = Convert.ToDecimal(
                    dt.Rows[0]["GiaBan"]
                );

                int tonKho = Convert.ToInt32(
                    dt.Rows[0]["SoLuongTon"]
                );

                txtDonGia.Text =
                    giaBan.ToString("N0");

                txtTonKho.Text =
                    tonKho.ToString();

                TinhThanhTien();
            }
            else
            {
                txtDonGia.Text = "";
                txtTonKho.Text = "";
                txtThanhTien.Text = "0 đ";

                MessageBox.Show(
                    "Không tìm thấy thông tin sản phẩm"
                );
            }
        }
        private string TaoMaChiTiet()
        {
            DataTable dt = new DataTable();

            string sql =
                "SELECT ISNULL(MAX(" +
                "CAST(SUBSTRING(MaChiTiet, 3, " +
                "LEN(MaChiTiet)) AS INT)" +
                "), 0) + 1 AS MaMoi " +
                "FROM CHITIETHOADON " +
                "WHERE MaChiTiet LIKE 'CT%'";

            HAMXULY.Truyvan(sql, dt);

            int soMoi = Convert.ToInt32(
                dt.Rows[0]["MaMoi"]
            );

            return "CT" + soMoi.ToString("D3");
        }
        private string TaoMaHoaDon()
        {
            DataTable dt = new DataTable();

            string sql =
                "SELECT ISNULL(MAX(" +
                "CAST(SUBSTRING(MaHD, 3, LEN(MaHD)) AS INT)" +
                "), 0) + 1 AS MaMoi " +
                "FROM HOADON " +
                "WHERE MaHD LIKE 'HD%'";

            HAMXULY.Truyvan(sql, dt);

            int maMoi = Convert.ToInt32(
                dt.Rows[0]["MaMoi"]
            );

            return "HD" + maMoi.ToString("D3");
        }



        private void cboSP_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboSP.SelectedIndex == -1 ||
                cboSP.SelectedValue == null)
            {
                txtTonKho.Text = "";
                txtDonGia.Text = "";
                txtThanhTien.Text = "0 đ";
                return;
            }

            DataRowView rowView =
                cboSP.SelectedItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            string maSP =
                rowView["MaSP"].ToString();

            DataTable dt = new DataTable();

            string sql =
                "SELECT GiaBan, SoLuongTon " +
                "FROM SANPHAM " +
                "WHERE MaSP = '" + maSP + "'";

            if (HAMXULY.Truyvan(sql, dt) &&
                dt.Rows.Count > 0)
            {
                decimal giaBan = Convert.ToDecimal(
                    dt.Rows[0]["GiaBan"]
                );

                int tonKho = Convert.ToInt32(
                    dt.Rows[0]["SoLuongTon"]
                );

                txtDonGia.Text =
                    giaBan.ToString("N0");

                txtTonKho.Text =
                    tonKho.ToString();

                TinhThanhTien();
            }
        }

        private void numSoLuong_ValueChanged(
            object sender,
            EventArgs e)
        {
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            decimal donGia;

            string gia = txtDonGia.Text
                .Replace(",", "")
                .Replace(".", "")
                .Replace(" đ", "")
                .Trim();

            if (!decimal.TryParse(gia, out donGia))
            {
                txtThanhTien.Text = "0 đ";
                return;
            }

            int soLuong =
                Convert.ToInt32(numSoLuong.Value);

            decimal thanhTien =
                soLuong * donGia;

            txtThanhTien.Text =
                thanhTien.ToString("N0") + " đ";
        }

        private bool KiemTraThemSanPham()
        {
            if (cboSP.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm"
                );

                cboSP.Focus();
                return false;
            }

            int soLuong =
                Convert.ToInt32(numSoLuong.Value);

            int tonKho;

            if (!int.TryParse(
                    txtTonKho.Text.Trim(),
                    out tonKho))
            {
                MessageBox.Show(
                    "Không lấy được tồn kho sản phẩm"
                );

                return false;
            }

            if (soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải lớn hơn 0"
                );

                return false;
            }

            if (soLuong > tonKho)
            {
                MessageBox.Show(
                    "Số lượng bán vượt quá tồn kho.\n" +
                    "Tồn kho hiện tại: " + tonKho
                );

                return false;
            }

            return true;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!KiemTraThemSanPham())
            {
                return;
            }

            string maSP =
                cboSP.SelectedValue.ToString();

            string tenSP = cboSP.Text;

            int soLuong =
                Convert.ToInt32(numSoLuong.Value);

            decimal donGia = Convert.ToDecimal(
                txtDonGia.Text
                    .Replace(",", "")
                    .Replace(".", "")
                    .Trim()
            );

            // Nếu sản phẩm đã có thì cộng số lượng.
            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (row["MaSP"].ToString() == maSP)
                {
                    int soLuongCu =
                        Convert.ToInt32(
                            row["SoLuong"]
                        );

                    int soLuongMoi =
                        soLuongCu + soLuong;

                    int tonKho =
                        Convert.ToInt32(
                            txtTonKho.Text
                        );

                    if (soLuongMoi > tonKho)
                    {
                        MessageBox.Show(
                            "Tổng số lượng vượt quá tồn kho.\n" +
                            "Tồn kho hiện tại: " + tonKho
                        );

                        return;
                    }

                    row["SoLuong"] = soLuongMoi;

                    row["ThanhTien"] =
                        soLuongMoi * donGia;

                    CapNhatThanhToan();
                    ResetSanPham();

                    return;
                }
            }

            DataRow newRow = dtChiTiet.NewRow();

            newRow["MaSP"] = maSP;
            newRow["TenSP"] = tenSP;
            newRow["SoLuong"] = soLuong;
            newRow["DonGia"] = donGia;
            newRow["ThanhTien"] =
                soLuong * donGia;

            dtChiTiet.Rows.Add(newRow);

            CapNhatThanhToan();
            ResetSanPham();
            pnlThanhToan.Enabled = true;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvBanHang.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa"
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa sản phẩm này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                int rowIndex =
                    dgvBanHang.CurrentRow.Index;

                dtChiTiet.Rows.RemoveAt(rowIndex);

                CapNhatThanhToan();
            }
        }

        private decimal LayTongTien()
        {
            decimal tongTien = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                tongTien += Convert.ToDecimal(
                    row["ThanhTien"]
                );
            }

            return tongTien;
        }

        private void CapNhatThanhToan()
        {
            decimal tongTien = LayTongTien();

            txtTongTien.Text =
                tongTien.ToString("N0") + " đ";

            txtSoMatHang.Text =
                dtChiTiet.Rows.Count.ToString();

            TinhTienThua();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TinhTienThua();
        }
        private void TinhTienThua()
        {
            decimal tongTien = LayTongTien();
            decimal tienKhachDua;

            string tien = txtTienKhachDua.Text
                .Replace(",", "")
                .Replace(".", "")
                .Replace(" đ", "")
                .Trim();

            if (!decimal.TryParse(
                    tien,
                    out tienKhachDua))
            {
                txtTienThua.Text = "0 đ";
                return;
            }

            decimal tienThua =
                tienKhachDua - tongTien;

            txtTienThua.Text =
                tienThua.ToString("N0") + " đ";
        }
        private bool KiemTraThanhToan()
        {
            if (cboNV.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên"
                );

                cboNV.Focus();
                return false;
            }

            if (cboKH.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn khách hàng"
                );

                cboKH.Focus();
                return false;
            }

            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Hóa đơn chưa có sản phẩm"
                );

                return false;
            }

            if (cboPhuongThuc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phương thức thanh toán"
                );

                return false;
            }

            if (cboPhuongThuc.Text == "Tiền mặt")
            {
                decimal tienKhachDua;

                string tien =
                    txtTienKhachDua.Text
                        .Replace(",", "")
                        .Replace(".", "")
                        .Trim();

                if (!decimal.TryParse(
                        tien,
                        out tienKhachDua))
                {
                    MessageBox.Show(
                        "Tiền khách đưa không hợp lệ"
                    );

                    txtTienKhachDua.Focus();
                    return false;
                }

                if (tienKhachDua < LayTongTien())
                {
                    MessageBox.Show(
                        "Tiền khách đưa chưa đủ"
                    );

                    txtTienKhachDua.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!KiemTraThanhToan())
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xác nhận thanh toán hóa đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            string maHD = txtMaHD.Text.Trim();

            string maNV =
                cboNV.SelectedValue.ToString();

            string maKH =
                cboKH.SelectedValue.ToString();

            string ngayLap =
                dtpNgayLap.Value.ToString(
                    "yyyy-MM-dd HH:mm:ss"
                );

            decimal tongTien = LayTongTien();

            string tongTienSQL =
                tongTien.ToString(
                    CultureInfo.InvariantCulture
                );

            string sqlHD =
                "INSERT INTO HOADON " +
                "(MaHD, MaNV, MaKH, NgayLap, " +
                "TongTien, TrangThai) VALUES (" +
                "'" + maHD + "', " +
                "'" + maNV + "', " +
                "'" + maKH + "', " +
                "'" + ngayLap + "', " +
                tongTienSQL + ", " +
                "N'Đã thanh toán')";
            
            HAMXULY.RunSQL(sqlHD);
            string maChiTiet = TaoMaChiTiet();
            foreach (DataRow row in dtChiTiet.Rows)
            {
                

                string maSP =
                    row["MaSP"].ToString();

                int soLuong =
                    Convert.ToInt32(
                        row["SoLuong"]
                    );

                decimal donGia =
                    Convert.ToDecimal(
                        row["DonGia"]
                    );

                decimal thanhTien =
                    Convert.ToDecimal(
                        row["ThanhTien"]
                    );

                string donGiaSQL =
                    donGia.ToString(
                        CultureInfo.InvariantCulture
                    );

                string thanhTienSQL =
                    thanhTien.ToString(
                        CultureInfo.InvariantCulture
                    );

                string sqlCT =
                          "INSERT INTO CHITIETHOADON " +
                          "(MaChiTiet, MaHD, MaSP, " +
                          "SoLuong, DonGia, ThanhTien) " +
                          "VALUES (" +
                         "'" + maChiTiet + "', " +
                          "'" + maHD + "', " +
                          "'" + maSP + "', " +
                          soLuong + ", " +
                          donGiaSQL + ", " +
                          thanhTienSQL + ")";

                

                HAMXULY.RunSQL(sqlCT);

                string sqlTonKho =
                    "UPDATE SANPHAM SET " +
                    "SoLuongTon = SoLuongTon - " +
                    soLuong + " " +
                    "WHERE MaSP = '" + maSP + "'";

                HAMXULY.RunSQL(sqlTonKho);
            }

            MessageBox.Show(
                "Thanh toán thành công!\n" +
                "Tồn kho đã được cập nhật."
            );

            ResetHoaDon();
            pnlThanhToan.Enabled = false;
        }
        private void ResetSanPham()
        {
            cboSP.SelectedIndex = -1;
            txtTonKho.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "0 đ";
            numSoLuong.Value = 1;
        }

        private void ResetHoaDon()
        {
            dtChiTiet.Rows.Clear();

            txtMaHD.Text = TaoMaHoaDon();

            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;
            cboSP.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;

            txtTonKho.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "0 đ";

            txtTongTien.Text = "0 đ";
            txtSoMatHang.Text = "0";
            txtTienKhachDua.Text = "";
            txtTienThua.Text = "0 đ";

            cboPhuongThuc.SelectedIndex = 0;

            numSoLuong.Value = 1;

            cboNV.Focus();
        }

        private void cboPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool laTienMat =
              cboPhuongThuc.Text == "Tiền mặt";

            txtTienKhachDua.Enabled = laTienMat;

            if (!laTienMat)
            {
                txtTienKhachDua.Text =
                    LayTongTien().ToString("N0");

                txtTienThua.Text = "0 đ";
            }
            else
            {
                txtTienKhachDua.Text = "";
                txtTienThua.Text = "0 đ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Bạn có muốn thoát không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex == -1 ||
       cboSP.SelectedValue == null)
            {
                txtTonKho.Text = "";
                txtDonGia.Text = "";
                txtThanhTien.Text = "0 đ";
                return;
            }

            DataRowView rowView =
                cboSP.SelectedItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            string maSP = rowView["MaSP"].ToString();

            // Lấy tồn kho
            string sqlTonKho =
                "SELECT SoLuongTon FROM SANPHAM " +
                "WHERE MaSP = '" + maSP + "'";

            txtTonKho.Text =
                HAMXULY.GetFieldValues(sqlTonKho);

            // Lấy giá bán
            string sqlGiaBan =
                "SELECT GiaBan FROM SANPHAM " +
                "WHERE MaSP = '" + maSP + "'";

            string giaBan =
                HAMXULY.GetFieldValues(sqlGiaBan);

            decimal donGia;

            if (decimal.TryParse(giaBan, out donGia))
            {
                txtDonGia.Text = donGia.ToString("N0");
            }
            else
            {
                txtDonGia.Text = "0";
            }

            TinhThanhTien();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Bạn có muốn thoát không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
