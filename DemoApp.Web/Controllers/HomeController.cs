using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            ViewBag.BuildVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(4);
            ViewBag.ServerName = System.Environment.MachineName;

            // read connection string
            var connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"];
            if (connString != null)
            {
                ViewBag.ConnectionString = connString.ConnectionString;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
