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
            this.nmrPhanTramGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemThucUong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPhanTramGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thức uống:";
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Location = new System.Drawing.Point(727, 142);
            this.nmrSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(118, 26);
            this.nmrSoLuong.TabIndex = 5;
            this.nmrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
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
            this.txtTongTien.Size = new System.Drawing.Size(155, 26);
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
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thông Tin Bàn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
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
            this.cboLoaiThucUong.Size = new System.Drawing.Size(286, 28);
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
            this.cboThucUong.Size = new System.Drawing.Size(286, 28);
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
            this.lvwHoaDon.Location = new System.Drawing.Point(576, 187);
            this.lvwHoaDon.Name = "lvwHoaDon";
            this.lvwHoaDon.Size = new System.Drawing.Size(561, 347);
            this.lvwHoaDon.TabIndex = 6;
            this.lvwHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvwHoaDon.View = System.Windows.Forms.View.Details;
            this.lvwHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvwHoaDon_SelectedIndexChanged);
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
            // nmrPhanTramGiamGia
            // 
            this.nmrPhanTramGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrPhanTramGiamGia.Location = new System.Drawing.Point(727, 572);
            this.nmrPhanTramGiamGia.Name = "nmrPhanTramGiamGia";
            this.nmrPhanTramGiamGia.Size = new System.Drawing.Size(110, 26);
            this.nmrPhanTramGiamGia.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giảm giá (%):";
            // 
            // cboChuyenBan
            // 
            this.cboChuyenBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboChuyenBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBan.FormattingEnabled = true;
            this.cboChuyenBan.Location = new System.Drawing.Point(576, 611);
            this.cboChuyenBan.Name = "cboChuyenBan";
            this.cboChuyenBan.Size = new System.Drawing.Size(139, 28);
            this.cboChuyenBan.TabIndex = 12;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGiamGia.Location = new System.Drawing.Point(726, 602);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(110, 39);
            this.btnGiamGia.TabIndex = 13;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = false;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.BackgroundImage = global::DoAn_Winform.Properties.Resources.cole;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Location = new System.Drawing.Point(1041, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 44);
            this.btnSua.TabIndex = 15;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.BackgroundImage = global::DoAn_Winform.Properties.Resources.Tru;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Location = new System.Drawing.Point(1041, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 46);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnChuyenBan.Enabled = false;
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Image = global::DoAn_Winform.Properties.Resources.caiBan;
            this.btnChuyenBan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenBan.Location = new System.Drawing.Point(576, 540);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(139, 60);
            this.btnChuyenBan.TabIndex = 10;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::DoAn_Winform.Properties.Resources.HoanThanhSize48;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(1016, 578);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(144, 60);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemThucUong
            // 
            this.btnThemThucUong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemThucUong.BackgroundImage = global::DoAn_Winform.Properties.Resources.cong;
            this.btnThemThucUong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemThucUong.Enabled = false;
            this.btnThemThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThucUong.Location = new System.Drawing.Point(929, 129);
            this.btnThemThucUong.Name = "btnThemThucUong";
            this.btnThemThucUong.Size = new System.Drawing.Size(84, 52);
            this.btnThemThucUong.TabIndex = 4;
            this.btnThemThucUong.UseVisualStyleBackColor = false;
            this.btnThemThucUong.Click += new System.EventHandler(this.btnThemThucUong_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1164, 662);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 700);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}