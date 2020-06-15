using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nccTam = new NhaCungCapDAO();

        public List<NhaCungCapDTO> LoadDsNCC()
        {
            return nccTam.LoadDsNCC();
        }

        public NhaCungCapDTO TimKiemNCC(string tenNCC)
        {
            return nccTam.TimKiemNCC(tenNCC);
        }

        public bool ThemNCC(NhaCungCapDTO ncc)
        {
            return nccTam.ThemNCC(ncc);
        }

        public bool SuaNCC(NhaCungCapDTO ncc)
        {
            return nccTam.SuaNCC(ncc);
        }

        public bool XoaNCC(int maNCC)
        {
            return nccTam.XoaNCC(maNCC);
        }
    }
}
