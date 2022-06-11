using BaiDangConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHOALUAN.Models.BUS
{
    public class WebDangKyHB
    {
        public static IEnumerable<HocBong> DanhSach()
        {
            var db = new BaiDangConnectionDB();
            return db.Query<HocBong>("select * from HocBong");
        }
        public static HocBong chitiet(string a)
        {
            var db = new BaiDangConnectionDB();
            return db.SingleOrDefault<HocBong>("select * from HocBong where idHocBong= @0", a);
        }
        public static IEnumerable<HocBong> DanhSachHB()
        {
            var db = new BaiDangConnectionDB();
            return db.Query<HocBong>("select * from HocBong ");
        }
        public static void InsertHB(HocBong hb)
        {
            var db = new BaiDangConnectionDB();
            db.Insert(hb);
        }
        public static void ThemHB(HocBong hb)
        {
            var db = new BaiDangConnectionDB();
            db.Insert(hb);
        }
        public static void UpdateHB(String id, HocBong hb)
        {
            var db = new BaiDangConnectionDB();
            db.Update(hb, id);
        }
    }
}