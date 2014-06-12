using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using DatabasePerson.Models;


namespace MVC4Razor.Areas.Details.Controllers
{
    public class PersonController : Controller
    {

        public static string status="";
        //
        // GET: /Details/Person/

        public ActionResult Index()
        {
            DBConnect connect = new DBConnect();

            List<Person> displayList;
            displayList = connect.select();
            ViewBag.Data = new List<Person>();
            ViewBag.Data = displayList;
            ViewBag.status = new String(status.ToCharArray());
            return View();
        }

        //
        // GET: /Details/Person/Details/5

        public ActionResult Details(int id)
        {
            
            return View();
        }

        //
        // GET: /Details/Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Details/Person/Create

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            try
            {
                DBConnect connect = new DBConnect();

                int JerseyNum = int.Parse(form["JerseyNumber"].ToString());
                string PlayerName = form["PlayerName"].ToString();
                string Country = form["CountryDropDown"].ToString();
                // TODO: Add insert logic here

                if (connect.Insert(JerseyNum, PlayerName, Country))
                    status = "Successfully inserted!!";
                else 
                    status="Unsuccessful";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Details/Person/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Details/Person/Edit/5

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
        // GET: /Details/Person/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Details/Person/Delete/5

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
