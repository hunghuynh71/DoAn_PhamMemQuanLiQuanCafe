using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuNhapHangBUS
    {
        PhieuNhapHangDAO pnhDAO = new PhieuNhapHangDAO();

        public List<PhieuNhapHangDTO> loadDsPNH()
        {
            return pnhDAO.loadDsPNH();
        }

        public bool ThemPNH(PhieuNhapHangDTO pnh, out int maPNH)
        {
            return pnhDAO.ThemPNH(pnh, out maPNH);
        }
    }
}
