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
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete =
                    "DELETE FROM HOADON WHERE MAHD = '" +
                    txtMHD.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?",
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

                    ShowHoaDon();
                    ResetText();
                }

                HAMXULY.Connect();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            panelHoaDon.Enabled = false;
            ShowHoaDon();

            string sql;

            sql = "SELECT MANV FROM NHANVIEN";
            HAMXULY.FillCombo(sql, cboNV, "MANV", "MANV");

            sql = "SELECT MAKH, TENKH FROM KHACHHANG";
            HAMXULY.FillCombo(sql, cboKH, "MAKH", "TENKH");
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

                Luoi_HOADON.EnableHeadersVisualStyles = false;
                Luoi_HOADON.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void Luoi_HOADON_Click(object sender, EventArgs e)
        {
            txtMHD.Text = Luoi_HOADON.CurrentRow.Cells["MAHD"].Value.ToString();
            txtNB.Text = Luoi_HOADON.CurrentRow.Cells["NGAYBAN"].Value.ToString();

            //lấy dữ liệu từ Luoi_MatHang lên combobox
            string MANV;

            MANV = Luoi_HOADON.CurrentRow.Cells["MANV"].Value.ToString();

            cboNV.Text = MANV;

            //

            string MAKH, sql;

            MAKH = Luoi_HOADON.CurrentRow.Cells["MAKH"].Value.ToString();
            sql = "SELECT TENKH FROM KHACHHANG WHERE MAKH=N'" + MAKH + "'";
            cboKH.Text = HAMXULY.GetFieldValues(sql);
        }
        private void ThemHoaDon()
        {
            HAMXULY.Connect();

            string sqlInsert =
                "INSERT INTO HOADON(MAHD, MANV, MAKH, NGAYBAN) VALUES(" +
                "N'" + txtMHD.Text.Trim() + "'," +
                "N'" + cboNV.SelectedValue.ToString() + "'," +
                "'" + cboKH.SelectedValue.ToString() + "'," +
                "'" + txtNB.Text.Trim() + "')";

            try
            {
                HAMXULY.RunSQL(sqlInsert);

                MessageBox.Show("Thêm hóa đơn thành công!");

                
                ShowHoaDon();

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
            if (string.IsNullOrWhiteSpace(txtMHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtMHD.Focus();
                return false;
            }

            if (cboNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboNV.Focus();
                return false;
            }

            if (cboKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboKH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNB.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNB.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelHoaDon.Enabled = true;

            ResetText();

            txtMHD.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void SuaHoaDon()
        {
            if (txtMHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMHD.Focus();
            }
            else
            {
                string SqlUpdate =
                   @"UPDATE HOADON SET " +
                    "MANV = N'" + cboNV.SelectedValue.ToString() + "', " +
                    "MAKH = '" + cboKH.SelectedValue.ToString() + "', " +
                    "NGAYBAN = '" + txtNB.Text + "' " +
                    "WHERE MAHD = '" + txtMHD.Text + "'";

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(SqlUpdate);

                    MessageBox.Show("Đã sửa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowHoaDon();
                    ResetText();

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;

                    txtMHD.Enabled = true;
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panelHoaDon.Enabled = true;

            txtMHD.Enabled = false; // không cho sửa mã hàng

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            if (btnThem.Enabled == true)
                ThemHoaDon();
            else
                SuaHoaDon();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelHoaDon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMHD.Enabled = true;
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
