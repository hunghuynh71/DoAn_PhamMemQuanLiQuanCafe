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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void btnTraCuuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
        }

        private void btnTraCuuPhieuNhapHang_Click(object sender, EventArgs e)
        {
            frmTraCuuPhieuNhapHang f = new frmTraCuuPhieuNhapHang();
            f.ShowDialog();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            frmChonBaoCao f = new frmChonBaoCao();
            f.ShowDialog();
        }

    }
}
