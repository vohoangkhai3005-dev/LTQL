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
    public partial class frmCTHD : Form
    {
        bool isLoaded = false;
        public frmCTHD()
        {
            InitializeComponent();
        }
        private void ShowCTHD()
        {
            DataTable dtCTHD = new DataTable();
            HAMXULY.Connect();

            string sqlCTHD = @"
                                SELECT
                                    C.IDCHITIET,
                                    C.MAHD,
                                    C.MAHANG,
                                    M.TENHANG,
                                    C.SOLUONG,
                                    C.DONGIA,
                                    C.GIAMGIA,
                                    C.THANHTIEN
                                FROM CHITIETHOADON C
                                INNER JOIN MATHANG M ON C.MAHANG = M.MAHANG";

            if (HAMXULY.Truyvan(sqlCTHD, dtCTHD))
            {
                Luoi_CTHD.DataSource = dtCTHD;

               

                Luoi_CTHD.Columns[0].HeaderText = "ID Chi Tiết";
                Luoi_CTHD.Columns[0].Width = 100;

                Luoi_CTHD.Columns[1].HeaderText = "Mã Hóa Đơn";
                Luoi_CTHD.Columns[1].Width = 120;

                Luoi_CTHD.Columns[3].HeaderText = "Tên Hàng";
                Luoi_CTHD.Columns[3].Width = 120;

                Luoi_CTHD.Columns[4].HeaderText = "Số Lượng";
                Luoi_CTHD.Columns[4].Width = 100;

                Luoi_CTHD.Columns[5].HeaderText = "Đơn Giá";
                Luoi_CTHD.Columns[5].Width = 120;

                Luoi_CTHD.Columns[6].HeaderText = "Giảm Giá";
                Luoi_CTHD.Columns[6].Width = 100;

                Luoi_CTHD.Columns[7].HeaderText = "Thành Tiền";
                Luoi_CTHD.Columns[7].Width = 150;

                Luoi_CTHD.Columns["MAHANG"].Visible = false;

                Luoi_CTHD.EnableHeadersVisualStyles = false;
                Luoi_CTHD.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void luoi_CTHD_Click(object sender, EventArgs e)
        {
            txtMCTHD.Text = Luoi_CTHD.CurrentRow.Cells["IDCHITIET"].Value.ToString();
            txtSL.Text = Luoi_CTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDG.Text = Luoi_CTHD.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtGG.Text = Luoi_CTHD.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtTT.Text = Luoi_CTHD.CurrentRow.Cells["THANHTIEN"].Value.ToString();

            cboMHD.Text = Luoi_CTHD.CurrentRow.Cells["MAHD"].Value.ToString();

            string MAHANG, sql;

            MAHANG = Luoi_CTHD.CurrentRow.Cells["MAHANG"].Value.ToString();
            sql = "SELECT TENHANG FROM MATHANG WHERE MAHANG=N'" + MAHANG + "'";
            cboMMH.Text = HAMXULY.GetFieldValues(sql);
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {

            HAMXULY.Connect();

            panelCTHD.Enabled = false;
            ShowCTHD();

            string sql;

            sql = "SELECT MAHD FROM HOADON";
            HAMXULY.FillCombo(sql, cboMHD, "MAHD", "MAHD");

            sql = "SELECT MAHANG, TENHANG FROM MATHANG";
            HAMXULY.FillCombo(sql, cboMMH, "MAHANG", "TENHANG");

            isLoaded = true;
        }
        private void ThemCTHD()
        {
            HAMXULY.Connect();

            string sqlInsert =
                "INSERT INTO CHITIETHOADON(MAHD, MAHANG, SOLUONG, DONGIA, GIAMGIA, THANHTIEN) VALUES(" +
                "N'" + cboMHD.SelectedValue.ToString() + "'," +
                "'" + cboMMH.SelectedValue.ToString() + "'," +
                txtSL.Text.Trim() + "," +
                txtDG.Text.Trim() + "," +
                txtGG.Text.Trim() + "," +
                txtTT.Text.Trim() + ")";

            try
            {
                HAMXULY.RunSQL(sqlInsert);

                MessageBox.Show("Thêm chi tiết hóa đơn thành công!");

                ShowCTHD();

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
            if (cboMHD.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboMHD.Focus();
                return false;
            }

            if (cboMMH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã mặt hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cboMMH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtSL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDG.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDG.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGG.Text))
            {
                txtGG.Text = "0";
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelCTHD.Enabled = true;

            ResetText();

            txtMCTHD.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMCTHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn chi tiết hóa đơn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                HAMXULY.Connect();

                string sqlDelete =
                    "DELETE FROM CHITIETHOADON WHERE IDCHITIET = '" +
                    txtMCTHD.Text.Trim() + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa chi tiết hóa đơn này?",
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

                    ShowCTHD();
                    ResetText();
                }

                HAMXULY.Connect();
            }
        }
        private void SuaCTHD()
        {
            if (txtMCTHD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã chi tiết hóa đơn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMCTHD.Focus();
            }
            if (txtSL.Text == "" || txtDG.Text == "" || txtGG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin số!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string SqlUpdate =
                   @"UPDATE CHITIETHOADON SET " +
                    "MAHD = N'" + cboMHD.SelectedValue.ToString() + "', " +
                    "MAHANG = '" + cboMMH.SelectedValue.ToString() + "', " +
                    "SOLUONG = " + txtSL.Text + ", " +
                    "DONGIA = " + txtDG.Text + ", " +
                    "GIAMGIA = " + txtGG.Text + ", " +
                    "THANHTIEN = " + txtTT.Text + " " +
                    "WHERE IDCHITIET = " + txtMCTHD.Text;

                try
                {
                    HAMXULY.Connect();

                    HAMXULY.RunSQL(SqlUpdate);

                    MessageBox.Show("Đã sửa thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ShowCTHD();
                    ResetText();

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;

                    txtMCTHD.Enabled = true;
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            panelCTHD.Enabled = true;

            txtMCTHD.Enabled = false; // không cho sửa mã hàng

           

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelCTHD.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMCTHD.Enabled = true;
        }
        private void ResetText()
        {
            txtMCTHD.Text = "";    // Mã chi tiết hóa đơn
            cboMHD.SelectedIndex = -1; // ComboBox Mã hóa đơn (bỏ chọn)
            cboMMH.SelectedIndex = -1; // ComboBox Mã mặt hàng (bỏ chọn)
            txtSL.Text = "0";      // Số lượng (mặc định để bằng 0 hoặc rỗng "" tùy bạn)
            txtDG.Text = "0";      // Đơn giá
            txtGG.Text = "0";      // Giảm giá
            txtTT.Text = "0";      // Thành tiền
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            if (btnThem.Enabled == true)
                ThemCTHD();
            else
                SuaCTHD();
        }

        private void button5_Click(object sender, EventArgs e)
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
        private void TinhThanhTien()
        {
            double sl = 0, gd = 0, gg = 0;

            double.TryParse(txtSL.Text, out sl);
            double.TryParse(txtDG.Text, out gd);
            double.TryParse(txtGG.Text, out gg);

            double tt = sl * gd * (1 - gg / 100);

            txtTT.Text = tt.ToString("0.00");
 
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtGG_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void cboMMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (cboMMH.SelectedValue == null) return;

            string maHang = cboMMH.SelectedValue.ToString();

            string sql = "SELECT DONGIABAN FROM MATHANG WHERE MAHANG = N'" + maHang + "'";

            string gia = HAMXULY.GetFieldValues(sql);

            txtDG.Text = gia;

            TinhThanhTien();
            DataTable dt = new DataTable();
            HAMXULY.Connect();

           // string sql = "SELECT DONGIABAN FROM MATHANG WHERE MAHANG = N'" + maHang + "'";

          //  if (HAMXULY.Truyvan(sql, dt))
          //  {
          //      txtDG.Text = dt.Rows[0]["DONGIABAN"].ToString();
          //      TinhThanhTien();
          //  }

        }
    }
}
