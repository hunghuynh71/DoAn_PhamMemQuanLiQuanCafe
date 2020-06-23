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
        public frmBanHang()
        {
            InitializeComponent();
            //LoadDsLoaiThucUong();
            //LoadDsThucUong();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDsBan();
        }

        #region Method

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
        BanBUS banBUS = new BanBUS();
        void LoadDsBan()
        {
            List<BanDTO> dsBan = banBUS.LoadDsBan();

            foreach(BanDTO item in dsBan)
            {
                Button button = new Button() { Width=70, Height=70};

                button.Click += button_Click;

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

        HoaDonBUS hdBUS = new HoaDonBUS();
        ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        void LoadThongTinHD(int maBan)
        {
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
            int maBan = ((sender as Button).Tag as BanDTO).Soban;
            LoadThongTinHD(maBan);
        }

        #endregion

    }
}
