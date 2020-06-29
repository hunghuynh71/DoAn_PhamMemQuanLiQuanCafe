using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DonDatHangBUS
    {
        DonDatHangDAO ddhDAO = new DonDatHangDAO();

        public List<DonDatHangDTO> LoadDsDDH()
        {
            return ddhDAO.LoadDsDDH();
        }

        public bool ThemDDH(DonDatHangDTO ddh, out int maDDH)
        {
            return ddhDAO.ThemDDH(ddh, out maDDH);
        }

        public void DuyetDDH(int maDDH)
        {
            ddhDAO.DuyetDDH(maDDH);
        }
    }
}
