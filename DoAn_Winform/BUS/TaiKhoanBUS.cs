using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkTam = new TaiKhoanDAO();

        public List<TaiKhoanDTO> LoadDsTK()
        {
            return tkTam.LoadDsTK();
        }

        public bool ThemTK(TaiKhoanDTO tk)
        {
            return tkTam.ThemTK(tk);
        }

        public bool XoaTK(string tenDN)
        {
            return tkTam.XoaTK(tenDN);
        }
    }
}
