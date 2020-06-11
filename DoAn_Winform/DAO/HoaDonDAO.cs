using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public HoaDonDTO LoadHDChuaThanhToanTheoMaBan(int maBan)
        {
            //return db.HOA_DON.Where(p => p.SOBAN == maBan && p.TRANGTHAI == 0).Select(c => new HoaDonDTO
            //{
            //    Tentu = c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.TENTU).FirstOrDefault(),
            //    Soluong = c.CHI_TIET_HOA_DON.Select(u => u.SL).FirstOrDefault(),
            //    Gianiemyet = c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.GIA).FirstOrDefault(),
            //    Thanhtien = c.CHI_TIET_HOA_DON.Select(u => u.SL).FirstOrDefault() * c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.GIA).FirstOrDefault()
            //}).SingleOrDefault();

            return db.HOA_DON.Where(p => p.SOBAN == maBan && p.TRANGTHAI == 0).Select(u => new HoaDonDTO 
            { Mahd = u.MAHD, Ngaylap = u.NGAYLAP, Manvlap = u.MANVLAP, Soban = u.SOBAN, Trangthai = u.TRANGTHAI }).SingleOrDefault();
        }
    }
}
