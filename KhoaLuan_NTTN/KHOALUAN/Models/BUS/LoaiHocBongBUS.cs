using BaiDangConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHOALUAN.Models.BUS
{
    public class LoaiHocBongBUS
    {
        public static IEnumerable<LoaiHocBong> DanhSach()
        {
            var db = new BaiDangConnectionDB();
            return db.Query<LoaiHocBong>("select * from LoaiHocBong");
        }
        public static LoaiHocBong Edit(string a)
        {
            var db = new BaiDangConnectionDB();
            return db.SingleOrDefault<LoaiHocBong>("select * from LoaiHocBong where idLHB= @0", a);
        }

        internal static object Edit()
        {
            throw new NotImplementedException();
        }

        public static void ThemLHB(LoaiHocBong lhb)
        {
            var db = new BaiDangConnectionDB();
            db.Insert(lhb);
        }
        public static LoaiHocBong ChiTietAD(String id)
        {
            var db = new BaiDangConnectionDB();
            return db.SingleOrDefault<LoaiHocBong>("select * from LoaiHocBong where idLHB = '" + id + "'");

        }
        public static void UpdateLHB(String id, LoaiHocBong lhb)
        {
            var db = new BaiDangConnectionDB();
            db.Update(lhb, id);
        }
    }
}