﻿namespace DoAn_Winform
{
    partial class frmHome
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
            this.toolAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXemThongKEThuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuanLikho = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLapPHieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAcountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolAdmin
            // 
            this.toolAdmin.Name = "toolAdmin";
            this.toolAdmin.Size = new System.Drawing.Size(93, 33);
            this.toolAdmin.Text = "Admin";
            this.toolAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // toolThuNgan
            // 
            this.toolThuNgan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolLapHoaDon,
            this.toolXemThongKEThuChi});
            this.toolThuNgan.Name = "toolThuNgan";
            this.toolThuNgan.Size = new System.Drawing.Size(131, 33);
            this.toolThuNgan.Text = "Thu Ngân";
            // 
            // ToolLapHoaDon
            // 
            this.ToolLapHoaDon.Name = "ToolLapHoaDon";
            this.ToolLapHoaDon.Size = new System.Drawing.Size(316, 34);
            this.ToolLapHoaDon.Text = "Lập hóa đơn";
            this.ToolLapHoaDon.Click += new System.EventHandler(this.tínhTiềnToolStripMenuItem_Click);
            // 
            // toolXemThongKEThuChi
            // 
            this.toolXemThongKEThuChi.Name = "toolXemThongKEThuChi";
            this.toolXemThongKEThuChi.Size = new System.Drawing.Size(316, 34);
            this.toolXemThongKEThuChi.Text = "Xem thống kê thu chi";
            this.toolXemThongKEThuChi.Click += new System.EventHandler(this.xemThôngTinHóaĐơnToolStripMenuItem_Click);
            // 
            // toolQuanLikho
            // 
            this.toolQuanLikho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDatHang,
            this.toolLapPHieuNhap});
            this.toolQuanLikho.Name = "toolQuanLikho";
            this.toolQuanLikho.Size = new System.Drawing.Size(152, 33);
            this.toolQuanLikho.Text = "Quản lí kho ";
            // 
            // toolDatHang
            // 
            this.toolDatHang.Name = "toolDatHang";
            this.toolDatHang.Size = new System.Drawing.Size(318, 34);
            this.toolDatHang.Text = "Lập yêu cầu đặt hàng";
            this.toolDatHang.Click += new System.EventHandler(this.đặtHàngToolStripMenuItem_Click);
            // 
            // toolLapPHieuNhap
            // 
            this.toolLapPHieuNhap.Name = "toolLapPHieuNhap";
            this.toolLapPHieuNhap.Size = new System.Drawing.Size(318, 34);
            this.toolLapPHieuNhap.Text = "Lập phiếu nhập hàng";
            this.toolLapPHieuNhap.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // toolTaiKhoan
            // 
            this.toolTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.editAcountToolStripMenuItem});
            this.toolTaiKhoan.Name = "toolTaiKhoan";
            this.toolTaiKhoan.Size = new System.Drawing.Size(135, 33);
            this.toolTaiKhoan.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // editAcountToolStripMenuItem
            // 
            this.editAcountToolStripMenuItem.Name = "editAcountToolStripMenuItem";
            this.editAcountToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.editAcountToolStripMenuItem.Text = "Chỉnh sửa mật khẩu";
            this.editAcountToolStripMenuItem.Click += new System.EventHandler(this.editAcountToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdmin,
            this.toolThuNgan,
            this.toolQuanLikho,
            this.toolTaiKhoan,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(19, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.lậpHóaĐơnToolStripMenuItem,
            this.xemBáoCáoToolStripMenuItem,
            this.đặtHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.chỉnhSửaMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(139, 33);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click_1);
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // xemBáoCáoToolStripMenuItem
            // 
            this.xemBáoCáoToolStripMenuItem.Name = "xemBáoCáoToolStripMenuItem";
            this.xemBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.xemBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.xemBáoCáoToolStripMenuItem.Text = "Xem báo cáo ";
            this.xemBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xemBáoCáoToolStripMenuItem_Click);
            // 
            // đặtHàngToolStripMenuItem
            // 
            this.đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            this.đặtHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.đặtHàngToolStripMenuItem.Text = "Đặt hàng";
            this.đặtHàngToolStripMenuItem.Click += new System.EventHandler(this.đặtHàngToolStripMenuItem_Click_1);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // chỉnhSửaMậtKhẩuToolStripMenuItem
            // 
            this.chỉnhSửaMậtKhẩuToolStripMenuItem.Name = "chỉnhSửaMậtKhẩuToolStripMenuItem";
            this.chỉnhSửaMậtKhẩuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.chỉnhSửaMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(381, 34);
            this.chỉnhSửaMậtKhẩuToolStripMenuItem.Text = "Chỉnh sửa mật khẩu";
            this.chỉnhSửaMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(381, 34);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ quản lí";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolThuNgan;
        private System.Windows.Forms.ToolStripMenuItem ToolLapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem toolXemThongKEThuChi;
        private System.Windows.Forms.ToolStripMenuItem toolQuanLikho;
        private System.Windows.Forms.ToolStripMenuItem toolDatHang;
        private System.Windows.Forms.ToolStripMenuItem toolLapPHieuNhap;
        private System.Windows.Forms.ToolStripMenuItem toolTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAcountToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}