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
            return db.HOA_DON.Where(p => p.SOBAN == maBan && p.TRANGTHAI == 0).Select(u => new HoaDonDTO 
            { Mahd = u.MAHD, Ngaylap = u.NGAYLAP, Manvlap = u.MANVLAP, Soban = u.SOBAN, Trangthai = u.TRANGTHAI }).SingleOrDefault();
        }
    
        public bool ThemThucUongTheoBan(BanDTO ban,int MaNVLap , string TenTU, string LoaiTU,int SoLg)
        {
            bool flag;
            try
            {//Lay Thong Tin Thuc Uong Theo TenTu Va Loai Tu
                THUC_UONG MonAn = new THUC_UONG();
                MonAn = db.THUC_UONG.Where(u => u.TRANGTHAIXOA == false && u.TENTU == TenTU && u.LOAI_THUC_UONG.TENLOAITU == LoaiTU).SingleOrDefault();
                //Lap Hoa Don

               
                if (ban.Trangthai == 0)
                {
                    BAN bandb = new BAN();
                    bandb = db.BANs.Where(u => u.SOBAN == ban.Soban).SingleOrDefault();
                    bandb.TRANGTHAI = 1;
                    db.SaveChanges();
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
                    db.SaveChanges();                  
                }
                else 
                {
                    HoaDonDTO mahd = db.HOA_DON.Where(u => u.SOBAN == ban.Soban && u.TRANGTHAI == 0).Select(v => new HoaDonDTO { Mahd = v.MAHD,Soban=v.SOBAN }).SingleOrDefault();
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
                    db.SaveChanges();
                }              
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
                HOA_DON hd = db.HOA_DON.Where(u => u.SOBAN == ban.Soban && u.TRANGTHAI== 0).SingleOrDefault();
                hd.TRANGTHAI = 1;
                db.SaveChanges();
                BAN bandb = db.BANs.Where(u => u.SOBAN == ban.Soban).SingleOrDefault();
                bandb.TRANGTHAI = 0;
                db.SaveChanges();
                flag = true;
            }
            catch(Exception e)
            {
                flag = false;
            }
            return flag;
        }

        public bool ChuyenBan(BanDTO banHienTai, string TenBanMoi,int ManvLap)
        {
            try
            {
                BAN banMoi = db.BANs.Where(u => u.TENBAN == TenBanMoi).SingleOrDefault();
                BAN banCu = db.BANs.Where(u => u.SOBAN == banHienTai.Soban).SingleOrDefault();
                if (banMoi.TRANGTHAI==0) // Bàn Chưa có người
                {
                    banCu.TRANGTHAI = 0;
                    banMoi.TRANGTHAI = 1;
                    HOA_DON hd = new HOA_DON();
                    hd = db.HOA_DON.Where(u => u.SOBAN == banHienTai.Soban && u.TRANGTHAI == 0 && u.TRANGTHAIXOA == false).SingleOrDefault();
                    hd.SOBAN = banMoi.SOBAN;
                    db.SaveChanges();
                }
                else //Ban Có Người
                {

                    banCu.TRANGTHAI = 0;
                    //Lay
                    HOA_DON hd = new HOA_DON();
                    hd = db.HOA_DON.Where(u => u.SOBAN == banMoi.SOBAN && u.TRANGTHAI == 0 && u.TRANGTHAIXOA == false).SingleOrDefault();
                    //  ThemVao Database
                    int MaHDCU = db.HOA_DON.Where(u=> u.SOBAN == banHienTai.Soban && u.TRANGTHAI==0).SingleOrDefault().MAHD;

                    List<ChiTietHoaDonDTO> listCTHDCU = db.CHI_TIET_HOA_DON.Where(u => u.MAHD == MaHDCU).Select(v => new
                        ChiTietHoaDonDTO { 
                                                   Mahd =v.MAHD,
                                                   Giaban=v.GIABAN,
                                                   Matu=v.MATU,
                                                   Tentu=v.THUC_UONG.TENTU,
                                                   Soluong=v.SL                                              
                                        }).ToList();
                    //
                  BanDTO bDTO = new BanDTO {
                  Soban=banMoi.SOBAN,Socho=banMoi.SOCHO,Tenban=banMoi.TENBAN,Trangthai=banMoi.TRANGTHAI};
                  foreach(ChiTietHoaDonDTO cthd in listCTHDCU)
                  {
                      int MaLoaiTu= db.THUC_UONG.Where(u=> u.MATU==cthd.Matu).SingleOrDefault().MALOAITU;
                      string TenLoaiTU= db.LOAI_THUC_UONG.Where(u=> u.MALOAITU== MaLoaiTu).SingleOrDefault().TENLOAITU;
                     
                      if(ThemThucUongTheoBan(bDTO,ManvLap,cthd.Tentu,TenLoaiTU,cthd.Soluong))
                      {
                          
                      }

                  }         
                    // sau khi add vao hd moi hd cu bi huy bo
                  HOA_DON HDCU = new HOA_DON();
                  List<CHI_TIET_HOA_DON> CTHDCU = new List<CHI_TIET_HOA_DON>();
                  HDCU = db.HOA_DON.Where(u => u.SOBAN == banHienTai.Soban && u.TRANGTHAI == 0).SingleOrDefault();
                  CTHDCU = db.CHI_TIET_HOA_DON.Where(u => u.MAHD == HDCU.MAHD).ToList();
                  db.CHI_TIET_HOA_DON.RemoveRange(CTHDCU);             
                  db.SaveChanges();
                  db.HOA_DON.Remove(HDCU);
                  db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    
    }
}
