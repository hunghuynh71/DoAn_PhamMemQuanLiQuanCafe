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
using BUS;
namespace DoAn_Winform
{
    public partial class frmPhieuNhaphag : Form
    {
        TaiKhoanDTO tkGlobal = new TaiKhoanDTO();
        int maddh;
        List<ChiTietDonDatHangDTO> listct = new List<ChiTietDonDatHangDTO>();

        public frmPhieuNhaphag()
        {
            InitializeComponent();
        }

        public frmPhieuNhaphag(int ma, List<ChiTietDonDatHangDTO> list,TaiKhoanDTO tk)
        {
            maddh = ma;
            listct = list;
            tkGlobal = tk;
            InitializeComponent();
        }

        public frmPhieuNhaphag(TaiKhoanDTO tk)
        {
            InitializeComponent();
            tkGlobal = tk;
        }

        void LoadComboboxTenHH()
        {
            HangHoaBUS hhBUS = new HangHoaBUS();
            cmbTenHangHoa.DataSource = hhBUS.LoadDsHH();
            cmbTenHangHoa.DisplayMember = "Tenhh";
            cmbTenHangHoa.ValueMember = "Mahh";
        }

        void LoadComboboxDDH()
        {
            DonDatHangBUS ddhBUS = new DonDatHangBUS();
            cboDonDatHang.DataSource = ddhBUS.LoadDsDDH();
            cboDonDatHang.DisplayMember = "Maddh";
            cboDonDatHang.ValueMember = "Maddh";
        }

        void LoadComboboxTenNCC()
        {
            NhaCungCapBUS nccBUS = new NhaCungCapBUS();
            cboNhaCungCap.DataSource = nccBUS.LoadDsNCC();
            cboNhaCungCap.DisplayMember = "Tenncc";
            cboNhaCungCap.ValueMember = "Mancc";
        }
        void LoadDsPNH()
        {
            PhieuNhapHangBUS pnhBUS = new PhieuNhapHangBUS();
            dtgvPhieuNhapHang.AutoGenerateColumns = false;
            dtgvPhieuNhapHang.DataSource = pnhBUS.loadDsPNH();
        }

        void LoadDDHDuocChon()
        {
            cboDonDatHang.SelectedValue = maddh;
            lvwChiTietPhieuNhap.Items.Clear();
            foreach(ChiTietDonDatHangDTO ct in listct)
            {
                ListViewItem lvi = new ListViewItem(ct.Tenhh);
                lvi.SubItems.Add(ct.Sl.ToString());
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add(ct.Mahh.ToString());
                lvwChiTietPhieuNhap.Items.Add(lvi);
            }
        }

        private void frmPhieuNhaphag_Load(object sender, EventArgs e)
        {
            LoadComboboxTenHH();
            LoadComboboxDDH();
            LoadComboboxTenNCC();
            LoadDsPNH();
            LoadDDHDuocChon();
        }

        public bool IsNumber(string pValue)
        {
            //kt ky tu dau tien neu ko phai la so thi return false
            if (!char.IsDigit(pValue[0]))
                return false;
            //kt ky tu tiep theo neu ko phai la so va dau '.' thi return false
            for (int i = 1; i < pValue.Length - 1; i++) 
            {
                if (!Char.IsDigit(pValue[i]) && pValue[i] != '.') 
                    return false;
            }
            //kt ky tu cuoi cung neu ko phai la so thi return false
            if (!char.IsDigit(pValue[pValue.Length-1]))
                return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGia.Text == "")
                MessageBox.Show("Bạn chưa nhập giá", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!IsNumber(txtGia.Text))
                MessageBox.Show("Nhập giá chưa đúng định dạng, giá phải là số (số nguyên hoặc số thực)", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                HangHoaBUS hhBUS = new HangHoaBUS();
                string tenhh = hhBUS.LoadTenhhTheoMaHH((int)cmbTenHangHoa.SelectedValue);
                ListViewItem lvi = new ListViewItem(tenhh);
                lvi.SubItems.Add(nmrSoLuong.Value.ToString());
                lvi.SubItems.Add(txtGia.Text);
                double thanhTien=Convert.ToDouble(nmrSoLuong.Value.ToString())*Convert.ToDouble(txtGia.Text);
                lvi.SubItems.Add(thanhTien.ToString());
                lvi.SubItems.Add(((int)cmbTenHangHoa.SelectedValue).ToString());
                if (lvwChiTietPhieuNhap.Items.Count != 0)
                {
                    bool flag = true;
                    foreach (ListViewItem item in lvwChiTietPhieuNhap.Items)
                    {
                        if (item.SubItems[3].Text == ((int)cmbTenHangHoa.SelectedValue).ToString())
                        {
                            MessageBox.Show("Hàng hóa đã được thêm gòi nha đừng thêm nữa, ahihi!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flag = false;
                        }
                    }
                    if (flag == true)
                        lvwChiTietPhieuNhap.Items.Add(lvi);
                }
                else
                {
                    lvwChiTietPhieuNhap.Items.Add(lvi);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = lvwChiTietPhieuNhap.SelectedItems[0];
                lvwChiTietPhieuNhap.Items.Remove(lvi);
            }

            catch (Exception r)
            {
                MessageBox.Show("Hãy chọn háng hóa muốn xòa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtGia.Text == "")
                MessageBox.Show("Bạn chưa nhập giá", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!IsNumber(txtGia.Text))
                MessageBox.Show("Nhập giá chưa đúng định dạng, giá phải là số (số nguyên hoặc số thực)", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    ListViewItem lv = lvwChiTietPhieuNhap.SelectedItems[0];
                    lv.SubItems[1].Text = nmrSoLuong.Value.ToString();
                    lv.SubItems[2].Text = txtGia.Text;
                    double thanhTien = Convert.ToDouble(lv.SubItems[1].Text) * Convert.ToDouble(lv.SubItems[2].Text);
                    lv.SubItems[3].Text = thanhTien.ToString();
                    MessageBox.Show("Sữa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception r)
                {
                    MessageBox.Show("Hãy chọn háng hóa muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTaoPhieuNhapHang_Click(object sender, EventArgs e)
        {
            if (lvwChiTietPhieuNhap.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm hàng hóa vào đơn đặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double tongTien = 0;
                foreach(ListViewItem item in lvwChiTietPhieuNhap.Items)
                {
                    if (item.SubItems[2].Text=="")
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ giá, hãy nhập thêm giá!", "Nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        tongTien += Convert.ToDouble(item.SubItems[1].Text) * Convert.ToDouble(item.SubItems[2].Text);
                }
                PhieuNhapHangDTO pnhDTO = new PhieuNhapHangDTO();
                pnhDTO.Manvlap = tkGlobal.Manv;
                pnhDTO.Maddh = Convert.ToInt32(cboDonDatHang.SelectedValue);
                pnhDTO.Mancc = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                pnhDTO.Tongtien=tongTien;

                PhieuNhapHangBUS pnhBUS = new PhieuNhapHangBUS();
                int mapnh;
                if (pnhBUS.ThemPNH(pnhDTO, out mapnh))
                {
                    foreach (ListViewItem item in lvwChiTietPhieuNhap.Items)
                    {
                        ChiTietPhieuNhapHangBUS ctBUS = new ChiTietPhieuNhapHangBUS();
                        ChiTietPhieuNhapHangDTO ctDTO = new ChiTietPhieuNhapHangDTO();

                        ctDTO.Mapnh = mapnh;
                        ctDTO.Mahh = Convert.ToInt32(item.SubItems[4].Text);
                        ctDTO.Soluong = Convert.ToInt32(item.SubItems[2].Text);
                        ctDTO.Gia = Convert.ToInt32(item.SubItems[1].Text);
                        ctBUS.ThemChiTietPNH(ctDTO);
                    }
                    MessageBox.Show("Tạo phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsPNH();
                }
                else
                {
                    MessageBox.Show("Tạo phiếu nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTraCuuDDH_Click(object sender, EventArgs e)
        {
            frmTraCuuDonDatHang f = new frmTraCuuDonDatHang(tkGlobal);
            this.Close();
            f.ShowDialog();
        }

        private void lvwChiTietPhieuNhap_MouseClick(object sender, MouseEventArgs e)
        {
            cmbTenHangHoa.Text = lvwChiTietPhieuNhap.SelectedItems[0].Text.ToString();
            nmrSoLuong.Value = Convert.ToInt32(lvwChiTietPhieuNhap.SelectedItems[0].SubItems[1].Text);
            txtGia.Text = lvwChiTietPhieuNhap.SelectedItems[0].SubItems[2].Text.ToString();
        }

        private void dtgvPhieuNhapHang_MouseClick(object sender, MouseEventArgs e)
        {
            lvwChiTietPhieuNhap.Items.Clear();
            int mapnh = Convert.ToInt32(dtgvPhieuNhapHang.SelectedCells[0].OwningRow.Cells["colMaPNH"].Value.ToString());
            ChiTietPhieuNhapHangBUS ctBUS = new ChiTietPhieuNhapHangBUS();
            List<ChiTietPhieuNhapHangDTO> dsct = ctBUS.LoadDsChiTietPNHTheoMa(mapnh);
            foreach(ChiTietPhieuNhapHangDTO ct in dsct)
            {
                ListViewItem lvi = new ListViewItem(ct.Tenhh);
                lvi.SubItems.Add(ct.Gia.ToString());
                lvi.SubItems.Add(ct.Soluong.ToString());
                lvi.SubItems.Add((ct.Soluong * ct.Gia).ToString());
                lvi.SubItems.Add(ct.Mahh.ToString());
                lvwChiTietPhieuNhap.Items.Add(lvi);
            }
        }

    }
}
