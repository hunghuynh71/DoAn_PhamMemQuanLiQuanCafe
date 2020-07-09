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
        public bool ThanhToan(BanDTO ban,double tongTien, HoaDonTamDTO hdtam, int Manvlap)
        {
            return hdTam.ThanhToan(ban,tongTien,hdtam,Manvlap);
        }
        public bool ChuyenBan(BanDTO banCU, int MaBanMoi,List<HoaDonTamDTO> listhdtam)
        {
            return hdTam.ChuyenBan(banCU, MaBanMoi, listhdtam);
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
