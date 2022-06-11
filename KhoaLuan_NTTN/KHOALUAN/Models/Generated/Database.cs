




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `BaiDangConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DESKTOP-RINAG93\SQLEXPRESS;Initial Catalog=KHOALUAN_NTTN;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace BaiDangConnection
{

	public partial class BaiDangConnectionDB : Database
	{
		public BaiDangConnectionDB() 
			: base("BaiDangConnection")
		{
			CommonConstruct();
		}

		public BaiDangConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			BaiDangConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static BaiDangConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new BaiDangConnectionDB();
        }

		[ThreadStatic] static BaiDangConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static BaiDangConnectionDB repo { get { return BaiDangConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.DangKyHocBong")]



	[PrimaryKey("idDangKy", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class DangKyHocBong : BaiDangConnectionDB.Record<DangKyHocBong>  
    {



		[Column] public string idDangKy { get; set; }





		[Column] public string idSinhVien { get; set; }





		[Column] public string idHocBong { get; set; }





		[Column] public string idMinhChung { get; set; }





		[Column] public string tenHB { get; set; }





		[Column] public DateTime tgDangKy { get; set; }





		[Column] public DateTime tgDuyet { get; set; }





		[Column] public string tinhTrang { get; set; }





		[Column] public string GhiChu { get; set; }





		[Column] public string MinhChung2 { get; set; }





		[Column] public string MinhChung3 { get; set; }





		[Column] public string MinhChung4 { get; set; }





		[Column] public string MinhChung1 { get; set; }



	}

    

	[TableName("dbo.Diem")]



	[PrimaryKey("idDiem")]




	[ExplicitColumns]

    public partial class Diem : BaiDangConnectionDB.Record<Diem>  
    {



		[Column] public int idDiem { get; set; }





		[Column] public string idHocKy { get; set; }





		[Column] public string idSinhVien { get; set; }





		[Column] public int soTinChi { get; set; }





		[Column] public double? diemThang4 { get; set; }





		[Column] public double? diemThang10 { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.HoatDong")]



	[PrimaryKey("idHoatDong", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class HoatDong : BaiDangConnectionDB.Record<HoatDong>  
    {



		[Column] public string idHoatDong { get; set; }





		[Column] public string tenHoatDong { get; set; }





		[Column] public DateTime ngayBatDau { get; set; }





		[Column] public DateTime ngayKetThuc { get; set; }





		[Column] public double? diem { get; set; }





		[Column] public string ghiChu { get; set; }



	}

    

	[TableName("dbo.HocBong")]



	[PrimaryKey("idHocBong", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class HocBong : BaiDangConnectionDB.Record<HocBong>  
    {



		[Column] public string idHocBong { get; set; }





		[Column] public string idLHB { get; set; }





		[Column] public string tenHB { get; set; }





		[Column] public string DieuKien { get; set; }





		[Column] public DateTime ThoiGianDangKy { get; set; }





		[Column] public DateTime ThoiGianDuyet { get; set; }





		[Column] public DateTime ThoiGianPhatHB { get; set; }





		[Column] public string TrangThai { get; set; }





		[Column] public string HinhAnh { get; set; }





		[Column] public string MoTa { get; set; }



	}

    

	[TableName("dbo.HocKy")]



	[PrimaryKey("idHocKy", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class HocKy : BaiDangConnectionDB.Record<HocKy>  
    {



		[Column] public string idHocKy { get; set; }





		[Column] public string tenHocKy { get; set; }





		[Column] public DateTime tgBatDau { get; set; }





		[Column] public DateTime tgKetThuc { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.Khoa")]



	[PrimaryKey("idKhoa", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Khoa : BaiDangConnectionDB.Record<Khoa>  
    {



		[Column] public string idKhoa { get; set; }





		[Column] public string tenKhoa { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.LoaiHocBong")]



	[PrimaryKey("idLHB", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class LoaiHocBong : BaiDangConnectionDB.Record<LoaiHocBong>  
    {



		[Column] public string idLHB { get; set; }





		[Column] public string tenLHB { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.Lop")]



	[PrimaryKey("idLHP", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Lop : BaiDangConnectionDB.Record<Lop>  
    {



		[Column] public string idLHP { get; set; }





		[Column] public string idKhoa { get; set; }





		[Column] public string tenLop { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.MinhChung")]



	[PrimaryKey("idMinhChung", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class MinhChung : BaiDangConnectionDB.Record<MinhChung>  
    {



		[Column] public string idMinhChung { get; set; }





		[Column] public string TenMinhChung { get; set; }





		[Column] public byte[] HinhAnhMinhChung { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.SinhVien")]



	[PrimaryKey("idSinhVien", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class SinhVien : BaiDangConnectionDB.Record<SinhVien>  
    {



		[Column] public string idSinhVien { get; set; }





		[Column] public string idLHP { get; set; }





		[Column] public string tenSinhVien { get; set; }





		[Column] public string passwordSV { get; set; }





		[Column] public DateTime? ngaySinh { get; set; }





		[Column] public string email { get; set; }





		[Column] public string soDienThoai { get; set; }





		[Column] public string gioiTinh { get; set; }





		[Column] public string diaChi { get; set; }





		[Column] public string idHoatDong { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : BaiDangConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}


}
