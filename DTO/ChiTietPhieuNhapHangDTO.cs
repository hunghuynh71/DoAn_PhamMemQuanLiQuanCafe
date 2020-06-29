using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapHangDTO
    {
        private int mapnh;

        public int Mapnh
        {
            get { return mapnh; }
            set { mapnh = value; }
        }

        private int mahh;

        public int Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private string tenhh;

        public string Tenhh
        {
            get { return tenhh; }
            set { tenhh = value; }
        }
    }
}
