using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHangDTO
    {
        private string tennvlap;

        public string Tennvlap
        {
            get { return tennvlap; }
            set { tennvlap = value; }
        }

        private bool trangthaitaodon;

        public bool Trangthaitaodon
        {
            get { return trangthaitaodon; }
            set { trangthaitaodon = value; }
        }

        private DateTime ngaygiao;

        public DateTime Ngaygiao
        {
            get { return ngaygiao; }
            set { ngaygiao = value; }
        }

        private int mancc;

        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }

        private bool trangthaiduyet;

        public bool Trangthaiduyet
        {
            get { return trangthaiduyet; }
            set { trangthaiduyet = value; }
        }

        private bool trangthaixoa;

        public bool Trangthaixoa
        {
            get { return trangthaixoa; }
            set { trangthaixoa = value; }
        }

        private int manvlap;

        public int Manvlap
        {
            get { return manvlap; }
            set { manvlap = value; }
        }

        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        private int maddh;

        public int Maddh
        {
            get { return maddh; }
            set { maddh = value; }
        }
    }
}
