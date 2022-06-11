using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.DoanhNghiep.Controllers
{
    public class MainDNController : Controller
    {
        // GET: DoanhNghiep/MainDN
        public ActionResult Index()
        {
            return View();
        }

        // GET: DoanhNghiep/MainDN/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanhNghiep/MainDN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoanhNghiep/MainDN/Create
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

        // GET: DoanhNghiep/MainDN/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/MainDN/Edit/5
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

        // GET: DoanhNghiep/MainDN/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanhNghiep/MainDN/Delete/5
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
