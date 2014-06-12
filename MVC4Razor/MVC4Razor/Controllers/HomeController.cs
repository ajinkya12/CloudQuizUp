using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace MVC4Razor.Areas.ButtonDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /ButtonDemo/Home/

        public ActionResult Index()
        {
            Response.Redirect("~/UIConfig/Config");
            ViewBag.Message = "Message from Home Controller for Button";
            
            return View();
        }

        //
        // GET: /ButtonDemo/Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ButtonDemo/Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ButtonDemo/Home/Create

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

        //
        // GET: /ButtonDemo/Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ButtonDemo/Home/Edit/5

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

        //
        // GET: /ButtonDemo/Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ButtonDemo/Home/Delete/5

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
