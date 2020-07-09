using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace DoAn_Winform
{
    public partial class frmBanHang : Form
    {
        List<HoaDonTamDTO> ListHDTam = new List<HoaDonTamDTO>();

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
            HoaDonTamBUS hdtBUS= new HoaDonTamBUS();

            flpBan.Controls.Clear();
            List<BanDTO> dsBan = banBUS.LoadDsBan();
            if (dsBan.Count > 0)
            {
<<<<<<< HEAD
                Button button = new Button() { Width=120, Height=120};

                button.Click += button_Click;           
                button.Tag = item;  
                
                if(item.Trangthai == 1)
=======
                foreach (BanDTO item in dsBan)
>>>>>>> 5c224e9df7c2662858ce6ce06fcc5fad42577d8c
                {
                    Button button = new Button() { Width = 120, Height = 120 };
                    button.Click += button_Click;
                    button.Tag = item;
                    //if(item.Trangthai == 1)
                    //{
                    //    button.Text = item.Tenban + "\nTrống";
                    //    if (banglobal.Soban != item.Soban)
                    //        button.BackColor = Color.LightGreen;
                    //    else
                    //        button.BackColor = Color.SkyBlue;
                    //}
                    //else if (item.Trangthai == 2)
                    //{
                    //    button.Text = item.Tenban + "\nCó người";
                    //    if (banglobal.Soban != item.Soban)
                    //         button.BackColor = Color.LightPink;
                    //    else
                    //        button.BackColor = Color.SkyBlue;
                    //}

                    if (hdtBUS.LayHDTamTheoMaBan(item.Soban, ListHDTam) == null)
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
        }
        void LoadcboThucUong()
        {
            ThucUongBUS tubus = new ThucUongBUS();        
            cboThucUong.DataSource = tubus.LoadDsTU();
            cboThucUong.DisplayMember = "Tentu";
            cboThucUong.ValueMember = "Matu";        
        }
        void LoadcboLoaiThucUong()
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            //List<LoaiThucUongDTO> LoaiTuDTO = new List<LoaiThucUongDTO>();
            //LoaiTuDTO = ltubus.LoadDsLoaiTU();
            //foreach (LoaiThucUongDTO tu in LoaiTuDTO)
            //{
            //    cboLoaiThucUong.Items.Add(tu.Tenloaitu);
            //}
            cboLoaiThucUong.DataSource = ltubus.LoadDsLoaiTU();
            cboLoaiThucUong.DisplayMember = "Tenloaitu";
            cboLoaiThucUong.ValueMember = "Maloaitu";

        }
        void LoadcboChuyenBan()
        {           
           cboChuyenBan.DataSource = banBUS.LoadDsBan();
            cboChuyenBan.DisplayMember = "Tenban";
            cboChuyenBan.ValueMember = "Soban";
        }   
        public void LoadThongTinHD(int maBan)
        {
            if (maBan != null)
            {
                //HoaDonBUS hdBUS = new HoaDonBUS();
                //ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
                //lvwHoaDon.Items.Clear();
                //HoaDonDTO hdTam = hdBUS.LoadHDChuaThanhToanTheoMaBan(maBan);
                //if (hdTam != null)
                //{
                //    List<ChiTietHoaDonDTO> dsCT = cthdBUS.LoadDsCTHDTheoMaHD(hdTam.Mahd);
                //    double tongTien = 0;

                //    foreach (ChiTietHoaDonDTO item in dsCT)
                //    {
                //        ListViewItem lvi = new ListViewItem(item.Tentu);
                //        lvi.SubItems.Add(item.Soluong.ToString());
                //        lvi.SubItems.Add(item.Giaban.ToString());
                //        lvi.SubItems.Add(item.Thanhtien.ToString());

                //        lvwHoaDon.Items.Add(lvi);

                //        tongTien += item.Thanhtien;
                //    }
                //    tongTien = tongTien - (tongTien * Convert.ToDouble(nmrPhanTramGiamGia.Value) / 100);
                //    txtTongTien.Text = tongTien.ToString();
                //    txtTongTien.ReadOnly = true;
                //}

                lvwHoaDon.Items.Clear();

                HoaDonTamBUS hdtBUS = new HoaDonTamBUS();
                ThucUongBUS tuBUS = new ThucUongBUS();
                double tongTien = 0;
                if (hdtBUS.LayHDTamTheoMaBan(maBan, ListHDTam) != null)
                {
                    foreach (ThucUongDTO tu in hdtBUS.LayHDTamTheoMaBan(maBan, ListHDTam).ListTUTam)
                    {
                        double GiaTU = tuBUS.TimGiaTUTheoMaTU(tu.Matu);
                        double ThanhTien = GiaTU * tu.Soluong;
                        tongTien += ThanhTien;

                        ListViewItem lvi = new ListViewItem(tu.Matu.ToString());
                        lvi.SubItems.Add(tu.Tentu);
                        lvi.SubItems.Add(tu.Soluong.ToString());
                        lvi.SubItems.Add(GiaTU.ToString());
                        lvi.SubItems.Add(ThanhTien.ToString());
                        

                        lvwHoaDon.Items.Add(lvi);

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
                //if (hdbus.ThemThucUongTheoBan(BanGlobal, TaiKhoanGlobal.Manv, cboThucUong.Text, cboLoaiThucUong.Text, Convert.ToInt32(nmrSoLuong.Value)))
                //{
                //    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                //    btnThanhToan.Enabled = true;
                //    btnChuyenBan.Enabled = true;
                //    BanGlobal.Trangthai = 2;
                //    LoadThongTinHD(BanGlobal.Soban);
                //    LoadDsBan(BanGlobal);
                //}
                //else
                //    MessageBox.Show("Thêm Thất Bại", "Thông Báo");

                ThucUongDTO tudto = new ThucUongDTO
                {
                    Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue),
                    Matu = Convert.ToInt32(cboThucUong.SelectedValue),
                    Soluong = Convert.ToInt32(nmrSoLuong.Value),
                    Tentu = cboThucUong.SelectedText
                };

                if (ListHDTam.Count()>0)
                {
                    for(int i = 0; i < ListHDTam.Count();i++)
                    {
                        if(ListHDTam[i].MaBan == BanGlobal.Soban )
                        {
                            int dem = 0;
                            foreach (ThucUongDTO tu in ListHDTam[i].ListTUTam)
                            {
                                if (tu.Matu == tudto.Matu)
                                {
                                    tu.Soluong += tudto.Soluong;
                                    dem++;
                                    break;
                                }
                            }

                            if(dem ==0)
                            ListHDTam[i].ListTUTam.Add(tudto);

                            break;
                        }
                        if (i == ListHDTam.Count()-1)
                        {
                            HoaDonTamDTO hdtam = new HoaDonTamDTO();
                            hdtam.MaBan = BanGlobal.Soban;                  
                            hdtam.ListTUTam.Add(tudto);
                            ListHDTam.Add(hdtam);
                        }
                    }
                }
                else
                {
                    HoaDonTamDTO hdtam = new HoaDonTamDTO();
                    hdtam.MaBan = BanGlobal.Soban;
                    hdtam.ListTUTam.Add(tudto);
                    ListHDTam.Add(hdtam);
                }
                
            }
            else
                MessageBox.Show("Chưa Nhập Đầy Đủ Thông Tin Thức Uống", "Thông Báo");

            LoadThongTinHD(BanGlobal.Soban);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDonTamBUS hdtbus = new HoaDonTamBUS();
            HoaDonTamDTO hdtam = new HoaDonTamDTO();
            hdtam = hdtbus.LayHDTamTheoMaBan(BanGlobal.Soban, ListHDTam);

            DialogResult mes = MessageBox.Show("Bạn Muốn Thanh Toán Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mes==DialogResult.Yes)
            {
                if (hdbus.ThanhToan(BanGlobal,Convert.ToDouble(txtTongTien.Text),hdtam,TaiKhoanGlobal.Manv))
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
            if (banBUS.KiemTraBanCoNguoiChua(Convert.ToInt32(cboChuyenBan.SelectedValue),ListHDTam) && cboChuyenBan.SelectedText !="" && cboChuyenBan.SelectedText != BanGlobal.Tenban)
            {
                DialogResult res = MessageBox.Show("Bàn Đã Có Người. Bàn Muốn Sự Lựa Chọn Khác Không?  ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    res = MessageBox.Show(" Thêm Các Món Vào Bàn Đã Chọn (Quen Biết) ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (hdbus.ChuyenBan(BanGlobal,Convert.ToInt32(cboChuyenBan.SelectedValue),ListHDTam))
                        { 
                            MessageBox.Show(" Thành Công", "Thông Báo");
                            //BanGlobal.Trangthai = 0;
                            LoadDsBan(BanGlobal);
                            lvwHoaDon.Items.Clear();
                        }
                        else
                            MessageBox.Show(" Thất Bại", "Thông Báo");
                    }
                }
            }
            else if (cboChuyenBan.SelectedText != "" && cboChuyenBan.SelectedText != BanGlobal.Tenban)
            {
                if (hdbus.ChuyenBan(BanGlobal, Convert.ToInt32(cboChuyenBan.SelectedValue), ListHDTam))
                { 
                            MessageBox.Show(" Thành Công", "Thông Báo");                     
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

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            double tongTien = Convert.ToDouble(txtTongTien.Text);
            tongTien = tongTien - (tongTien * Convert.ToDouble(nmrPhanTramGiamGia.Value) / 100);
            txtTongTien.Text = tongTien.ToString();
        }

        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListViewItem lvw = lvwHoaDon.SelectedItems[0];
            if(lvw != null)
            lvwHoaDon.Items.Remove(lvw);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListViewItem lvw = lvwHoaDon.SelectedItems[0];
            if (lvw != null)
            {
                foreach (HoaDonTamDTO hd in ListHDTam)
                {
                    if (hd.MaBan == BanGlobal.Soban)
                    {
                        foreach (ThucUongDTO tu in hd.ListTUTam)
                        {
                            if (tu.Matu == Convert.ToInt32(lvw.SubItems[0].Text))
                            {
                                tu.Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue);
                                tu.Matu = Convert.ToInt32(cboThucUong.SelectedValue);
                                tu.Soluong = Convert.ToInt32(nmrSoLuong.Value);
                                break;
                            }
                        }
                        break;
                    }
                }
            }

        }

        private void lvwHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvw = lvwHoaDon.SelectedItems[0];
            cboThucUong.SelectedText = lvw.SubItems[0].Text;
        }
    }
}
