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
        //QUAN_LI_QUAN_CAFE_HBKEntities db=new QUAN_LI_QUAN_CAFE_HBKEntities();
        BanDTO BanGlobal = new BanDTO();
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        HoaDonBUS hdbus = new HoaDonBUS();
        BanBUS banBUS = new BanBUS();
        public frmBanHang()
        {
            InitializeComponent();
            //LoadDsLoaiThucUong();
            //LoadDsThucUong();
        }
        public frmBanHang(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;
            InitializeComponent();
        }


        
        #region Method
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDsBan();
            LoadcboChuyenBan();
            LoadcboLoaiThucUong();
            LoadcboThucUong();
        }


        //void LoadDsLoaiThucUong()
        //{
        //    var result = from c in db.LOAI_THUC_UONG
        //                 where c.TRANGTHAIXOA == false
        //                 select c.TENLOAITU;
        //    cboLoaiThucUong.DataSource = result.ToList();
        //}

        //void LoadDsThucUong()
        //{
        //    var result = from c in db.THUC_UONG
        //                 where c.TRANGTHAIXOA == false
        //                 select c.TENTU;
        //    cboThucUong.DataSource = result.ToList();
        //}
   
        void LoadDsBan()
        {
            List<BanDTO> dsBan = banBUS.LoadDsBan();

            foreach(BanDTO item in dsBan)
            {
                Button button = new Button() { Width=70, Height=70};

                button.Click += button_Click;
                button.Leave += button_Leave;
                button.Tag = item;

                if(item.Trangthai==0)
                {
                    button.Text = item.Tenban + "\nTrống";
                    button.BackColor = Color.LightGreen;
                }
                else
                {
                    button.Text = item.Tenban + "\nCó người";
                    button.BackColor = Color.LightPink;
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


       
        void LoadThongTinHD(int maBan)
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
                    lvi.SubItems.Add(item.Gianiemyet.ToString());
                    lvi.SubItems.Add(item.Thanhtien.ToString());

                    lvwHoaDon.Items.Add(lvi);

                    tongTien += item.Thanhtien;
                }

                txtTongTien.Text = tongTien.ToString();
                txtTongTien.ReadOnly = true;
            }
            //else if (hdTam == null)
            //{
            //    //hdDTO = new HoaDonDTO();
            //    MessageBox.Show("ĐMM");
            //}               
            
        }

        #endregion


        #region Event

        private void button_Click(object sender, EventArgs e)
        {
            BanGlobal = ((sender as Button).Tag as BanDTO);
            int maBan = ((sender as Button).Tag as BanDTO).Soban;
            (sender as Button).Text += " Đang Chọn";
            LoadThongTinHD(maBan);
            btnThemThucUong.Enabled = true;
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

        void button_Leave(object sender, EventArgs e)
        {
           BanDTO item = (sender as Button).Tag as BanDTO;
            if (item.Trangthai == 0)
            {
                (sender as Button).Text = item.Tenban + "\nTrống";
                (sender as Button).BackColor = Color.LightGreen;
            }
            else if (item.Trangthai == 1)
            {
                (sender as Button).Text = item.Tenban + "\nCó người";
                (sender as Button).BackColor = Color.LightPink;
            }
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            if (cboThucUong.Text != null && cboLoaiThucUong != null)
            {
                if (hdbus.ThemThucUongTheoBan(BanGlobal, TaiKhoanGlobal.Manv, cboThucUong.Text, cboLoaiThucUong.Text, Convert.ToInt32(nmrSoLuong.Value)))
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
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
                if(hdbus.ThanhToan(BanGlobal))
                    MessageBox.Show("Thanh Toán Thành Công", "Thông Báo");
            }   
            else
            {
                MessageBox.Show("Đã Hủy Thanh Toán", "Thông Báo");
            }    

        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (banBUS.KiemTraBanCoNguoiChua(cboChuyenBan.Text))
            {
                DialogResult res = MessageBox.Show("Bàn Đã Có Người. Bàn Muốn Sự Lựa Chọn Khác Không?  ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    res = MessageBox.Show(" Thêm Các Món Vào Bàn Đã Chọn (Quen Biết) ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (banBUS.ChuyenBan(BanGlobal, cboChuyenBan.Text))
                            MessageBox.Show(" Thành Công", "Thông Báo");
                        else
                            MessageBox.Show(" Thất Bại", "Thông Báo");
                    }
                }
            }
        }
        private void cboThucUong_Leave(object sender, EventArgs e)
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            string LoaiTU = ltubus.TimLoaiTUTheoTenloai(cboThucUong.Text);
            if (LoaiTU != string.Empty)
            {
                cboLoaiThucUong.Text = LoaiTU;
            }
        }
        #endregion


    }
}
