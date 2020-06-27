using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<NhanVienDTO> LoadDsNV()
        {
            return db.NHAN_VIEN.Where(p => p.TRANGTHAIXOA == false).Select(p => new NhanVienDTO 
            { Manv = p.MANV, Tennv = p.TENNV, Diachi = p.DIACHI, Sdt = p.SDT, Chucvu = p.CHUCVU }).ToList();  
        }

        public NhanVienDTO TimKiemNV(string tenNV)
        {
            return db.NHAN_VIEN.Where(p => p.TRANGTHAIXOA == false && p.TENNV == tenNV).Select(p => new NhanVienDTO 
            { Manv = p.MANV, Tennv = p.TENNV, Diachi = p.DIACHI, Sdt = p.SDT, Chucvu = p.CHUCVU }).SingleOrDefault();
        }

        public bool ThemNV(NhanVienDTO nv)
        {
            try
            {
                NHAN_VIEN nvDB = new NHAN_VIEN
                {
                    TENNV = nv.Tennv,
                    DIACHI = nv.Diachi,
                    SDT = nv.Sdt,
                    CHUCVU = nv.Chucvu
                };
                db.NHAN_VIEN.Add(nvDB);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNV(NhanVienDTO nv)
        {
            try
            {
                NHAN_VIEN nvDB = db.NHAN_VIEN.SingleOrDefault(p => p.MANV == nv.Manv && p.TRANGTHAIXOA == false);
                nvDB.TENNV = nv.Tennv;
                nvDB.DIACHI = nv.Diachi;
                nvDB.SDT = nv.Sdt;
                nv.Chucvu = nv.Chucvu;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaNV(int maNV)
        {
            try
            {
                NHAN_VIEN nvDB = db.NHAN_VIEN.SingleOrDefault(p => p.MANV == maNV && p.TRANGTHAIXOA == false);
                nvDB.TRANGTHAIXOA = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }    
    }
}
