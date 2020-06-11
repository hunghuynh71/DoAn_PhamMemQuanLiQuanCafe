using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiThucUongDTO
    {
        private string tenloaitu;

        public string Tenloaitu
        {
            get { return tenloaitu; }
            set { tenloaitu = value; }
        }

        private int maloaitu;

        public int Maloaitu
        {
            get { return maloaitu; }
            set { maloaitu = value; }
        }
    }
}
