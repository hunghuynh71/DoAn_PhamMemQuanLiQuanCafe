using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuNhapHangDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();
        public List<PhieuNhapHangDTO> loadDsPNH()
        {
            return db.PHIEU_NHAP_HANG.Where(p => p.TRANGTHAIXOA == false).OrderByDescending(p=>p.MAPNH).Select(v => new PhieuNhapHangDTO
            {
                Mapnh = v.MAPNH,
                Maddh = v.MADDH,
                Mancc = v.MANCC,
                Manvlap = v.MANVLAP,
                Ngaylap = v.NGAYLAP,
                Tennvlap = v.NHAN_VIEN.TENNV,
                Tenncc = v.NHA_CUNG_CAP.TENNCC,
                Tongtien = v.TONGTIEN
            }).ToList();
        }
        public bool ThemPNH(PhieuNhapHangDTO ddh, out int maPNH)
        {
            maPNH = 0;
            try
            {
                PHIEU_NHAP_HANG phn = new PHIEU_NHAP_HANG();
                phn.MANVLAP = ddh.Manvlap;
                phn.MANCC = ddh.Mancc;
                phn.NGAYLAP = DateTime.Now;
                phn.MADDH = ddh.Maddh;
                phn.TONGTIEN = ddh.Tongtien;
                db.PHIEU_NHAP_HANG.Add(phn);
                db.SaveChanges();
                maPNH = phn.MAPNH;                
                return true;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        public int GetMaxIdOfPNH()
        {
            return db.PHIEU_NHAP_HANG.Max(p => p.MAPNH);
        }

        public bool CheckTonTaiPNH()
        {
            if (db.PHIEU_NHAP_HANG.Select(p => p).ToList().Count==0)
            {
                return false;
            }
            return true;
        }
    }
}
