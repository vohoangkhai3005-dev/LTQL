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
    
    public partial class frmNhaCungCap : Form
    {
        bool isAdding = false;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();
            pnlNCC.Enabled = false;
            ShowNCC();
            
            
        }
        private void ShowNCC()
        {
            DataTable dtNCC = new DataTable();
            HAMXULY.Connect();
            string sqlNCC = "SELECT * FROM NHACUNGCAP";
            if(HAMXULY.Truyvan(sqlNCC, dtNCC))
            {
                dgvNCC.DataSource = dtNCC;

                dgvNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
                dgvNCC.Columns[0].Width = 100;
                dgvNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
                dgvNCC.Columns[1].Width = 200;
                dgvNCC.Columns[2].HeaderText = "Số điện thoại liên hệ";
                dgvNCC.Columns[2].Width = 200;
                dgvNCC.Columns[3].HeaderText = "Email";
                dgvNCC.Columns[3].Width = 200;
                dgvNCC.Columns[4].HeaderText = "Địa chỉ";
                dgvNCC.Columns[4].Width = 200;

                dgvNCC.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dgvNCC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dgvNCC.RowTemplate.Height = 35;
                dgvNCC.ColumnHeadersHeight = 40;
                dgvNCC.RowsDefaultCellStyle.BackColor = Color.White;
                dgvNCC.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;



            }    
        }
        private bool KiemTraThongTin()
        {
            // Kiểm tra ô Mã hàng trống
            if (string.IsNullOrEmpty(txtMaNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return false; // Dừng lại, không cho thực hiện tiếp
            }

            // Kiểm tra ô Tên hàng trống
            if (string.IsNullOrEmpty(txtTenNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return false; // Dừng lại
            }

            // Nếu tất cả đều hợp lệ
            return true;
        }
        //đổ dữ liệu lên textbox
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtSDT.Text = dgvNCC.CurrentRow.Cells["SDT"].Value.ToString();
            txtMAIL.Text = dgvNCC.CurrentRow.Cells["EMAIL"].Value.ToString();
            textAddress.Text = dgvNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        private void ResetText()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtMAIL.Text = "";
            textAddress.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetText();
            isAdding = true;

            pnlNCC.Enabled = true;

            txtMaNCC.Focus();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void Them()
        {
            if (KiemTraThongTin())
            {
                string sqlInsert = "INSERT INTO NHACUNGCAP(MaNCC, TenNCC, SDT, EMAIL, DiaChi) VALUES (" +
                    "'" + txtMaNCC.Text + "'," +
                    "N'" + txtTenNCC.Text + "'," +
                    "'" + txtSDT.Text + "'," +
                    "'" + txtMAIL.Text + "'," +
                    "N'" + textAddress.Text + "')"
                    ;
                HAMXULY.RunSQL(sqlInsert);
                MessageBox.Show("Đã thêm thành công nhà cung cấp!", "Thông báo");
                ShowNCC();
                ResetText();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlNCC.Enabled = true;
            txtMaNCC.Enabled = false;
            isAdding = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void Sua()
        {
            if (KiemTraThongTin())
            {
                string sqlSua = "UPDATE NHACUNGCAP SET " +
                    "TenNCC = N'" + txtTenNCC.Text.Trim() + "', " +
                    "SDT = '" + txtSDT.Text + "', " +
                    "Email = '" + txtMAIL.Text + "'," +
                    "DiaChi = N'" + textAddress.Text + "' " +
                    "WHERE MaNCC = '" + txtMaNCC.Text + "'";

                HAMXULY.RunSQL(sqlSua);
                MessageBox.Show("Sửa nhà cung cấp thành công");

                ShowNCC();
                ResetText();

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                txtMaNCC.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM NHACUNGCAP WHERE MaNCC = '" + txtMaNCC.Text + "'";

                HAMXULY.RunSQL(sql);
                MessageBox.Show("Xóa nhà cung cấp thành công");

                ShowNCC();
                ResetText();
            }
        }
       
        //xử lý lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
            {
                return;
            }

            if (isAdding)
            {
                Them();
            }
            else
            {
                Sua();
            }

            pnlNCC.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            pnlNCC.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Xác nhận",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
