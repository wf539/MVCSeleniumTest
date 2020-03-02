using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSeleniumTest.Models;

namespace MvcSeleniumTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            List<ComboBoxData> comboentries = new List<ComboBoxData>(){new ComboBoxData(){id = 1, text = "entry1"},
                                                                        new ComboBoxData(){id = 2, text = "entry2"},
                                                                        new ComboBoxData(){id = 3, text = "entry3"}};
            ViewBag.Options = new SelectList(comboentries, "id", "text");

            if (Request["Name"] != null)
            {
                ViewBag.UserName = Request["Name"];
                ViewBag.Options = new SelectList(comboentries, "id", "text", Request["Options"]);
                return View("PostIndex");
            }
            
            return View();
        }

        public ActionResult Alert()
        {
            return View("Alert");
        }

        public ActionResult Links()
        {
            return View("Links");
        }

        public ActionResult IFrameTest()
        {
            return View("IFrameTest");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
