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
    public partial class frmTKKH : Form
    {
        public frmTKKH()
        {
            InitializeComponent();
        }

        private void frmTKKH_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            ShowKhachHang();

            // DataGridView đẹp hơn
            dgvTKKH.BackgroundColor = Color.White;
            dgvTKKH.BorderStyle = BorderStyle.None;

            dgvTKKH.EnableHeadersVisualStyles = false;

            dgvTKKH.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTKKH.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvTKKH.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTKKH.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTKKH.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTKKH.RowHeadersVisible = false;

            dgvTKKH.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTKKH.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTKKH.ReadOnly = true;

            dgvTKKH.AllowUserToAddRows = false;
        }
        private void ShowKhachHang()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM KHACHHANG";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTKKH.DataSource = dt;

                dgvTKKH.Columns["MAKH"].HeaderText = "Mã KH";
                dgvTKKH.Columns["TENKH"].HeaderText = "Tên khách";
                dgvTKKH.Columns["SDT"].HeaderText = "SĐT";
                dgvTKKH.Columns["EMAIL"].HeaderText = "Email";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string tukhoa = txtTimKiem.Text.Trim();

            string sql =
                "SELECT * FROM KHACHHANG " +
                "WHERE MAKH LIKE N'%" + tukhoa + "%' " +
                "OR TENKH LIKE N'%" + tukhoa + "%' " +
                "OR SDT LIKE '%" + tukhoa + "%' " +
                "OR EMAIL LIKE '%" + tukhoa + "%'";

            HAMXULY.Truyvan(sql, dt);

            dgvTKKH.DataSource = dt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            ShowKhachHang();

            txtTimKiem.Focus();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
