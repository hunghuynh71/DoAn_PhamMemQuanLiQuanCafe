using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucUongDTO
    {
        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private int maloaitu;

        public int Maloaitu
        {
            get { return maloaitu; }
            set { maloaitu = value; }
        }

        private string tentu;

        public string Tentu
        {
            get { return tentu; }
            set { tentu = value; }
        }

        private int matu;

        public int Matu
        {
            get { return matu; }
            set { matu = value; }
        }
    }
}
