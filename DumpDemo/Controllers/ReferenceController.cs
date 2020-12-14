using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using DumpDemo.Models;

namespace DumpDemo.Controllers
{
    public class ReferenceController : Controller
    {
        // GET: Reference
        public ActionResult Index()
        {
            //List<Reference> lst = new List<Reference>();
            //lst.Add(new Reference("Hardy Boys"));
            //lst.Add(new Reference("Nancy Drew"));
            //lst.Add(new Reference("Three Investigators"));
            //lst.Add(new Reference("Encyclopedia Brown"));

            // var = str(refToShow)

            //return View("Fuzzy");
            //DAL dal = new DAL();

            List<Reference> lst = DAL.ReferencesGet();
            return View(lst);
        }

        public ActionResult Details(int id) {
            Reference refToShow = DAL.ReferenceGet(id);
            //new Reference();
            //refToShow.Title = "To Kill a Mocking Bird";
            //refToShow.Publisher = "Awesome Publisher";
            //refToShow.Year = 1945;
            if (refToShow != null) {
                return View(refToShow);
            } else {
                return HttpNotFound();
            }
        }

        // GET
        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Create(Reference reffer){
            // string title, string publisher, int year) {
            //string ttl = Request.Form["Title"];
            //string pub = Request.Form["Publisher"];
            //int year = int.Parse(Request.Form["Year"]);
            //int a = 6;
            if (DAL.ReferenceAdd(reffer) > 0) {
                return RedirectToAction("Index");
            } else {
                return View(reffer);
            }

        }

    }
}