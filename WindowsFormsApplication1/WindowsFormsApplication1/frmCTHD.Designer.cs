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
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtMCTHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Luoi_CTHD = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.qlbhDataSet = new WindowsFormsApplication1.qlbhDataSet();
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETHOADONTableAdapter = new WindowsFormsApplication1.qlbhDataSetTableAdapters.CHITIETHOADONTableAdapter();
            this.mACHITIETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_CTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCTHD
            // 
            this.panelCTHD.Controls.Add(this.txtSP);
            this.panelCTHD.Controls.Add(this.txtMaHD);
            this.panelCTHD.Controls.Add(this.txtSL);
            this.panelCTHD.Controls.Add(this.txtTT);
            this.panelCTHD.Controls.Add(this.txtDG);
            this.panelCTHD.Controls.Add(this.txtMCTHD);
            this.panelCTHD.Controls.Add(this.label7);
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
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(163, 129);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(121, 34);
            this.txtSP.TabIndex = 17;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(163, 74);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 34);
            this.txtMaHD.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(480, 17);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(225, 34);
            this.txtSL.TabIndex = 16;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(480, 127);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(225, 34);
            this.txtTT.TabIndex = 15;
            this.txtTT.TextChanged += new System.EventHandler(this.txtTT_TextChanged);
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(480, 72);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(225, 34);
            this.txtDG.TabIndex = 11;
            this.txtDG.TextChanged += new System.EventHandler(this.txtDG_TextChanged);
            // 
            // txtMCTHD
            // 
            this.txtMCTHD.Location = new System.Drawing.Point(145, 14);
            this.txtMCTHD.Name = "txtMCTHD";
            this.txtMCTHD.Size = new System.Drawing.Size(139, 34);
            this.txtMCTHD.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi tiết";
            // 
            // Luoi_CTHD
            // 
            this.Luoi_CTHD.AutoGenerateColumns = false;
            this.Luoi_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACHITIETDataGridViewTextBoxColumn,
            this.mAHDDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.Luoi_CTHD.DataSource = this.cHITIETHOADONBindingSource;
            this.Luoi_CTHD.Location = new System.Drawing.Point(11, 219);
            this.Luoi_CTHD.Name = "Luoi_CTHD";
            this.Luoi_CTHD.RowHeadersWidth = 51;
            this.Luoi_CTHD.Size = new System.Drawing.Size(746, 154);
            this.Luoi_CTHD.TabIndex = 1;
            this.Luoi_CTHD.Click += new System.EventHandler(this.luoi_CTHD_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(573, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 48);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 429);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 48);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(276, 429);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 48);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(431, 429);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 48);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // qlbhDataSet
            // 
            this.qlbhDataSet.DataSetName = "qlbhDataSet";
            this.qlbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.cHITIETHOADONBindingSource.DataSource = this.qlbhDataSet;
            // 
            // cHITIETHOADONTableAdapter
            // 
            this.cHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // mACHITIETDataGridViewTextBoxColumn
            // 
            this.mACHITIETDataGridViewTextBoxColumn.DataPropertyName = "MACHITIET";
            this.mACHITIETDataGridViewTextBoxColumn.HeaderText = "MACHITIET";
            this.mACHITIETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mACHITIETDataGridViewTextBoxColumn.Name = "mACHITIETDataGridViewTextBoxColumn";
            this.mACHITIETDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "MASP";
            this.mASPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            this.mASPDataGridViewTextBoxColumn.Width = 125;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.Width = 125;
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            this.tHANHTIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 519);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Luoi_CTHD);
            this.Controls.Add(this.panelCTHD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            this.panelCTHD.ResumeLayout(false);
            this.panelCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi_CTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView Luoi_CTHD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private qlbhDataSet qlbhDataSet;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private qlbhDataSetTableAdapters.CHITIETHOADONTableAdapter cHITIETHOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACHITIETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
    }
}