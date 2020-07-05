using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();
        public List<ChiTietPhieuNhapHangDTO> LoadDsChiTietPNHTheoMa(int maPNH)
        {
            return db.CHI_TIET_PHIEU_NHAP_HANG.Where(p => p.MAPNH == maPNH).Select(p => new ChiTietPhieuNhapHangDTO
            {
                Mapnh = p.MAPNH,
                Mahh = p.MAHH,
                Tenhh = p.HANG_HOA.TENHH,
                Gia = p.GIA,
                Soluong = p.SL
            }).ToList();

        }

        public bool ThemChiTietPNH(ChiTietPhieuNhapHangDTO ctpnh)
        {
            try
            {
                CHI_TIET_PHIEU_NHAP_HANG ctpn = new CHI_TIET_PHIEU_NHAP_HANG();
                ctpn.MAPNH = ctpnh.Mapnh;
                ctpn.MAHH = ctpnh.Mahh;
                ctpn.GIA = ctpnh.Gia;
                ctpn.SL = ctpnh.Soluong;
                db.CHI_TIET_PHIEU_NHAP_HANG.Add(ctpn);
                db.SaveChanges();
                return true;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        public bool XoaChiTietPNH(int maPNH, int maHH)
        {
            try
            {
                CHI_TIET_PHIEU_NHAP_HANG ct = db.CHI_TIET_PHIEU_NHAP_HANG.SingleOrDefault(p => p.MAPNH == maPNH && p.MAHH == maHH);
                db.CHI_TIET_PHIEU_NHAP_HANG.Remove(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaChiTietPNH(ChiTietPhieuNhapHangDTO ctpnh)
        {
            try
            {
                CHI_TIET_PHIEU_NHAP_HANG ct = db.CHI_TIET_PHIEU_NHAP_HANG.SingleOrDefault(p => p.MAPNH == ctpnh.Mapnh && p.MAHH == ctpnh.Mahh);
                ct.SL = ctpnh.Soluong;
                ct.GIA = ctpnh.Gia;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
