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
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();

        public List<ChiTietHoaDonDTO> LoadDsCTHDTheoMaHD(int maHD)
        {
            return db.CHI_TIET_HOA_DON.Where(p => p.MAHD == maHD).Select(p => new ChiTietHoaDonDTO 
            { Tentu=p.THUC_UONG.TENTU, Soluong=p.SL,Giaban=p.GIABAN, Gianiemyet=p.THUC_UONG.GIA, Thanhtien=p.THUC_UONG.GIA*p.SL }).ToList();
        }
    }
}
