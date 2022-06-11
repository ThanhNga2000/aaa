using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.DoanhNghiep.Controllers
{
    public class DanhSachController : Controller
    {
        // GET: DoanhNghiep/DanhSach
        public ActionResult Index()
        {
            return View();
        }

        // GET: DoanhNghiep/DanhSach/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanhNghiep/DanhSach/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoanhNghiep/DanhSach/Create
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

        // GET: DoanhNghiep/DanhSach/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/DanhSach/Edit/5
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

        // GET: DoanhNghiep/DanhSach/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/DanhSach/Delete/5
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
