namespace DoAn_Winform
{
    partial class frmTraCuuDonDatHang
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
            this.dtgvDsDDH = new System.Windows.Forms.DataGridView();
            this.colMaDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNVLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChonDDH = new System.Windows.Forms.Button();
            this.lvwChiTietDDH = new System.Windows.Forms.ListView();
            this.colTenHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đơn đặt hàng đã duyệt";
            // 
            // dtgvDsDDH
            // 
            this.dtgvDsDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDDH,
            this.colNgayLap,
            this.colTenNVLap});
            this.dtgvDsDDH.Location = new System.Drawing.Point(12, 174);
            this.dtgvDsDDH.Name = "dtgvDsDDH";
            this.dtgvDsDDH.RowTemplate.Height = 24;
            this.dtgvDsDDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDsDDH.Size = new System.Drawing.Size(654, 467);
            this.dtgvDsDDH.TabIndex = 1;
            this.dtgvDsDDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDsDDH_MouseClick);
            // 
            // colMaDDH
            // 
            this.colMaDDH.DataPropertyName = "Maddh";
            this.colMaDDH.HeaderText = "Mã đơn đặt hàng";
            this.colMaDDH.Name = "colMaDDH";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "Ngaylap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colTenNVLap
            // 
            this.colTenNVLap.DataPropertyName = "Tennvlap";
            this.colTenNVLap.HeaderText = "Nhân viên lập";
            this.colTenNVLap.Name = "colTenNVLap";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(140, 105);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(291, 30);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(848, 105);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(291, 30);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(516, 97);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 50);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnChonDDH
            // 
            this.btnChonDDH.Location = new System.Drawing.Point(939, 20);
            this.btnChonDDH.Name = "btnChonDDH";
            this.btnChonDDH.Size = new System.Drawing.Size(200, 50);
            this.btnChonDDH.TabIndex = 5;
            this.btnChonDDH.Text = "Chọn đơn đặt hàng";
            this.btnChonDDH.UseVisualStyleBackColor = true;
            this.btnChonDDH.Click += new System.EventHandler(this.btnChonDDH_Click);
            // 
            // lvwChiTietDDH
            // 
            this.lvwChiTietDDH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenHH,
            this.colSoLuong});
            this.lvwChiTietDDH.Location = new System.Drawing.Point(673, 174);
            this.lvwChiTietDDH.Name = "lvwChiTietDDH";
            this.lvwChiTietDDH.Size = new System.Drawing.Size(477, 467);
            this.lvwChiTietDDH.TabIndex = 6;
            this.lvwChiTietDDH.UseCompatibleStateImageBehavior = false;
            this.lvwChiTietDDH.View = System.Windows.Forms.View.Details;
            // 
            // colTenHH
            // 
            this.colTenHH.Text = "Tên hàng hóa";
            this.colTenHH.Width = 172;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 200;
            // 
            // frmTraCuuDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.lvwChiTietDDH);
            this.Controls.Add(this.btnChonDDH);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.dtgvDsDDH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTraCuuDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmTraCuuDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDsDDH;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChonDDH;
        private System.Windows.Forms.ListView lvwChiTietDDH;
        private System.Windows.Forms.ColumnHeader colTenHH;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNVLap;
    }
}