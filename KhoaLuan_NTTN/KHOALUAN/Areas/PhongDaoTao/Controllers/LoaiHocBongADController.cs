using BaiDangConnection;
using KHOALUAN.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.PhongDaoTao.Controllers
{
    public class LoaiHocBongADController : Controller
    {
        // GET: PhongDaoTao/LoaiHocBongAD
        public ActionResult Index()
        {
            var db = LoaiHocBongBUS.DanhSach();
            return View(db);
        }

        // GET: PhongDaoTao/LoaiHocBongAD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhongDaoTao/LoaiHocBongAD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongDaoTao/LoaiHocBongAD/Create
        [HttpPost]
        public ActionResult Create(LoaiHocBong lhb)
        {
            try
            {
                // TODO: Add insert logic here
                LoaiHocBongBUS.ThemLHB(lhb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhongDaoTao/LoaiHocBongAD/Edit/5
        public ActionResult Edit(String id)
        {
            return View(LoaiHocBongBUS.ChiTietAD(id));
        }

        // POST: PhongDaoTao/LoaiHocBongAD/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, LoaiHocBong lhb)
        {
            try
            {
                // TODO: Add update logic here
                LoaiHocBongBUS.UpdateLHB(id, lhb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult DeleteTamThoi(String id)
        {
            return View(LoaiHocBongBUS.ChiTietAD(id));
        }

        // POST: Admin/NhaSanXuatAD/Delete/5
        [HttpPost]
        public ActionResult DeleteTamThoi(String id, LoaiHocBong lhb)
        {
            try
            {
                // TODO: Add delete logic here
                lhb.GhiChu = "1";
                LoaiHocBongBUS.UpdateLHB(id, lhb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhongDaoTao/LoaiHocBongAD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhongDaoTao/LoaiHocBongAD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
