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
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<DonDatHangDTO> LoadDsDDH()
        {
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false).Select(p => new DonDatHangDTO 
            {Maddh=p.MADDH, Ngaylap=p.NGAYLAP, Manvlap=p.MANVLAP, Mancc=p.MANCC, Ngaygiao=p.NGAYGIAO, Trangthaiduyet=p.TRANGTHAIDUYET, Tennvlap=p.NHAN_VIEN.TENNV}).ToList();
        }

        public bool ThemDDH(DonDatHangDTO ddh)
        {
            try
            {
                DON_DAT_HANG ddhtam = new DON_DAT_HANG();
                ddhtam.MANVLAP = ddh.Manvlap;
                ddhtam.MANCC = ddh.Mancc;
                ddhtam.NGAYGIAO = ddh.Ngaygiao;

                db.DON_DAT_HANG.Add(ddhtam);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            //finally
            //{

            //}
            //return false;
        }
    }
}
