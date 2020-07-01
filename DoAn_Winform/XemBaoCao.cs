using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace DoAn_Winform
{
    public partial class frmXemBaoCao : Form
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        public void BaoCaoDoanhThuTrongNgay()
        {
            HoaDonBUS hdBUS=new HoaDonBUS();
            List<HoaDonDTO> ListHDTrongNgay = hdBUS.LoadDsHDTrongNgay();
            //cprtXemDTTrongNgay rp = new cprtXemDTTrongNgay();
            crptDTTrongNgay rp = new crptDTTrongNgay();
            rp.SetDataSource(ListHDTrongNgay);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
