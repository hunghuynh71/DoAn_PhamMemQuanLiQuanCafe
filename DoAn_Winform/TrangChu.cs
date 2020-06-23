using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Winform
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.MdiParent = this;
            f.Show();
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.MdiParent = this;
            f.Show();
        }
        
        private void xemThôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.MdiParent = this;
            f.Show();
        }

        

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatHang f = new frmDatHang();
            f.MdiParent = this;
            f.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhaphag f = new frmPhieuNhaphag();
            f.MdiParent = this;
            f.Show();
        }

        private void editAcountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}