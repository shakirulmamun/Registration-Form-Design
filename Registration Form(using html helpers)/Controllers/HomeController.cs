using Registration_Form_using_html_helpers_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration_Form_using_html_helpers_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Index(myModel mymodel)
        {
            int personId = mymodel.PersonId;
            string name = mymodel.Name;
            string gender = mymodel.Gender;
            string city = mymodel.City;
            return View();
        }
    }
}