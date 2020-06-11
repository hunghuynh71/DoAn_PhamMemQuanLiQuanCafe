using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

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

        private string tennv;

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }

        private int manv;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
    }
}
