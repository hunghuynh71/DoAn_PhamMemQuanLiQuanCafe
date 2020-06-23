namespace DoAn_Winform
{
    partial class frmDatHang
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
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.dtgvDatHang = new System.Windows.Forms.DataGridView();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTinHangDat = new System.Windows.Forms.GroupBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatHang)).BeginInit();
            this.grbThongTinHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(409, 570);
            this.btnTaoDonDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(91, 41);
            this.btnTaoDonDatHang.TabIndex = 9;
            this.btnTaoDonDatHang.Text = "Tạo Đơn";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = true;
            // 
            // dtgvDatHang
            // 
            this.dtgvDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenHang,
            this.colTenNhaCungCap,
            this.colSoLuong,
            this.colNgayGiao});
            this.dtgvDatHang.Location = new System.Drawing.Point(31, 114);
            this.dtgvDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDatHang.Name = "dtgvDatHang";
            this.dtgvDatHang.Size = new System.Drawing.Size(679, 411);
            this.dtgvDatHang.TabIndex = 8;
            // 
            // colTenHang
            // 
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colNgayGiao
            // 
            this.colNgayGiao.HeaderText = "Ngày giao";
            this.colNgayGiao.Name = "colNgayGiao";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(242, 570);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grbThongTinHangDat
            // 
            this.grbThongTinHangDat.Controls.Add(this.nmrSoLuong);
            this.grbThongTinHangDat.Controls.Add(this.label6);
            this.grbThongTinHangDat.Controls.Add(this.cboNhaCungCap);
            this.grbThongTinHangDat.Controls.Add(this.label5);
            this.grbThongTinHangDat.Controls.Add(this.cboTenHangHoa);
            this.grbThongTinHangDat.Controls.Add(this.label4);
            this.grbThongTinHangDat.Controls.Add(this.label9);
            this.grbThongTinHangDat.Controls.Add(this.dtpNgayGiao);
            this.grbThongTinHangDat.Location = new System.Drawing.Point(747, 114);
            this.grbThongTinHangDat.Name = "grbThongTinHangDat";
            this.grbThongTinHangDat.Size = new System.Drawing.Size(423, 327);
            this.grbThongTinHangDat.TabIndex = 25;
            this.grbThongTinHangDat.TabStop = false;
            this.grbThongTinHangDat.Text = "Thông tin hàng đặt";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(144, 188);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(258, 22);
            this.nmrSoLuong.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(144, 115);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(258, 24);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(143, 48);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(258, 24);
            this.cboTenHangHoa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày Giao Hàng:";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.Location = new System.Drawing.Point(144, 259);
            this.dtpNgayGiao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(257, 22);
            this.dtpNgayGiao.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(795, 484);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(914, 484);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1026, 484);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 41);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 52);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đơn đặt hàng";
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThongTinHangDat);
            this.Controls.Add(this.dtgvDatHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaoDonDatHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatHang)).EndInit();
            this.grbThongTinHangDat.ResumeLayout(false);
            this.grbThongTinHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.DataGridView dtgvDatHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGiao;
        private System.Windows.Forms.GroupBox grbThongTinHangDat;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTenHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayGiao;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
    }
}