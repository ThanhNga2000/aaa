using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.DoanhNghiep.Controllers
{
    public class ThongTinCaNhanController : Controller
    {
        // GET: DoanhNghiep/ThongTinCaNhan
        public ActionResult Index()
        {
            return View();
        }

        // GET: DoanhNghiep/ThongTinCaNhan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanhNghiep/ThongTinCaNhan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoanhNghiep/ThongTinCaNhan/Create
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

        // GET: DoanhNghiep/ThongTinCaNhan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/ThongTinCaNhan/Edit/5
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

        // GET: DoanhNghiep/ThongTinCaNhan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/ThongTinCaNhan/Delete/5
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
