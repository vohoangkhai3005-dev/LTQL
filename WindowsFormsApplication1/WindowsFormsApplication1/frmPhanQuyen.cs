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
    public partial class frmPhanQuyen : Form
    {
        int IDUSER = 0;
        DataTable dtCN = new DataTable();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

           // cboNhom.Items.Add("Admin");
           // cboNhom.Items.Add("User");

            //cboNhom.Enabled = false;



            txtHoTen.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
            txtNhom.ReadOnly = true;

            panelPhanQuyen.Enabled = false;

            ShowTaiKhoan();
            LoadChucNang();

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

            // CheckedListBox đẹp hơn
            clbChucNang.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);

            clbChucNang.BackColor = Color.White;
            clbChucNang.ForeColor = Color.FromArgb(45, 45, 48);

            clbChucNang.BorderStyle = BorderStyle.FixedSingle;

            clbChucNang.CheckOnClick = true;
            clbChucNang.ThreeDCheckBoxes = true;

            clbChucNang.IntegralHeight = false;
            clbChucNang.HorizontalScrollbar = false;

            clbChucNang.ItemHeight = 30;
        }
        private void ShowTaiKhoan()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT IDUSER,HOTEN,TAIKHOANG,NHOM " +
                 "FROM TAIKHOAN " +
                 "WHERE NHOM <> 'SuperAdmin'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTaiKhoan.DataSource = dt;

                dgvTaiKhoan.Columns["IDUSER"].Visible = false;

                dgvTaiKhoan.Columns["HOTEN"].HeaderText = "Họ tên";
                dgvTaiKhoan.Columns["TAIKHOANG"].HeaderText = "Tài khoản";
                dgvTaiKhoan.Columns["NHOM"].HeaderText = "Nhóm";
            }
        }
        private void LoadChucNang()
        {
            dtCN.Clear();

            string sql = "SELECT IDCN,TENCN FROM CHUCNANG";

            HAMXULY.Truyvan(sql, dtCN);

            clbChucNang.Items.Clear();

            foreach (DataRow r in dtCN.Rows)
            {
                clbChucNang.Items.Add(r["TENCN"].ToString());
            }
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            panelPhanQuyen.Enabled = true;

            txtHoTen.Text =
        dgvTaiKhoan.CurrentRow.Cells["HOTEN"].Value.ToString();

            txtTaiKhoan.Text =
                dgvTaiKhoan.CurrentRow.Cells["TAIKHOANG"].Value.ToString();

            txtNhom.Text =
        dgvTaiKhoan.CurrentRow.Cells["NHOM"].Value.ToString();

            IDUSER = Convert.ToInt32(
                dgvTaiKhoan.CurrentRow.Cells["IDUSER"].Value);

            HienThiQuyen();
        }
        private void HienThiQuyen()
        {
            for (int i = 0; i < clbChucNang.Items.Count; i++)
                clbChucNang.SetItemChecked(i, false);

            DataTable dt = new DataTable();

            string sql =
                "SELECT IDCN FROM VAITRO WHERE IDUSER=" + IDUSER;

            HAMXULY.Truyvan(sql, dt);

            foreach (DataRow r in dt.Rows)
            {
                int idcn = Convert.ToInt32(r["IDCN"]);

                for (int i = 0; i < dtCN.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtCN.Rows[i]["IDCN"]) == idcn)
                    {
                        clbChucNang.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (IDUSER == 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản");
                return;
            }

            HAMXULY.Connect();

            string sql =
                "DELETE FROM VAITRO WHERE IDUSER=" + IDUSER;

            HAMXULY.RunSQL(sql);

            for (int i = 0; i < clbChucNang.Items.Count; i++)
            {
                if (clbChucNang.GetItemChecked(i))
                {
                    int idcn =
                        Convert.ToInt32(dtCN.Rows[i]["IDCN"]);

                    sql =
                        "INSERT INTO VAITRO(IDUSER,IDCN) VALUES(" +
                        IDUSER + "," + idcn + ")";

                    HAMXULY.RunSQL(sql);
                }
            }

            MessageBox.Show("Phân quyền thành công");

            panelPhanQuyen.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            MessageBox.Show("Đã hủy thao tác!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            panelPhanQuyen.Enabled = false;
        }
        private void ResetText()
        {
            txtHoTen.Clear();
            txtTaiKhoan.Clear();
            txtNhom.Clear();

            IDUSER = 0;

            for (int i = 0; i < clbChucNang.Items.Count; i++)
            {
                clbChucNang.SetItemChecked(i, false);
            }

            dgvTaiKhoan.ClearSelection();
        }
    }
}
