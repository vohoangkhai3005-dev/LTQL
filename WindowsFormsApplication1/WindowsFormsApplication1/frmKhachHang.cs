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
    public partial class frmKhachHang : Form
    {
        // Biến xác định đang Thêm hay Sửa
        private bool isThem = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            panelKHACHHANG.Enabled = false;
            ShowKhachHang();
        }
        private void ShowKhachHang()
        {
            DataTable dtKH = new DataTable();
            HAMXULY.Connect();

            string sqlKH = "SELECT * FROM KHACHHANG";

            if (HAMXULY.Truyvan(sqlKH, dtKH))
            {
                Luoi_KHACHHANG.DataSource = dtKH;

                Luoi_KHACHHANG.Columns[0].HeaderText = "Mã Khách Hàng";
                Luoi_KHACHHANG.Columns[0].Width = 120;

                Luoi_KHACHHANG.Columns[1].HeaderText = "Tên Khách Hàng";
                Luoi_KHACHHANG.Columns[1].Width = 150;

                Luoi_KHACHHANG.Columns[2].HeaderText = "Số Điện Thoại";
                Luoi_KHACHHANG.Columns[2].Width = 120;

                Luoi_KHACHHANG.Columns[3].HeaderText = "Địa Chỉ";
                Luoi_KHACHHANG.Columns[3].Width = 180;

                Luoi_KHACHHANG.Columns[4].HeaderText = "Email";
                Luoi_KHACHHANG.Columns[4].Width = 180;

                //Luoi_KHACHHANG.Columns[5].HeaderText = "Điểm Tích Lũy";
                //Luoi_KHACHHANG.Columns[5].Width = 70;

                Luoi_KHACHHANG.EnableHeadersVisualStyles = false;
                Luoi_KHACHHANG.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
            HAMXULY.DisConnect();
        }
        private void Luoi_KHACHHANG_Click(object sender, EventArgs e)
        {
            if (Luoi_KHACHHANG.CurrentRow == null)
                return;
            txtMKH.Text = Luoi_KHACHHANG.CurrentRow.Cells["MAKH"].Value.ToString();
            txtTKH.Text = Luoi_KHACHHANG.CurrentRow.Cells["TENKH"].Value.ToString();
            txtDC.Text = Luoi_KHACHHANG.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtDT.Text = Luoi_KHACHHANG.CurrentRow.Cells["SDT"].Value.ToString();
            txtEmail.Text = Luoi_KHACHHANG.CurrentRow.Cells["EMAIL"].Value.ToString();

            
        }
        private void ThemKhachHang()
        {
            if (!KiemTraThongTin())
                return;
            HAMXULY.Connect();

            string sqlInsert =
                "INSERT INTO KHACHHANG(MAKH,TENKH,SDT,DIACHI,EMAIL) VALUES(" +
                "N'" + txtMKH.Text.Trim() + "'," +
                "N'" + txtTKH.Text.Trim() + "'," +
                "'" + txtDT.Text.Trim() + "'," +
                "N'" + txtDC.Text.Trim() + "'," +
                "'" + txtEmail.Text.Trim() + "')";

            try
            {
                HAMXULY.RunSQL(sqlInsert);

                MessageBox.Show("Thêm khách hàng thành công!");

                ShowKhachHang();
                ResetText();

                panelKHACHHANG.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMKH.Enabled = true;

                HAMXULY.DisConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtMKH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtTKH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDC.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDT.Text))
            {
                MessageBox.Show("Vui lòng nhập điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            isThem = true;
            panelKHACHHANG.Enabled = true;

            ResetText();
            
            txtMKH.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete =
                    "DELETE FROM KHACHHANG WHERE MAKH = '" +
                    txtMKH.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?",
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

                    ShowKhachHang();
                    ResetText();
                }

                HAMXULY.DisConnect();
            }
        }
        private void SuaKhachHang()
        {
            if (txtMKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMKH.Focus();
            }
            else
            {
                string SqlUpdate =
                    "UPDATE KHACHHANG SET " +
                    "TENKH=N'" + txtTKH.Text.Trim() + "'," +
                    "SDT='" + txtDT.Text.Trim() + "'," +
                    "DIACHI=N'" + txtDC.Text.Trim() + "'," +
                    "EMAIL='" + txtEmail.Text.Trim() + "'" +
                    " WHERE MAKH='" + txtMKH.Text.Trim() + "'";

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(SqlUpdate);

                    MessageBox.Show("Đã sửa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowKhachHang();
                    ResetText();

                    panelKHACHHANG.Enabled = false;

                    HAMXULY.DisConnect();

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;

                    txtMKH.Enabled = true;
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!");
                return;
            }
            panelKHACHHANG.Enabled = true;

            txtMKH.Enabled = false; // không cho sửa mã hàng

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            if (isThem)
                ThemKhachHang();
            else
                SuaKhachHang();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelKHACHHANG.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMKH.Enabled = true;
        }
        private void ResetText()
        {
            txtMKH.Text = "";
            txtTKH.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";

           
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?",
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
