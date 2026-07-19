using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;


namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtTDN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean kiemtrathongtin()
        {
            if (txtTDN.Text == "")
            {
                MessageBox.Show("Chưa có tên đăng nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTDN.Focus();
                return false;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Chưa có mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMK.Focus();
                return false;
            }
            return true;
        }
        private void btnDN_Click(object sender, EventArgs e)
        {

            
            if (kiemtrathongtin())
            {
                /// Kết nối CSDL
                HAMXULY.Connect();

                string TAIKHOANG = txtTDN.Text.Trim();
                string MATKHAU = txtMK.Text.Trim();

                // Kiểm tra tài khoản trước
                string sqlKT = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = '" + TAIKHOANG + "'";
                DataTable dtKT = new DataTable();

                string mkDB = "";

                if (HAMXULY.Truyvan(sqlKT, dtKT))
                {
                    mkDB = dtKT.Rows[0]["MATKHAU"].ToString().Trim();
                    // kiểm tra đã mã hóa chx

                    //MessageBox.Show("Mật khẩu trong DB:\n" + mkDB);

                    // Nếu mật khẩu đã mã hóa SHA256
                    if (mkDB.Length == 64)
                    {
                        MATKHAU = HAMXULY.MaHoaSHA256(MATKHAU);
                    }
                }
                string sql1 = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = '" + TAIKHOANG + "' AND MATKHAU = '" + MATKHAU + "'";
                string sql2 = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = '" + TAIKHOANG + "' AND MATKHAU != '" + MATKHAU + "'";
                DataTable dtlg = new DataTable();
                frmMain frmM = new frmMain();


                string NHOMQUYEN = "";
                string IDUSER = "";

                

                    if (HAMXULY.Truyvan(sql1, dtlg))
                    {
                        

                        HAMXULY.TaiKhoanDangNhap = TAIKHOANG;

                        // Nếu mật khẩu cũ (chưa mã hóa) thì tự động mã hóa và cập nhật
                        if (mkDB != "" && mkDB.Length != 64)
                        {
                            string hash = HAMXULY.MaHoaSHA256(txtMK.Text.Trim());

                            string sqlUpdate = "UPDATE TAIKHOAN SET MATKHAU = '" + hash +
                                               "' WHERE TAIKHOANG = '" + TAIKHOANG + "'";

                            HAMXULY.RunSQL(sqlUpdate);
                            mkDB = hash;
                        }

                        NHOMQUYEN = dtlg.Rows[0]["NHOM"].ToString().Trim();
                        IDUSER = dtlg.Rows[0]["IDUSER"].ToString().Trim();

                        
                    if (NHOMQUYEN == "SuperAdmin")
                    {
                        frmM.MnHethong.Enabled = true;
                        frmM.MnThemTK.Enabled = true;
                        frmM.MnDoiMK.Enabled = true;

                        frmM.MnDanhM.Enabled = true;
                        frmM.MnCL.Enabled = true;
                        frmM.MnMH.Enabled = true;
                        frmM.MnKH.Enabled = true;
                        frmM.MnNV.Enabled = true;

                        frmM.MnHD.Enabled = true;
                        //frmM.MnCTHD.Enabled = true;
                        frmM.MnLHD.Enabled = true;

                        frmM.MnTK.Enabled = true;
                        frmM.MnTKKH.Enabled = true;
                        frmM.MnTKMH.Enabled = true;
                        frmM.MnTKHD.Enabled = true;

                        frmM.MnBC.Enabled = true;
                        frmM.MnLBC.Enabled = true;
                        frmM.MnTG.Enabled = true;

                        frmM.MnQP.Enabled = true;
                        frmM.MnPNK.Enabled = true;
                      

                        frmM.MnBH.Enabled = true;
                        frmM.Mnctpn.Enabled = true;
                        frmM.Show();
                        this.Hide();
                    }
                    else
                    {
                        // User -> phân quyền theo bảng VAITRO
                        string sql3 = "SELECT * FROM VAITRO WHERE IDUSER = '" + IDUSER + "'";
                        DataTable dtPQ = new DataTable();

                        if (HAMXULY.Truyvan(sql3, dtPQ))
                        {
                            //frmM.Show();

                            foreach (DataRow row in dtPQ.Rows)
                            {
                                if (row["IDCN"].ToString().Trim() == "1")
                                {
                                    frmM.MnThemTK.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "2")
                                {
                                    frmM.MnDoiMK.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "3") // QL danh mục
                                {
                                    frmM.MnDMSP.Enabled = true;  
                                }

                                if (row["IDCN"].ToString().Trim() == "4")
                                {
                                    frmM.MnMH.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "5")
                                {
                                    frmM.MnNV.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "6")
                                {
                                    frmM.MnKH.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "7")
                                {
                                    // Nếu có menu Hóa đơn thì mở ở đây
                                     frmM.MnLHD.Enabled = true;
                                }

                               // if (row["IDCN"].ToString().Trim() == "8")
                               // {
                                //    frmM.MnCTHD.Enabled = true;
                               // }

                                if (row["IDCN"].ToString().Trim() == "9")
                                {
                                    frmM.MnTKHD.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "10")
                                {
                                    frmM.MnTKKH.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "11")
                                {
                                    frmM.MnTKMH.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "12")
                                {
                                    frmM.MnBC.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "13")
                                {
                                    frmM.MnTG.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "12") //Báo cáo doanh thu
                                {
                                    frmM.MnLBC.Enabled = true;
                                }

                                // Giữ nguyên những menu chưa có trong bảng CHUCNANG
                                if (row["IDCN"].ToString().Trim() == "15")
                                {
                                    frmM.MnPNK.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "16")
                                {
                                    frmM.Mnctpn.Enabled = true;
                                }

                                if (row["IDCN"].ToString().Trim() == "17")
                                {
                                    frmM.MnTK.Enabled = true;
                                }
                            }
                            frmM.Show();
                            this.Hide();
                        }


                    }

                }
                else if(HAMXULY.Truyvan(sql2,dtlg))
                {
                    MessageBox.Show("Bạn sai mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTDN.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMK.Focus();
                    return;
                }
            }
        }

        //menu
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           txtMK.UseSystemPasswordChar = !chbHMK.Checked;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
