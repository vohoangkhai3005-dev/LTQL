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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlDM.Enabled = true;
            dangThem = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            txtMaDM.ResetText();
            txtTenDM.ResetText();
            txtMota.ResetText();
            txtMaDM.Focus();
        }
        //Hàm kiểm tra thông tin
        private Boolean Kiemtrathongtin()
        {
            if (txtMaDM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã danh mục", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTenDM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã danh mục", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //xử lý thêm
        private void ThemDM()
        {
            if (Kiemtrathongtin())
            {
                HAMXULY.Connect();
                string sqlInsert = "INSERT INTO DANHMUC(MaDanhMuc, TenDanhMuc, MoTa) " +
                    "VALUES ('" + txtMaDM.Text +
                    "','" + txtTenDM.Text +
                    "','" + txtMota.Text + "')";
                try
                {
                    HAMXULY.RunSQL(sqlInsert);
                    MessageBox.Show("Bạn đã thêm thành công 1 danh mục: ", txtTenDM.Text);
                    showDM();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }
        }

        private void dgvDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDM_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu từ lưới lên text box
            txtMaDM.Text = dgvDM.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            txtTenDM.Text = dgvDM.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
            txtMota.Text = dgvDM.CurrentRow.Cells["Mota"].Value.ToString();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            pnlDM.Enabled = false;
            showDM();
        }
        private void showDM()
        {
            DataTable dtDM = new DataTable();
            HAMXULY.Connect();
            string sqlDM = "SELECT * FROM DANHMUC";
            if (HAMXULY.Truyvan(sqlDM, dtDM))
            {
                dgvDM.DataSource = dtDM;

                dgvDM.Columns[0].HeaderText = "Mã danh mục";
                dgvDM.Columns[0].Width = 200;
                dgvDM.Columns[1].HeaderText = "Tên danh mục";
                dgvDM.Columns[1].Width = 250;
                dgvDM.Columns[2].HeaderText = "Mô tả";
                dgvDM.Columns[2].Width = 500;
                dgvDM.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dgvDM.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dgvDM.RowTemplate.Height = 35;
                dgvDM.ColumnHeadersHeight = 40;
                dgvDM.RowsDefaultCellStyle.BackColor = Color.White;
                dgvDM.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }
        private bool dangThem = false;

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlDM.Enabled = true;
            dangThem = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            txtMaDM.Enabled = false;
            txtTenDM.SelectAll();
        }
        private void SuaDM()
        {
            if (Kiemtrathongtin())
            {
                HAMXULY.Connect();
                string sqlUpdate = "UPDATE DANHMUC" +
                    " SET TenDanhMuc = N'" + txtTenDM.Text + "'," +
                    "MoTa = N'" + txtMota.Text + "'" +
                    "WHERE MaDanhMuc = N'" + txtMaDM.Text + "' ";
                try
                {
                    HAMXULY.RunSQL(sqlUpdate);
                    MessageBox.Show("Bạn đã sửa thành công 1 danh mục", "Thông báo");
                    showDM();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Kiemtrathongtin())
                return;
            if (dangThem)
            {
                ThemDM();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                SuaDM();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            pnlDM.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaDM();
        }
        //xử lý nút xóa
        private void XoaDM()
        {
            if (MessageBox.Show("Bạn có muốn xóa danh mục này không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string sqlDelete = "DELETE FROM DANHMUC WHERE MaDanhMuc = N'" + txtMaDM.Text + "'";
                HAMXULY.RunSQL(sqlDelete);
                showDM();   //load lại dữ liệu
                MessageBox.Show("Bạn đã xóa thành công danh mục");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
