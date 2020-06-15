using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HangHoaDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<HangHoaDTO> LoadDsHH()
        {
            return db.HANG_HOA.Where(p => p.TRANGTHAIXOA == false).Select(p => new HangHoaDTO 
            { Mahh = p.MAHH, Tenhh = p.TENHH, Dvt = p.DVT, Slton = p.SLTON }).ToList();
        }

        public HangHoaDTO TimKiemHH(string tenHH)
        {
            return db.HANG_HOA.Where(p => p.TRANGTHAIXOA == false && p.TENHH == tenHH).Select(p => new HangHoaDTO 
            { Mahh = p.MAHH, Tenhh = p.TENHH, Dvt = p.DVT, Slton = p.SLTON }).SingleOrDefault();

        }

        public bool ThemHH(HangHoaDTO hh)
        {
            try
            {
                HANG_HOA hhDB = new HANG_HOA
                {
                    TENHH = hh.Tenhh,
                    DVT = hh.Dvt,
                    SLTON = hh.Slton
                };
                db.HANG_HOA.Add(hhDB);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SuaHH(HangHoaDTO hh)
        {
            try
            {
                HANG_HOA hhDB = db.HANG_HOA.SingleOrDefault(p => p.MAHH == hh.Mahh && p.TRANGTHAIXOA == false);
                hhDB.TENHH = hh.Tenhh;
                hhDB.DVT = hh.Dvt;
                hhDB.SLTON = hh.Slton;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaHH(int maHH)
        {
            try
            {
                HANG_HOA hhDB = db.HANG_HOA.SingleOrDefault(p => p.MAHH == maHH && p.TRANGTHAIXOA == false);
                hhDB.TRANGTHAIXOA = true;
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