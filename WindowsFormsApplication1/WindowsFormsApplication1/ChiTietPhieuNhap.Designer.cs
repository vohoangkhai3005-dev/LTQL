
namespace WindowsFormsApplication1
{
    partial class ChiTietPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlCTPN = new System.Windows.Forms.Panel();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDGN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaPN = new System.Windows.Forms.ComboBox();
            this.cboCTPN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.pnlCTPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIÊU NHẬP KHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(18, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 32);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(122, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 32);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(232, 284);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 32);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(350, 284);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 32);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(473, 284);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 32);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(18, 339);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(580, 150);
            this.dgvCTPN.TabIndex = 25;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(473, 495);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 32);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlCTPN
            // 
            this.pnlCTPN.Controls.Add(this.cboSP);
            this.pnlCTPN.Controls.Add(this.txtThanhTien);
            this.pnlCTPN.Controls.Add(this.txtSL);
            this.pnlCTPN.Controls.Add(this.txtDGN);
            this.pnlCTPN.Controls.Add(this.label10);
            this.pnlCTPN.Controls.Add(this.label9);
            this.pnlCTPN.Controls.Add(this.label8);
            this.pnlCTPN.Controls.Add(this.label7);
            this.pnlCTPN.Controls.Add(this.label6);
            this.pnlCTPN.Controls.Add(this.cboMaPN);
            this.pnlCTPN.Controls.Add(this.cboCTPN);
            this.pnlCTPN.Controls.Add(this.label2);
            this.pnlCTPN.Location = new System.Drawing.Point(4, 79);
            this.pnlCTPN.Name = "pnlCTPN";
            this.pnlCTPN.Size = new System.Drawing.Size(603, 199);
            this.pnlCTPN.TabIndex = 28;
            // 
            // cboSP
            // 
            this.cboSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(128, 107);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(182, 28);
            this.cboSP.TabIndex = 39;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(126, 157);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(216, 26);
            this.txtThanhTien.TabIndex = 38;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(473, 101);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 26);
            this.txtSL.TabIndex = 37;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtDGN
            // 
            this.txtDGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGN.Location = new System.Drawing.Point(473, 62);
            this.txtDGN.Name = "txtDGN";
            this.txtDGN.Size = new System.Drawing.Size(121, 26);
            this.txtDGN.TabIndex = 36;
            this.txtDGN.TextChanged += new System.EventHandler(this.txtDGN_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(356, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Đơn giá nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sản phẩm nhập";
            // 
            // cboMaPN
            // 
            this.cboMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPN.FormattingEnabled = true;
            this.cboMaPN.Location = new System.Drawing.Point(141, 65);
            this.cboMaPN.Name = "cboMaPN";
            this.cboMaPN.Size = new System.Drawing.Size(91, 28);
            this.cboMaPN.TabIndex = 30;
            // 
            // cboCTPN
            // 
            this.cboCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCTPN.FormattingEnabled = true;
            this.cboCTPN.Location = new System.Drawing.Point(179, 22);
            this.cboCTPN.Name = "cboCTPN";
            this.cboCTPN.Size = new System.Drawing.Size(53, 28);
            this.cboCTPN.TabIndex = 29;
            // 
            // ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 538);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCTPN);
            this.Name = "ChiTietPhieuNhap";
            this.Text = "Form Chi tiết phiếu nhập kho";
            this.Load += new System.EventHandler(this.ChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.pnlCTPN.ResumeLayout(false);
            this.pnlCTPN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlCTPN;
        private System.Windows.Forms.ComboBox cboMaPN;
        private System.Windows.Forms.ComboBox cboCTPN;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDGN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}