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
    public partial class frmHoaDon : Form
    {
        private bool isAdding = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            panelHoaDon.Enabled = false;
            ShowHoaDon();

            string sqlNV;
            sqlNV = "SELECT MANV, TENNV FROM NHANVIEN";
            HAMXULY.FillCombo(sqlNV, cboNV, "MANV", "TENNV");

            string sqlKH;
            sqlKH = "SELECT MAKH, TENKH FROM KHACHHANG";
            HAMXULY.FillCombo(sqlKH, cboKH, "MAKH", "TENKH");

            string sqlHD;
            sqlHD = "SELECT MAHD FROM HOADON";
            HAMXULY.FillCombo(sqlHD, cboHD, "MAHD", "MAHD");

            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;

            txtTongTien.ReadOnly = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            cboTrangThai.Enabled = false;

            Luoi_HOADON.Enabled = true;


        }
        private void ShowHoaDon()
        {
            DataTable dtHD = new DataTable();
            HAMXULY.Connect();

            string sqlHD = "SELECT * FROM HOADON";

            if (HAMXULY.Truyvan(sqlHD, dtHD))
            {
                Luoi_HOADON.DataSource = dtHD;

                Luoi_HOADON.Columns[0].HeaderText = "Mã Hóa Đơn";
                Luoi_HOADON.Columns[0].Width = 120;

                Luoi_HOADON.Columns[1].HeaderText = "Mã Nhân Viên";
                Luoi_HOADON.Columns[1].Width = 120;

                Luoi_HOADON.Columns[2].HeaderText = "Mã Khách Hàng";
                Luoi_HOADON.Columns[2].Width = 120;

                Luoi_HOADON.Columns[3].HeaderText = "Ngày Bán";
                Luoi_HOADON.Columns[3].Width = 150;

                Luoi_HOADON.Columns[4].HeaderText = "Tổng tiền";
                Luoi_HOADON.Columns[4].Width = 150;

                Luoi_HOADON.Columns[5].HeaderText = "Trạng thái";
                Luoi_HOADON.Columns[5].Width = 200;

                Luoi_HOADON.EnableHeadersVisualStyles = false;
                // Màu nền chung
                Luoi_HOADON.BackgroundColor = Color.White;
                Luoi_HOADON.BorderStyle = BorderStyle.None;

                // Màu dòng thường
                Luoi_HOADON.RowsDefaultCellStyle.BackColor =
                    Color.FromArgb(248, 250, 252);

                Luoi_HOADON.RowsDefaultCellStyle.ForeColor =
                    Color.FromArgb(30, 41, 59);

                // Màu dòng xen kẽ
                Luoi_HOADON.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(226, 232, 240);

                // Màu khi chọn dòng
                Luoi_HOADON.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(59, 130, 246);

                Luoi_HOADON.DefaultCellStyle.SelectionForeColor =
                    Color.White;

                // Màu tiêu đề
                Luoi_HOADON.EnableHeadersVisualStyles = false;

                Luoi_HOADON.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(15, 23, 42);

                Luoi_HOADON.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;

                Luoi_HOADON.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(15, 23, 42);

                // Font và chiều cao
                Luoi_HOADON.DefaultCellStyle.Font =
                    new Font("Segoe UI", 11);

                Luoi_HOADON.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 11, FontStyle.Bold);

                Luoi_HOADON.RowTemplate.Height = 34;
                Luoi_HOADON.ColumnHeadersHeight = 40;

                // Đường kẻ nhẹ
                Luoi_HOADON.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                Luoi_HOADON.GridColor =
                    Color.FromArgb(203, 213, 225);

                // Căn giữa tiêu đề
                Luoi_HOADON.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Không hiện cột trống bên trái
                Luoi_HOADON.RowHeadersVisible = false;


                Luoi_HOADON.RowTemplate.Height = 32;

                Luoi_HOADON.ClearSelection();
            }
        }

        private void Luoi_HOADON_Click(object sender, EventArgs e)
        {

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

        private void Luoi_HOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimTheoMaHD()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM HOADON WHERE MAHD LIKE N'%" + cboHD.Text.Trim() + "%'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_HOADON.DataSource = dt;
            }
        }

        private void TimTheoKhachHang()
        {
            if (cboKH.SelectedIndex == -1)
                return;

            DataTable dt = new DataTable();

            string sql = "SELECT * FROM HOADON WHERE MAKH = N'" + cboKH.SelectedValue.ToString() + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_HOADON.DataSource = dt;
            }
        }

        private void TimTheoNgay()
        {
            DataTable dt = new DataTable();

            string ngay = dtpNgayLap.Value.ToString("yyyy-MM-dd");

            string sql = "SELECT * FROM HOADON WHERE CONVERT(date, NGAYLAP)='" + ngay + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_HOADON.DataSource = dt;
            }
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }

            frmCTHD frm = new frmCTHD();

            frm.MaHD = cboHD.Text.Trim();

            frm.ShowDialog();
        }

        private void cboHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Luoi_HOADON_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Luoi_HOADON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool KiemTraThongTin()
        {
            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                cboHD.Focus();
                return false;
            }

            if (cboNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                cboNV.Focus();
                return false;
            }

            if (cboKH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                cboKH.Focus();
                return false;
            }

            return true;
        }
        private bool KiemTraTonKho(string maHD)
        {
            DataTable dt = new DataTable();

            string sql =
                "SELECT CT.MaSP, CT.SoLuong, SP.SoLuongTon " +
                "FROM CHITIETHOADON CT " +
                "INNER JOIN SANPHAM SP ON CT.MaSP = SP.MaSP " +
                "WHERE CT.MaHD = '" + maHD + "'";

            HAMXULY.Truyvan(sql, dt);

            foreach (DataRow row in dt.Rows)
            {
                int soLuongBan = Convert.ToInt32(row["SoLuong"]);
                int soLuongTon = Convert.ToInt32(row["SoLuongTon"]);

                if (soLuongBan > soLuongTon)
                {
                    MessageBox.Show(
                        "Sản phẩm " + row["MaSP"] +
                        " không đủ số lượng tồn kho"
                    );

                    return false;
                }
            }

            return true;
        }
        private bool MaHDDaTonTai(string maHD)
        {
            DataTable dt = new DataTable();

            string sql = "SELECT MaHD FROM HOADON " +
                         "WHERE MaHD = '" + maHD + "'";

            HAMXULY.Truyvan(sql, dt);

            return dt.Rows.Count > 0;
        }
        private void ResetForm()
        {
            cboHD.Text = "";
            txtTongTien.Text = "0 đ";

            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;

            lblTrangThai.Text = "Chưa thanh toán";
            lblTrangThai.ForeColor = Color.DarkOrange;

            cboHD.Enabled = true;

            panelHoaDon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            isAdding = false;

            Luoi_HOADON.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }

            if (lblTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Hóa đơn đã thanh toán không được phép xóa"
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa hóa đơn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            string maHD = cboHD.Text.Trim();

            string sqlCT =
                "DELETE FROM CHITIETHOADON WHERE MaHD = '" + maHD + "'";

            HAMXULY.RunSQL(sqlCT);

            string sqlHD = "DELETE FROM HOADON WHERE MaHD = '" + maHD + "'";

            HAMXULY.RunSQL(sqlHD);

            MessageBox.Show("Xóa hóa đơn thành công");

            ShowHoaDon();

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
                return;
            }

            if (lblTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã thanh toán");
                return;
            }

            string maHD = cboHD.Text.Trim();
            if (!KiemTraTonKho(maHD))
            {
                return;
            }
            DataTable dt = new DataTable();

            string sqlCT =
                "SELECT MaSP, SoLuong " +
                "FROM CHITIETHOADON " +
                "WHERE MaHD = '" + maHD + "'";

            HAMXULY.Truyvan(sqlCT, dt);

            foreach (DataRow row in dt.Rows)
            {
                string maSP = row["MaSP"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                string sqlTonKho =
                    "UPDATE SANPHAM " +
                    "SET SoLuongTon = SoLuongTon - " + soLuong + " " +
                    "WHERE MaSP = '" + maSP + "' " +
                    "AND SoLuongTon >= " + soLuong;

                HAMXULY.RunSQL(sqlTonKho);
            }

            string sqlTrangThai =
                "UPDATE HOADON " +
                "SET TrangThai = N'Đã thanh toán' " +
                "WHERE MaHD = '" + maHD + "'";

            HAMXULY.RunSQL(sqlTrangThai);

            MessageBox.Show(
                "Xác nhận thanh toán thành công. Tồn kho đã được cập nhật!"
            );

            ShowHoaDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;

            panelHoaDon.Enabled = true;

            cboHD.Enabled = true;
            txtTongTien.ReadOnly = true;

            cboHD.Text = "";
            txtTongTien.Text = "0 đ";

            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;

            cboTrangThai.Text = "Chưa thanh toán";
            cboTrangThai.ForeColor = Color.DarkOrange;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            cboHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa");
                return;
            }

            if (lblTrangThai.Text.Trim() == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Hóa đơn đã thanh toán không được phép sửa"
                );

                return;
            }

            isAdding = false;

            panelHoaDon.Enabled = true;

            // Không cho sửa khóa chính.
            cboHD.Enabled = false;
            txtTongTien.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            cboNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa");
                return;
            }

            if (lblTrangThai.Text.Trim() == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Hóa đơn đã thanh toán không được phép xóa"
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa hóa đơn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            string maHD = cboHD.Text.Trim();

            // Xóa chi tiết trước vì có khóa ngoại.
            string sqlCT = "DELETE FROM CHITIETHOADON " +
                           "WHERE MaHD = '" + maHD + "'";

            HAMXULY.RunSQL(sqlCT);

            string sqlHD = "DELETE FROM HOADON " +
                           "WHERE MaHD = '" + maHD + "' " +
                           "AND TrangThai = N'Chưa thanh toán'";

            HAMXULY.RunSQL(sqlHD);

            MessageBox.Show("Xóa hóa đơn thành công");

            ShowHoaDon();
            ResetForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                return;
            }

            string maHD = cboHD.Text.Trim();
            string maNV = cboNV.SelectedValue.ToString();
            string maKH = cboKH.SelectedValue.ToString();
            string ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");

            if (isAdding)
            {
                if (MaHDDaTonTai(maHD))
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại");

                    cboHD.Focus();
                    cboHD.SelectAll();

                    return;
                }

                string sql = "INSERT INTO HOADON " +
                                "(MaHD, MaNV, MaKH, NgayLap, TongTien, TrangThai) " +
                                "VALUES (" +
                                "'" + maHD + "', " +
                                "'" + maNV + "', " +
                                "'" + maKH + "', " +
                                "'" + ngayLap + "', " +
                                "0, " +
                                "N'Chưa thanh toán')";

                HAMXULY.RunSQL(sql);

                MessageBox.Show("Thêm hóa đơn thành công");
            }
            else
            {
                string sql = "UPDATE HOADON SET " +
                                "MaNV = '" + maNV + "', " +
                                "MaKH = '" + maKH + "', " +
                                "NgayLap = '" + ngayLap + "' " +
                                "WHERE MaHD = '" + maHD + "' " +
                                "AND TrangThai = N'Chưa thanh toán'";

                HAMXULY.RunSQL(sql);

                MessageBox.Show("Cập nhật hóa đơn thành công");
            }

            ShowHoaDon();
            ResetForm();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn hủy thao tác không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void Luoi_HOADON_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Luoi_HOADON_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Luoi_HOADON_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = Luoi_HOADON.Rows[e.RowIndex];

                DataRowView data = row.DataBoundItem as DataRowView;

                if (data == null)
                    return;

                cboHD.Text = data["MAHD"].ToString();

                string maNV = data["MANV"].ToString();
                string maKH = data["MAKH"].ToString();

                cboNV.SelectedValue = maNV;
                cboKH.SelectedValue = maKH;

                txtTongTien.Text = Convert.ToDecimal(
        Luoi_HOADON.CurrentRow.Cells["TONGTIEN"].Value).ToString("N0") + " đ";
                if (data["NGAYLAP"] != DBNull.Value)
                {
                    dtpNgayLap.Value =
                        Convert.ToDateTime(data["NGAYLAP"]);
                }

                //show trạng thái
                string trangThai = Luoi_HOADON.CurrentRow.Cells["TrangThai"].Value.ToString();

                cboTrangThai.Text = trangThai;

                if (trangThai == "Đã thanh toán")
                {
                    cboTrangThai.ForeColor = Color.Green;
                }
                else if (trangThai == "Chưa thanh toán")
                {
                    cboTrangThai.ForeColor = Color.OrangeRed;
                }
                else if (trangThai == "Đã hủy")
                {
                    cboTrangThai.ForeColor = Color.Red;
                }
                else
                {
                    cboTrangThai.ForeColor = Color.Black;
                }
            }
        }




    }
}
