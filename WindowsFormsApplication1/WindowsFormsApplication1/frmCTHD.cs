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

        public string MaHD { get; set; }
        public string masp { get; private set; }

        private void ShowCTHD()
        {
            DataTable dtCTHD = new DataTable();
            HAMXULY.Connect();

            string sqlCTHD = @"
                                SELECT
                                    C.MACHITIET,
                                    C.MAHD,
                                    C.MASP,
                                    S.TenSP,
                                    C.SOLUONG,
                                    C.DONGIA,                                 
                                    C.THANHTIEN
                                FROM CHITIETHOADON C
                                INNER JOIN SANPHAM S ON C.MASP = S.MaSP";

            if (HAMXULY.Truyvan(sqlCTHD, dtCTHD))
            {
                Luoi_CTHD.DataSource = dtCTHD;
               
                Luoi_CTHD.Columns[0].HeaderText = "Mã Chi Tiết";
                Luoi_CTHD.Columns[0].Width = 100;

                Luoi_CTHD.Columns[1].HeaderText = "Mã Hóa Đơn";
                Luoi_CTHD.Columns[1].Width = 120;

                Luoi_CTHD.Columns[2].HeaderText = "Tên Sản Phẩm";
                Luoi_CTHD.Columns[2].Width = 120;

                Luoi_CTHD.Columns[3].HeaderText = "Số Lượng";
                Luoi_CTHD.Columns[3].Width = 100;

                Luoi_CTHD.Columns[4].HeaderText = "Đơn Giá";
                Luoi_CTHD.Columns[4].Width = 120;

                Luoi_CTHD.Columns[5].HeaderText = "Thành Tiền";
                Luoi_CTHD.Columns[5].Width = 150;

                Luoi_CTHD.Columns["MASP"].Visible = false;

                Luoi_CTHD.EnableHeadersVisualStyles = false;
                Luoi_CTHD.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }
        private void luoi_CTHD_Click(object sender, EventArgs e)
        {
            if (Luoi_CTHD.Rows.Count == 0) return;

            txtMCTHD.Text = Luoi_CTHD.CurrentRow.Cells["MACHITIET"].Value.ToString();
            txtMaHD.Text = Luoi_CTHD.CurrentRow.Cells["MAHD"].Value.ToString();

            string mamh = Luoi_CTHD.CurrentRow.Cells["MASP"].Value.ToString();

            // Hiện tên san pham
            string sql = "SELECT TenSP FROM SANPHAM WHERE MaSP = N'" + masp + "'";
            txtSP.Text = HAMXULY.GetFieldValues(sql);

            txtSL.Text = Luoi_CTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDG.Text = Luoi_CTHD.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtTT.Text = Luoi_CTHD.CurrentRow.Cells["THANHTIEN"].Value.ToString();
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
            this.cHITIETHOADONTableAdapter.Fill(this.qlbhDataSet.CHITIETHOADON);

            HAMXULY.Connect();

            // Chỉ xem, không chỉnh sửa
            txtMCTHD.ReadOnly = true;
            txtMaHD.ReadOnly = true;
            txtSP.ReadOnly = true;
            txtSL.ReadOnly = true;
            txtDG.ReadOnly = true;           
            txtTT.ReadOnly = true;

            if (!string.IsNullOrEmpty(MaHD))
            {
                txtMaHD.Text = MaHD;
                ShowCTHD(MaHD);
            }
        }
        private void ShowCTHD(string mahd)
        {
            DataTable dt = new DataTable();

            string sql = @"SELECT MACHITIET,
                          MAHD,
                          MASP,
                          SOLUONG,
                          DONGIA,
                          THANHTIEN
                   FROM CHITIETHOADON
                   WHERE MAHD = N'" + mahd + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_CTHD.DataSource = dt;

                Luoi_CTHD.Columns[0].HeaderText = "Mã Chi Tiết";
                Luoi_CTHD.Columns[1].HeaderText = "Mã Hóa Đơn";
                Luoi_CTHD.Columns[2].HeaderText = "Mã Sản Phẩm";
                Luoi_CTHD.Columns[3].HeaderText = "Số lượng";
                Luoi_CTHD.Columns[4].HeaderText = "Đơn giá";
                Luoi_CTHD.Columns[6].HeaderText = "Thành tiền";

                Luoi_CTHD.EnableHeadersVisualStyles = false;
                Luoi_CTHD.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
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
        
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            decimal thanhtien = Convert.ToDecimal(txtSL.Text) * Convert.ToDecimal(txtDG.Text);
            txtTT.Text = thanhtien.ToString();

            string sql =
            @"UPDATE CHITIETHOADON
            SET
            SOLUONG=" + txtSL.Text + @",
            DONGIA=" + txtDG.Text + @",
            THANHTIEN=" + txtTT.Text + @"
            WHERE MACHITIET=N'" + txtMCTHD.Text + "'";

            HAMXULY.RunSQL(sql);

            string sqlTong =
            @"UPDATE HOADON
            SET TongTien=
            (
            SELECT ISNULL(SUM(ThanhTien),0)
            FROM CHITIETHOADON
            WHERE MAHD=N'" + txtMaHD.Text + @"'
            )
            WHERE MAHD=N'" + txtMaHD.Text + "'";

            HAMXULY.RunSQL(sqlTong);
            ShowCTHD(txtMaHD.Text);
            MessageBox.Show("Đã sửa.");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HAMXULY.Connect();
            decimal thanhtien = Convert.ToDecimal(txtSL.Text) * Convert.ToDecimal(txtDG.Text);
            txtTT.Text = thanhtien.ToString();

            // Kiểm tra tồn kho
            string sqlKT = "SELECT SoLuongTon FROM SANPHAM WHERE MaSP=N'" + txtSP.Text + "'";
            int ton = Convert.ToInt32(HAMXULY.GetFieldValues(sqlKT));

            if (ton < Convert.ToInt32(txtSL.Text))
            {
                MessageBox.Show("Sản phẩm không đủ số lượng tồn!");
                return;
            }

            // Thêm CTHD
            string sql =
            @"INSERT INTO CHITIETHOADON
            (
                MACHITIET,
                MAHD,
                MASP,
                SOLUONG,
                DONGIA,
                THANHTIEN
            )
            VALUES
            (
            N'" + txtMCTHD.Text + @"',
            N'" + txtMaHD.Text + @"',
            N'" + txtSP.Text + @"',
            " + txtSL.Text + @",
            " + txtDG.Text + @",
            " + txtTT.Text + ")";

            HAMXULY.RunSQL(sql);

            // Trừ tồn kho
            string sqlTon =
            @"UPDATE SANPHAM
            SET SoLuongTon = SoLuongTon - " + txtSL.Text +
              " WHERE TenSP=N'" + txtSP.Text + "'";

            HAMXULY.RunSQL(sqlTon);

            // Cập nhật tổng tiền hóa đơn
            string sqlTong =
            @"UPDATE HOADON
            SET TongTien=
            (
            SELECT ISNULL(SUM(ThanhTien),0)
            FROM CHITIETHOADON
            WHERE MAHD=N'" + txtMaHD.Text + @"'
            )
            WHERE MAHD=N'" + txtMaHD.Text + "'";

            HAMXULY.RunSQL(sqlTong);
            ShowCTHD(txtMaHD.Text);
            MessageBox.Show("Đã thêm chi tiết hóa đơn.", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
                return;

            HAMXULY.Connect();

            // Cộng lại tồn kho
            string sqlTon =
            @"UPDATE SANPHAM
            SET SoLuongTon = SoLuongTon + " + txtSL.Text +
            " WHERE TenSP=N'" + txtSP.Text + "'";

            HAMXULY.RunSQL(sqlTon);

            // Xóa CTHD
            string sql =
            @"DELETE FROM CHITIETHOADON
            WHERE MACHITIET=N'" + txtMCTHD.Text + "'";

            HAMXULY.RunSQL(sql);

            // Cập nhật tổng tiền
            string sqlTong =
            @"UPDATE HOADON
            SET TongTien=
            (
            SELECT ISNULL(SUM(ThanhTien),0)
            FROM CHITIETHOADON
            WHERE MAHD=N'" + txtMaHD.Text + @"'
            )
            WHERE MAHD=N'" + txtMaHD.Text + "'";

            HAMXULY.RunSQL(sqlTong);
            ShowCTHD(txtMaHD.Text);
            MessageBox.Show("Đã xóa.", "Thông báo");
        }
    }
}
