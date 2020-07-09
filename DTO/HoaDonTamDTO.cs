using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonTamDTO
    {
        int maBan;

        List<ThucUongDTO> listTUTam;
        public int MaBan { get => MaBan; set => MaBan = value; }
        public List<ThucUongDTO> ListTUTam { get => ListTUTam; set => ListTUTam = value; }
    }
}
