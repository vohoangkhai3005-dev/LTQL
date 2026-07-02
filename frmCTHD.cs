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
            if (Luoi_CTHD.Rows.Count == 0) return;

            txtMCTHD.Text = Luoi_CTHD.CurrentRow.Cells["MACTHD"].Value.ToString();
            txtMaHD.Text = Luoi_CTHD.CurrentRow.Cells["MAHD"].Value.ToString();

            string mamh = Luoi_CTHD.CurrentRow.Cells["MAMH"].Value.ToString();

            // Hiện tên mặt hàng
            string sql = "SELECT TENMH FROM MATHANG WHERE MAMH = N'" + mamh + "'";
            txtMH.Text = HAMXULY.GetFieldValues(sql);

            txtSL.Text = Luoi_CTHD.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDG.Text = Luoi_CTHD.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtGG.Text = Luoi_CTHD.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtTT.Text = Luoi_CTHD.CurrentRow.Cells["THANHTIEN"].Value.ToString();
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {

            HAMXULY.Connect();

            // Chỉ xem, không chỉnh sửa
            txtMCTHD.ReadOnly = true;
            txtMaHD.ReadOnly = true;
            txtMH.ReadOnly = true;
            txtSL.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtGG.ReadOnly = true;
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
                          MAMH,
                          SOLUONG,
                          DONGIA,
                          GIAMGIA,
                          THANHTIEN
                   FROM CTHD
                   WHERE MAHD = N'" + mahd + "'";

            if (HAMXULY.Truyvan(sql, dt))
            {
                Luoi_CTHD.DataSource = dt;

                Luoi_CTHD.Columns[0].HeaderText = "Mã Chi Tiết";
                Luoi_CTHD.Columns[1].HeaderText = "Mã Hóa Đơn";
                Luoi_CTHD.Columns[2].HeaderText = "Mã Mặt Hàng";
                Luoi_CTHD.Columns[3].HeaderText = "Số lượng";
                Luoi_CTHD.Columns[4].HeaderText = "Đơn giá";
                Luoi_CTHD.Columns[5].HeaderText = "Giảm giá";
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
    }
}
