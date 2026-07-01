using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACK
{
    public partial class frmInHoaDon : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet2.INCHITIETHD' table. You can move, or remove it, as needed.
            this.INCHITIETHDTableAdapter.Fill(this.qlbhDataSet2.INCHITIETHD);

            this.rpvHoaDon.RefreshReport();

            this.Text = $"Hóa đơn #{MaHD}";
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    DataSet ds = new DataSet();

                    // Lấy thông tin hóa đơn chính
                    string sqlHD = @"
                        SELECT 
                            MaHD, 
                            NgayLap, 
                            NhanVien,
                            TongTien,
                            GiamGia,
                            ThanhTien,
                            ISNULL((SELECT TenKH FROM KhachHang WHERE MaKH = HoaDon.MaKH), N'Khách lẻ') as TenKH,
                            ISNULL((SELECT SDT FROM KhachHang WHERE MaKH = HoaDon.MaKH), '') as SDT
                        FROM HoaDon 
                        WHERE MaHD = @mahd";

                    SqlDataAdapter daHD = new SqlDataAdapter(sqlHD, conn);
                    daHD.SelectCommand.Parameters.AddWithValue("@mahd", MaHD);
                    daHD.Fill(ds, "HoaDon");

                    // Lấy chi tiết sản phẩm
                    string sqlCT = @"
                        SELECT 
                            ct.MaSP,
                            sp.TenSP,
                            ct.SoLuong,
                            ct.DonGia,
                            ct.ThanhTien
                        FROM ChiTietHoaDon ct
                        JOIN SanPham sp ON ct.MaSP = sp.MaSP
                        WHERE ct.MaHD = @mahd";

                    SqlDataAdapter daCT = new SqlDataAdapter(sqlCT, conn);
                    daCT.SelectCommand.Parameters.AddWithValue("@mahd", MaHD);
                    daCT.Fill(ds, "ChiTietHoaDon");

                    // Gán dữ liệu vào ReportViewer
                    rpvHoaDon.LocalReport.ReportPath = @"Reports\rptHoaDon.rdlc"; // ← Đường dẫn file report

                    rpvHoaDon.LocalReport.DataSources.Clear();
                    rpvHoaDon.LocalReport.DataSources.Add(new ReportDataSource("dsHoaDon", ds.Tables["HoaDon"]));
                    rpvHoaDon.LocalReport.DataSources.Add(new ReportDataSource("dsChiTietHoaDon", ds.Tables["ChiTietHoaDon"]));

                    rpvHoaDon.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                rpvHoaDon.PrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
