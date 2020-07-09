namespace DoAn_Winform
{
    partial class frmPhieuNhaphag
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
            this.label11 = new System.Windows.Forms.Label();
            this.lvwChiTietPhieuNhap = new System.Windows.Forms.ListView();
            this.colTenHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbTenHangHoa = new System.Windows.Forms.ComboBox();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDonDatHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvPhieuNhapHang = new System.Windows.Forms.DataGridView();
            this.colMaPNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuuDDH = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhapHang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(431, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(315, 44);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phiếu Nhập Hàng";
            // 
            // lvwChiTietPhieuNhap
            // 
            this.lvwChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenHH,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.lvwChiTietPhieuNhap.HideSelection = false;
            this.lvwChiTietPhieuNhap.Location = new System.Drawing.Point(627, 235);
            this.lvwChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwChiTietPhieuNhap.Name = "lvwChiTietPhieuNhap";
            this.lvwChiTietPhieuNhap.Size = new System.Drawing.Size(522, 404);
            this.lvwChiTietPhieuNhap.TabIndex = 18;
            this.lvwChiTietPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.lvwChiTietPhieuNhap.View = System.Windows.Forms.View.Details;
            this.lvwChiTietPhieuNhap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwChiTietPhieuNhap_MouseClick);
            // 
            // colTenHH
            // 
            this.colTenHH.Text = "Tên hàng hóa";
            this.colTenHH.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 180;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmrSoLuong);
            this.groupBox1.Controls.Add(this.cmbTenHangHoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(627, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(522, 170);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(167, 117);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(233, 26);
            this.txtGia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên hàng hóa";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(167, 77);
            this.nmrSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(235, 26);
            this.nmrSoLuong.TabIndex = 9;
            this.nmrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTenHangHoa
            // 
            this.cmbTenHangHoa.FormattingEnabled = true;
            this.cmbTenHangHoa.Location = new System.Drawing.Point(167, 34);
            this.cmbTenHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTenHangHoa.Name = "cmbTenHangHoa";
            this.cmbTenHangHoa.Size = new System.Drawing.Size(233, 28);
            this.cmbTenHangHoa.TabIndex = 8;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(163, 171);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(243, 28);
            this.cboNhaCungCap.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // cboDonDatHang
            // 
            this.cboDonDatHang.FormattingEnabled = true;
            this.cboDonDatHang.Location = new System.Drawing.Point(163, 117);
            this.cboDonDatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDonDatHang.Name = "cboDonDatHang";
            this.cboDonDatHang.Size = new System.Drawing.Size(243, 28);
            this.cboDonDatHang.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn đặt hàng";
            // 
            // dtgvPhieuNhapHang
            // 
            this.dtgvPhieuNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPNH,
            this.colMaDonDatHang,
            this.colTenNCC,
            this.colTenNhanVienLap,
            this.colTongTien});
            this.dtgvPhieuNhapHang.Location = new System.Drawing.Point(13, 235);
            this.dtgvPhieuNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvPhieuNhapHang.Name = "dtgvPhieuNhapHang";
            this.dtgvPhieuNhapHang.ReadOnly = true;
            this.dtgvPhieuNhapHang.RowHeadersWidth = 51;
            this.dtgvPhieuNhapHang.RowTemplate.Height = 24;
            this.dtgvPhieuNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuNhapHang.Size = new System.Drawing.Size(606, 404);
            this.dtgvPhieuNhapHang.TabIndex = 31;
            this.dtgvPhieuNhapHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvPhieuNhapHang_MouseClick);
            // 
            // colMaPNH
            // 
            this.colMaPNH.DataPropertyName = "Mapnh";
            this.colMaPNH.HeaderText = "Mã phiếu nhập hàng";
            this.colMaPNH.Name = "colMaPNH";
            this.colMaPNH.ReadOnly = true;
            // 
            // colMaDonDatHang
            // 
            this.colMaDonDatHang.DataPropertyName = "Maddh";
            this.colMaDonDatHang.HeaderText = "Mã đơn đặt hàng";
            this.colMaDonDatHang.MinimumWidth = 6;
            this.colMaDonDatHang.Name = "colMaDonDatHang";
            this.colMaDonDatHang.ReadOnly = true;
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "Tenncc";
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            // 
            // colTenNhanVienLap
            // 
            this.colTenNhanVienLap.DataPropertyName = "Tennvlap";
            this.colTenNhanVienLap.HeaderText = "Tên nhân viên lập";
            this.colTenNhanVienLap.MinimumWidth = 6;
            this.colTenNhanVienLap.Name = "colTenNhanVienLap";
            this.colTenNhanVienLap.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "Tongtien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // btnTraCuuDDH
            // 
            this.btnTraCuuDDH.Image = global::DoAn_Winform.Properties.Resources.timkiemSize48;
            this.btnTraCuuDDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuDDH.Location = new System.Drawing.Point(442, 157);
            this.btnTraCuuDDH.Name = "btnTraCuuDDH";
            this.btnTraCuuDDH.Size = new System.Drawing.Size(172, 54);
            this.btnTraCuuDDH.TabIndex = 33;
            this.btnTraCuuDDH.Text = "Tk đơn đặt hàng";
            this.btnTraCuuDDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraCuuDDH.UseVisualStyleBackColor = true;
            this.btnTraCuuDDH.Click += new System.EventHandler(this.btnTraCuuDDH_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::DoAn_Winform.Properties.Resources.cong;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(412, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::DoAn_Winform.Properties.Resources.cole;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(412, 114);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::DoAn_Winform.Properties.Resources.Tru;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(412, 62);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoPhieuNhapHang
            // 
            this.btnTaoPhieuNhapHang.Image = global::DoAn_Winform.Properties.Resources.HoanThanhSize48;
            this.btnTaoPhieuNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuNhapHang.Location = new System.Drawing.Point(442, 87);
            this.btnTaoPhieuNhapHang.Margin = new System.Windows.Forms.Padding(6);
            this.btnTaoPhieuNhapHang.Name = "btnTaoPhieuNhapHang";
            this.btnTaoPhieuNhapHang.Size = new System.Drawing.Size(172, 54);
            this.btnTaoPhieuNhapHang.TabIndex = 9;
            this.btnTaoPhieuNhapHang.Text = "Tạo phiếu nhập";
            this.btnTaoPhieuNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPhieuNhapHang.UseVisualStyleBackColor = true;
            this.btnTaoPhieuNhapHang.Click += new System.EventHandler(this.btnTaoPhieuNhapHang_Click);
            // 
            // frmPhieuNhaphag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1164, 662);
            this.Controls.Add(this.btnTraCuuDDH);
            this.Controls.Add(this.dtgvPhieuNhapHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwChiTietPhieuNhap);
            this.Controls.Add(this.cboDonDatHang);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.btnTaoPhieuNhapHang);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "frmPhieuNhaphag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.frmPhieuNhaphag_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoPhieuNhapHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvwChiTietPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.ComboBox cmbTenHangHoa;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colTenHH;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader colGia;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cboDonDatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvPhieuNhapHang;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Button btnTraCuuDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
    }
}