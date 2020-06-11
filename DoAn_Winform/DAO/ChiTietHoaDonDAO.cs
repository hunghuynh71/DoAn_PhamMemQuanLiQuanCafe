using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<ChiTietHoaDonDTO> LoadDsCTHDTheoMaHD(int maHD)
        {
            return db.CHI_TIET_HOA_DON.Where(p => p.MAHD == maHD).Select(p => new ChiTietHoaDonDTO 
            { Tentu=p.THUC_UONG.TENTU, Soluong=p.SL, Gianiemyet=p.THUC_UONG.GIA, Thanhtien=p.THUC_UONG.GIA*p.SL }).ToList();
        }
    }
}
