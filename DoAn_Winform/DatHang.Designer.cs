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
            this.dtgvChiTietDatHang = new System.Windows.Forms.DataGridView();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinHangDat = new System.Windows.Forms.GroupBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDsDDH = new System.Windows.Forms.DataGridView();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnTaoDDH = new System.Windows.Forms.Button();
            this.colMaDonDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDatHang)).BeginInit();
            this.grbThongTinHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChiTietDatHang
            // 
            this.dtgvChiTietDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenHang,
            this.colTenNhaCungCap,
            this.colSoLuong,
            this.colNgayGiao});
            this.dtgvChiTietDatHang.Location = new System.Drawing.Point(621, 242);
            this.dtgvChiTietDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChiTietDatHang.Name = "dtgvChiTietDatHang";
            this.dtgvChiTietDatHang.Size = new System.Drawing.Size(548, 399);
            this.dtgvChiTietDatHang.TabIndex = 8;
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
            // grbThongTinHangDat
            // 
            this.grbThongTinHangDat.Controls.Add(this.nmrSoLuong);
            this.grbThongTinHangDat.Controls.Add(this.label6);
            this.grbThongTinHangDat.Controls.Add(this.btnSua);
            this.grbThongTinHangDat.Controls.Add(this.cboTenHangHoa);
            this.grbThongTinHangDat.Controls.Add(this.btnXoa);
            this.grbThongTinHangDat.Controls.Add(this.label4);
            this.grbThongTinHangDat.Controls.Add(this.btnThem);
            this.grbThongTinHangDat.Controls.Add(this.label9);
            this.grbThongTinHangDat.Controls.Add(this.dtpNgayGiao);
            this.grbThongTinHangDat.Location = new System.Drawing.Point(621, 76);
            this.grbThongTinHangDat.Name = "grbThongTinHangDat";
            this.grbThongTinHangDat.Size = new System.Drawing.Size(548, 159);
            this.grbThongTinHangDat.TabIndex = 25;
            this.grbThongTinHangDat.TabStop = false;
            this.grbThongTinHangDat.Text = "Thông tin hàng đặt";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(174, 73);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(190, 22);
            this.nmrSoLuong.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(176, 161);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(190, 24);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(415, 117);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 41);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(173, 33);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(190, 24);
            this.cboTenHangHoa.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(415, 67);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(415, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày Giao Hàng:";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.Location = new System.Drawing.Point(174, 108);
            this.dtpNgayGiao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(189, 22);
            this.dtpNgayGiao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đơn đặt hàng";
            // 
            // dtgvDsDDH
            // 
            this.dtgvDsDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonDatHang,
            this.colNgayLap,
            this.colTenNhanVienLap,
            this.colTrangThaiDuyet});
            this.dtgvDsDDH.Location = new System.Drawing.Point(12, 242);
            this.dtgvDsDDH.Name = "dtgvDsDDH";
            this.dtgvDsDDH.RowTemplate.Height = 24;
            this.dtgvDsDDH.Size = new System.Drawing.Size(602, 399);
            this.dtgvDsDDH.TabIndex = 30;
            this.dtgvDsDDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDsDDH_MouseClick);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(30, 20);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(100, 50);
            this.btnDatHang.TabIndex = 6;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnTaoDDH
            // 
            this.btnTaoDDH.Location = new System.Drawing.Point(405, 147);
            this.btnTaoDDH.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoDDH.Name = "btnTaoDDH";
            this.btnTaoDDH.Size = new System.Drawing.Size(100, 50);
            this.btnTaoDDH.TabIndex = 6;
            this.btnTaoDDH.Text = "Tạo đơn đặt hàng";
            this.btnTaoDDH.UseVisualStyleBackColor = true;
            this.btnTaoDDH.Click += new System.EventHandler(this.btnTaoDDH_Click);
            // 
            // colMaDonDatHang
            // 
            this.colMaDonDatHang.DataPropertyName = "Maddh";
            this.colMaDonDatHang.HeaderText = "Mã đơn đặt hàng";
            this.colMaDonDatHang.Name = "colMaDonDatHang";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "Ngaylap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colTenNhanVienLap
            // 
            this.colTenNhanVienLap.DataPropertyName = "Tennvlap";
            this.colTenNhanVienLap.HeaderText = "Tên nhân viên lập";
            this.colTenNhanVienLap.Name = "colTenNhanVienLap";
            // 
            // colTrangThaiDuyet
            // 
            this.colTrangThaiDuyet.DataPropertyName = "Trangthaiduyet";
            this.colTrangThaiDuyet.HeaderText = "Trạng thái duyệt";
            this.colTrangThaiDuyet.Name = "colTrangThaiDuyet";
            this.colTrangThaiDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dtgvDsDDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbThongTinHangDat);
            this.Controls.Add(this.dtgvChiTietDatHang);
            this.Controls.Add(this.btnTaoDDH);
            this.Controls.Add(this.btnDatHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDatHang)).EndInit();
            this.grbThongTinHangDat.ResumeLayout(false);
            this.grbThongTinHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiTietDatHang;
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
        private System.Windows.Forms.DataGridView dtgvDsDDH;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnTaoDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiDuyet;
    }
}