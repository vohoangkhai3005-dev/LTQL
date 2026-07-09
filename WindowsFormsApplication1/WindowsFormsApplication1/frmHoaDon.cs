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

            cboNV.SelectedIndex = -1;
            cboKH.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;
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
            if (e.RowIndex < 0)
                return;

            txtMHD.Text = Luoi_HOADON.CurrentRow.Cells["MAHD"].Value.ToString();

            //lấy dữ liệu từ Luoi_MatHang lên combobox
            string MANV;

            MANV = Luoi_HOADON.CurrentRow.Cells["MANV"].Value.ToString();

            cboNV.Text = MANV;

            string MAKH, sql;

            MAKH = Luoi_HOADON.CurrentRow.Cells["MAKH"].Value.ToString();
            sql = "SELECT TENKH FROM KHACHHANG WHERE MAKH=N'" + MAKH + "'";
            cboKH.Text = HAMXULY.GetFieldValues(sql);
            dtpNgayLap.Text = Luoi_HOADON.CurrentRow.Cells["NGAYBAN"].Value.ToString();
        }

        private void TimTheoMaHD()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM HOADON WHERE MAHD LIKE N'%" + txtMHD.Text.Trim() + "%'";

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

            string sql = "SELECT * FROM HOADON WHERE CONVERT(date, NGAYBAN)='" + ngay + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_HOADON.DataSource = dt;
            }
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.");

                return;
            }

            frmReportCTHD frm = new frmReportCTHD();

            frm.MAHD = txtMHD.Text;

            frm.ShowDialog();
        }

        private void txtMHD_TextChanged(object sender, EventArgs e)
        {
            TimTheoMaHD();
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKH.SelectedIndex != -1)
                TimTheoKhachHang();
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            TimTheoNgay();
        }

        private void Luoi_HOADON_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXemCTHD.PerformClick();
        }
    }
}
