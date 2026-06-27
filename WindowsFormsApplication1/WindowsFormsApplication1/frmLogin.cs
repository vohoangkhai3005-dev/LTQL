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
                //kn csdl
                HAMXULY.Connect();
                string TAIKHOANG = txtTDN.Text.Trim(), MATKHAU = txtMK.Text.Trim();
                string sql1 = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = '" + TAIKHOANG + "' AND MATKHAU = '" + MATKHAU + "'";
                string sql2 = "SELECT * FROM TAIKHOAN WHERE TAIKHOANG = '" + TAIKHOANG + "' AND MATKHAU != '" + MATKHAU + "'";
                DataTable dtlg = new DataTable();
                frmMain frmM = new frmMain();



                if (HAMXULY.Truyvan(sql1, dtlg))
                {
                    string NHOMQUYEN = dtlg.Rows[0]["NHOM"].ToString().Trim();
                    
                    string IDUSER = dtlg.Rows[0]["IDUSER"].ToString().Trim();
                    if (NHOMQUYEN == "Admin")
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
                        frmM.MnCTHD.Enabled = true;

                        frmM.MnTK.Enabled = true;
                        frmM.MnTKKH.Enabled = true;
                        frmM.MnTKMH.Enabled = true;
                        frmM.MnTKHD.Enabled = true;

                        frmM.MnBC.Enabled = true;
                        frmM.MnTG.Enabled = true;

                        // Kiểm tra sau khi đã bật
                        MessageBox.Show(frmM.MnThemTK.Enabled.ToString());

                        frmM.Show();
                        this.Hide();
                    }
                    else
                    {
                        string sql3 = "SELECT * FROM VAITRO WHERE IDUSER = '" + IDUSER + "'";
                        DataTable dtPQ = new DataTable();

                        if (HAMXULY.Truyvan(sql3, dtPQ))
                        {
                            frmM.Show();

                            foreach (DataRow row in dtPQ.Rows)
                            {
                                if (row["IDCN"].ToString().Trim() == "1")
                                {
                                    frmM.MnHethong.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "2")
                                {
                                    frmM.MnThemTK.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "3")
                                {
                                    frmM.MnDoiMK.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "4")
                                {
                                    frmM.MnDanhM.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "5")
                                {
                                    frmM.MnCL.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "6")
                                {
                                    frmM.MnMH.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "7")
                                {
                                    frmM.MnKH.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "8")
                                {
                                    frmM.MnNV.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "9")
                                {
                                    frmM.MnCTHD.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "10")
                                {
                                    frmM.MnTK.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "11")
                                {
                                    frmM.MnTKKH.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "12")
                                {

                                    frmM.MnTKMH.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "13")
                                {
                                    frmM.MnTKHD.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "14")
                                {
                                    frmM.MnBC.Enabled = true;
                                }
                                if (row["IDCN"].ToString().Trim() == "15")
                                {
                                    frmM.MnTG.Enabled = true;
                                }
                            }
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
       
    }
}
