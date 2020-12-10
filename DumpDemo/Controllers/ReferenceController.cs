using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Reference> lst = new List<Reference>();
            lst.Add(new Reference("Hardy Boys"));
            lst.Add(new Reference("Nancy Drew"));
            lst.Add(new Reference("Three Investigators"));
            lst.Add(new Reference("Encyclopedia Brown"));

            // var = str(refToShow)

            //return View("Fuzzy");
            return View(lst);
        }

        public ActionResult Details() {
            Reference refToShow = new Reference();
            refToShow.Title = "To Kill a Mocking Bird";
            refToShow.Publisher = "Awesome Publisher";
            refToShow.Year = 1945;
            return View(refToShow);
        }

    }
}