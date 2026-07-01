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
    public partial class frmTKHD : Form
    {
        public frmTKHD()
        {
            InitializeComponent();
        }

        private void frmTKHD_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            ShowHoaDon();

            // DataGridView đẹp
            dgvTKHD.BackgroundColor = Color.White;
            dgvTKHD.BorderStyle = BorderStyle.None;

            dgvTKHD.EnableHeadersVisualStyles = false;

            dgvTKHD.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTKHD.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvTKHD.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTKHD.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTKHD.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTKHD.RowHeadersVisible = false;

            dgvTKHD.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTKHD.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKHD.AllowUserToAddRows = false;
            dgvTKHD.ReadOnly = true;
        }
        private void ShowHoaDon()
        {
            DataTable dt = new DataTable();

            string sql =
            @"SELECT
        HD.MAHD,
        KH.TENKH,
        NV.TENNV,
        HD.NGAYLAP,
        HD.TONGTIEN
      FROM HOADON HD
      INNER JOIN KHACHHANG KH
            ON HD.MAKH = KH.MAKH
      INNER JOIN NHANVIEN NV
            ON HD.MANV = NV.MANV";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTKHD.DataSource = dt;

                dgvTKHD.Columns["MAHD"].HeaderText = "Mã HĐ";
                dgvTKHD.Columns["TENKH"].HeaderText = "Khách hàng";
                dgvTKHD.Columns["TENNV"].HeaderText = "Nhân viên";
                dgvTKHD.Columns["NGAYLAP"].HeaderText = "Ngày lập";
                dgvTKHD.Columns["TONGTIEN"].HeaderText = "Tổng tiền";

                dgvTKHD.Columns["TONGTIEN"].DefaultCellStyle.Format = "N0";

                dgvTKHD.ClearSelection();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string tk = txtTimKiem.Text.Trim();

            string sql =
            @"SELECT
        HD.MAHD,
        KH.TENKH,
        NV.TENNV,
        HD.NGAYLAP,
        HD.TONGTIEN
      FROM HOADON HD
      INNER JOIN KHACHHANG KH
            ON HD.MAKH = KH.MAKH
      INNER JOIN NHANVIEN NV
            ON HD.MANV = NV.MANV
      WHERE
            HD.MAHD LIKE N'%" + tk + @"%'
         OR KH.TENKH LIKE N'%" + tk + @"%'
         OR NV.TENNV LIKE N'%" + tk + @"%'
         OR CONVERT(NVARCHAR,HD.NGAYLAP,103) LIKE '%" + tk + @"%'";

            HAMXULY.Truyvan(sql, dt);

            dgvTKHD.DataSource = dt;

            dgvTKHD.ClearSelection();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
             txtTimKiem.Clear();

                ShowHoaDon();

                txtTimKiem.Focus();
        }

        private void dgvTKHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
