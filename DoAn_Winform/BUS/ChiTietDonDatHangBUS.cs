using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietDonDatHangBUS
    {
        ChiTietDonDatHangDAO ctddhDAO = new ChiTietDonDatHangDAO();

        public List<ChiTietDonDatHangDTO> LoadDsChiTietDDHtheoMaDDH(int maDDH)
        {
            return ctddhDAO.LoadDsChiTietDDHTheoMaDDH(maDDH);
        }

        public bool ThemChiTietDDH(ChiTietDonDatHangDTO ct)
        {
            return ctddhDAO.ThemChiTietDDH(ct);
        }

        public bool XoaChiTietDDH(int maDDH, int maHH)
        {
            return ctddhDAO.XoaChiTietDDH(maDDH, maHH);
        }

        public bool SuaChiTietDDH(ChiTietDonDatHangDTO ct)
        {
            return ctddhDAO.SuaChiTietDDH(ct);
        }
    }
}
