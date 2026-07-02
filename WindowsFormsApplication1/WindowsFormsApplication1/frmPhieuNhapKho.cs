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
    public partial class frmPhieuNhapKho : Form
    {
        DataTable dtChiTiet;
        public frmPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();
            Khoitaobangtam();
            dtpNN.Value = DateTime.Now;
            lblTongTien.Text = "Tổng tiền: 0 đ";

            //LOAD lên combobox
            string sqlNCC = "SELECT * FROM NHACUNGCAP";
            HAMXULY.FillCombo(sqlNCC, cboNCC, "MaNCC", "TenNCC");
            string sqlNV = "SELECT * FROM NHANVIEN";
            HAMXULY.FillCombo(sqlNV, cboNV, "MaNV", "TenNV");
            String sqlSP = "SELECT * FROM SANPHAM";
            HAMXULY.FillCombo(sqlSP, cboSP, "MaSP", "TenSP");

           
            cboNCC.SelectedIndex = -1;
            cboNV.SelectedIndex = -1;
            cboSP.SelectedIndex = -1;
        }

        private void Khoitaobangtam()
        {
            dtChiTiet = new DataTable();

            dtChiTiet.Columns.Add("MaSP", typeof(string));
            dtChiTiet.Columns.Add("TenSP", typeof(string));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("DonGiaBan", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));

            dgvCT.DataSource = dtChiTiet;

            dgvCT.Columns["MaSP"].HeaderText = "Mã SP";
            dgvCT.Columns["MaSP"].Width = 100;

            dgvCT.Columns["TenSP"].HeaderText = "Tên SP";
            dgvCT.Columns["TenSP"].Width = 220;

            dgvCT.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCT.Columns["SoLuong"].Width = 100;

            dgvCT.Columns["DonGiaBan"].HeaderText = "Đơn giá";
            dgvCT.Columns["DonGiaBan"].Width = 130;

            dgvCT.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvCT.Columns["ThanhTien"].Width = 150;

            dgvCT.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvCT.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvCT.RowTemplate.Height = 32;
            dgvCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // hàm kiểm tra phiếu
        private bool KiemTraPhieu()
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập");
                txtMaPN.Focus();
                return false;
            }

            if (cboNCC.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp");
                cboNCC.Focus();
                return false;
            }

            if (cboNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                cboNV.Focus();
                return false;
            }

            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu nhập chưa có sản phẩm nào");
                return false;
            }

            return true;
        }

        private bool KiemTraThemSanPham()
        {
            if (cboSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                cboSP.Focus();
                return false;
            }

            if (numSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                numSL.Focus();
                return false;
            }

            decimal donGia;

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraThemSanPham())
            {
                return;
            }

            string maSP = cboSP.SelectedValue.ToString();
            string tenSP = cboSP.Text;
            int soLuong = Convert.ToInt32(numSL.Value);
            decimal donGia = Convert.ToDecimal(txtDonGia.Text.Trim());

            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (row["MaSP"].ToString() == maSP)
                {
                    int soLuongCu = Convert.ToInt32(row["SoLuong"]);
                    row["SoLuong"] = soLuongCu + soLuong;
                    row["ThanhTien"] = Convert.ToInt32(row["SoLuong"]) * Convert.ToDecimal(row["DonGiaBan"]);

                    CapNhatTongTien();

                    cboSP.SelectedIndex = -1;
                    txtDonGia.Text = "";
                    numSL.Value = 1;
                    return;
                }
            }

            DataRow newRow = dtChiTiet.NewRow();

            newRow["MaSP"] = maSP;
            newRow["TenSP"] = tenSP;
            newRow["SoLuong"] = soLuong;
            newRow["DonGiaBan"] = donGia;
            newRow["ThanhTien"] = soLuong * donGia;

            dtChiTiet.Rows.Add(newRow);

            CapNhatTongTien();

            cboSP.SelectedIndex = -1;
            txtDonGia.Text = "";
            numSL.Value = 1;
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }

            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " đ";
        }

        private decimal LayTongTien()
        {
            decimal tongTien = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }

            return tongTien;
        }
        private bool MaPNDaTonTai(string maPN)
        {
            DataTable dt = new DataTable();

            string sql = "SELECT MaPN FROM PHIEUNHAP WHERE MaPN = '" + maPN + "'";

            HAMXULY.Truyvan(sql, dt);

            return dt.Rows.Count > 0;
        }

        private int TaoMaCTPN()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT ISNULL(MAX(MaCTPN), 0) + 1 AS MaMoi FROM CHITIETPHIEUNHAP";

            HAMXULY.Truyvan(sql, dt);

            return Convert.ToInt32(dt.Rows[0]["MaMoi"]);
        }
        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa sản phẩm này khỏi phiếu nhập không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dtChiTiet.Rows.RemoveAt(e.RowIndex);
                CapNhatTongTien();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraPhieu())
            {
                return;
            }

            string maPN = txtMaPN.Text.Trim();
            string maNCC = cboNCC.SelectedValue.ToString();
            string maNV = cboNV.SelectedValue.ToString();
            string ngayNhap = dtpNN.Value.ToString("yyyy-MM-dd");
            string ghiChu = txtGhichu.Text.Trim();
            decimal tongTien = LayTongTien();

            string sqlPN = "INSERT INTO PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTien, GhiChu) VALUES (" +
                           "'" + maPN + "', " +
                           "'" + maNCC + "', " +
                           "'" + maNV + "', " +
                           "'" + ngayNhap + "', " +
                           tongTien + ", " +
                           "N'" + ghiChu + "')";

            HAMXULY.RunSQL(sqlPN);


            foreach (DataRow row in dtChiTiet.Rows)
            {
                int maCTPN = TaoMaCTPN();

                string maSP = row["MaSP"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                decimal donGia = Convert.ToDecimal(row["DonGiaBan"]);

                string sqlCT = "INSERT INTO CHITIETPHIEUNHAP(MaCTPN, MaPN, MaSP, SoLuong, DonGiaBan) VALUES (" +
                               maCTPN + ", " +
                               "'" + maPN + "', " +
                               "'" + maSP + "', " +
                               soLuong + ", " +
                               donGia + ")";

                HAMXULY.RunSQL(sqlCT);

                string sqlCapNhatTon = "UPDATE SANPHAM SET SoLuongTon = SoLuongTon + " + soLuong +
                                       " WHERE MaSP = '" + maSP + "'";

                HAMXULY.RunSQL(sqlCapNhatTon);
            }

            MessageBox.Show("Lưu phiếu nhập thành công. Tồn kho đã được cập nhật!");

            ResetForm();
        }

        private void ResetForm()
        {
            txtMaPN.Text = "";
            txtGhichu.Text = "";
            txtDonGia.Text = "";

            cboNCC.SelectedIndex = -1;
            cboNV.SelectedIndex = -1;
            cboSP.SelectedIndex = -1;

            numSL.Value = 1;
            dtpNN.Value = DateTime.Now;

            dtChiTiet.Rows.Clear();
            CapNhatTongTien();

            txtMaPN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                      "Xác nhận",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}