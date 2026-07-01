using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{

    class HAMXULY
    {

        
        //khai bao biến toàn cục
        public static SqlConnection conn;

        //hàm kết nối
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-NA08D0R\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=123456";
            //conn.ConnectionString = @"Data Source=2C01\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=123456";
            //conn.ConnectionString = @"Data Source=KHAI\KHAI;Initial Catalog=QLBH;User ID=sa;Password=123456";
            conn.Open();// mở kết nối
        }
        public static void DisConnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        // TRUY  VẤN LÁY DL CSDL
        //LẤY DL VÀ KT 
        public static Boolean Truyvan(string strSQL, DataTable dt)
        {
            Boolean kq = false;
            SqlDataAdapter da;
            try
            {
                da = new SqlDataAdapter(strSQL, conn);
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                    kq = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");

            }
            return kq;  
        }  
        //hàm run sql
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = HAMXULY.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            cmd.Dispose();
            cmd = null;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        //LẤY GIÁ TRỊ TỪ DATAGRIDVIEW LÊN COMBOBOX
        public static string GetFieldValues(string sql)
        {
            
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

        //Lưu tài khoản đang đăng nhập
        public static string TaiKhoanDangNhap = "";
    }

   

}
