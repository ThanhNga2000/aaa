using KHOALUAN.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Controllers
{
    public class BaiDangController : Controller
    {
        // GET: BaiDang
        public ActionResult Index()
        {
            var db = WebDangKyHB.DanhSach();
            return View(db);
        }

        // GET: BaiDang/Details/5
        public ActionResult Details(String id)
        {
            var db = WebDangKyHB.chitiet(id);
            return View(db);
        }

        // GET: BaiDang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaiDang/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BaiDang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaiDang/Edit/5
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

        // GET: BaiDang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaiDang/Delete/5
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
