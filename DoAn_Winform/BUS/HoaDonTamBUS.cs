using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
  public  class HoaDonTamBUS
    {
        HoaDonTamDAO hdDAO = new HoaDonTamDAO();

        public HoaDonTamDTO LayHDTamTheoMaBan(int MaBan, List<HoaDonTamDTO> lhdtam)
        {
            return hdDAO.LayHDTheoMaBan(MaBan, lhdtam);
        }

    }
}
