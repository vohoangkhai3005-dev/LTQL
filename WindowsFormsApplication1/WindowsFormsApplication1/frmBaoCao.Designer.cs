namespace WindowsFormsApplication1
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTongDoanhThuTop = new System.Windows.Forms.Label();
            this.dgvTopSanPham = new System.Windows.Forms.DataGridView();
            this.btnXemTop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.dtpDenNgayTop = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgayTop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnIn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 669);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDoanhThu);
            this.tabPage1.Controls.Add(this.lblTongDoanhThu);
            this.tabPage1.Controls.Add(this.btnXem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpDenNgay);
            this.tabPage1.Controls.Add(this.dtpTuNgay);
            this.tabPage1.Controls.Add(this.rdoThang);
            this.tabPage1.Controls.Add(this.rdoNgay);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(23, 325);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(806, 296);
            this.dgvDoanhThu.TabIndex = 9;
            this.dgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick);
            this.dgvDoanhThu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDoanhThu_RowPostPaint);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(33, 264);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(187, 29);
            this.lblTongDoanhThu.TabIndex = 8;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(318, 197);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(183, 37);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ngày ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ ngày ";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(537, 125);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 34);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(152, 121);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 34);
            this.dtpTuNgay.TabIndex = 3;
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(226, 67);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(156, 33);
            this.rdoThang.TabIndex = 2;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Theo tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(33, 67);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(148, 33);
            this.rdoNgay.TabIndex = 1;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Theo ngày";
            this.rdoNgay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại thống kê";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTongDoanhThuTop);
            this.tabPage2.Controls.Add(this.dgvTopSanPham);
            this.tabPage2.Controls.Add(this.btnXemTop);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cboTop);
            this.tabPage2.Controls.Add(this.dtpDenNgayTop);
            this.tabPage2.Controls.Add(this.dtpTuNgayTop);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhThuTop
            // 
            this.lblTongDoanhThuTop.AutoSize = true;
            this.lblTongDoanhThuTop.Location = new System.Drawing.Point(16, 281);
            this.lblTongDoanhThuTop.Name = "lblTongDoanhThuTop";
            this.lblTongDoanhThuTop.Size = new System.Drawing.Size(237, 29);
            this.lblTongDoanhThuTop.TabIndex = 15;
            this.lblTongDoanhThuTop.Text = "Tổng doanh thu Top:";
            // 
            // dgvTopSanPham
            // 
            this.dgvTopSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSanPham.Location = new System.Drawing.Point(16, 321);
            this.dgvTopSanPham.Name = "dgvTopSanPham";
            this.dgvTopSanPham.RowTemplate.Height = 24;
            this.dgvTopSanPham.Size = new System.Drawing.Size(815, 300);
            this.dgvTopSanPham.TabIndex = 14;
            this.dgvTopSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopSanPham_CellContentClick);
            // 
            // btnXemTop
            // 
            this.btnXemTop.Location = new System.Drawing.Point(318, 224);
            this.btnXemTop.Name = "btnXemTop";
            this.btnXemTop.Size = new System.Drawing.Size(121, 55);
            this.btnXemTop.TabIndex = 13;
            this.btnXemTop.Text = "Xem";
            this.btnXemTop.UseVisualStyleBackColor = true;
            this.btnXemTop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Top ";
            // 
            // cboTop
            // 
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Location = new System.Drawing.Point(32, 156);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(121, 37);
            this.cboTop.TabIndex = 11;
            // 
            // dtpDenNgayTop
            // 
            this.dtpDenNgayTop.Location = new System.Drawing.Point(516, 42);
            this.dtpDenNgayTop.Name = "dtpDenNgayTop";
            this.dtpDenNgayTop.Size = new System.Drawing.Size(200, 34);
            this.dtpDenNgayTop.TabIndex = 10;
            // 
            // dtpTuNgayTop
            // 
            this.dtpTuNgayTop.Location = new System.Drawing.Point(139, 42);
            this.dtpTuNgayTop.Name = "dtpTuNgayTop";
            this.dtpTuNgayTop.Size = new System.Drawing.Size(200, 34);
            this.dtpTuNgayTop.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đến ngày ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Từ ngày ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(334, 721);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(135, 47);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 780);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTopSanPham;
        private System.Windows.Forms.Button btnXemTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.DateTimePicker dtpDenNgayTop;
        private System.Windows.Forms.DateTimePicker dtpTuNgayTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblTongDoanhThuTop;
    }
}