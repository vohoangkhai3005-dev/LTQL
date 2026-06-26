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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ShowNhanVien()
        {
            DataTable dtNV= new DataTable();
            HAMXULY.Connect();

            string sqlNV = "SELECT * FROM NHANVIEN";

            if (HAMXULY.Truyvan(sqlNV, dtNV))
            {
                Luoi_NHANVIEN.DataSource = dtNV;

                Luoi_NHANVIEN.Columns[0].HeaderText = "Mã Nhân Viên";
                Luoi_NHANVIEN.Columns[0].Width = 110;

                Luoi_NHANVIEN.Columns[1].HeaderText = "Tên Nhân Viên";
                Luoi_NHANVIEN.Columns[1].Width = 150;

                Luoi_NHANVIEN.Columns[2].HeaderText = "Ngày Sinh";
                Luoi_NHANVIEN.Columns[2].Width = 100;

                Luoi_NHANVIEN.Columns[3].HeaderText = "Giới Tính";
                Luoi_NHANVIEN.Columns[3].Width = 80;

                Luoi_NHANVIEN.Columns[4].HeaderText = "Địa Chỉ";
                Luoi_NHANVIEN.Columns[4].Width = 180;

                Luoi_NHANVIEN.Columns[5].HeaderText = "Điện Thoại";
                Luoi_NHANVIEN.Columns[5].Width = 110;

                Luoi_NHANVIEN.EnableHeadersVisualStyles = false;
                Luoi_NHANVIEN.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void Luoi_NHANVIEN_Click(object sender, EventArgs e)
        {
            txtMANV.Text = Luoi_NHANVIEN.CurrentRow.Cells["MANV"].Value.ToString();
            txtTNV.Text = Luoi_NHANVIEN.CurrentRow.Cells["TENNV"].Value.ToString();
            txtNS.Text = Luoi_NHANVIEN.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txtGT.Text = Luoi_NHANVIEN.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txtDC.Text = Luoi_NHANVIEN.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtDT.Text = Luoi_NHANVIEN.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
        }

        private void Luoi_NHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            panelNhanVien.Enabled = false;
            ShowNhanVien();
        }
        private void ThemNhanVien()
        {
            HAMXULY.Connect();

            string sqlInsert =
                "INSERT INTO NHANVIEN(MANV, TENNV, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI) VALUES(" +
                "N'" + txtMANV.Text.Trim() + "'," +
                "N'" + txtTNV.Text.Trim() + "'," +
                "'" + txtNS.Text.Trim() + "'," +
                "N'" + txtGT.Text.Trim() + "'," +
                "N'" + txtDC.Text.Trim() + "'," +
                "'" + txtDT.Text.Trim() + "')";

            try
            {
                HAMXULY.RunSQL(sqlInsert);

                MessageBox.Show("Thêm nhân viên thành công!");

                ShowNhanVien();

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMANV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtMANV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtTNV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNS.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNS.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGT.Text))
            {
                MessageBox.Show("Vui lòng nhập giới tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtGT.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelNhanVien.Enabled = true;

            ResetText();

            txtMANV.Focus();

            btnThem.Enabled = false; 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void ResetText()
        {
            txtMANV.Text = "";
            txtTNV.Text = "";
            txtNS.Text = "";
            txtGT.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete =
                    "DELETE FROM NHANVIEN WHERE MANV = '" +
                    txtMANV.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?",
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

                    ShowNhanVien();
                    ResetText();
                }

                HAMXULY.Connect();
            }
        }
        private void SuaNhanVien()
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMANV.Focus();
            }
            else
            {
                string SqlUpdate =
                   @"UPDATE NHANVIEN SET " +
                    "TENNV = N'" + txtTNV.Text + "', " +
                    "NGAYSINH = '" + txtNS.Text + "', " +
                    "GIOITINH = N'" + txtGT.Text + "', " +
                    "DIACHI = N'" + txtDC.Text + "', " +
                    "DIENTHOAI = '" + txtDT.Text + "' " +
                    "WHERE MANV = '" + txtMANV.Text + "'";

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(SqlUpdate);

                    MessageBox.Show("Đã sửa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowNhanVien();
                    ResetText();

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;

                    txtMANV.Enabled = true;
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panelNhanVien.Enabled = true;

            txtMANV.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            if (btnThem.Enabled == true)
                ThemNhanVien();
            else
                SuaNhanVien();
        }

        private void txtHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelNhanVien.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMANV.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
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
