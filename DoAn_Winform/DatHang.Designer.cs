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
            this.components = new System.ComponentModel.Container();
            this.grbThongTinHangDat = new System.Windows.Forms.GroupBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDsDDH = new System.Windows.Forms.DataGridView();
            this.colMaDonDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.lvwChiTietDDh = new System.Windows.Forms.ListView();
            this.colTenHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoaDDH = new System.Windows.Forms.Button();
            this.grbThongTinHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.grbThongTinHangDat.Location = new System.Drawing.Point(668, 65);
            this.grbThongTinHangDat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTinHangDat.Name = "grbThongTinHangDat";
            this.grbThongTinHangDat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTinHangDat.Size = new System.Drawing.Size(490, 168);
            this.grbThongTinHangDat.TabIndex = 25;
            this.grbThongTinHangDat.TabStop = false;
            this.grbThongTinHangDat.Text = "Thông tin hàng đặt";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(170, 100);
            this.nmrSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(200, 30);
            this.nmrSoLuong.TabIndex = 3;
            this.nmrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(380, 115);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(170, 44);
            this.cboTenHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(198, 33);
            this.cboTenHangHoa.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 65);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(380, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày Giao Hàng:";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.Location = new System.Drawing.Point(187, 162);
            this.dtpNgayGiao.Margin = new System.Windows.Forms.Padding(6);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(249, 30);
            this.dtpNgayGiao.TabIndex = 4;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(186, 103);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(250, 33);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 55);
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
            this.dtgvDsDDH.Location = new System.Drawing.Point(13, 241);
            this.dtgvDsDDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvDsDDH.Name = "dtgvDsDDH";
            this.dtgvDsDDH.ReadOnly = true;
            this.dtgvDsDDH.RowHeadersWidth = 51;
            this.dtgvDsDDH.RowTemplate.Height = 24;
            this.dtgvDsDDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDsDDH.Size = new System.Drawing.Size(647, 399);
            this.dtgvDsDDH.TabIndex = 30;
            this.dtgvDsDDH.Leave += new System.EventHandler(this.dtgvDsDDH_Leave);
            this.dtgvDsDDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDsDDH_MouseClick);
            // 
            // colMaDonDatHang
            // 
            this.colMaDonDatHang.DataPropertyName = "Maddh";
            this.colMaDonDatHang.HeaderText = "Mã đơn đặt hàng";
            this.colMaDonDatHang.MinimumWidth = 6;
            this.colMaDonDatHang.Name = "colMaDonDatHang";
            this.colMaDonDatHang.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "Ngaylap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTenNhanVienLap
            // 
            this.colTenNhanVienLap.DataPropertyName = "Tennvlap";
            this.colTenNhanVienLap.HeaderText = "Tên nhân viên lập";
            this.colTenNhanVienLap.MinimumWidth = 6;
            this.colTenNhanVienLap.Name = "colTenNhanVienLap";
            this.colTenNhanVienLap.ReadOnly = true;
            // 
            // colTrangThaiDuyet
            // 
            this.colTrangThaiDuyet.DataPropertyName = "Trangthaiduyet";
            this.colTrangThaiDuyet.HeaderText = "Trạng thái duyệt";
            this.colTrangThaiDuyet.MinimumWidth = 6;
            this.colTrangThaiDuyet.Name = "colTrangThaiDuyet";
            this.colTrangThaiDuyet.ReadOnly = true;
            this.colTrangThaiDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThaiDuyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(481, 95);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(6);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(150, 50);
            this.btnDatHang.TabIndex = 6;
            this.btnDatHang.Text = "Đặt hàng ";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // lvwChiTietDDh
            // 
            this.lvwChiTietDDh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenHH,
            this.colSoLuong});
            this.lvwChiTietDDh.HideSelection = false;
            this.lvwChiTietDDh.Location = new System.Drawing.Point(668, 241);
            this.lvwChiTietDDh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwChiTietDDh.Name = "lvwChiTietDDh";
            this.lvwChiTietDDh.Size = new System.Drawing.Size(490, 399);
            this.lvwChiTietDDh.TabIndex = 31;
            this.lvwChiTietDDh.UseCompatibleStateImageBehavior = false;
            this.lvwChiTietDDh.View = System.Windows.Forms.View.Details;
            this.lvwChiTietDDh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwChiTietDDh_MouseClick);
            // 
            // colTenHH
            // 
            this.colTenHH.Text = "Tên hàng hóa";
            this.colTenHH.Width = 180;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 176;
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Location = new System.Drawing.Point(481, 154);
            this.btnXoaDDH.Name = "btnXoaDDH";
            this.btnXoaDDH.Size = new System.Drawing.Size(150, 50);
            this.btnXoaDDH.TabIndex = 32;
            this.btnXoaDDH.Text = "Xóa đơn";
            this.btnXoaDDH.UseVisualStyleBackColor = true;
            this.btnXoaDDH.Click += new System.EventHandler(this.btnXoaDDH_Click);
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.btnXoaDDH);
            this.Controls.Add(this.lvwChiTietDDh);
            this.Controls.Add(this.dtgvDsDDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbThongTinHangDat);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNgayGiao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.grbThongTinHangDat.ResumeLayout(false);
            this.grbThongTinHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListView lvwChiTietDDh;
        private System.Windows.Forms.ColumnHeader colTenHH;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVienLap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThaiDuyet;
        private System.Windows.Forms.Button btnXoaDDH;
    }
}