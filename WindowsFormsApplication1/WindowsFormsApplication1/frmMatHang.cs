using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            panelMH.Enabled = false;
            ShowMatHang();
            string sqlDM = "SELECT * FROM DANHMUC";
            HAMXULY.FillCombo(sqlDM, cboMaChatLieu, "MaDanhMuc", "TenDanhMuc");
            string sqlPL = "SELECT * FROM SANPHAM";
            HAMXULY.FillCombo(sqlPL, cboPL, "MaSP", "PhanLoai");
            string sqlNCC = "SELECT * FROM NHACUNGCAP";
            HAMXULY.FillCombo(sqlNCC, cboMNCC, "MaNCC", "TenNCC");
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            dt.Rows.Add("Đang bán", true);
            dt.Rows.Add("Ngừng bán", false);

            cboTrangThai.DataSource = dt;
            cboTrangThai.DisplayMember = "Text";
            cboTrangThai.ValueMember = "Value";
            picSP.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowMatHang()
        {
            DataTable dtMatHang = new DataTable();
            HAMXULY.Connect();
            string sqlMH = "SELECT * FROM SANPHAM";
            if (HAMXULY.Truyvan(sqlMH, dtMatHang))
            {
                Luoi_MatHang.DataSource = dtMatHang;
                Luoi_MatHang.Columns[0].HeaderText = "Mã hàng";
                Luoi_MatHang.Columns[0].Width = 100;
                Luoi_MatHang.Columns[1].HeaderText = "Tên hàng";
                Luoi_MatHang.Columns[1].Width = 100;
                Luoi_MatHang.Columns[2].HeaderText = "Tên NCC";
                Luoi_MatHang.Columns[2].Width = 100;
                Luoi_MatHang.Columns[3].HeaderText = "Danh mục";
                Luoi_MatHang.Columns[3].Width = 100;
                Luoi_MatHang.Columns[4].HeaderText = "Phân loại";
                Luoi_MatHang.Columns[4].Width = 100;
                Luoi_MatHang.Columns[5].HeaderText = "Đơn giá bán";
                Luoi_MatHang.Columns[5].Width = 150;
                Luoi_MatHang.Columns[6].HeaderText = "Số lượng";
                Luoi_MatHang.Columns[6].Width = 100;
                Luoi_MatHang.Columns[7].HeaderText = "Hạn sử dụng";
                Luoi_MatHang.Columns[7].Width = 150;
                Luoi_MatHang.Columns[8].HeaderText = "Đường dẫn hình ảnh SP";
                Luoi_MatHang.Columns[8].Width = 150;
                Luoi_MatHang.Columns[9].HeaderText = "Mô tả";
                Luoi_MatHang.Columns[9].Width = 100;
                Luoi_MatHang.Columns[10].HeaderText = "Trạng thái";
                Luoi_MatHang.Columns[10].Width = 100;


                Luoi_MatHang.EnableHeadersVisualStyles = false;
                Luoi_MatHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void Luoi_MatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ResetText()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaBan.Text = "";
            dtpHanSuDung.Text = "";
            txtMoTa.Text = "";
            cboMaChatLieu.Text = "";
            dtpHanSuDung.Text = "";
            cboTrangThai.Text = "";
            hinhAnh = "";
            picSP.Image = null;

            cboMaChatLieu.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelMH.Enabled = true;

            ResetText();

            txtMaHang.Focus();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void ThemMatHang()
        {
            if (KiemTraThongTin())
            {
                HAMXULY.Connect();

                // Đã sửa: Thêm N trước chuỗi tiếng Việt, bỏ dấu nháy đơn cho các trường kiểu số (FLOAT)
                string sqlInsert = "INSERT INTO SANPHAM(MaSP, TenSP, MaNCC, MaDanhMuc, PhanLoai, GiaBan, SoLuongTon, HanSuDung, HinhAnh, MoTa, TrangThai) VALUES(" +
                "'" + txtMaHang.Text.Trim() + "', " +
                "N'" + txtTenHang.Text.Trim() + "', " +
                "'" + cboMNCC.SelectedValue.ToString() + "', " +
                "'" + cboMaChatLieu.SelectedValue.ToString() + "', " +
                "N'" + cboPL.SelectedValue.ToString() + "', " +
                txtDonGiaBan.Text.Trim() + ", " +
                txtSoLuong.Text.Trim() + ", " +
                "'" + dtpHanSuDung.Value.ToString("yyyy-MM-dd") + "', " +
                "'" + hinhAnh + "', " +
                "N'" + txtMoTa.Text.Trim() + "', " +
                (Convert.ToBoolean(cboTrangThai.SelectedValue) ? "1" : "0") +
                ")";

                try
                {
                    HAMXULY.RunSQL(sqlInsert);
                    // Đã sửa: Nối chuỗi bằng dấu + để hiển thị MessageBox chính xác
                    MessageBox.Show("Bạn đã thêm thành công mặt hàng: " + txtTenHang.Text);
                    ShowMatHang();

                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }
        }
        private bool KiemTraThongTin()
        {
            // Kiểm tra ô Mã hàng trống
            if (string.IsNullOrEmpty(txtMaHang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return false; // Dừng lại, không cho thực hiện tiếp
            }

            // Kiểm tra ô Tên hàng trống
            if (string.IsNullOrEmpty(txtTenHang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return false; // Dừng lại
            }

            // Nếu tất cả đều hợp lệ
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete =
                    "DELETE FROM SANPHAM WHERE MaSP = '" +
                    txtMaHang.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này ?",
                                    "Xác nhận xóa",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    HAMXULY.RunSQL(sqlDelete);

                    MessageBox.Show("Đã xóa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowMatHang();
                    ResetText();
                }

                HAMXULY.Connect();
            }
        }
        private void SuaMatHang()
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMaHang.Focus();
            }
            else if (txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else
            {
                string sqlUpdate =
                "UPDATE SANPHAM SET " +
                "TenSP = N'" + txtTenHang.Text.Trim() + "', " +
                "MaNCC = '" + cboMNCC.SelectedValue.ToString() + "', " +
                "MaDanhMuc = '" + cboMaChatLieu.SelectedValue.ToString() + "', " +
                "PhanLoai = N'" + cboPL.SelectedValue.ToString() + "', " +
                "GiaBan = " + txtDonGiaBan.Text.Trim() + ", " +
                "SoLuongTon = " + txtSoLuong.Text.Trim() + ", " +
                "HanSuDung = '" + dtpHanSuDung.Value.ToString("yyyy-MM-dd") + "', " +
                "HinhAnh = '" + hinhAnh + "', " +
                "MoTa = N'" + txtMoTa.Text.Trim() + "', " +
                "TrangThai = " + (Convert.ToBoolean(cboTrangThai.SelectedValue) ? "1" : "0") + " " +
                "WHERE MaSP = '" + txtMaHang.Text.Trim() + "'";

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(sqlUpdate);

                    MessageBox.Show("Đã sửa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowMatHang();
                    ResetText();

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;

                    txtMaHang.Enabled = true;
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panelMH.Enabled = true;

            txtMaHang.Enabled = false; // không cho sửa mã hàng

            txtTenHang.SelectAll();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
                ThemMatHang();
            else
                SuaMatHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelMH.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaHang.Enabled = true;
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
        private string LayThuMucAnh()
        {
            string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            string thuMucAnh = Path.Combine(projectPath, "Images");

            Directory.CreateDirectory(thuMucAnh);

            return thuMucAnh;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string hinhAnh = "";
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string tenFile = Path.GetFileName(ofd.FileName);
                    string thuMucAnh = LayThuMucAnh();
                    string dich = Path.Combine(thuMucAnh, tenFile);

                    File.Copy(ofd.FileName, dich, true);

                    hinhAnh = tenFile;

                    if (picSP.Image != null)
                    {
                        picSP.Image.Dispose();
                        picSP.Image = null;
                    }

                    using (var img = Image.FromFile(dich))
                    {
                        picSP.Image = new Bitmap(img);
                    }

                    picSP.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        

        private void Luoi_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = Luoi_MatHang.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenHang.Text = Luoi_MatHang.CurrentRow.Cells["TenSP"].Value.ToString();
            cboMNCC.Text = Luoi_MatHang.CurrentRow.Cells["MaNCC"].Value.ToString();
            cboMaChatLieu.Text = Luoi_MatHang.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            cboPL.Text = Luoi_MatHang.CurrentRow.Cells["PhanLoai"].Value.ToString();
            txtDonGiaBan.Text = Luoi_MatHang.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtSoLuong.Text = Luoi_MatHang.CurrentRow.Cells["SoLuongTon"].Value.ToString();
            dtpHanSuDung.Text = Luoi_MatHang.CurrentRow.Cells["HanSuDung"].Value.ToString();
            hinhAnh = Luoi_MatHang.CurrentRow.Cells["HinhAnh"].Value.ToString();
            txtMoTa.Text = Luoi_MatHang.CurrentRow.Cells["MoTa"].Value.ToString();
            cboTrangThai.Text = Luoi_MatHang.CurrentRow.Cells["TrangThai"].Value.ToString();

            string MaDanhMuc, sqlDM;
            //lấy dữ liệu từ Luoi_MatHang lên combobox
            MaDanhMuc = Luoi_MatHang.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            sqlDM = "SELECT TenDanhMuc FROM DANHMUC WHERE MaDanhMuc=N'" + MaDanhMuc + "'";
            cboMaChatLieu.Text = HAMXULY.GetFieldValues(sqlDM);
            string MaNCC, sqlNCC;
            MaNCC = Luoi_MatHang.CurrentRow.Cells["MaNCC"].Value.ToString();
            sqlNCC = "SELECT TenNCC FROM NHACUNGCAP WHERE MaNCC=N'" + MaNCC + "'";
            cboMNCC.Text = HAMXULY.GetFieldValues(sqlNCC);

            //sửa hình 
            hinhAnh = Luoi_MatHang.CurrentRow.Cells["HinhAnh"].Value.ToString();

            string duongDan = Path.Combine(LayThuMucAnh(), hinhAnh);

            if (File.Exists(duongDan))
            {
                if (picSP.Image != null)
                {
                    picSP.Image.Dispose();
                    picSP.Image = null;
                }

                using (var img = Image.FromFile(duongDan))
                {
                    picSP.Image = new Bitmap(img);
                }

                picSP.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picSP.Image = null;
                MessageBox.Show("Không tìm thấy ảnh: " + duongDan);
            }
        }


    } 
}
