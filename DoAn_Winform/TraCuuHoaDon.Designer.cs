namespace DoAn_Winform
{
    partial class frmHoaDon
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
            this.dtgvTraCuuHoaDon = new System.Windows.Forms.DataGridView();
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTienThuDuoc = new System.Windows.Forms.TextBox();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.dtgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTraCuuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTraCuuHoaDon
            // 
            this.dtgvTraCuuHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTraCuuHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTraCuuHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colThoiGianLap,
            this.colBan,
            this.colNhanVienLap,
            this.colSoTien});
            this.dtgvTraCuuHoaDon.Location = new System.Drawing.Point(13, 198);
            this.dtgvTraCuuHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTraCuuHoaDon.Name = "dtgvTraCuuHoaDon";
            this.dtgvTraCuuHoaDon.Size = new System.Drawing.Size(677, 442);
            this.dtgvTraCuuHoaDon.TabIndex = 4;
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.Location = new System.Drawing.Point(362, 110);
            this.btnSearchHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(112, 37);
            this.btnSearchHD.TabIndex = 3;
            this.btnSearchHD.Text = "Tìm Kiếm";
            this.btnSearchHD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tra cứu hóa đơn";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(107, 95);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(107, 141);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lượng hóa đơn";
            // 
            // txtSoLuongHoaDon
            // 
            this.txtSoLuongHoaDon.Location = new System.Drawing.Point(820, 92);
            this.txtSoLuongHoaDon.Name = "txtSoLuongHoaDon";
            this.txtSoLuongHoaDon.Size = new System.Drawing.Size(166, 22);
            this.txtSoLuongHoaDon.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền thu được";
            // 
            // txtSoTienThuDuoc
            // 
            this.txtSoTienThuDuoc.Location = new System.Drawing.Point(820, 136);
            this.txtSoTienThuDuoc.Name = "txtSoTienThuDuoc";
            this.txtSoTienThuDuoc.Size = new System.Drawing.Size(166, 22);
            this.txtSoTienThuDuoc.TabIndex = 7;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(1030, 110);
            this.btnXuatBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(112, 37);
            this.btnXuatBaoCao.TabIndex = 8;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietHoaDon
            // 
            this.dtgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenThucUong,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dtgvChiTietHoaDon.Location = new System.Drawing.Point(707, 198);
            this.dtgvChiTietHoaDon.Name = "dtgvChiTietHoaDon";
            this.dtgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgvChiTietHoaDon.Size = new System.Drawing.Size(463, 442);
            this.dtgvChiTietHoaDon.TabIndex = 5;
            // 
            // colTenThucUong
            // 
            this.colTenThucUong.HeaderText = "Tên thức uống";
            this.colTenThucUong.Name = "colTenThucUong";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng ";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            // 
            // colThoiGianLap
            // 
            this.colThoiGianLap.HeaderText = "Thời gian lập";
            this.colThoiGianLap.Name = "colThoiGianLap";
            // 
            // colBan
            // 
            this.colBan.HeaderText = "Bàn";
            this.colBan.Name = "colBan";
            // 
            // colNhanVienLap
            // 
            this.colNhanVienLap.HeaderText = "Nhân viên lập";
            this.colNhanVienLap.Name = "colNhanVienLap";
            // 
            // colSoTien
            // 
            this.colSoTien.HeaderText = "Số tiền";
            this.colSoTien.Name = "colSoTien";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dtgvChiTietHoaDon);
            this.Controls.Add(this.txtSoTienThuDuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuongHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnSearchHD);
            this.Controls.Add(this.dtgvTraCuuHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTraCuuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTraCuuHoaDon;
        private System.Windows.Forms.Button btnSearchHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTienThuDuoc;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.DataGridView dtgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
    }
}