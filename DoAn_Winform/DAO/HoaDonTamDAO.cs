using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonTamDAO
    {


      public  HoaDonTamDTO LayHDTheoMaBan(int MaBan , List<HoaDonTamDTO> lhdtam)
      {
            HoaDonTamDTO hdtam = new HoaDonTamDTO();
            hdtam = null;
            if (lhdtam != null)
            {
                foreach (HoaDonTamDTO hd in lhdtam)
                {
                    if (hd.MaBan == MaBan)
                    {
                        hdtam = hd;
                        break;
                    }
                }
            }
            return hdtam;
        }

    }
}
