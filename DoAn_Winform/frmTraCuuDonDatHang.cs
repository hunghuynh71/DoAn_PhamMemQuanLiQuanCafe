using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace DoAn_Winform
{
    public partial class frmTraCuuDonDatHang : Form
    {
        TaiKhoanDTO tkGlobal = new TaiKhoanDTO();
        public frmTraCuuDonDatHang()
        {
            InitializeComponent();
        }

        public frmTraCuuDonDatHang(TaiKhoanDTO tk)
        {
            tkGlobal = tk;
            InitializeComponent();
        }

        private void frmTraCuuDonDatHang_Load(object sender, EventArgs e)
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            dtgvDsDDH.AutoGenerateColumns = false;
            dtgvDsDDH.DataSource = ddhBUS.LoadDsDDHDaDuyet();
        }

        private void dtgvDsDDH_MouseClick(object sender, MouseEventArgs e)
        {
            lvwChiTietDDH.Items.Clear();
            int maDDH = Convert.ToInt32(dtgvDsDDH.SelectedCells[0].OwningRow.Cells["colMaDDH"].Value.ToString());
            ChiTietDonDatHangBUS ctBUS = new ChiTietDonDatHangBUS();
            List<ChiTietDonDatHangDTO> listCtDDH = ctBUS.LoadDsChiTietDDHtheoMaDDH(maDDH);

            foreach(ChiTietDonDatHangDTO item in listCtDDH)
            {
                ListViewItem lvi = new ListViewItem(item.Tenhh);
                lvi.SubItems.Add(item.Sl.ToString());
                lvi.SubItems.Add(item.Mahh.ToString());
                lvwChiTietDDH.Items.Add(lvi);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            dtgvDsDDH.AutoGenerateColumns = false;
            dtgvDsDDH.DataSource = ddhBUS.LoadDsDDHDaDuyet(dtpTuNgay.Value,dtpDenNgay.Value);
        }

        private void btnChonDDH_Click(object sender, EventArgs e)
        {
            int ma=0;
            List<ChiTietDonDatHangDTO> listctddh = new List<ChiTietDonDatHangDTO>();
            LayTTDatHang(out ma, out listctddh);
            frmPhieuNhaphag f = new frmPhieuNhaphag(ma, listctddh,tkGlobal);
            this.Close();
            f.ShowDialog();
        }

        void LayTTDatHang(out int maddh, out List<ChiTietDonDatHangDTO> listct)
        {
            maddh = 0;
            listct = new List<ChiTietDonDatHangDTO>();
            maddh= Convert.ToInt32(dtgvDsDDH.SelectedCells[0].OwningRow.Cells["colMaDDH"].Value.ToString());
            ChiTietDonDatHangBUS ctddhBUS=new ChiTietDonDatHangBUS();
            listct = ctddhBUS.LoadDsChiTietDDHtheoMaDDH(maddh);
        }
    }
}
