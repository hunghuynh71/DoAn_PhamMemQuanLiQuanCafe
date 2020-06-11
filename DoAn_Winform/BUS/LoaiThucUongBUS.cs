using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiThucUongBUS
    {
        LoaiThucUongDAO loaituTam = new LoaiThucUongDAO();

        public List<LoaiThucUongDTO> LoadDsLoaiTU()
        {
            return loaituTam.LoadDsLoaiTU();
        }

        public bool ThemLoaiTU(LoaiThucUongDTO ltu)
        {
            return loaituTam.ThemLoaiTU(ltu);
        }

        public bool SuaLoaiTU(LoaiThucUongDTO ltu)
        {
            return loaituTam.SuaLoaiTU(ltu);
        }

        public bool XoaLoaiTU(int maLoaiTU)
        {
            return loaituTam.XoaLoaiTU(maLoaiTU);
        }
    }
}
