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
using DTO;

namespace DoAn_Winform
{
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }

        #region Method

        void LoadComboboxTenHH()
        {
            HangHoaBUS hhBUS=new HangHoaBUS();
            cboTenHangHoa.DataSource = hhBUS.LoadDsHH();
            cboTenHangHoa.DisplayMember = "Tenhh";
            cboTenHangHoa.ValueMember = "Mahh";
        }

        void LoadComboboxTenNCC()
        {
            NhaCungCapBUS nccBUS = new NhaCungCapBUS();
            cboNhaCungCap.DataSource = nccBUS.LoadDsNCC();
            cboNhaCungCap.DisplayMember = "Tenncc";
            cboNhaCungCap.ValueMember = "Mancc";
        }

        void LoadDsDDH()
        {
            DonDatHangBUS ddhBUS=new DonDatHangBUS();
            dtgvDsDDH.AutoGenerateColumns = false;
            dtgvDsDDH.DataSource=ddhBUS.LoadDsDDH();
            dtgvDsDDH.Columns["colNgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //foreach(DataRow row in dtgvDsDDH.Rows)
            //{
            //    if(Convert.ToUInt32(row["colTrangThaiDuyet"])==1)
            //        colTrangThaiDuyet

            //}
        }

        #endregion

        #region Event

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            LoadComboboxTenHH();
            LoadComboboxTenNCC();
            LoadDsDDH();
        }


        private void btnTaoDDH_Click(object sender, EventArgs e)
        {
            DonDatHangDTO ddh = new DonDatHangDTO();
            ddh.Manvlap = 15;
            ddh.Mancc = ((NhaCungCapDTO)cboNhaCungCap.SelectedItem).Mancc;
            ddh.Ngaygiao = DateTime.Now;
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            if(ddhBUS.ThemDDH(ddh))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsDDH();
                             
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //load chi tiết ddh chi chọn vào ddh trong danh sách
        private void dtgvDsDDH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvDsDDH.SelectedRows[0];
                int maDDH = Convert.ToInt32(dtr.Cells["colMaDonDatHang"].Value.ToString());
                ChiTietDonDatHangBUS ctddhBUS = new ChiTietDonDatHangBUS();
                dtgvChiTietDatHang.AutoGenerateColumns = false;
                dtgvChiTietDatHang.DataSource = ctddhBUS.LoadDsChiTietDDHtheoMaDDH(maDDH);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //th1: thêm chi tiết khi chưa tạo đơn đặt hàng (thêm ddh mới)
            
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }


        private void btnDatHang_Click(object sender, EventArgs e)
        {

        }

    }
}
