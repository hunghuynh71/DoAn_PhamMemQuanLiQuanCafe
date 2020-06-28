using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ThucUongDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<ThucUongDTO> LoadDsThucUong()
        {
            return db.THUC_UONG.Where(p => p.TRANGTHAIXOA == false).Select(p => new ThucUongDTO 
            { Matu = p.MATU, Tentu = p.TENTU, Maloaitu = p.MALOAITU, Gia = p.GIA }).ToList();
        }

        public ThucUongDTO TimKiemTU(string tenTU)
        {
            return db.THUC_UONG.Where(p => p.TRANGTHAIXOA == false && p.TENTU == tenTU).Select(p => new ThucUongDTO 
            { Matu = p.MATU, Tentu = p.TENTU, Maloaitu = p.MALOAITU, Gia = p.GIA }).SingleOrDefault();
        }

        public bool ThemTU(ThucUongDTO tu)
        {
            try
            {
                THUC_UONG tuDB = new THUC_UONG
                {
                    TENTU = tu.Tentu,
                    MALOAITU = tu.Maloaitu,
                    GIA = tu.Gia
                };
                db.THUC_UONG.Add(tuDB);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }            
        }

        public bool SuaTU(ThucUongDTO tu)
        {
            try
            {
                THUC_UONG tuDB = db.THUC_UONG.SingleOrDefault(p => p.MATU == tu.Matu && p.TRANGTHAIXOA == false);
                tuDB.TENTU = tu.Tentu;
                tuDB.MALOAITU = tu.Maloaitu;
                tu.Gia = tu.Gia;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaTU(int maTU)
        {
            try
            {
                THUC_UONG tuDB = db.THUC_UONG.SingleOrDefault(p => p.MATU == maTU && p.TRANGTHAIXOA == false);
                tuDB.TRANGTHAIXOA = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public List<ThucUongDTO> TimDrinkTheoTenLoaiTU(string TenLoaiTU)
        {
            List<ThucUongDTO> ListTU = new List<ThucUongDTO>();
            if(TenLoaiTU == "Tất Cả")
            {
                ListTU = db.THUC_UONG.Where(v=> v.TRANGTHAIXOA==false).Select(u => new ThucUongDTO
                    {
                        Tentu = u.TENTU,
                        Gia = u.GIA,
                        Maloaitu = u.MALOAITU,
                        Matu = u.MATU
                    }).ToList();
            }
            else
            {
                ListTU = db.THUC_UONG.Where(u => u.LOAI_THUC_UONG.TENLOAITU == TenLoaiTU).Select(u => new ThucUongDTO
                {
                    Tentu = u.TENTU,
                    Gia = u.GIA,
                    Maloaitu = u.MALOAITU,
                    Matu = u.MATU
                }).ToList();
            }
            return ListTU;
        }
    
    }
}
