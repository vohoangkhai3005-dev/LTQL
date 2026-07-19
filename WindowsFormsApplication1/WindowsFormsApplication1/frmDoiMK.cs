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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            panelDoiMK.Enabled = true;

            txtHoTen.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;

            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
            txtNhapLai.UseSystemPasswordChar = true;

            string sql =
                "SELECT HOTEN,TAIKHOANG FROM TAIKHOAN WHERE TAIKHOANG=N'" +
                HAMXULY.TaiKhoanDangNhap + "'";

            DataTable dt = new DataTable();

            if (HAMXULY.Truyvan(sql, dt))
            {
                txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
                txtTaiKhoan.Text = dt.Rows[0]["TAIKHOANG"].ToString();
            }
        }
        private bool KiemTraThongTin()
        {
            if (txtMKCu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ");
                txtMKCu.Focus();
                return false;
            }

            if (txtMKMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                txtMKMoi.Focus();
                return false;
            }

            if (txtNhapLai.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu");
                txtNhapLai.Focus();
                return false;
            }

            if (txtMKMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
                txtNhapLai.Focus();
                return false;
            }

            return true;
        }
        private void DoiMatKhau()
        {
            // Lấy thông tin tài khoản
            string sql = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = N'" +
                         txtTaiKhoan.Text + "'";

            DataTable dt = new DataTable();

            if (!HAMXULY.Truyvan(sql, dt))
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return;
            }

            // Lấy mật khẩu trong CSDL
            string mkDB = dt.Rows[0]["MATKHAU"].ToString().Trim();

            // Kiểm tra mật khẩu cũ
            if (mkDB.Length == 64) // Đã mã hóa SHA256
            {
                if (HAMXULY.MaHoaSHA256(txtMKCu.Text.Trim()) != mkDB)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                    txtMKCu.Focus();
                    return;
                }
            }
            else // Chưa mã hóa
            {
                if (txtMKCu.Text.Trim() != mkDB)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                    txtMKCu.Focus();
                    return;
                }
            }

            // Mã hóa mật khẩu mới trước khi lưu
            string mkMoi = HAMXULY.MaHoaSHA256(txtMKMoi.Text.Trim());

            sql = "UPDATE TAIKHOAN SET MATKHAU='" +
                  mkMoi +
                  "' WHERE TAIKHOANG=N'" +
                  txtTaiKhoan.Text + "'";

            HAMXULY.RunSQL(sql);

            MessageBox.Show("Đổi mật khẩu thành công!");

            ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            DoiMatKhau();
        }
        private void ResetText()
        {
            txtMKCu.Clear();
            txtMKMoi.Clear();
            txtNhapLai.Clear();

            txtMKCu.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
