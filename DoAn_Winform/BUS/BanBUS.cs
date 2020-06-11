﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BanBUS
    {
        BanDAO banTam = new BanDAO();
        
        public List<BanDTO> LoadDsBan()
        {
            return banTam.LoadDsBan();
        }

        public bool ThemBan(BanDTO ban)
        {
            return banTam.ThemBan(ban);
        }

        public bool SuaBan(BanDTO ban)
        {
            return banTam.SuaBan(ban);
        }

        public bool XoaBan(int maBan)
        {
            return banTam.XoaBan(maBan);
        }
    }
}
