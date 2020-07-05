using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoaiThucUongDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();

        public List<LoaiThucUongDTO> LoadDsLoaiTU()
        {
            return db.LOAI_THUC_UONG.Where(p => p.TRANGTHAIXOA == false).Select(p => new LoaiThucUongDTO
            { Maloaitu = p.MALOAITU, Tenloaitu = p.TENLOAITU }).ToList();
        }

        public LoaiThucUongDTO TimKiemLoaiTU(string tenLTU)
        {
            return db.LOAI_THUC_UONG.Where(p => p.TRANGTHAIXOA == false && p.TENLOAITU == tenLTU).Select(p => new LoaiThucUongDTO
            { Maloaitu = p.MALOAITU, Tenloaitu = p.TENLOAITU }).SingleOrDefault();
        }

        public bool ThemLoaiTU(LoaiThucUongDTO ltu)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = new LOAI_THUC_UONG
                {
                    TENLOAITU = ltu.Tenloaitu
                };
                db.LOAI_THUC_UONG.Add(ltuDB);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaLoaiTU(LoaiThucUongDTO ltu)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = db.LOAI_THUC_UONG.SingleOrDefault(p => p.MALOAITU == ltu.Maloaitu && p.TRANGTHAIXOA == false);
                ltuDB.TENLOAITU = ltu.Tenloaitu;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaLoaiTU(int maLoaiTU)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = db.LOAI_THUC_UONG.SingleOrDefault(p => p.MALOAITU == maLoaiTU && p.TRANGTHAIXOA == false);
                ltuDB.TRANGTHAIXOA = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string TimLoaiThucUongTheoTenTU(string TenTU)
        {
            string TenLoaiTU;
            
                try
                {   
                    THUC_UONG tu = db.THUC_UONG.Where(u => u.TENTU == TenTU && u.TRANGTHAIXOA == false).SingleOrDefault();
                    if(tu != null)
                        TenLoaiTU = db.LOAI_THUC_UONG.Where(u => u.MALOAITU == tu.MALOAITU).SingleOrDefault().TENLOAITU;
                    else
                        TenLoaiTU = "";
                }
                catch (Exception e)
                {
                    TenLoaiTU = "";
                }
            
            return TenLoaiTU;
        }
    }
}
