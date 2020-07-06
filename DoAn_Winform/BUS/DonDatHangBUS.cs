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

        public List<DonDatHangDTO> LoadDsDDH(TaiKhoanDTO tk)
        {
            return ddhDAO.LoadDsDDH(tk);
        }

        public List<DonDatHangDTO> LoadDsDDHDaDuyet(DateTime tuNgay, DateTime denNgay)
        {
            return ddhDAO.LoadDsDDHDaDuyet(tuNgay, denNgay);
        }

        public List<DonDatHangDTO> LoadDsDDHDaDuyet()
        {
            return ddhDAO.LoadDsDDHDaDuyet();
        }

        public bool ThemDDH(DonDatHangDTO ddh, out int maDDH)
        {
            return ddhDAO.ThemDDH(ddh, out maDDH);
        }

        public bool XoaDDH(int maDDH)
        {
            return ddhDAO.XoaDDH(maDDH);
        }

        public void DuyetDDH(int maDDH)
        {
            ddhDAO.DuyetDDH(maDDH);
        }

        public bool ThemDonDatHangTest(List<HangHoaDTO> hhdto , DateTime ngaygiao,int manv,int mancc)
        {
            return ddhDAO.ThemDonDatHangTest(hhdto, ngaygiao, mancc, manv);
        }
    }
}
