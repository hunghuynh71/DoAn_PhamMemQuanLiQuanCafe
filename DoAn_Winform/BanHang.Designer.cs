namespace DoAn_Winform
{
    partial class frmBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemThucUong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoaiThucUong = new System.Windows.Forms.ComboBox();
            this.cboThucUong = new System.Windows.Forms.ComboBox();
            this.lvwHoaDon = new System.Windows.Forms.ListView();
            this.colTenTU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaTU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.nmrPhanTramGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnGiamGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPhanTramGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thức uống:";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(1032, 87);
            this.nmrSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(118, 30);
            this.nmrSoLuong.TabIndex = 5;
            this.nmrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemThucUong
            // 
            this.btnThemThucUong.BackColor = System.Drawing.Color.Silver;
            this.btnThemThucUong.Enabled = false;
            this.btnThemThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThucUong.Location = new System.Drawing.Point(1032, 14);
            this.btnThemThucUong.Name = "btnThemThucUong";
            this.btnThemThucUong.Size = new System.Drawing.Size(118, 53);
            this.btnThemThucUong.TabIndex = 4;
            this.btnThemThucUong.Text = "Thêm";
            this.btnThemThucUong.UseVisualStyleBackColor = false;
            this.btnThemThucUong.Click += new System.EventHandler(this.btnThemThucUong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(858, 611);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(168, 30);
            this.txtTongTien.TabIndex = 7;
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.flpBan.Location = new System.Drawing.Point(14, 43);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(556, 598);
            this.flpBan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thông Tin Bàn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại thức uống:";
            // 
            // cboLoaiThucUong
            // 
            this.cboLoaiThucUong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLoaiThucUong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLoaiThucUong.FormattingEnabled = true;
            this.cboLoaiThucUong.Items.AddRange(new object[] {
            "Tất Cả"});
            this.cboLoaiThucUong.Location = new System.Drawing.Point(727, 86);
            this.cboLoaiThucUong.Name = "cboLoaiThucUong";
            this.cboLoaiThucUong.Size = new System.Drawing.Size(286, 33);
            this.cboLoaiThucUong.TabIndex = 2;
            this.cboLoaiThucUong.TextChanged += new System.EventHandler(this.cboLoaiThucUong_TextChanged);
            this.cboLoaiThucUong.Click += new System.EventHandler(this.cboLoaiThucUong_Click);
            // 
            // cboThucUong
            // 
            this.cboThucUong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboThucUong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboThucUong.FormattingEnabled = true;
            this.cboThucUong.Location = new System.Drawing.Point(727, 25);
            this.cboThucUong.Name = "cboThucUong";
            this.cboThucUong.Size = new System.Drawing.Size(286, 33);
            this.cboThucUong.TabIndex = 3;
            this.cboThucUong.TextChanged += new System.EventHandler(this.cboThucUong_TextChanged);
            // 
            // lvwHoaDon
            // 
            this.lvwHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenTU,
            this.colSL,
            this.colGiaTU,
            this.colThanhTien});
            this.lvwHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHoaDon.HideSelection = false;
            this.lvwHoaDon.Location = new System.Drawing.Point(589, 145);
            this.lvwHoaDon.Name = "lvwHoaDon";
            this.lvwHoaDon.Size = new System.Drawing.Size(561, 389);
            this.lvwHoaDon.TabIndex = 6;
            this.lvwHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvwHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // colTenTU
            // 
            this.colTenTU.Text = "Tên thức uống";
            // 
            // colSL
            // 
            this.colSL.Text = "Số lượng ";
            // 
            // colGiaTU
            // 
            this.colGiaTU.Text = "Giá";
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Silver;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1032, 569);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(118, 72);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.Silver;
            this.btnChuyenBan.Enabled = false;
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(589, 540);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(126, 60);
            this.btnChuyenBan.TabIndex = 10;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // nmrPhanTramGiamGia
            // 
            this.nmrPhanTramGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPhanTramGiamGia.Location = new System.Drawing.Point(727, 565);
            this.nmrPhanTramGiamGia.Name = "nmrPhanTramGiamGia";
            this.nmrPhanTramGiamGia.Size = new System.Drawing.Size(110, 30);
            this.nmrPhanTramGiamGia.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giảm giá (%):";
            // 
            // cboChuyenBan
            // 
            this.cboChuyenBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboChuyenBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBan.FormattingEnabled = true;
            this.cboChuyenBan.Location = new System.Drawing.Point(589, 608);
            this.cboChuyenBan.Name = "cboChuyenBan";
            this.cboChuyenBan.Size = new System.Drawing.Size(126, 33);
            this.cboChuyenBan.TabIndex = 12;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(726, 605);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(110, 39);
            this.btnGiamGia.TabIndex = 13;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.btnGiamGia);
            this.Controls.Add(this.cboChuyenBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrPhanTramGiamGia);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lvwHoaDon);
            this.Controls.Add(this.cboThucUong);
            this.Controls.Add(this.cboLoaiThucUong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.btnThemThucUong);
            this.Controls.Add(this.nmrSoLuong);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPhanTramGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.Button btnThemThucUong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiThucUong;
        private System.Windows.Forms.ComboBox cboThucUong;
        private System.Windows.Forms.ListView lvwHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ColumnHeader colTenTU;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colGiaTU;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.NumericUpDown nmrPhanTramGiamGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChuyenBan;
        private System.Windows.Forms.Button btnGiamGia;
    }
}