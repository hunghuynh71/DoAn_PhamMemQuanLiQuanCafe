using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public HoaDonDTO LoadHDChuaThanhToanTheoMaBan(int maBan)
        {
            //return db.HOA_DON.Where(p => p.SOBAN == maBan && p.TRANGTHAI == 0).Select(c => new HoaDonDTO
            //{
            //    Tentu = c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.TENTU).FirstOrDefault(),
            //    Soluong = c.CHI_TIET_HOA_DON.Select(u => u.SL).FirstOrDefault(),
            //    Gianiemyet = c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.GIA).FirstOrDefault(),
            //    Thanhtien = c.CHI_TIET_HOA_DON.Select(u => u.SL).FirstOrDefault() * c.CHI_TIET_HOA_DON.Select(u => u.THUC_UONG.GIA).FirstOrDefault()
            //}).SingleOrDefault();

            return db.HOA_DON.Where(p => p.SOBAN == maBan && p.TRANGTHAI == 0).Select(u => new HoaDonDTO 
            { Mahd = u.MAHD, Ngaylap = u.NGAYLAP, Manvlap = u.MANVLAP, Soban = u.SOBAN, Trangthai = u.TRANGTHAI }).SingleOrDefault();
        }
    
        public bool ThemThucUongTheoBan(BanDTO ban,int MaNVLap , string TenTU, string LoaiTU,int SoLg)
        {
            bool flag;
            try
            {//Lay Thong Tin Thuc Uong Theo TenTu Va Loai Tu
                THUC_UONG MonAn = new THUC_UONG();
                HoaDonDTO mahd = db.HOA_DON.Where(u => u.SOBAN == ban.Soban && u.TRANGTHAI == 0).Select(v => new HoaDonDTO { Mahd = v.MAHD }).SingleOrDefault();
                MonAn = db.THUC_UONG.Where(u => u.TRANGTHAIXOA == false && u.TENTU == TenTU && u.LOAI_THUC_UONG.TENLOAITU == LoaiTU).SingleOrDefault();
                //Lap Hoa Don

               
                if (ban.Trangthai == 0)
                {
                    HOA_DON hdAdd = new HOA_DON
                    {
                        SOBAN = ban.Soban,
                        NGAYLAP = DateTime.Now,
                        TRANGTHAIXOA = false,
                        TRANGTHAI = 0,
                        MANVLAP = MaNVLap
                    };
                    db.HOA_DON.Add(hdAdd);
                    db.SaveChanges();
                    CHI_TIET_HOA_DON cthdAdd = new CHI_TIET_HOA_DON
                    {
                        MAHD = hdAdd.MAHD,
                        MATU = MonAn.MATU,
                        SL = SoLg,
                        GIABAN = MonAn.GIA
                    };
                    db.CHI_TIET_HOA_DON.Add(cthdAdd);
                }
                else 
                {
                    CHI_TIET_HOA_DON ctHoaDon = new CHI_TIET_HOA_DON();
                    if (db.CHI_TIET_HOA_DON.Where(u => u.MATU == MonAn.MATU &&  u.MAHD == mahd.Mahd && mahd.Soban== ban.Soban).SingleOrDefault() != null)
                    {
                        ctHoaDon = db.CHI_TIET_HOA_DON.Where(u => u.MATU == MonAn.MATU && u.MAHD == mahd.Mahd && mahd.Soban == ban.Soban).SingleOrDefault();
                        ctHoaDon.SL  += SoLg;
                    }
                    else
                    {
                        ctHoaDon.MAHD = mahd.Mahd;
                        ctHoaDon.MATU = MonAn.MATU;
                        ctHoaDon.SL = SoLg;
                        ctHoaDon.GIABAN = MonAn.GIA;
                        db.CHI_TIET_HOA_DON.Add(ctHoaDon);
                    }
                  
                }
                db.SaveChanges();
                //Lap Chi Tiet Hoa Don Sau Khi Đã có Hóa Đơn 

                flag = true;
            }
            catch(Exception e)
            {
                flag = false;
            }
            return flag;
        }
        
        public bool ThanhToan(BanDTO ban)
        {
            bool flag;
            try
            {
                HOA_DON hd = db.HOA_DON.Where(u => u.SOBAN == ban.Soban && u.TRANGTHAI == 0).SingleOrDefault();
                hd.TRANGTHAI = 1;
                db.SaveChanges();
                flag = true;
            }
            catch(Exception e)
            {
                flag = false;
            }
            return flag;
        }
       
       
    
    }
}
