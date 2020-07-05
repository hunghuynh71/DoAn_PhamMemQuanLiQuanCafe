using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DonDatHangDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();

        public List<DonDatHangDTO> LoadDsDDH()
        {
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false).OrderByDescending(p => p.MADDH).Select(p => new DonDatHangDTO { Maddh = p.MADDH, Ngaylap = p.NGAYLAP.Value, Manvlap = p.MANVLAP, Mancc = p.MANCC, Ngaygiao = p.NGAYGIAO, Trangthaiduyet = p.TRANGTHAIDUYET, Tennvlap = p.NHAN_VIEN.TENNV}).ToList();
        }

        public bool ThemDDH(DonDatHangDTO ddh, out int maDDH)
        {
            if (this.CheckTonTaiDDH() == false)
                maDDH = 1;
            else
                maDDH = this.GetMaxIdOfDDH() + 1;
            try
            {
                DON_DAT_HANG ddhtam = new DON_DAT_HANG();
                ddh.Maddh = 1;
                ddhtam.MANVLAP = ddh.Manvlap;
                ddhtam.MANCC = ddh.Mancc;
                ddhtam.NGAYLAP = DateTime.Now;
                ddhtam.NGAYGIAO = ddh.Ngaygiao;
                db.DON_DAT_HANG.Add(ddhtam);
                db.SaveChanges();
                return true;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        public int GetMaxIdOfDDH()
        {
            int kq;
            kq=db.DON_DAT_HANG.Max(p => p.MADDH);
            return kq;
        }

        public bool CheckTonTaiDDH()
        {
            if (db.DON_DAT_HANG.Select(p => p).ToList().Count==0)
            {
                return false;
            }
            return true;
        }

        public void DuyetDDH(int maDDH)
        {
            DON_DAT_HANG ddhTam = db.DON_DAT_HANG.Where(p => p.MADDH == maDDH && p.TRANGTHAIDUYET == false).SingleOrDefault();
            ddhTam.TRANGTHAIDUYET = true;
            db.SaveChanges();
        }
    }
}
