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
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();
        public List<PhieunhapHangDTO> loadDsPNH()
        {
            return db.PHIEU_NHAP_HANG.Where(p => p.TRANGTHAIXOA == true).Select(v => new PhieunhapHangDTO
            {
                Mapnh = v.MAPNH,
                Maddh = v.MADDH,
                Mancc = v.MANCC,
                Manvlap = v.MANVLAP,
                Ngaylap = v.NGAYLAP
            }).ToList();
        }
        public bool ThemPNH(PhieunhapHangDTO ddh, out int maPNH)
        {

            if (this.CheckTonTaiPNH() == false)
                maPNH = 1;
            else
                maPNH = GetMaxIdOfPNH() + 1;
            try
            {
                PHIEU_NHAP_HANG phn = new PHIEU_NHAP_HANG();
                phn.MANVLAP = ddh.Manvlap;
                phn.MANCC = ddh.Mancc;
                phn.NGAYLAP = DateTime.Now;

                db.PHIEU_NHAP_HANG.Add(phn);
                db.SaveChanges();
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
            if (db.PHIEU_NHAP_HANG.Select(p => p).ToList() == null)
            {
                return false;
            }
            return true;
        }
    }
}
