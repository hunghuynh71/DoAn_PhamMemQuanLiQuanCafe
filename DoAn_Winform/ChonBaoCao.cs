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
    public partial class frmChonBaoCao : Form
    {
        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if(radBCDoanhThuTrongNgay.Checked)
            {
                frmXemBaoCao f = new frmXemBaoCao();
                f.BaoCaoDoanhThuTrongNgay();
                f.ShowDialog();
            }
            else if(radBCChiTieuTrongNgay.Checked)
            {
                frmXemBaoCao f = new frmXemBaoCao();
                f.BaoCaoChiTieuTrongNgay();
                f.ShowDialog();
            }
            else if(radBCDoanhThuTrongKhoan.Checked)
            {
                
                frmXemBaoCao f = new frmXemBaoCao();
                f.BaoCaoDoanhThuTrongKhoan(dtpTuNgay.Value,dtpDenNgay.Value);
                f.ShowDialog();
            }
            else if (radBCChiTieuTrongKhoan.Checked)
            { 
                frmXemBaoCao f = new frmXemBaoCao();
                f.BaoCaoChiTieuTrongKhoan(dtpTuNgay.Value, dtpDenNgay.Value);
                f.ShowDialog();
            }
            else if (radBCDoanhThuTungSPTrongThang.Checked)
            {
                frmXemBaoCao f = new frmXemBaoCao();
                f.BaoCaoDoanhThuTungSPTrongThang();
                f.ShowDialog();
            }
        }

        private void frmChonBaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
        }

        private void radBCDoanhThuTrongNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(radBCDoanhThuTrongNgay.Checked)
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void radBCChiTieuTrongNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radBCChiTieuTrongNgay.Checked)
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }

        private void radBCDoanhThuTrongKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (radBCDoanhThuTrongKhoan.Checked)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
        }

        private void radBCChiTieuTrongKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (radBCChiTieuTrongKhoan.Checked)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
        }

        private void radBCDoanhThuTungSPTrongThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radBCDoanhThuTungSPTrongThang.Checked)
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
        }
    }
}
