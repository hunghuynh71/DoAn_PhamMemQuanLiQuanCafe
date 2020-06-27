namespace DoAn_Winform
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
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAcountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // kếToánToolStripMenuItem
            // 
            this.kếToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhTiềnToolStripMenuItem,
            this.xemThôngTinHóaĐơnToolStripMenuItem});
            this.kếToánToolStripMenuItem.Name = "kếToánToolStripMenuItem";
            this.kếToánToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.kếToánToolStripMenuItem.Text = "Thu Ngân";
            // 
            // tínhTiềnToolStripMenuItem
            // 
            this.tínhTiềnToolStripMenuItem.Name = "tínhTiềnToolStripMenuItem";
            this.tínhTiềnToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.tínhTiềnToolStripMenuItem.Text = "Lập hóa đơn";
            this.tínhTiềnToolStripMenuItem.Click += new System.EventHandler(this.tínhTiềnToolStripMenuItem_Click);
            // 
            // xemThôngTinHóaĐơnToolStripMenuItem
            // 
            this.xemThôngTinHóaĐơnToolStripMenuItem.Name = "xemThôngTinHóaĐơnToolStripMenuItem";
            this.xemThôngTinHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.xemThôngTinHóaĐơnToolStripMenuItem.Text = "Báo cáo doanh thu";
            this.xemThôngTinHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinHóaĐơnToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtHàngToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.quanLyToolStripMenuItem.Text = "Quản lí kho ";
            // 
            // đặtHàngToolStripMenuItem
            // 
            this.đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            this.đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.đặtHàngToolStripMenuItem.Text = "Yêu cầu đặt hàng";
            this.đặtHàngToolStripMenuItem.Click += new System.EventHandler(this.đặtHàngToolStripMenuItem_Click);
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.phiếuNhậpToolStripMenuItem.Text = "Lập phiếu nhập hàng";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // tàiKhoảngToolStripMenuItem
            // 
            this.tàiKhoảngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.editAcountToolStripMenuItem});
            this.tàiKhoảngToolStripMenuItem.Name = "tàiKhoảngToolStripMenuItem";
            this.tàiKhoảngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảngToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // editAcountToolStripMenuItem
            // 
            this.editAcountToolStripMenuItem.Name = "editAcountToolStripMenuItem";
            this.editAcountToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.editAcountToolStripMenuItem.Text = "Edit Acount";
            this.editAcountToolStripMenuItem.Click += new System.EventHandler(this.editAcountToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.kếToánToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.tàiKhoảngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAcountToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}