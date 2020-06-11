using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdTam = new HoaDonDAO();
        public HoaDonDTO LoadHDChuaThanhToanTheoMaBan(int maBan)
        {
            return hdTam.LoadHDChuaThanhToanTheoMaBan(maBan);
        }
    }
}
