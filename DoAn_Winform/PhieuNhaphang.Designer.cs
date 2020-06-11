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
            this.grbThongTinHangNhap = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvPhieuNhapHang = new System.Windows.Forms.DataGridView();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhapHang = new System.Windows.Forms.Button();
            this.grbThongTinHangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phiếu Nhập Hàng";
            // 
            // grbThongTinHangNhap
            // 
            this.grbThongTinHangNhap.Controls.Add(this.txtDonGia);
            this.grbThongTinHangNhap.Controls.Add(this.nmrSoLuong);
            this.grbThongTinHangNhap.Controls.Add(this.label6);
            this.grbThongTinHangNhap.Controls.Add(this.cboNhaCungCap);
            this.grbThongTinHangNhap.Controls.Add(this.label5);
            this.grbThongTinHangNhap.Controls.Add(this.label1);
            this.grbThongTinHangNhap.Controls.Add(this.cboTenHangHoa);
            this.grbThongTinHangNhap.Controls.Add(this.label4);
            this.grbThongTinHangNhap.Location = new System.Drawing.Point(728, 110);
            this.grbThongTinHangNhap.Name = "grbThongTinHangNhap";
            this.grbThongTinHangNhap.Size = new System.Drawing.Size(377, 246);
            this.grbThongTinHangNhap.TabIndex = 34;
            this.grbThongTinHangNhap.TabStop = false;
            this.grbThongTinHangNhap.Text = "Thông tin hàng giao";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(145, 188);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(226, 22);
            this.txtDonGia.TabIndex = 4;
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(143, 136);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(228, 22);
            this.nmrSoLuong.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(143, 90);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(228, 24);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn giá:";
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(143, 48);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(228, 24);
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
            // dtgvPhieuNhapHang
            // 
            this.dtgvPhieuNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenHang,
            this.colTenNhaCungCap,
            this.colSoLuong,
            this.colDonGia});
            this.dtgvPhieuNhapHang.Location = new System.Drawing.Point(26, 110);
            this.dtgvPhieuNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPhieuNhapHang.Name = "dtgvPhieuNhapHang";
            this.dtgvPhieuNhapHang.Size = new System.Drawing.Size(667, 336);
            this.dtgvPhieuNhapHang.TabIndex = 8;
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
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(198, 489);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1008, 405);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 41);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(883, 405);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(756, 405);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhieuNhapHang
            // 
            this.btnTaoPhieuNhapHang.Location = new System.Drawing.Point(391, 489);
            this.btnTaoPhieuNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoPhieuNhapHang.Name = "btnTaoPhieuNhapHang";
            this.btnTaoPhieuNhapHang.Size = new System.Drawing.Size(121, 41);
            this.btnTaoPhieuNhapHang.TabIndex = 9;
            this.btnTaoPhieuNhapHang.Text = "Tạo phiếu nhập";
            this.btnTaoPhieuNhapHang.UseVisualStyleBackColor = true;
            // 
            // frmPhieuNhaphag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 566);
            this.Controls.Add(this.grbThongTinHangNhap);
            this.Controls.Add(this.dtgvPhieuNhapHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaoPhieuNhapHang);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhaphag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhập Hàng";
            this.grbThongTinHangNhap.ResumeLayout(false);
            this.grbThongTinHangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbThongTinHangNhap;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvPhieuNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoPhieuNhapHang;
    }
}