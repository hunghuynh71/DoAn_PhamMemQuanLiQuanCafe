using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietPhieuNhapHangBUS
    {
        ChiTietPhieuNhapDAO ctpnhDAO = new ChiTietPhieuNhapDAO();

        public List<ChiTietPhieuNhapHangDTO> LoadDsChiTietPNHTheoMa(int maPNH)
        {
            return ctpnhDAO.LoadDsChiTietPNHTheoMa(maPNH);
        }

        public bool ThemChiTietPNH(ChiTietPhieuNhapHangDTO ctpnh)
        {
            return ctpnhDAO.ThemChiTietPNH(ctpnh);
        }

        public bool XoaChiTietPNH(int maDDH, int maHH)
        {
            return ctpnhDAO.XoaChiTietPNH(maDDH, maHH);
        }

        public bool SuaChiTietPNH(ChiTietPhieuNhapHangDTO ctpnh)
        {
            return ctpnhDAO.SuaChiTietPNH(ctpnh);
        }
    }
}
