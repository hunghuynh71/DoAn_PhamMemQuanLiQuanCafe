using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        private double thanhtien;

        public double Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        private double gianiemyet;

        public double Gianiemyet
        {
            get { return gianiemyet; }
            set { gianiemyet = value; }
        }

        private string tentu;

        public string Tentu
        {
            get { return tentu; }
            set { tentu = value; }
        }

        private double giaban;

        public double Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private int matu;

        public int Matu
        {
            get { return matu; }
            set { matu = value; }
        }

        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
    }
}
