using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdTam = new HoaDonDAO();
        public HoaDonDTO LoadHDChuaThanhToanTheoMaBan(int maBan)
        {
            return hdTam.LoadHDChuaThanhToanTheoMaBan(maBan);
        }

        public List<HoaDonDTO> LoadDsHDTrongNgay()
        {
            return hdTam.LoadDsHDTrongNgay();
        }

        public bool ThemThucUongTheoBan(BanDTO ban , int Manv , string TenTU, string LoaiTU,int SoLg)
        {
            return hdTam.ThemThucUongTheoBan(ban,Manv,TenTU,LoaiTU,SoLg);
        }
        public bool ThanhToan(BanDTO ban,double tongTien)
        {
            return hdTam.ThanhToan(ban,tongTien);
        }
        public bool ChuyenBan(BanDTO ban, string TenBan,int MavnLap)
        {
            return hdTam.ChuyenBan(ban, TenBan,MavnLap);
        }
        public List<HoaDonDTO> loadDoanhThu_frmAmin(bool TraCuuTheoNgay, DateTime Start, DateTime End)
        {
            return hdTam.loadDoanhThu_FrmAmin(TraCuuTheoNgay, Start, End);
        }

        public List<HoaDonDTO> LoadDsHD()
        {
            return hdTam.LoadDsHD();
        }
    }
}
