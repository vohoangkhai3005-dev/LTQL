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
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
        }

        private void ShowChatLieu()
        {
            //Đã có hàm kết nối, ngắt kết nối, hàm lấy dữ liệu
            //Khai báo DataTable để chứa dữ liệu 
            DataTable dtChatLieu = new DataTable();
            //Kết nối
            HAMXULY.Connect();
            //Câu lệnh truy vấn lấy dữ liệu
            string sqlChatLieu = "SELECT * FROM CHATLIEU";
            // Thực hiện truy vấn
            if (HAMXULY.Truyvan(sqlChatLieu, dtChatLieu))
            {
                LuoiChatLieu.DataSource = dtChatLieu;
                LuoiChatLieu.Columns[0].HeaderText = "Mã chất liệu";
                LuoiChatLieu.Columns[0].Width = 200;
                LuoiChatLieu.Columns[1].HeaderText = "Tên chất liệu";
                LuoiChatLieu.Columns[1].Width = 250;
                LuoiChatLieu.EnableHeadersVisualStyles = false;
                LuoiChatLieu.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            ShowChatLieu();


            TrangTri tt = new TrangTri();

            tt.BoTronButton(btnThem, 20);
            tt.BoTronButton(btnSua, 20);
            tt.BoTronButton(btnXoa, 20);
            tt.BoTronButton(btnLuu, 20);
            tt.BoTronButton(btnHuy, 20);

            btnThem.Text = "➕";
            btnXoa.Text = "🗑 ";
            btnSua.Text = "✏ ";
            btnLuu.Text = "💾 ";
            btnHuy.Text = "❌ ";

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            panelCL.BackColor = Color.Transparent;
            
        }

        private void LuoiChatLieu_Click(object sender, EventArgs e)
        {
            txtMaCL.Text = LuoiChatLieu.CurrentRow.Cells["MACHATLIEU"].Value.ToString();
            txtTenCL.Text = LuoiChatLieu.CurrentRow.Cells["TENCHATLIEU"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaCL.Text=="")
            {
                // thông báo chưa chọn mã chất liệu
                MessageBox.Show("Bạn chưa chọn mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //XÓA BẰNG LỆNH SQLDELETE
                //KẾT NỐI 
                HAMXULY.Connect();
                string sqlDelete = "DELETE FROM CHATLIEU WHERE MACHATLIEU = '" + txtMaCL.Text + "'";
                if(MessageBox.Show("Bạn có chắc muống xóa chất liệu này ?", "Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    HAMXULY.RunSQL(sqlDelete);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                // gọi lại hàm show chất liệu
                ShowChatLieu();
                // xóa dl trên textbox
                ResetText();
                //ngắc k nối
                HAMXULY.DisConnect();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panelCL.Enabled = true;
            txtMaCL.Enabled = false;
            txtTenCL.SelectAll();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelCL.Enabled = true;
            ResetText();
            txtMaCL.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void ThemChatLieu()
        {
            if (txtMaCL.Text == "")
                {
                MessageBox.Show("Vui lòng nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon. Information);
                txtMaCL.Focus();
                }
            else if (txtTenCL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCL.Focus();
            }
            else
            { 
                string SqlInsert = "INSERT INTO CHATLIEU (MACHATLIEU, TENCHATLIEU) VALUES('" + txtMaCL.Text + "', N'" + txtTenCL.Text + "')";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSQL(SqlInsert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowChatLieu();
                    ResetText();
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }

                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
                
            }///
        }
        private void SuaChatLieu()
        {
            if (txtMaCL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCL.Focus();
            }
            else if (txtTenCL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCL.Focus();
            }
            else
            {
                string SqlUpdate = "UPDATE CHATLIEU SET TENCHATLIEU = N'" + txtTenCL.Text + "' WHERE MACHATLIEU = '" + txtMaCL.Text + "'"; 
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSQL(SqlUpdate);
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowChatLieu();
                    ResetText();
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }

                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }

            }///
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
                ThemChatLieu();
            else
                SuaChatLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();

            panelCL.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void ResetText()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
