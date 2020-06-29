using DTO;
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
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;           
            InitializeComponent();
            PhanQuyenTK();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.MdiParent = this;
            f.Show();
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang(TaiKhoanGlobal);
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
            frmAccount f = new frmAccount(TaiKhoanGlobal);
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolThuNgan.Enabled = true;
            ToolLapHoaDon.Enabled = true;
            toolXemThongKEThuChi.Enabled = true;

            toolQuanLikho.Enabled = true;
            toolLapPHieuNhap.Enabled = true;
            toolDatHang.Enabled = true;

            toolAdmin.Enabled = true;
            this.Close();
        }
      public  void PhanQuyenTK()
        {
            if(TaiKhoanGlobal.Loaitaikhoan==2)
            {
                toolThuNgan.Enabled = false;
                ToolLapHoaDon.Enabled = false;
                toolXemThongKEThuChi.Enabled = false;

                toolQuanLikho.Enabled = false;
                toolLapPHieuNhap.Enabled = false;
                toolDatHang.Enabled = false;
            }
            else if (TaiKhoanGlobal.Loaitaikhoan == 3)
            {
                toolAdmin.Enabled = false;

                toolQuanLikho.Enabled = false;
                toolLapPHieuNhap.Enabled = false;
                toolDatHang.Enabled = false;
            }
            else if(TaiKhoanGlobal.Loaitaikhoan == 4)
            {
                toolThuNgan.Enabled = false;              
                toolLapPHieuNhap.Enabled = false;
                toolXemThongKEThuChi.Enabled = false;

                toolAdmin.Enabled = false;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}