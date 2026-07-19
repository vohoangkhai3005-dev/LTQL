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
    public partial class frmThemTK : Form
    {
        public frmThemTK()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemTK_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            cboNhom.Items.Add("SuperAdmin");
            cboNhom.Items.Add("Admin");
            cboNhom.Items.Add("User");

            panelTaiKhoan.Enabled = false;

            ShowTaiKhoan();

            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.MultiSelect = false;

            dgvTaiKhoan.ClearSelection();


            txtMatKhau.UseSystemPasswordChar = true;

            // DataGridView đẹp hơn
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;

            dgvTaiKhoan.EnableHeadersVisualStyles = false;

            dgvTaiKhoan.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTaiKhoan.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTaiKhoan.RowHeadersVisible = false;

            dgvTaiKhoan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTaiKhoan.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTaiKhoan.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvTaiKhoan.GridColor = Color.Gainsboro;

            dgvTaiKhoan.ColumnHeadersHeight = 40;

            dgvTaiKhoan.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvTaiKhoan.RowTemplate.Height = 35;

            dgvTaiKhoan.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 240, 255);

            dgvTaiKhoan.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToResizeColumns = false;
            dgvTaiKhoan.AllowUserToResizeRows = false;
        }
        private void ShowTaiKhoan()
        {
            DataTable dt = new DataTable();

            string sql =
                "SELECT IDUSER,HOTEN,TAIKHOANG,MATKHAU,NHOM FROM TAIKHOAN";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTaiKhoan.DataSource = dt;

                dgvTaiKhoan.Columns["IDUSER"].Visible = false;

                dgvTaiKhoan.Columns["HOTEN"].HeaderText = "Họ tên";

                dgvTaiKhoan.Columns["TAIKHOANG"].HeaderText = "Tài khoản";

                dgvTaiKhoan.Columns["MATKHAU"].Visible = false;

                dgvTaiKhoan.Columns["NHOM"].HeaderText = "Nhóm";
            }
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            txtHoTen.Text =
        dgvTaiKhoan.CurrentRow.Cells["HOTEN"].Value.ToString();

            txtTaiKhoan.Text =
                dgvTaiKhoan.CurrentRow.Cells["TAIKHOANG"].Value.ToString();

            txtMatKhau.Text =
                 dgvTaiKhoan.CurrentRow.Cells["MATKHAU"].Value.ToString();

            cboNhom.Text =
                dgvTaiKhoan.CurrentRow.Cells["NHOM"].Value.ToString();
        }
        private bool KiemTraThongTin()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập họ tên");
                txtHoTen.Focus();
                return false;
            }

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản");
                txtTaiKhoan.Focus();
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txtMatKhau.Focus();
                return false;
            }

            if (cboNhom.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhóm");
                cboNhom.Focus();
                return false;
            }

            return true;
        }
        private void ThemTaiKhoan()
        {
            string mk = HAMXULY.MaHoaSHA256(txtMatKhau.Text.Trim());

            string sql =
                "INSERT INTO TAIKHOAN(HOTEN,TAIKHOANG,MATKHAU,NHOM) VALUES(" +
                "N'" + txtHoTen.Text.Trim() + "'," +
                "N'" + txtTaiKhoan.Text.Trim() + "'," +
                "N'" + mk + "'," +
                "N'" + cboNhom.Text + "')";

            try
            {
                HAMXULY.Connect();

                HAMXULY.RunSQL(sql);

                MessageBox.Show("Thêm thành công");

                ShowTaiKhoan();

                ResetText();

                dgvTaiKhoan.ClearSelection();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Enabled = true;

            ResetText();

            txtHoTen.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void SuaTaiKhoan()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản");
                return;
            }

            string sql =
                "UPDATE TAIKHOAN SET " +
                "HOTEN=N'" + txtHoTen.Text + "'," +
                "MATKHAU=N'" + txtMatKhau.Text + "'," +
                "NHOM=N'" + cboNhom.Text + "'" +
                " WHERE TAIKHOANG='" + txtTaiKhoan.Text + "'";

            HAMXULY.Connect();

            HAMXULY.RunSQL(sql);

            MessageBox.Show("Đã sửa");

            ShowTaiKhoan();

            ResetText();

            dgvTaiKhoan.ClearSelection();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtTaiKhoan.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            panelTaiKhoan.Enabled = true;

            txtTaiKhoan.Enabled = false; // Không cho sửa tài khoản
            txtMatKhau.ReadOnly = true;  // Không cho sửa mật khẩu

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            if (txtTaiKhoan.Enabled)
                ThemTaiKhoan();
            else
                SuaTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == HAMXULY.TaiKhoanDangNhap)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                string sqlDelete =
                    "DELETE FROM TAIKHOAN WHERE TAIKHOANG = N'" +
                    txtTaiKhoan.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?",
                                    "Xác nhận xóa",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(sqlDelete);

                    MessageBox.Show("Đã xóa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowTaiKhoan();
                    ResetText();

                    dgvTaiKhoan.ClearSelection();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelTaiKhoan.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtTaiKhoan.Enabled = true;
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
        private void ResetText()
        {
            txtHoTen.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cboNhom.SelectedIndex = -1;
        }
    }
}
