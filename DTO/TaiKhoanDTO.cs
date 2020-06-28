using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
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

        private int loaitaikhoan;

        public int Loaitaikhoan
        {
            get { return loaitaikhoan; }
            set { loaitaikhoan = value; }
        }

        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        private string tendangnhap;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
    }
}
