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
            string sql = "SELECT * FROM CHATLIEU";
            HAMXULY.FillCombo(sql, cboMaChatLieu, "machatlieu", "tenchatlieu");
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
            string sqlMH = "SELECT * FROM MATHANG";
            if (HAMXULY.Truyvan(sqlMH, dtMatHang))
            {
                Luoi_MatHang.DataSource = dtMatHang;
                Luoi_MatHang.Columns[0].HeaderText = "Mã hàng";
                Luoi_MatHang.Columns[0].Width = 100;
                Luoi_MatHang.Columns[1].HeaderText = "Tên hàng";
                Luoi_MatHang.Columns[1].Width = 120;
                Luoi_MatHang.Columns[2].HeaderText = "Mã Chất Liệu";
                Luoi_MatHang.Columns[2].Width = 100;
                Luoi_MatHang.Columns[3].HeaderText = "Số lượng";
                Luoi_MatHang.Columns[3].Width = 100;
                Luoi_MatHang.Columns[4].HeaderText = "Đơn giá nhập";
                Luoi_MatHang.Columns[4].Width = 150;
                Luoi_MatHang.Columns[5].HeaderText = "Đơn giá bán";
                Luoi_MatHang.Columns[5].Width = 150;
                Luoi_MatHang.Columns[6].HeaderText = "Ghi chú";
                Luoi_MatHang.Columns[6].Width = 100;

                Luoi_MatHang.EnableHeadersVisualStyles = false;
                Luoi_MatHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void Luoi_MatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = Luoi_MatHang.CurrentRow.Cells["mahang"].Value.ToString();
            txtTenHang.Text = Luoi_MatHang.CurrentRow.Cells["tenhang"].Value.ToString();
            txtSoLuong.Text = Luoi_MatHang.CurrentRow.Cells["soluong"].Value.ToString();
            txtDonGiaNhap.Text = Luoi_MatHang.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtDonGiaBan.Text = Luoi_MatHang.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtGhiChu.Text = Luoi_MatHang.CurrentRow.Cells["ghichu"].Value.ToString();

            string Machatlieu, sql;
            //lấy dữ liệu từ Luoi_MatHang lên combobox
            Machatlieu = Luoi_MatHang.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            sql = "SELECT TenChatLieu FROM ChatLieu WHERE MaChatLieu=N'" + Machatlieu + "'";
            cboMaChatLieu.Text = HAMXULY.GetFieldValues(sql);
        }
        private void ResetText()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtGhiChu.Text = "";

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
                string sqlInsert = "INSERT INTO MATHANG(MAHANG, TENHANG, MACHATLIEU, SOLUONG, DONGIANHAP, DONGIABAN, GHICHU) VALUES(" +
                    "'" + txtMaHang.Text.Trim() + "', " +
                    "N'" + txtTenHang.Text.Trim() + "', " +
                    "'" + cboMaChatLieu.SelectedValue.ToString() + "', " +
                    txtSoLuong.Text.Trim() + ", " +
                    txtDonGiaNhap.Text.Trim() + ", " +
                    txtDonGiaBan.Text.Trim() + ", " +
                    "N'" + txtGhiChu.Text.Trim() + "')";

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
                    "DELETE FROM MATHANG WHERE MAHANG = '" +
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
                string SqlUpdate =
                    "UPDATE MATHANG SET " +
                    "TENHANG = N'" + txtTenHang.Text + "', " +
                    "MACHATLIEU = '" + cboMaChatLieu.SelectedValue.ToString() + "', " +
                    "SOLUONG = " + txtSoLuong.Text + ", " +
                    "DONGIANHAP = " + txtDonGiaNhap.Text + ", " +
                    "DONGIABAN = " + txtDonGiaBan.Text + ", " +
                    "GHICHU = N'" + txtGhiChu.Text + "' " +
                    "WHERE MAHANG = '" + txtMaHang.Text + "'";

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(SqlUpdate);

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
    }
}
