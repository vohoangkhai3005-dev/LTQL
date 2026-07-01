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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            rtbNoiDung.Clear();

            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.BorderStyle = BorderStyle.None;
            rtbNoiDung.BackColor = Color.White;
            rtbNoiDung.Font = new Font("Segoe UI", 11);
            rtbNoiDung.ForeColor = Color.Black;

            // ===== TIÊU ĐỀ =====
            rtbNoiDung.SelectionIndent = 25;

            rtbNoiDung.SelectionFont = new Font("Segoe UI", 18, FontStyle.Bold);
            rtbNoiDung.SelectionColor = Color.FromArgb(0, 102, 204);
            rtbNoiDung.AppendText("PHẦN MỀM QUẢN LÝ BÁN HÀNG\n\n");

            // ===== GIỚI THIỆU =====
            rtbNoiDung.SelectionFont = new Font("Segoe UI", 11);
            rtbNoiDung.SelectionColor = Color.Black;
            rtbNoiDung.AppendText("Phần mềm được xây dựng nhằm hỗ trợ cửa hàng quản lý hoạt động bán hàng một cách nhanh chóng và hiệu quả.\n\n");

            // ===== THÔNG TIN =====
            rtbNoiDung.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
            rtbNoiDung.SelectionColor = Color.FromArgb(0, 102, 204);
            rtbNoiDung.AppendText("THÔNG TIN PHẦN MỀM\n");

            rtbNoiDung.SelectionFont = new Font("Segoe UI", 11);
            rtbNoiDung.SelectionColor = Color.Black;
            rtbNoiDung.AppendText("---------------------------------------------\n");
            rtbNoiDung.AppendText("• Tên phần mềm : Quản lý bán hàng WinForms\n");
            rtbNoiDung.AppendText("• Phiên bản     : 1.0\n");
            rtbNoiDung.AppendText("• Ngôn ngữ      : C# WinForms (.NET Framework)\n");
            rtbNoiDung.AppendText("• Cơ sở dữ liệu : SQL Server\n\n");

            // ===== CHỨC NĂNG =====
            rtbNoiDung.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
            rtbNoiDung.SelectionColor = Color.FromArgb(0, 102, 204);
            rtbNoiDung.AppendText("CHỨC NĂNG CHÍNH\n");

            rtbNoiDung.SelectionFont = new Font("Segoe UI", 11);
            rtbNoiDung.SelectionColor = Color.Black;
            rtbNoiDung.AppendText("---------------------------------------------\n");
            rtbNoiDung.AppendText("✔ Quản lý khách hàng\n");
            rtbNoiDung.AppendText("✔ Quản lý sản phẩm\n");
            rtbNoiDung.AppendText("✔ Quản lý hóa đơn\n");
            rtbNoiDung.AppendText("✔ Tìm kiếm dữ liệu\n");
            rtbNoiDung.AppendText("✔ Báo cáo doanh thu\n\n");

            // ===== TÁC GIẢ =====
            rtbNoiDung.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
            rtbNoiDung.SelectionColor = Color.FromArgb(0, 102, 204);
            rtbNoiDung.AppendText("THÔNG TIN TÁC GIẢ\n");

            rtbNoiDung.SelectionFont = new Font("Segoe UI", 11);
            rtbNoiDung.SelectionColor = Color.Black;
            rtbNoiDung.AppendText("---------------------------------------------\n");
            rtbNoiDung.AppendText("• Người thực hiện : Nguyễn Văn A\n");
            rtbNoiDung.AppendText("• Trường          : Cao đẳng Ctim \n");
            rtbNoiDung.AppendText("• Email           : nguyenvana@gmail.com\n");
            rtbNoiDung.AppendText("• Điện thoại      : 09xx.xxx.xxx\n\n");

            // ===== LỜI CẢM ƠN =====
            rtbNoiDung.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
            rtbNoiDung.SelectionColor = Color.OrangeRed;
            rtbNoiDung.AppendText("LỜI CẢM ƠN\n");

            rtbNoiDung.SelectionFont = new Font("Segoe UI", 11);
            rtbNoiDung.SelectionColor = Color.Black;
            rtbNoiDung.AppendText("---------------------------------------------\n");
            rtbNoiDung.AppendText("Cảm ơn quý thầy cô và người dùng đã sử dụng phần mềm.\n");
            rtbNoiDung.AppendText("Mọi góp ý xin vui lòng liên hệ nhóm phát triển.\n\n\n\n\n");

            this.ActiveControl = btnThoat;
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
    }
}
