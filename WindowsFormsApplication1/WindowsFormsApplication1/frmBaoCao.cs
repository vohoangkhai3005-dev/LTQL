using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        private void ShowDoanhThu()
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
                    @"SELECT HD.MAHD,
                             HD.NGAYLAP,
                             NV.TENNV,
                             KH.TENKH,
                             HD.TONGTIEN
                    FROM HOADON HD
                    INNER JOIN NHANVIEN NV
                    ON HD.MANV = NV.MANV
                    INNER JOIN KHACHHANG KH
                    ON HD.MAKH = KH.MAKH";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvDoanhThu.DataSource = dt;

                dgvDoanhThu.Columns[0].HeaderText = "Mã HĐ";
                dgvDoanhThu.Columns[1].HeaderText = "Ngày lập";
                dgvDoanhThu.Columns[2].HeaderText = "Nhân viên";
                dgvDoanhThu.Columns[3].HeaderText = "Khách hàng";
                dgvDoanhThu.Columns[4].HeaderText = "Tổng tiền";

                dgvDoanhThu.EnableHeadersVisualStyles = false;
                dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

                TinhTongDoanhThu();
            }
        }
        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (!rdoNgay.Checked && !rdoThang.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại thống kê!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql = "";

            if (rdoNgay.Checked)
            {
                sql =
                @"SELECT HD.MAHD,
                 HD.NGAYLAP,
                 NV.TENNV,
                 KH.TENKH,
                 HD.TONGTIEN
          FROM HOADON HD
          INNER JOIN NHANVIEN NV
          ON HD.MANV = NV.MANV
          INNER JOIN KHACHHANG KH
          ON HD.MAKH = KH.MAKH
          WHERE HD.NGAYLAP BETWEEN '" +
                  dtpTuNgay.Value.ToString("yyyy-MM-dd") +
                  "' AND '" +
                  dtpDenNgay.Value.ToString("yyyy-MM-dd") + "'";
            }
            else if (rdoThang.Checked)
            {
                sql =
                @"SELECT HD.MAHD,
                 HD.NGAYLAP,
                 NV.TENNV,
                 KH.TENKH,
                 HD.TONGTIEN
          FROM HOADON HD
          INNER JOIN NHANVIEN NV
          ON HD.MANV = NV.MANV
          INNER JOIN KHACHHANG KH
          ON HD.MAKH = KH.MAKH
          WHERE MONTH(HD.NGAYLAP) = " + dtpTuNgay.Value.Month +
                  " AND YEAR(HD.NGAYLAP) = " + dtpTuNgay.Value.Year;
            }

            // Thực hiện truy vấn
            HAMXULY.Truyvan(sql, dt);

            // Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                dgvDoanhThu.DataSource = null;
                lblTongDoanhThu.Text = "Tổng doanh thu: 0 VNĐ";
                return;
            }
            if (rdoNgay.Checked && dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Có dữ liệu
            dgvDoanhThu.DataSource = dt;

            dgvDoanhThu.Columns[0].HeaderText = "Mã HĐ";
            dgvDoanhThu.Columns[1].HeaderText = "Ngày lập";
            dgvDoanhThu.Columns[2].HeaderText = "Nhân viên";
            dgvDoanhThu.Columns[3].HeaderText = "Khách hàng";
            dgvDoanhThu.Columns[4].HeaderText = "Tổng tiền";

            dgvDoanhThu.EnableHeadersVisualStyles = false;
            dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

            TinhTongDoanhThu();
        }
        private void TinhTongDoanhThu()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvDoanhThu.Rows)
            {
                if (r.Cells["TONGTIEN"].Value != null &&
                    r.Cells["TONGTIEN"].Value != DBNull.Value)
                {
                    tong += Convert.ToDecimal(r.Cells["TONGTIEN"].Value);
                }
            }

            lblTongDoanhThu.Text = "Tổng doanh thu: " +
                                   tong.ToString("N0") + " VNĐ";
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();

            cboTop.Items.Add("5");
            cboTop.Items.Add("10");
            cboTop.Items.Add("20");

            cboTop.SelectedIndex = 0;

            dgvDoanhThu.DataSource = null;
            dgvTopSanPham.DataSource = null;

            lblTongDoanhThu.Text = "Tổng doanh thu: 0 VNĐ";
            // DataGridView Doanh Thu
            dgvDoanhThu.BackgroundColor = Color.White;
            dgvDoanhThu.BorderStyle = BorderStyle.None;

            dgvDoanhThu.EnableHeadersVisualStyles = false;

            dgvDoanhThu.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvDoanhThu.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvDoanhThu.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvDoanhThu.RowHeadersVisible = false;

            dgvDoanhThu.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDoanhThu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDoanhThu.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvDoanhThu.GridColor = Color.Gainsboro;

            dgvDoanhThu.ColumnHeadersHeight = 40;
            dgvDoanhThu.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvDoanhThu.RowTemplate.Height = 35;

            dgvDoanhThu.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 240, 255);

            dgvDoanhThu.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToResizeColumns = false;
            dgvDoanhThu.AllowUserToResizeRows = false;

            dgvDoanhThu.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            

            // DataGridView Top Sản Phẩm
            dgvTopSanPham.BackgroundColor = Color.White;
            dgvTopSanPham.BorderStyle = BorderStyle.None;

            dgvTopSanPham.EnableHeadersVisualStyles = false;

            dgvTopSanPham.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvTopSanPham.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvTopSanPham.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTopSanPham.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTopSanPham.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvTopSanPham.RowHeadersVisible = false;

            dgvTopSanPham.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTopSanPham.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTopSanPham.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvTopSanPham.GridColor = Color.Gainsboro;

            dgvTopSanPham.ColumnHeadersHeight = 40;
            dgvTopSanPham.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvTopSanPham.RowTemplate.Height = 35;

            dgvTopSanPham.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 240, 255);

            dgvTopSanPham.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvTopSanPham.AllowUserToAddRows = false;
            dgvTopSanPham.AllowUserToResizeColumns = false;
            dgvTopSanPham.AllowUserToResizeRows = false;

            dgvTopSanPham.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            
        }
        private void ShowTopSanPham()
        {
            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
            @"SELECT TOP 5
        SP.MASP,
        SP.TENSP,
        SUM(CT.SOLUONG) AS SOLUONGBAN,
        SUM(CT.THANHTIEN) AS DOANHTHU
      FROM CHITIETHOADON CT
      INNER JOIN SANPHAM SP
      ON CT.MASP = SP.MASP
      GROUP BY SP.MASP, SP.TENSP
      ORDER BY SOLUONGBAN DESC";

            if (HAMXULY.Truyvan(sql, dt))
            {
                dgvTopSanPham.DataSource = dt;

                dgvTopSanPham.Columns[0].HeaderText = "Mã SP";
                dgvTopSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                dgvTopSanPham.Columns[2].HeaderText = "Số lượng bán";
                dgvTopSanPham.Columns[3].HeaderText = "Doanh thu";

                dgvTopSanPham.EnableHeadersVisualStyles = false;
                dgvTopSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra chọn Top
            if (string.IsNullOrWhiteSpace(cboTop.Text))
            {
                MessageBox.Show("Vui lòng chọn số lượng Top sản phẩm!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                cboTop.Focus();
                return;
            }

            // Kiểm tra khoảng thời gian
            if (dtpTuNgayTop.Value > dtpDenNgayTop.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();

            HAMXULY.Connect();

            string sql =
            @"SELECT TOP " + cboTop.Text + @"
        SP.MASP,
        SP.TENSP,
        SUM(CT.SOLUONG) AS SOLUONGBAN,
        SUM(CT.THANHTIEN) AS DOANHTHU
      FROM CHITIETHOADON CT
      INNER JOIN SANPHAM SP
      ON CT.MASP = SP.MASP
      INNER JOIN HOADON HD
      ON CT.MAHD = HD.MAHD
      WHERE HD.NGAYLAP BETWEEN '" +
                  dtpTuNgayTop.Value.ToString("yyyy-MM-dd") +
                  "' AND '" +
                  dtpDenNgayTop.Value.ToString("yyyy-MM-dd") +
                  @"'
      GROUP BY SP.MASP, SP.TENSP
      ORDER BY SOLUONGBAN DESC";

            HAMXULY.Truyvan(sql, dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong khoảng thời gian này!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                dgvTopSanPham.DataSource = null;
                lblTongDoanhThuTop.Text = "Tổng doanh thu Top: 0 VNĐ";
                return;
            }

            dgvTopSanPham.DataSource = dt;
            TinhTongDoanhThuTop();
        }
        private void TinhTongDoanhThuTop()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvTopSanPham.Rows)
            {
                if (r.IsNewRow) continue;

                tong += Convert.ToDecimal(r.Cells["DOANHTHU"].Value);
            }

            lblTongDoanhThuTop.Text =
                "Tổng doanh thu Top: " +
                tong.ToString("N0") + " VNĐ";
        }
        private void dgvDoanhThu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void dgvTopSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // MessageBox.Show(tabControl1.SelectedIndex.ToString());

            if (tabControl1.SelectedIndex == 0)
                InDoanhThu(e);
            else
                InTopSanPham(e);

            
        }
        private void InDoanhThu(PrintPageEventArgs e)
        {
            Font tieude = new Font("Times New Roman", 18, FontStyle.Bold);
            Font font = new Font("Times New Roman", 11);

            int y = 40;

            // Tiêu đề
            e.Graphics.DrawString("BÁO CÁO DOANH THU",
                tieude,
                Brushes.Black,
                250,
                y);

            y += 45;

            // Ngày in
            e.Graphics.DrawString("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"),
                font,
                Brushes.Black,
                30,
                y);

            y += 30;

            // Tổng doanh thu
            e.Graphics.DrawString(lblTongDoanhThu.Text,
                font,
                Brushes.Black,
                30,
                y);

            y += 40;

            // Tiêu đề cột
            e.Graphics.DrawString("STT", font, Brushes.Black, 30, y);
            e.Graphics.DrawString("Mã HĐ", font, Brushes.Black, 80, y);
            e.Graphics.DrawString("Ngày lập", font, Brushes.Black, 170, y);
            e.Graphics.DrawString("Nhân viên", font, Brushes.Black, 300, y);
            e.Graphics.DrawString("Khách hàng", font, Brushes.Black, 450, y);
            e.Graphics.DrawString("Tổng tiền", font, Brushes.Black, 620, y);

            y += 25;

            e.Graphics.DrawLine(Pens.Black, 20, y, 760, y);

            y += 10;

            int stt = 1;

            foreach (DataGridViewRow r in dgvDoanhThu.Rows)
            {
                if (r.IsNewRow) continue;

                e.Graphics.DrawString(stt.ToString(), font, Brushes.Black, 30, y);
                e.Graphics.DrawString(r.Cells[0].Value.ToString(), font, Brushes.Black, 80, y);
                e.Graphics.DrawString(Convert.ToDateTime(r.Cells[1].Value).ToString("dd/MM/yyyy"), font, Brushes.Black, 170, y);
                e.Graphics.DrawString(r.Cells[2].Value.ToString(), font, Brushes.Black, 300, y);
                e.Graphics.DrawString(r.Cells[3].Value.ToString(), font, Brushes.Black, 450, y);
                e.Graphics.DrawString(
                    Convert.ToDecimal(r.Cells[4].Value).ToString("N0"),
                    font,
                    Brushes.Black,
                    620,
                    y);

                stt++;
                y += 25;
            }

            y += 20;

            e.Graphics.DrawLine(Pens.Black, 20, y, 760, y);

            y += 30;

            e.Graphics.DrawString(lblTongDoanhThu.Text,
                new Font("Times New Roman", 12, FontStyle.Bold),
                Brushes.Black,
                500,
                y);
        }
        private void InTopSanPham(PrintPageEventArgs e)
        {
            Font tieude = new Font("Times New Roman", 18, FontStyle.Bold);
            Font font = new Font("Times New Roman", 11);
            Font fontDam = new Font("Times New Roman", 12, FontStyle.Bold);

            int y = 40;

            // Tiêu đề
            e.Graphics.DrawString("BÁO CÁO TOP SẢN PHẨM",
                tieude,
                Brushes.Black,
                220,
                y);

            y += 45;

            // Ngày in
            e.Graphics.DrawString("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy"),
                font,
                Brushes.Black,
                30,
                y);

            y += 30;

            // Tổng doanh thu Top
            e.Graphics.DrawString(lblTongDoanhThuTop.Text,
                font,
                Brushes.Black,
                30,
                y);

            y += 40;

            // Tiêu đề cột
            e.Graphics.DrawString("STT", font, Brushes.Black, 30, y);
            e.Graphics.DrawString("Mã SP", font, Brushes.Black, 80, y);
            e.Graphics.DrawString("Tên sản phẩm", font, Brushes.Black, 180, y);
            e.Graphics.DrawString("SL bán", font, Brushes.Black, 470, y);
            e.Graphics.DrawString("Doanh thu", font, Brushes.Black, 570, y);

            y += 25;

            // Kẻ đường trên
            e.Graphics.DrawLine(Pens.Black, 20, y, 760, y);

            y += 10;

            int stt = 1;

            foreach (DataGridViewRow r in dgvTopSanPham.Rows)
            {
                if (r.IsNewRow) continue;

                e.Graphics.DrawString(stt.ToString(), font, Brushes.Black, 30, y);
                e.Graphics.DrawString(r.Cells[0].Value.ToString(), font, Brushes.Black, 80, y);
                e.Graphics.DrawString(r.Cells[1].Value.ToString(), font, Brushes.Black, 180, y);
                e.Graphics.DrawString(r.Cells[2].Value.ToString(), font, Brushes.Black, 470, y);

                e.Graphics.DrawString(
                    Convert.ToDecimal(r.Cells[3].Value).ToString("N0"),
                    font,
                    Brushes.Black,
                    570,
                    y);

                stt++;
                y += 25;
            }

            // Kẻ đường dưới
            y += 10;
            e.Graphics.DrawLine(Pens.Black, 20, y, 760, y);

            // Tổng doanh thu cuối trang
            y += 30;
            e.Graphics.DrawString(
                lblTongDoanhThuTop.Text,
                fontDam,
                Brushes.Black,
                500,
                y);
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                // Tab Doanh Thu
                dgvDoanhThu.DataSource = null;
                lblTongDoanhThu.Text = "Tổng doanh thu: 0 VNĐ";

                rdoNgay.Checked = false;
                rdoThang.Checked = false;
                dtpTuNgay.Value = DateTime.Now;
                dtpDenNgay.Value = DateTime.Now;
            }
            else
            {
                // Tab Top Sản Phẩm
                dgvTopSanPham.DataSource = null;
                lblTongDoanhThuTop.Text = "Tổng doanh thu Top: 0 VNĐ";

                cboTop.SelectedIndex = 0;
                dtpTuNgayTop.Value = DateTime.Now;
                dtpDenNgayTop.Value = DateTime.Now;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn thoát khỏi màn hình báo cáo không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
