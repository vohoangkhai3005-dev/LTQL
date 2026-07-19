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
    public partial class ChiTietPhieuNhap : Form
    {
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            ShowCTPN();
            pnlCTPN.Enabled = false;
            cboMaPN.Enabled = false;
            txtThanhTien.Enabled = false;

            txtSL.TextChanged += txtSL_TextChanged;
            txtDGN.TextChanged += txtDGN_TextChanged;


            string sqlCTPN;
            sqlCTPN = "SELECT MaCTPN FROM CHITIETPHIEUNHAP";
            HAMXULY.FillCombo(sqlCTPN, cboCTPN, "MaCTPN", "MACTPN");

            string sqlPN;
            sqlPN = "SELECT MaPN FROM PHIEUNHAP";
            HAMXULY.FillCombo(sqlPN, cboMaPN, "MaPN", "MaPN");

            string sqlSP;
            sqlSP = "SELECT MaSP, TenSP FROM SANPHAM";
            HAMXULY.FillCombo(sqlSP, cboSP, "MaSP", "TenSP");

            cboCTPN.Visible = false;
        }
        private void ShowCTPN()
        {
            DataTable dtCTPN = new DataTable();
            HAMXULY.Connect();

            string sqlCTHD = @"
                                SELECT
                                    C.MaCTPN,
                                    C.MaPN,
                                    C.MaSP,
                                    S.TenSP,
                                    C.SoLuong,
                                    C.DonGiaBan,
                                    C.ThanhTien
                                FROM CHITIETPHIEUNHAP C
                                INNER JOIN SANPHAM S ON C.MaSP = S.MaSP";

            if (HAMXULY.Truyvan(sqlCTHD, dtCTPN))
            {
                dgvCTPN.DataSource = dtCTPN;



                dgvCTPN.Columns[0].HeaderText = "ID Chi Tiết";
                dgvCTPN.Columns[0].Width = 100;

                dgvCTPN.Columns[1].HeaderText = "Mã phiếu nhập";
                dgvCTPN.Columns[1].Width = 120;

                dgvCTPN.Columns[2].HeaderText = "Mã sản phẩm";
                dgvCTPN.Columns[2].Width = 120;

                dgvCTPN.Columns[3].HeaderText = "Tên sản phẩm";
                dgvCTPN.Columns[3].Width = 100;

                dgvCTPN.Columns[4].HeaderText = "Số lượng";
                dgvCTPN.Columns[4].Width = 120;

                dgvCTPN.Columns[5].HeaderText = "Đơn giá nhập";
                dgvCTPN.Columns[5].Width = 100;

                dgvCTPN.Columns[6].HeaderText = "Thành Tiền";
                dgvCTPN.Columns[6].Width = 150;

                dgvCTPN.Columns["MaCTPN"].Visible = false;

                dgvCTPN.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                dgvCTPN.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dgvCTPN.RowTemplate.Height = 35;
                dgvCTPN.ColumnHeadersHeight = 40;
                dgvCTPN.RowsDefaultCellStyle.BackColor = Color.White;
                dgvCTPN.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || dgvCTPN.CurrentRow == null)
                return;
            cboCTPN.Text = dgvCTPN.CurrentRow.Cells["MaCTPN"].Value.ToString();

            string maSP = dgvCTPN.CurrentRow.Cells["MaSP"].Value.ToString();
            string sqlSP = "SELECT TenSP FROM SANPHAM WHERE MaSP = N'" + maSP + "'";
            cboSP.Text = HAMXULY.GetFieldValues(sqlSP);


            

            txtSL.Text = dgvCTPN.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDGN.Text = dgvCTPN.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtThanhTien.Text = dgvCTPN.CurrentRow.Cells["ThanhTien"].Value.ToString();
            string maPN = dgvCTPN.CurrentRow.Cells["MaPN"].Value.ToString();
            string sqlPN = "SELECT MaPN FROM PHIEUNHAP WHERE MaPN = N'" + maPN + "'";
            cboMaPN.Text = HAMXULY.GetFieldValues(sqlPN);


            



        }
        //hàm kiểm tra thông tin
        private bool KiemTraThongTin()
        {
            if (cboMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã phiếu nhập");
                cboMaPN.Focus();
                return false;
            }

            if (cboSP.SelectedValue == null || cboSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                cboSP.Focus();
                return false;
            }

            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSL.Focus();
                return false;
            }

            int soLuong;
            if (!int.TryParse(txtSL.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0");
                txtSL.Focus();
                return false;
            }

            if (txtDGN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá nhập");
                txtDGN.Focus();
                return false;
            }

            decimal donGia;
            if (!decimal.TryParse(txtDGN.Text.Trim(), out donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá nhập phải lớn hơn 0");
                txtDGN.Focus();
                return false;
            }

            return true;
        }
        private void TinhThanhTien()
        {
            int soLuong;
            decimal donGiaNhap;

            if (int.TryParse(txtSL.Text.Trim(), out soLuong) &&
                decimal.TryParse(txtDGN.Text.Trim(), out donGiaNhap))
            {
                decimal thanhTien = soLuong * donGiaNhap;
                txtThanhTien.Text = thanhTien.ToString("0");
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }
        bool isAdding = true;
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            pnlCTPN.Enabled = true;

            cboSP.ResetText();
            cboSP.Focus();

            txtDGN.ResetText();
            txtSL.ResetText();
            txtThanhTien.ResetText();
            isAdding = true;
        }
        //xử lý thêm
        private void them()
        {
            if (!KiemTraThongTin()) {
                return; 
            }
            HAMXULY.Connect();

            string sqlInsert =
                "INSERT INTO CHITIETPHIEUNHAP(MaPN, MaSP, SoLuong, DonGiaBan) VALUES(" +
                "N'" + cboMaPN.SelectedValue.ToString() + "'," +
                "'" + cboSP.SelectedValue.ToString() + "'," +
                txtSL.Text.Trim() + "," +
                txtDGN.Text.Trim() + ")";

            try
            {
                HAMXULY.RunSQL(sqlInsert);

                MessageBox.Show("Thêm vào chi tiết hóa phiếu công!");

                ShowCTPN();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        //xử lý sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdding = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            pnlCTPN.Enabled = true;
        }
        private void Sua()
        {
            if (!KiemTraThongTin())
            {
                return;
            }

            TinhThanhTien();

            string SqlUpdate =
                "UPDATE CHITIETPHIEUNHAP SET " +
                "MaPN = N'" + cboMaPN.SelectedValue.ToString() + "', " +
                "MaSP = N'" + cboSP.SelectedValue.ToString() + "', " +
                "SoLuong = " + txtSL.Text.Trim() + ", " +
                "DonGiaBan = " + txtDGN.Text.Trim() +
                
                "WHERE MaCTPN = " + cboCTPN.Text.Trim();

            try
            {
                HAMXULY.Connect();
                HAMXULY.RunSQL(SqlUpdate);

                MessageBox.Show("Đã sửa thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ShowCTPN();
                ResetText();

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboCTPN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn chi tiết hóa đơn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete ="DELETE FROM CHITIETPHIEUNHAP WHERE MaCTPN = " + cboCTPN.Text.Trim();

                if (MessageBox.Show("Bạn có chắc muốn xóa chi tiết phiếu nhập này?",
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

                    ShowCTPN();
                    ResetText();
                }

                HAMXULY.Connect();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                them();
            }
            else
            {
                Sua();
            }
            
        }

        private void txtDGN_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?",
                       "Xác nhận",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            pnlCTPN.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
