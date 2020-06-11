using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvTam = new NhanVienDAO();

        public List<NhanVienDTO> LoadDsNV()
        {
            return nvTam.LoadDsNV();
        }

        public bool ThemNV(NhanVienDTO nv)
        {
            return nvTam.ThemNV(nv);
        }

        public bool SuaNV(NhanVienDTO nv)
        {
            return nvTam.SuaNV(nv);
        }

        public bool XoaNV(int maNV)
        {
            return nvTam.XoaNV(maNV);
        }
    }
}
