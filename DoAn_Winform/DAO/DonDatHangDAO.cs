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
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false).OrderByDescending(p => p.MADDH).Select(p => new DonDatHangDTO 
            { 
                Maddh = p.MADDH, 
                Ngaylap = p.NGAYLAP.Value, 
                Manvlap = p.MANVLAP, 
                Mancc = p.MANCC, 
                Ngaygiao = p.NGAYGIAO, 
                Trangthaiduyet = p.TRANGTHAIDUYET, 
                Tennvlap = p.NHAN_VIEN.TENNV
            }).ToList();
        }

        public List<DonDatHangDTO> LoadDsDDH(TaiKhoanDTO tk)
        {
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false && p.MANVLAP == tk.Manv).OrderByDescending(p => p.MADDH).Select(p => new DonDatHangDTO 
            { 
                Maddh = p.MADDH, 
                Ngaylap = p.NGAYLAP.Value, 
                Manvlap = p.MANVLAP, 
                Mancc = p.MANCC, 
                Ngaygiao = p.NGAYGIAO, 
                Trangthaiduyet = p.TRANGTHAIDUYET, 
                Tennvlap = p.NHAN_VIEN.TENNV 
            }).ToList();
        }

        public List<DonDatHangDTO> LoadDsDDHDaDuyet()
        {
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false && p.TRANGTHAIDUYET == true).OrderByDescending(p => p.MADDH).Select(p => new DonDatHangDTO
            {
                Maddh = p.MADDH,
                Ngaylap = p.NGAYLAP.Value,
                Manvlap = p.MANVLAP,
                Mancc = p.MANCC,
                Ngaygiao = p.NGAYGIAO,
                Trangthaiduyet = p.TRANGTHAIDUYET,
                Tennvlap = p.NHAN_VIEN.TENNV
            }).ToList();
        }

        public List<DonDatHangDTO> LoadDsDDHDaDuyet(DateTime tuNgay, DateTime denNgay)
        {
            return db.DON_DAT_HANG.Where(p => p.TRANGTHAIXOA == false && p.TRANGTHAIDUYET == true && p.NGAYLAP > tuNgay && p.NGAYLAP < denNgay).OrderByDescending(p => p.MADDH).Select(p => new DonDatHangDTO
            {
                Maddh = p.MADDH,
                Ngaylap = p.NGAYLAP.Value,
                Manvlap = p.MANVLAP,
                Mancc = p.MANCC,
                Ngaygiao = p.NGAYGIAO,
                Trangthaiduyet = p.TRANGTHAIDUYET,
                Tennvlap = p.NHAN_VIEN.TENNV
            }).ToList();
        }

        public bool ThemDDH(DonDatHangDTO ddh, out int maDDH)
        {
            maDDH = 0;
            try
            {
                DON_DAT_HANG ddhtam = new DON_DAT_HANG();
                ddhtam.MANVLAP = ddh.Manvlap;
                ddhtam.MANCC = ddh.Mancc;
                ddhtam.NGAYLAP = DateTime.Now;
                ddhtam.NGAYGIAO = ddh.Ngaygiao;
                db.DON_DAT_HANG.Add(ddhtam);
                db.SaveChanges();
                maDDH = ddhtam.MADDH;
                return true;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        // hàm test 
        public bool ThemDonDatHangTest(List<HangHoaDTO> listHH,DateTime NgayGiao,int Mancc,int manvlap)
        {
            try
            {  // Tao đơn đặt hàng
                DON_DAT_HANG ddh = new DON_DAT_HANG();
                ddh.MANCC = Mancc;
                ddh.MANVLAP = manvlap;
                ddh.NGAYGIAO = NgayGiao;
                ddh.NGAYLAP = DateTime.Now;
                db.DON_DAT_HANG.Add(ddh);
                db.SaveChanges();
                // tạo chi tiết hóa đơn
                foreach (HangHoaDTO hhdto in listHH)
                {
                    int hh = db.HANG_HOA.Where(u => u.TENHH == hhdto.Tenhh && u.TRANGTHAIXOA == false).SingleOrDefault().MAHH;

                    CHI_TIET_DON_DAT_HANG ctddh = new CHI_TIET_DON_DAT_HANG
                    {
                        MADDH = ddh.MADDH,
                        MAHH = hh,
                        SL = hhdto.Slton
                    };
                    db.CHI_TIET_DON_DAT_HANG.Add(ctddh);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
       
        }

        public bool XoaDDH(int maDDH)
        {
            try
            {
                DON_DAT_HANG ddhtam = db.DON_DAT_HANG.Where(p => p.MADDH == maDDH && p.TRANGTHAIXOA == false && p.TRANGTHAIDUYET == false).SingleOrDefault();
                if (ddhtam != null)
                {
                    ddhtam.TRANGTHAIXOA = true;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception r)
            {
                return false;
            }
        }

        public void DuyetDDH(int maDDH)
        {
            DON_DAT_HANG ddhTam = db.DON_DAT_HANG.Where(p => p.MADDH == maDDH && p.TRANGTHAIDUYET == false).SingleOrDefault();
            ddhTam.TRANGTHAIDUYET = true;
            db.SaveChanges();
        }
    }
}
