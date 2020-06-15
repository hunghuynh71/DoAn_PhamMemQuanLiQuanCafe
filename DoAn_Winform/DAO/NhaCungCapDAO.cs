using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();
        public List<NhaCungCapDTO> LoadDsNCC()
        {
            return db.NHA_CUNG_CAP.Where(p => p.TRANGTHAIXOA == false).Select(p => new NhaCungCapDTO 
            { Mancc = p.MANCC, Tenncc = p.TENNCC, Diachi = p.DIACHI, Sdt = p.SDT }).ToList();
        }
        
        public NhaCungCapDTO TimKiemNCC(string tenNCC)
        {
            return db.NHA_CUNG_CAP.Where(p => p.TRANGTHAIXOA == false && p.TENNCC == tenNCC).Select(p => new NhaCungCapDTO 
            { Mancc=p.MANCC, Tenncc = p.TENNCC, Diachi = p.DIACHI, Sdt = p.SDT }).SingleOrDefault();
        }

        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            try
            {
                NHA_CUNG_CAP nccDB = new NHA_CUNG_CAP
                {
                    TENNCC=ncc.Tenncc,
                    DIACHI=ncc.Diachi,
                    SDT=ncc.Sdt
                };
                db.NHA_CUNG_CAP.Add(nccDB);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                NHA_CUNG_CAP nccDB = db.NHA_CUNG_CAP.SingleOrDefault(p => p.MANCC == ncc.Mancc && p.TRANGTHAIXOA == false);
                nccDB.TENNCC = ncc.Tenncc;
                nccDB.DIACHI = ncc.Diachi;
                nccDB.SDT = ncc.Sdt;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaNCC(int maNCC)
        {
            try
            {
                NHA_CUNG_CAP nccDB = db.NHA_CUNG_CAP.SingleOrDefault(p => p.MANCC == maNCC && p.TRANGTHAIXOA == false);
                nccDB.TRANGTHAIXOA = true;
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
