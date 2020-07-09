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
        public int MaBan { get => MaBan; set => MaBan = value; }


        List<ThucUongDTO> listTUTam = new List<ThucUongDTO>();   
        public List<ThucUongDTO> ListTUTam { get => listTUTam; set => listTUTam = value; }
    }
}
