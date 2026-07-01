namespace WindowsFormsApplication1
{
    partial class frmNhanvien
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
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtTNV = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.Label();
            this.Luoi_NHANVIEN = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtHuy = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_NHANVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.Controls.Add(this.txtDT);
            this.panelNhanVien.Controls.Add(this.txtDC);
            this.panelNhanVien.Controls.Add(this.txtGT);
            this.panelNhanVien.Controls.Add(this.txtNS);
            this.panelNhanVien.Controls.Add(this.txtTNV);
            this.panelNhanVien.Controls.Add(this.txtMANV);
            this.panelNhanVien.Controls.Add(this.label6);
            this.panelNhanVien.Controls.Add(this.label5);
            this.panelNhanVien.Controls.Add(this.label4);
            this.panelNhanVien.Controls.Add(this.label3);
            this.panelNhanVien.Controls.Add(this.label2);
            this.panelNhanVien.Controls.Add(this.Ma);
            this.panelNhanVien.Location = new System.Drawing.Point(11, 6);
            this.panelNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(551, 137);
            this.panelNhanVien.TabIndex = 0;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(389, 94);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 30);
            this.txtDT.TabIndex = 11;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(371, 52);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 30);
            this.txtDC.TabIndex = 10;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(371, 12);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(100, 30);
            this.txtGT.TabIndex = 9;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(129, 94);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(100, 30);
            this.txtNS.TabIndex = 8;
            // 
            // txtTNV
            // 
            this.txtTNV.Location = new System.Drawing.Point(129, 55);
            this.txtTNV.Name = "txtTNV";
            this.txtTNV.Size = new System.Drawing.Size(100, 30);
            this.txtTNV.TabIndex = 7;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(129, 15);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 30);
            this.txtMANV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // Ma
            // 
            this.Ma.AutoSize = true;
            this.Ma.Location = new System.Drawing.Point(20, 15);
            this.Ma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(130, 25);
            this.Ma.TabIndex = 0;
            this.Ma.Text = "Mã nhân viên";
            // 
            // Luoi_NHANVIEN
            // 
            this.Luoi_NHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_NHANVIEN.Location = new System.Drawing.Point(12, 164);
            this.Luoi_NHANVIEN.Name = "Luoi_NHANVIEN";
            this.Luoi_NHANVIEN.Size = new System.Drawing.Size(549, 145);
            this.Luoi_NHANVIEN.TabIndex = 1;
            this.Luoi_NHANVIEN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_NHANVIEN_CellContentClick);
            this.Luoi_NHANVIEN.Click += new System.EventHandler(this.Luoi_NHANVIEN_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(94, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 346);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(275, 346);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtHuy
            // 
            this.txtHuy.Location = new System.Drawing.Point(382, 346);
            this.txtHuy.Name = "txtHuy";
            this.txtHuy.Size = new System.Drawing.Size(75, 33);
            this.txtHuy.TabIndex = 6;
            this.txtHuy.Text = "Hủy";
            this.txtHuy.UseVisualStyleBackColor = true;
            this.txtHuy.Click += new System.EventHandler(this.txtHuy_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 402);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.Luoi_NHANVIEN);
            this.Controls.Add(this.panelNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.panelNhanVien.ResumeLayout(false);
            this.panelNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_NHANVIEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ma;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtTNV;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.DataGridView Luoi_NHANVIEN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button txtHuy;
        private System.Windows.Forms.Button button6;
    }
}