using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Web;
using System.Web.Mvc;

namespace NetWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string wmiQuery = string.Format("select CommandLine from Win32_Process");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery);
            ManagementObjectCollection retObjectCollection = searcher.Get();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}