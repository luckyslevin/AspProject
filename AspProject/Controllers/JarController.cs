using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspProject.Controllers
{
    public class JarController : Controller
    {
        // GET: Jar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jar/Create
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

        // GET: Jar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jar/Edit/5
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

        // GET: Jar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jar/Delete/5
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
