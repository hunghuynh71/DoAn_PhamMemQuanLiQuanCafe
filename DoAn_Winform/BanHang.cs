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
    public partial class frmBanHang : Form
    {
        BanDTO BanGlobal = new BanDTO();
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        HoaDonBUS hdbus = new HoaDonBUS();
        BanBUS banBUS = new BanBUS();
        public frmBanHang()
        {
            InitializeComponent();      
        }
        public frmBanHang(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;
            InitializeComponent();
        }
       
        #region Method
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDsBan(BanGlobal);
            LoadcboChuyenBan();
            LoadcboLoaiThucUong();
            LoadcboThucUong();
        }   
       public void LoadDsBan(BanDTO banglobal)
        {
            flpBan.Controls.Clear();
            List<BanDTO> dsBan = banBUS.LoadDsBan();

            foreach(BanDTO item in dsBan)
            {
                Button button = new Button() { Width=120, Height=120};

                button.Click += button_Click;           
                button.Tag = item;                
                if(item.Trangthai==0)
                {
                    button.Text = item.Tenban + "\nTrống";
                    if (banglobal.Soban != item.Soban)
                        button.BackColor = Color.LightGreen;
                    else
                        button.BackColor = Color.SkyBlue;
                }
                else
                {
                    button.Text = item.Tenban + "\nCó người";
                    if (banglobal.Soban != item.Soban)
                         button.BackColor = Color.LightPink;
                    else
                        button.BackColor = Color.SkyBlue;
                }

                flpBan.Controls.Add(button);
            }
        }
        void LoadcboThucUong()
        {
            ThucUongBUS tubus = new ThucUongBUS();
            List< ThucUongDTO> TuDTO = new List<ThucUongDTO>();
            TuDTO = tubus.LoadDsTU();
            foreach(ThucUongDTO tu in TuDTO)
            {
                cboThucUong.Items.Add(tu.Tentu);
            }    
        }
        void LoadcboLoaiThucUong()
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            List<LoaiThucUongDTO> LoaiTuDTO = new List<LoaiThucUongDTO>();
            LoaiTuDTO = ltubus.LoadDsLoaiTU();
            foreach (LoaiThucUongDTO tu in LoaiTuDTO)
            {
                cboLoaiThucUong.Items.Add(tu.Tenloaitu);
            }
        }
        void LoadcboChuyenBan()
        {
            
            List<BanDTO> Listbbus = new List<BanDTO>();
            Listbbus = banBUS.LoadDsBan();
            foreach (BanDTO bann in Listbbus)
            {
                cboChuyenBan.Items.Add(bann.Tenban);
            }
        }   
        public void LoadThongTinHD(int maBan)
        {
            if (maBan != null)
            {
                HoaDonBUS hdBUS = new HoaDonBUS();
                ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
                lvwHoaDon.Items.Clear();
                HoaDonDTO hdTam = hdBUS.LoadHDChuaThanhToanTheoMaBan(maBan);

                //int maHD = hdBUS.LoadHDChuaThanhToanTheoMaBan(maBan).Mahd;
                if (hdTam != null)
                {
                    List<ChiTietHoaDonDTO> dsCT = cthdBUS.LoadDsCTHDTheoMaHD(hdTam.Mahd);
                    double tongTien = 0;

                    foreach (ChiTietHoaDonDTO item in dsCT)
                    {
                        ListViewItem lvi = new ListViewItem(item.Tentu);
                        lvi.SubItems.Add(item.Soluong.ToString());
                        lvi.SubItems.Add(item.Giaban.ToString());
                        lvi.SubItems.Add(item.Thanhtien.ToString());

                        lvwHoaDon.Items.Add(lvi);

                        tongTien += item.Thanhtien;
                    }
                    tongTien = tongTien - (tongTien * Convert.ToDouble(nmrPhanTramGiamGia.Value) / 100);
                    txtTongTien.Text = tongTien.ToString();
                    txtTongTien.ReadOnly = true;
                }
            }                     
        }

        #endregion


        #region Event

        private void button_Click(object sender, EventArgs e)
        {
            BanGlobal = ((sender as Button).Tag as BanDTO);
            int maBan = ((sender as Button).Tag as BanDTO).Soban;
            (sender as Button).BackColor= Color.SkyBlue;
            LoadThongTinHD(maBan);
            btnThemThucUong.Enabled = true;
            LoadDsBan(BanGlobal);
            if(lvwHoaDon.Items.Count > 0)
            {
                btnThanhToan.Enabled = true;
                btnChuyenBan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnChuyenBan.Enabled = false;
            }

        }
        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            if (cboThucUong.Text != null && cboLoaiThucUong != null)
            {
                if (hdbus.ThemThucUongTheoBan(BanGlobal, TaiKhoanGlobal.Manv, cboThucUong.Text, cboLoaiThucUong.Text, Convert.ToInt32(nmrSoLuong.Value)))
                { 
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    BanGlobal.Trangthai = 1;
                    LoadThongTinHD(BanGlobal.Soban);              
                    LoadDsBan(BanGlobal);
                }
                else
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
            else
                MessageBox.Show("Chưa Đầy Đủ Thông Tin Thức Uống", "Thông Báo");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show("Ông Có Chắc Là Ông Muốn Thanh Toán Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mes==DialogResult.Yes)
            {
                if (hdbus.ThanhToan(BanGlobal,Convert.ToDouble(txtTongTien.Text)))
                {
                    MessageBox.Show("Thanh Toán Thành Công", "Thông Báo");
                    LoadDsBan(BanGlobal);
                    lvwHoaDon.Items.Clear();
                }
            }   
            else
            {
                MessageBox.Show("Đã Hủy Thanh Toán", "Thông Báo");
            }    

        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (!banBUS.KiemTraBanCoNguoiChua(cboChuyenBan.Text) && cboChuyenBan.Text !="" && cboChuyenBan.Text != BanGlobal.Tenban)
            {
                DialogResult res = MessageBox.Show("Bàn Đã Có Người. Bàn Muốn Sự Lựa Chọn Khác Không?  ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    res = MessageBox.Show(" Thêm Các Món Vào Bàn Đã Chọn (Quen Biết) ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (hdbus.ChuyenBan(BanGlobal, cboChuyenBan.Text,TaiKhoanGlobal.Manv))
                        { 
                            MessageBox.Show(" Thành Công", "Thông Báo");
                            BanGlobal.Trangthai = 0;
                            LoadDsBan(BanGlobal);
                        }
                        else
                            MessageBox.Show(" Thất Bại", "Thông Báo");
                    }
                }
            }
            else if (cboChuyenBan.Text != "" && cboChuyenBan.Text != BanGlobal.Tenban)
            {
                if (hdbus.ChuyenBan(BanGlobal, cboChuyenBan.Text,TaiKhoanGlobal.Manv))
                        { 
                            MessageBox.Show(" Thành Công", "Thông Báo");
                            BanGlobal.Trangthai = 0;
                            LoadDsBan(BanGlobal);
                        }
                        else
                            MessageBox.Show("Thất Bại", "Thông Báo");
            }
            else
                MessageBox.Show("Thông Tin Nhập Không Đúng Hoặc Thiếu!", "Thông Báo");
            cboChuyenBan.Text = string.Empty;
        }
     
        private void cboThucUong_TextChanged(object sender, EventArgs e)
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            string LoaiTU = ltubus.TimLoaiTUTheoTenloai(cboThucUong.Text);
            if (LoaiTU != "")
            {
                cboLoaiThucUong.Text = LoaiTU;
            }
        }
        private void cboLoaiThucUong_TextChanged(object sender, EventArgs e)
        {
            ThucUongBUS tubus = new ThucUongBUS();
            List<ThucUongDTO> ListTUDTO = tubus.TimDrinkTheoTenLoaiDrink(cboLoaiThucUong.Text);
            if (ListTUDTO.Count() > 0)
            {
                cboThucUong.Items.Clear();
                foreach (ThucUongDTO tu in ListTUDTO)
                {
                    cboThucUong.Items.Add(tu.Tentu);
                }
            }
        }
        private void cboLoaiThucUong_Click(object sender, EventArgs e)
        {
            cboThucUong.Text = "";
        }

 
        
        #endregion

        

    



    }
}
