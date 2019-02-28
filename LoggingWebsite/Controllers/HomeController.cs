using LoggingWebsite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoggingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            try
            {
                if(true == true)
                {
                    throw new Exception("True is geen false!");
                }
                // wordt nooit uitgevoerd tenzij true ooit false wordt.
                return View(); 
            }
            catch (Exception ex)
            {
                LoggingHelper.writeToFile("error", ex.Message);
                return Redirect("/");
            }
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
    }
}