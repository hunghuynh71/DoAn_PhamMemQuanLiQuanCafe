using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography;

namespace DAO
{
    public class TaiKhoanDAO
    {
        QUAN_LI_QUAN_CAFE_HBKEntities1 db = new QUAN_LI_QUAN_CAFE_HBKEntities1();
        
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

        public string MaHoaChuoi(string input)
        {
            string output;

            MD5 md = MD5.Create();

            byte[] inputSTR = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md.ComputeHash(inputSTR);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++) 
            {
                sb.Append(hash[i].ToString("X"));
            }

            output = sb.ToString();
            return output;
        }

        public bool ThemTK(TaiKhoanDTO tk)
        {
            try
            {
                //Lưu ý do dùng TENDANGNHAP làm khóa nên khi thêm 1 tên ĐN trùng với 1 tên đã có thì sẽ thêm thất bại
                TAI_KHOAN tkDB = new TAI_KHOAN
                {
                    TENDANGNHAP=tk.Tendangnhap,
                    MATKHAU = MaHoaChuoi(tk.Matkhau),
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
            string mk = MaHoaChuoi(MatKh);
            TaiKhoanDTO KiemTra = db.TAI_KHOAN.Where(u => u.TRANGTHAIXOA == false && u.TENDANGNHAP == TenDN && u.MATKHAU == mk).Select(v => new TaiKhoanDTO
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
        public bool SuaTK(TaiKhoanDTO tkSUa,string MatKhaucu,string MatKhauMoi)
        {
            try { 
            TAI_KHOAN tk = new TAI_KHOAN();
            string mkCu=MaHoaChuoi(MatKhaucu);
            string mkMoi = MaHoaChuoi(MatKhauMoi);
            tk = db.TAI_KHOAN.Where(u=> u.TENDANGNHAP == tkSUa.Tendangnhap && u.MATKHAU == mkCu).SingleOrDefault();
            if (tk == null)
                return false;
            tk.MATKHAU = mkMoi;
            db.SaveChanges();
            return true;
            }catch(Exception e)
            {
                return false;
            }
        }
    }
}
