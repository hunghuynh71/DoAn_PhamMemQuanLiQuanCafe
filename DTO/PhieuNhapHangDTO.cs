using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieunhapHangDTO
    {
        private int mapnh;

        public int Mapnh
        {
            get { return mapnh; }
            set { mapnh = value; }
        }

        private int mancc;

        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }

        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        private int manvlap;

        public int Manvlap
        {
            get { return manvlap; }
            set { manvlap = value; }
        }

        private int maddh;

        public int Maddh
        {
            get { return maddh; }
            set { maddh = value; }
        }

        private int trangthaixoa;

        public int Trangthaixoa
        {
            get { return trangthaixoa; }
            set { trangthaixoa = value; }
        }


        private string tenhanghoa;

        public string Tenhanghoa
        {
            get { return tenhanghoa; }
            set { tenhanghoa = value; }
        }

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}
