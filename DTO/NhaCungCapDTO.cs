using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string tenncc;

        public string Tenncc
        {
            get { return tenncc; }
            set { tenncc = value; }
        }

        private int mancc;

        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
    }
}
