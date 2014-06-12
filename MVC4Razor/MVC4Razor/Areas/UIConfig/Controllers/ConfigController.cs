using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using MVC4Razor.Areas.UIConfig.Model;

namespace MVC4Razor.Areas.UIConfig.Controllers
{
    public class ConfigController : Controller
    {
        //
        // GET: /UIConfig/Config/

        public ActionResult Index()
        {
            ConfigModel configModel = new ConfigModel();
            string path = System.IO.Path.GetFullPath(Server.MapPath("~/Input.xlsx"));
            ViewBag.Data = new Dictionary<string, List<string>>();

            ViewBag.Data = configModel.GetExcel(path);
            
            return View();
        }

        //
        // GET: /UIConfig/Config/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /UIConfig/Config/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UIConfig/Config/Create

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
        // GET: /UIConfig/Config/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UIConfig/Config/Edit/5

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
        // GET: /UIConfig/Config/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UIConfig/Config/Delete/5

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
