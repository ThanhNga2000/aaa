using BaiDangConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHOALUAN.Models.BUS
{
    public class DoanhNghiepBUS
    {
        public static void ThemHB(HocBong hb)
        {
            var db = new BaiDangConnectionDB();
            db.Insert(hb);
        }
    }
}