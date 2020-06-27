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
            this.radThuChi = new System.Windows.Forms.RadioButton();
            this.radChi = new System.Windows.Forms.RadioButton();
            this.radThu = new System.Windows.Forms.RadioButton();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radThuChi
            // 
            this.radThuChi.AutoSize = true;
            this.radThuChi.Location = new System.Drawing.Point(359, 205);
            this.radThuChi.Name = "radThuChi";
            this.radThuChi.Size = new System.Drawing.Size(95, 21);
            this.radThuChi.TabIndex = 0;
            this.radThuChi.TabStop = true;
            this.radThuChi.Text = "Thu và chi";
            this.radThuChi.UseVisualStyleBackColor = true;
            // 
            // radChi
            // 
            this.radChi.AutoSize = true;
            this.radChi.Location = new System.Drawing.Point(258, 205);
            this.radChi.Name = "radChi";
            this.radChi.Size = new System.Drawing.Size(49, 21);
            this.radChi.TabIndex = 0;
            this.radChi.TabStop = true;
            this.radChi.Text = "Chi";
            this.radChi.UseVisualStyleBackColor = true;
            // 
            // radThu
            // 
            this.radThu.AutoSize = true;
            this.radThu.Location = new System.Drawing.Point(135, 205);
            this.radThu.Name = "radThu";
            this.radThu.Size = new System.Drawing.Size(54, 21);
            this.radThu.TabIndex = 0;
            this.radThu.TabStop = true;
            this.radThu.Text = "Thu";
            this.radThu.UseVisualStyleBackColor = true;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(232, 268);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(125, 45);
            this.btnXemBaoCao.TabIndex = 1;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(69, 138);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(348, 138);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn báo cáo";
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.radThu);
            this.Controls.Add(this.radChi);
            this.Controls.Add(this.radThuChi);
            this.Name = "frmChonBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radThuChi;
        private System.Windows.Forms.RadioButton radChi;
        private System.Windows.Forms.RadioButton radThu;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}