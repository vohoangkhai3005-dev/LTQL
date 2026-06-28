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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public ToolStripMenuItem MnHethong
        {
            get { return MnHeThong; }
            set {MnHeThong = value; }
        }
        
         public ToolStripMenuItem MnThemTK
        {
            get { return MnThemtk; }
            set {MnThemtk = value; }
        }
         public ToolStripMenuItem MnDoiMK
         {
             get { return MnDoimk; }
             set { MnDoimk = value; }
         }
         public ToolStripMenuItem MnDanhM
         {
             get { return MnDanhm; }
             set { MnDanhm = value; }
         }
         public ToolStripMenuItem MnCL
         {
             get { return Mncl; }
             set { Mncl = value; }
         }
         public ToolStripMenuItem MnMH
         {
             get { return Mnmh; }
             set { Mnmh = value; }
         }
         public ToolStripMenuItem MnKH
         {
             get { return Mnkh; }
             set { Mnkh = value; }
         }
         public ToolStripMenuItem MnNV
         {
             get { return Mnnv; }
             set { Mnnv = value; }
         }
         public ToolStripMenuItem MnHD
         {
             get { return Mnhd; }
             set { Mnhd = value; }
         }
         public ToolStripMenuItem MnCTHD
         {
             get { return Mncthd; }
             set { Mncthd = value; }
         }
         public ToolStripMenuItem MnTK
         {
             get { return Mntk; }
             set { Mntk = value; }
         }
         public ToolStripMenuItem MnTKKH
         {
             get { return Mntkkh; }
             set { Mntkkh = value; }
         }
         public ToolStripMenuItem MnTKMH
         {
             get { return Mntkmh; }
             set { Mntkmh = value; }
         }
         public ToolStripMenuItem MnTKHD
         {
             get { return Mntkhd; }
             set { Mntkhd = value; }
         }
         public ToolStripMenuItem MnBC
         {
             get { return Mnbc; }
             set { Mnbc = value; }
         }
         public ToolStripMenuItem MnTG
         {
             get { return Mntg; }
             set { Mntg = value; }
         }

        private void đổiMậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mnnv_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            
            f.Show();
        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mnbc_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
