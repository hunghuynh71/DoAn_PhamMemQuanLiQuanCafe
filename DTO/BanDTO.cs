using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        private int trangthai;

        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        private int socho;

        public int Socho
        {
            get { return socho; }
            set { socho = value; }
        }

        private string tenban;

        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }

        private int soban;

        public int Soban
        {
            get { return soban; }
            set { soban = value; }
        }
    }
}
