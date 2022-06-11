using BaiDangConnection;
using KHOALUAN.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.DoanhNghiep.Controllers
{
    public class DangBaiController : Controller
    {
        // GET: DoanhNghiep/DangBai
        public ActionResult Index()
        {
            var db = WebDangKyHB.DanhSachHB();
            return View(db);
        }

        // GET: DoanhNghiep/DangBai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanhNghiep/DangBai/Create
        public ActionResult Create()
        {
            //ViewBag.idLHB = new SelectList(WebDangKyHB.DanhSach(), "idLHB", "tenLHB");
            return View();
        }

        // POST: DoanhNghiep/DangBai/Create
        [HttpPost]
        public ActionResult Create(HocBong hb)
        {
            // TODO: Add insert logic here
            WebDangKyHB.ThemHB(hb);
            return RedirectToAction("Index");
            //try ý ông như ri à
            //{
            //    // TODO: Add insert logic here
            //    WebDangKyHB.ThemHB(hb);
            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: DoanhNghiep/DangBai/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/DangBai/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DoanhNghiep/DangBai/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/DangBai/Delete/5
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
