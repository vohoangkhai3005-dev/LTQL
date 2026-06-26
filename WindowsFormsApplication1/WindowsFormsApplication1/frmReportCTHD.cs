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
    public partial class frmReportCTHD : Form
    {
        public frmReportCTHD()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReportCTHD_Load(object sender, EventArgs e)
        {
            HAMXULY.Connect();
            string sql = "SELECT * FROM HOADON";
            HAMXULY.FillCombo(sql, cboHoaDon, "MAHD", "MAHD");

            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet2.INCHITIET' table. You can move, or remove it, as needed.
            this.INCHITIETTableAdapter.Fill(this.QLBHDataSet2.INCHITIET, cboHoaDon.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
