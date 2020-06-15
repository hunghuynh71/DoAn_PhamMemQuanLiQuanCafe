using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HangHoaBUS
    {
        HangHoaDAO hhTam = new HangHoaDAO();

        public List<HangHoaDTO> LoadDsHH()
        {
            return hhTam.LoadDsHH();
        }

        public HangHoaDTO TimKiemHH(string tenHH)
        {
            return hhTam.TimKiemHH(tenHH);
        }

        public bool ThemHH(HangHoaDTO hh)
        {
            return hhTam.ThemHH(hh);
        }

        public bool SuaHH(HangHoaDTO hh)
        {
            return hhTam.SuaHH(hh);
        }

        public bool XoaHH(int maHH)
        {
            return hhTam.XoaHH(maHH);
        }
    }
}
