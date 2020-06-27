using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietDonDatHangDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<ChiTietDonDatHangDTO> LoadDsChiTietDDHTheoMaDDH(int maDDH)
        {
            return db.CHI_TIET_DON_DAT_HANG.Where(p => p.MADDH == maDDH).Select(p => new ChiTietDonDatHangDTO {Maddh=p.MADDH, Mahh=p.MAHH, Sl=p.SL, Tenhh=p.HANG_HOA.TENHH}).ToList();
        }

        public bool ThemChiTietDDH(ChiTietDonDatHangDTO ctddh)
        {
            try
            {
                CHI_TIET_DON_DAT_HANG ct = new CHI_TIET_DON_DAT_HANG();
                ct.MADDH = ctddh.Maddh;
                ct.MAHH = ctddh.Mahh;
                ct.SL = ctddh.Sl;

                db.CHI_TIET_DON_DAT_HANG.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool XoaChiTietDDH(int maDDH, int maHH)
        {
            try
            {
                CHI_TIET_DON_DAT_HANG ct = db.CHI_TIET_DON_DAT_HANG.SingleOrDefault(p => p.MADDH == maDDH && p.MAHH == maDDH);
                db.CHI_TIET_DON_DAT_HANG.Remove(ct);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaChiTietDDH(ChiTietDonDatHangDTO ctddh)
        {
            try
            {
                CHI_TIET_DON_DAT_HANG ct = db.CHI_TIET_DON_DAT_HANG.SingleOrDefault(p => p.MADDH == ctddh.Maddh && p.MAHH == ctddh.Mahh);
                ct.SL = ctddh.Sl;
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
