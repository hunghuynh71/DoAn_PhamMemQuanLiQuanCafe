namespace DoAn_Winform
{
    partial class frmThongKeDoanhThu
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
            this.btnTraCuuHoaDon = new System.Windows.Forms.Button();
            this.btnTraCuuPhieuNhapHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTraCuuHoaDon
            // 
            this.btnTraCuuHoaDon.Location = new System.Drawing.Point(102, 173);
            this.btnTraCuuHoaDon.Name = "btnTraCuuHoaDon";
            this.btnTraCuuHoaDon.Size = new System.Drawing.Size(104, 44);
            this.btnTraCuuHoaDon.TabIndex = 1;
            this.btnTraCuuHoaDon.Text = "Tra cứu hóa đơn";
            this.btnTraCuuHoaDon.UseVisualStyleBackColor = true;
            this.btnTraCuuHoaDon.Click += new System.EventHandler(this.btnTraCuuHoaDon_Click);
            // 
            // btnTraCuuPhieuNhapHang
            // 
            this.btnTraCuuPhieuNhapHang.Location = new System.Drawing.Point(229, 173);
            this.btnTraCuuPhieuNhapHang.Name = "btnTraCuuPhieuNhapHang";
            this.btnTraCuuPhieuNhapHang.Size = new System.Drawing.Size(104, 44);
            this.btnTraCuuPhieuNhapHang.TabIndex = 2;
            this.btnTraCuuPhieuNhapHang.Text = "Tra cứu phiếu nhập hàng";
            this.btnTraCuuPhieuNhapHang.UseVisualStyleBackColor = true;
            this.btnTraCuuPhieuNhapHang.Click += new System.EventHandler(this.btnTraCuuPhieuNhapHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống  kê doanh thu";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(360, 173);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(104, 44);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.btnTraCuuPhieuNhapHang);
            this.Controls.Add(this.btnTraCuuHoaDon);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraCuuHoaDon;
        private System.Windows.Forms.Button btnTraCuuPhieuNhapHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}