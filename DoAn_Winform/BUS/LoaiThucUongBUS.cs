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

        public LoaiThucUongDTO TimKiemLoaiTU(string tenLTU)
        {
            return loaituTam.TimKiemLoaiTU(tenLTU);
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
