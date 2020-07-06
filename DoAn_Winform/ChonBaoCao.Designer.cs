namespace DoAn_Winform
{
    partial class frmChonBaoCao
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
            this.radBCDoanhThuTrongKhoan = new System.Windows.Forms.RadioButton();
            this.radBCDoanhThuTrongNgay = new System.Windows.Forms.RadioButton();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radBCDoanhThuTungSPTrongThang = new System.Windows.Forms.RadioButton();
            this.radBCChiTieuTrongNgay = new System.Windows.Forms.RadioButton();
            this.radBCChiTieuTrongKhoan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radBCDoanhThuTrongKhoan
            // 
            this.radBCDoanhThuTrongKhoan.AutoSize = true;
            this.radBCDoanhThuTrongKhoan.Location = new System.Drawing.Point(228, 246);
            this.radBCDoanhThuTrongKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTrongKhoan.Name = "radBCDoanhThuTrongKhoan";
            this.radBCDoanhThuTrongKhoan.Size = new System.Drawing.Size(231, 29);
            this.radBCDoanhThuTrongKhoan.TabIndex = 0;
            this.radBCDoanhThuTrongKhoan.TabStop = true;
            this.radBCDoanhThuTrongKhoan.Text = "Doanh thu trong khoản";
            this.radBCDoanhThuTrongKhoan.UseVisualStyleBackColor = true;
            this.radBCDoanhThuTrongKhoan.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTrongKhoan_CheckedChanged);
            // 
            // radBCDoanhThuTrongNgay
            // 
            this.radBCDoanhThuTrongNgay.AutoSize = true;
            this.radBCDoanhThuTrongNgay.Location = new System.Drawing.Point(228, 170);
            this.radBCDoanhThuTrongNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTrongNgay.Name = "radBCDoanhThuTrongNgay";
            this.radBCDoanhThuTrongNgay.Size = new System.Drawing.Size(220, 29);
            this.radBCDoanhThuTrongNgay.TabIndex = 0;
            this.radBCDoanhThuTrongNgay.TabStop = true;
            this.radBCDoanhThuTrongNgay.Text = "Doanh thu trong ngày";
            this.radBCDoanhThuTrongNgay.UseVisualStyleBackColor = true;
            this.radBCDoanhThuTrongNgay.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTrongNgay_CheckedChanged);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(511, 525);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(188, 70);
            this.btnXemBaoCao.TabIndex = 1;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(228, 358);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(298, 30);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(744, 358);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(298, 30);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 69);
            this.label3.TabIndex = 3;
            this.label3.Text = "Báo cáo thống kê";
            // 
            // radBCDoanhThuTungSPTrongThang
            // 
            this.radBCDoanhThuTungSPTrongThang.AutoSize = true;
            this.radBCDoanhThuTungSPTrongThang.Location = new System.Drawing.Point(228, 450);
            this.radBCDoanhThuTungSPTrongThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTungSPTrongThang.Name = "radBCDoanhThuTungSPTrongThang";
            this.radBCDoanhThuTungSPTrongThang.Size = new System.Drawing.Size(360, 29);
            this.radBCDoanhThuTungSPTrongThang.TabIndex = 0;
            this.radBCDoanhThuTungSPTrongThang.TabStop = true;
            this.radBCDoanhThuTungSPTrongThang.Text = "Doanh thu từng sản phẩm trong tháng\r\n";
            this.radBCDoanhThuTungSPTrongThang.UseVisualStyleBackColor = true;
            this.radBCDoanhThuTungSPTrongThang.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTungSPTrongThang_CheckedChanged);
            // 
            // radBCChiTieuTrongNgay
            // 
            this.radBCChiTieuTrongNgay.AutoSize = true;
            this.radBCChiTieuTrongNgay.Location = new System.Drawing.Point(744, 170);
            this.radBCChiTieuTrongNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCChiTieuTrongNgay.Name = "radBCChiTieuTrongNgay";
            this.radBCChiTieuTrongNgay.Size = new System.Drawing.Size(196, 29);
            this.radBCChiTieuTrongNgay.TabIndex = 0;
            this.radBCChiTieuTrongNgay.TabStop = true;
            this.radBCChiTieuTrongNgay.Text = "Chi tiêu trong ngày";
            this.radBCChiTieuTrongNgay.UseVisualStyleBackColor = true;
            this.radBCChiTieuTrongNgay.CheckedChanged += new System.EventHandler(this.radBCChiTieuTrongNgay_CheckedChanged);
            // 
            // radBCChiTieuTrongKhoan
            // 
            this.radBCChiTieuTrongKhoan.AutoSize = true;
            this.radBCChiTieuTrongKhoan.Location = new System.Drawing.Point(744, 246);
            this.radBCChiTieuTrongKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCChiTieuTrongKhoan.Name = "radBCChiTieuTrongKhoan";
            this.radBCChiTieuTrongKhoan.Size = new System.Drawing.Size(207, 29);
            this.radBCChiTieuTrongKhoan.TabIndex = 0;
            this.radBCChiTieuTrongKhoan.TabStop = true;
            this.radBCChiTieuTrongKhoan.Text = "Chi tiêu trong khoản";
            this.radBCChiTieuTrongKhoan.UseVisualStyleBackColor = true;
            this.radBCChiTieuTrongKhoan.CheckedChanged += new System.EventHandler(this.radBCChiTieuTrongKhoan_CheckedChanged);
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.radBCChiTieuTrongNgay);
            this.Controls.Add(this.radBCDoanhThuTrongNgay);
            this.Controls.Add(this.radBCDoanhThuTungSPTrongThang);
            this.Controls.Add(this.radBCChiTieuTrongKhoan);
            this.Controls.Add(this.radBCDoanhThuTrongKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChonBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn báo cáo";
            this.Load += new System.EventHandler(this.frmChonBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBCDoanhThuTrongKhoan;
        private System.Windows.Forms.RadioButton radBCDoanhThuTrongNgay;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radBCDoanhThuTungSPTrongThang;
        private System.Windows.Forms.RadioButton radBCChiTieuTrongNgay;
        private System.Windows.Forms.RadioButton radBCChiTieuTrongKhoan;
    }
}