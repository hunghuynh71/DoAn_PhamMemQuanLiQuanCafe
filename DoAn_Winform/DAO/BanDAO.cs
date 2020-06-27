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
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();
        public List<BanDTO> LoadDsBan()
        {
            return db.BANs.Where(p => p.TRANGTHAIXOA == false).Select(p => new BanDTO 
            { Soban = p.SOBAN, Tenban = p.TENBAN, Socho = p.SOCHO, Trangthai = p.TRANGTHAI }).ToList();
        }

        public BanDTO TimKiemBan(string tenBan)
        {
            return db.BANs.Where(p => p.TRANGTHAIXOA == false && p.TENBAN == tenBan).Select(p => new BanDTO 
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
                BAN banDB = db.BANs.SingleOrDefault(p => p.SOBAN == ban.Soban && p.TRANGTHAIXOA == false);
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
                BAN banDB = db.BANs.SingleOrDefault(p => p.SOBAN == maBan && p.TRANGTHAIXOA == false);
                banDB.TRANGTHAIXOA = true;
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
            if (db.BANs.Where(u => u.TENBAN == TenBanChuyen && u.TRANGTHAI == 0).Count() > 0)
                return true;
            else
                return false;
        }
        public bool ChuyenBan(BanDTO banHienTai, string TenBanMoi)
        {
            try
            {
                BAN banMoi = db.BANs.Where(u => u.TENBAN == TenBanMoi).SingleOrDefault();
                BAN banCu = db.BANs.Where(u => u.SOBAN == banHienTai.Soban).SingleOrDefault();
                if (banMoi != null && banMoi.TRANGTHAI == 0)
                {                   
                    banCu.TRANGTHAI = 0;
                    banMoi.TRANGTHAI = 1;
                    HOA_DON hd = new HOA_DON();
                    hd = db.HOA_DON.Where(u => u.SOBAN == banHienTai.Soban && u.TRANGTHAI == 0 && u.TRANGTHAIXOA == false).SingleOrDefault();
                    hd.SOBAN = banMoi.SOBAN;
                    db.SaveChanges();
                }
                else
                {
                    banCu.TRANGTHAI = 0;
                    HOA_DON hd = new HOA_DON();
                    hd = db.HOA_DON.Where(u => u.SOBAN == banHienTai.Soban && u.TRANGTHAI == 0 && u.TRANGTHAIXOA == false).SingleOrDefault();
                    hd.SOBAN = banMoi.SOBAN;
                    db.SaveChanges();
                }
                return true;
            }catch(Exception e)
            {
                return false;
            }
                
        }
    }
}
