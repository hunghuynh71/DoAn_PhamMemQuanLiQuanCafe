﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ThucUongBUS
    {
        ThucUongDAO tuTam = new ThucUongDAO();

        public List<ThucUongDTO> LoadDsTU()
        {
            return tuTam.LoadDsThucUong();
        }

        public ThucUongDTO TimKiemTU(string tenTU)
        {
            return tuTam.TimKiemTU(tenTU);
        }

        public bool ThemTU(ThucUongDTO tu)
        {
            return tuTam.ThemTU(tu);
        }

        public bool SuaTU(ThucUongDTO tu)
        {
            return tuTam.SuaTU(tu);
        }

        public bool XoaTU(int maTU)
        {
            return tuTam.XoaTU(maTU);
        }
        public List<ThucUongDTO> TimDrinkTheoTenLoaiDrink(string TenLoaiTU)
        {
            return tuTam.TimDrinkTheoTenLoaiTU(TenLoaiTU);
        }
        public double TimGiaTUTheoMaTU(int MaTU)
        {
            return tuTam.TimGiaBanTheoMaTU(MaTU);
        }

    }
}
