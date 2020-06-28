using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();
        
        public List<TaiKhoanDTO> LoadDsTK()
        {
            return db.TAI_KHOAN.Where(p => p.TRANGTHAIXOA == false).Select(p => new TaiKhoanDTO 
            { Tendangnhap = p.TENDANGNHAP, Matkhau = p.MATKHAU, Loaitaikhoan = p.LOAITAIKHOAN, Tennv=p.NHAN_VIEN.TENNV}).ToList();
        }

        public TaiKhoanDTO TimKiemTK(string tenDN)
        {
            return db.TAI_KHOAN.Where(p => p.TRANGTHAIXOA == false && p.TENDANGNHAP == tenDN).Select(p => new TaiKhoanDTO 
            { Tendangnhap = p.TENDANGNHAP, Matkhau = p.MATKHAU, Loaitaikhoan = p.LOAITAIKHOAN, Manv = p.MANV }).SingleOrDefault();
        }

        public bool ThemTK(TaiKhoanDTO tk)
        {
            try
            {
                //Lưu ý do dùng TENDANGNHAP làm khóa nên khi thêm 1 tên ĐN trùng với 1 tên đã có thì sẽ thêm thất bại
                TAI_KHOAN tkDB = new TAI_KHOAN
                {
                    TENDANGNHAP=tk.Tendangnhap,
                    MATKHAU=tk.Matkhau,
                    LOAITAIKHOAN=tk.Loaitaikhoan,
                    MANV=tk.Manv
                };
                db.TAI_KHOAN.Add(tkDB);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTK(string tenDN)
        {
            try
            {
                TAI_KHOAN tkDB = db.TAI_KHOAN.SingleOrDefault(p => p.TENDANGNHAP == tenDN && p.TRANGTHAIXOA == false);
                tkDB.TRANGTHAIXOA = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KiemTraDangNhap(out TaiKhoanDTO tk, string TenDN, string MatKh)
        {
            bool flag = false;

            TaiKhoanDTO KiemTra = db.TAI_KHOAN.Where(u => u.TRANGTHAIXOA == false && u.TENDANGNHAP == TenDN && u.MATKHAU == MatKh).Select(v => new TaiKhoanDTO
            {
                Manv = v.MANV,
                Loaitaikhoan = v.LOAITAIKHOAN,
                Tendangnhap = v.TENDANGNHAP,
                Matkhau = v.MATKHAU,
                Tennv = v.NHAN_VIEN.TENNV
            }).SingleOrDefault();

            if (KiemTra != null)
            {
                tk = KiemTra;
                flag = true;
            }
            else
                tk = null;

            return flag;
        }
    }
}
