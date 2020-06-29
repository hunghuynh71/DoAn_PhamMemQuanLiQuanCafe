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
            HangHoaBUS hhBUS = new HangHoaBUS();
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
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            dtgvDsDDH.AutoGenerateColumns = false;
            dtgvDsDDH.DataSource = ddhBUS.LoadDsDDH();
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

        void BindingsHH()
        {
            //ListViewItem lvi = lvwChiTietDDh.SelectedItems[0];
            //cboTenHangHoa.SelectedItem = lvi.Text.ToString();
            //nmrSoLuong.Value = Convert.ToInt32(lvi.SubItems[1].Text);
        }

        void LoadDanhSachDDH()
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            dtgvDsDDH.AutoGenerateColumns = false;
            dtgvDsDDH.DataSource = ddhBUS.LoadDsDDH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangHoaBUS hhBUS = new HangHoaBUS();
            string tenhh = hhBUS.LoadTenhhTheoMaHH((int)cboTenHangHoa.SelectedValue);
            ListViewItem lvi = new ListViewItem(tenhh);
            lvi.SubItems.Add(nmrSoLuong.Value.ToString());
            lvi.SubItems.Add(((int)cboTenHangHoa.SelectedValue).ToString());

            if (lvwChiTietDDh.Items.Count != 0)
            {
                bool flag = true;
                foreach (ListViewItem item in lvwChiTietDDh.Items)
                {
                    if (item.SubItems[2].Text == ((int)cboTenHangHoa.SelectedValue).ToString())
                    {
                        MessageBox.Show("Hàng hóa đã được thêm gòi nha đừng thêm nữa, ahihi!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = false;
                    }
                }
                if (flag == true)
                    lvwChiTietDDh.Items.Add(lvi);
            }
            else
            {
                lvwChiTietDDh.Items.Add(lvi);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwChiTietDDh.SelectedItems[0];
            lvi.SubItems[1].Text = nmrSoLuong.Value.ToString();
        }

        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwChiTietDDh.SelectedItems[0];
            lvwChiTietDDh.Items.Remove(lvi);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (lvwChiTietDDh.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm hàng hóa vào đơn đặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DonDatHangDTO ddhDTO = new DonDatHangDTO();
                ddhDTO.Manvlap = 15;
                ddhDTO.Mancc = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                ddhDTO.Ngaygiao = dtpNgayGiao.Value;

                DonDatHangBUS ddhBUS = new DonDatHangBUS();
                int maDDH;
                if (ddhBUS.ThemDDH(ddhDTO, out maDDH))
                {
                    foreach (ListViewItem item in lvwChiTietDDh.Items)
                    {
                        ChiTietDonDatHangBUS ctBUS = new ChiTietDonDatHangBUS();
                        ChiTietDonDatHangDTO ctDTO = new ChiTietDonDatHangDTO();
                        ctDTO.Maddh = maDDH;
                        ctDTO.Mahh = Convert.ToInt32(item.SubItems[2].Text);
                        ctDTO.Sl = Convert.ToInt32(item.SubItems[1].Text);
                        ctBUS.ThemChiTietDDH(ctDTO);
                    }
                    MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDDH();
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lvwChiTietDDh_MouseClick(object sender, MouseEventArgs e)
        {
            BindingsHH();
        }

        private void dtgvDsDDH_MouseClick(object sender, MouseEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnDatHang.Enabled = false;
            foreach (ListViewItem item in lvwChiTietDDh.Items)
            {
                item.Remove();
            }
            int maDDH = Convert.ToInt32(dtgvDsDDH.SelectedCells[0].OwningRow.Cells["colMaDonDatHang"].Value.ToString());
            ChiTietDonDatHangBUS ctBUS = new ChiTietDonDatHangBUS();
            List<ChiTietDonDatHangDTO> listCtDDH = ctBUS.LoadDsChiTietDDHtheoMaDDH(maDDH);
            //lvwChiTietDDh.Clear();
            foreach (ChiTietDonDatHangDTO item in listCtDDH)
            {
                //HangHoaBUS hhBUS = new HangHoaBUS();
                //string tenhh = hhBUS.LoadTenhhTheoMaHH();
                ListViewItem lvi = new ListViewItem(item.Tenhh);
                lvi.SubItems.Add(item.Sl.ToString());
                lvi.SubItems.Add(item.Mahh.ToString());
                lvwChiTietDDh.Items.Add(lvi);
            }
        }

        private void dtgvDsDDH_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void dtgvDsDDH_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dtgvDsDDH_Move(object sender, EventArgs e)
        {

        }

        private void dtgvDsDDH_Leave(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnDatHang.Enabled = true;
        }

        private void dtgvDsDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTenHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
