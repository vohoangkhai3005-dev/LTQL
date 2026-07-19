namespace WindowsFormsApplication1
{
    partial class frmCTHD
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
            this.components = new System.ComponentModel.Container();
            this.panelCTHD = new System.Windows.Forms.Panel();
            this.cboMH = new System.Windows.Forms.ComboBox();
            this.cboMHD = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtMCTHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panelCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCTHD
            // 
            this.panelCTHD.Controls.Add(this.cboMH);
            this.panelCTHD.Controls.Add(this.cboMHD);
            this.panelCTHD.Controls.Add(this.txtSL);
            this.panelCTHD.Controls.Add(this.txtDG);
            this.panelCTHD.Controls.Add(this.txtMCTHD);
            this.panelCTHD.Controls.Add(this.label5);
            this.panelCTHD.Controls.Add(this.label4);
            this.panelCTHD.Controls.Add(this.label3);
            this.panelCTHD.Controls.Add(this.label2);
            this.panelCTHD.Controls.Add(this.label1);
            this.panelCTHD.Location = new System.Drawing.Point(11, 10);
            this.panelCTHD.Name = "panelCTHD";
            this.panelCTHD.Size = new System.Drawing.Size(746, 191);
            this.panelCTHD.TabIndex = 0;
            // 
            // cboMH
            // 
            this.cboMH.FormattingEnabled = true;
            this.cboMH.Location = new System.Drawing.Point(145, 129);
            this.cboMH.Name = "cboMH";
            this.cboMH.Size = new System.Drawing.Size(560, 32);
            this.cboMH.TabIndex = 18;
            this.cboMH.SelectedIndexChanged += new System.EventHandler(this.cboMH_SelectedIndexChanged);
            // 
            // cboMHD
            // 
            this.cboMHD.FormattingEnabled = true;
            this.cboMHD.Location = new System.Drawing.Point(145, 74);
            this.cboMHD.Name = "cboMHD";
            this.cboMHD.Size = new System.Drawing.Size(139, 32);
            this.cboMHD.TabIndex = 17;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(480, 17);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(225, 29);
            this.txtSL.TabIndex = 16;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(480, 72);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(225, 29);
            this.txtDG.TabIndex = 11;
            // 
            // txtMCTHD
            // 
            this.txtMCTHD.Location = new System.Drawing.Point(145, 14);
            this.txtMCTHD.Name = "txtMCTHD";
            this.txtMCTHD.Size = new System.Drawing.Size(139, 29);
            this.txtMCTHD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi tiết";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(129, 437);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(225, 29);
            this.txtTT.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(11, 219);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.Size = new System.Drawing.Size(746, 154);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Luoi_CTHD_CellClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(668, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(12, 379);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 31);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(129, 378);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 32);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(257, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 31);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(531, 377);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 32);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.panelCTHD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            this.panelCTHD.ResumeLayout(false);
            this.panelCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCTHD;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtMCTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboMH;
        private System.Windows.Forms.ComboBox cboMHD;
    }
}