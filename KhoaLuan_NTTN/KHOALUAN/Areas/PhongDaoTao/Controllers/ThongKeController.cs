using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KHOALUAN.Areas.PhongDaoTao.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: PhongDaoTao/ThongKe
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhongDaoTao/ThongKe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhongDaoTao/ThongKe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongDaoTao/ThongKe/Create
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

        // GET: PhongDaoTao/ThongKe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhongDaoTao/ThongKe/Edit/5
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

        // GET: PhongDaoTao/ThongKe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhongDaoTao/ThongKe/Delete/5
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
