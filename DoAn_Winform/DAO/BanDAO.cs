using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{     
    public class BanDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();
        public List<BanDTO> LoadDsBan()
        {
            return db.BANs.Where(p => p.TRANGTHAI != 0).Select(p => new BanDTO 
            { Soban = p.SOBAN, Tenban = p.TENBAN, Socho = p.SOCHO, Trangthai = p.TRANGTHAI }).ToList();
        }

        public BanDTO TimKiemBan(string tenBan)
        {
            return db.BANs.Where(p => p.TRANGTHAI != 0 && p.TENBAN == tenBan).Select(p => new BanDTO 
            { Soban = p.SOBAN, Tenban = p.TENBAN, Socho = p.SOCHO, Trangthai = p.TRANGTHAI }).SingleOrDefault();
        }

        public bool ThemBan(BanDTO ban)
        {
            try
            {
                BAN banDB = new BAN()
                {
                    SOCHO = ban.Socho,
                    TENBAN = ban.Tenban
                };
                db.BANs.Add(banDB);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SuaBan(BanDTO ban)
        {
            try
            {
                BAN banDB = db.BANs.SingleOrDefault(p => p.SOBAN == ban.Soban && p.TRANGTHAI != 0);
                banDB.SOCHO = ban.Socho;
                banDB.TENBAN = ban.Tenban;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaBan(int maBan)
        {
            try
            {
                BAN banDB = db.BANs.SingleOrDefault(p => p.SOBAN == maBan && p.TRANGTHAI != 0);
                banDB.TRANGTHAI = 0;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool KiemTraBanCoNguoiKhong(string TenBanChuyen)
        {
            // true : Bàn Có Người và ngược Lại
            if (db.BANs.Where(u => u.TENBAN == TenBanChuyen && u.TRANGTHAI == 2).Count() > 0)
                return true;
            else
                return false;
        }
       
    }
}
