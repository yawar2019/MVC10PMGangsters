using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorAttributeExample.Controllers
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
        [HandleError(View="Error1")]
        public ActionResult GetSomeError(string id)
        {
            try
            {
                int c = 0, a = 10;
                c = a / Convert.ToInt32(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View();
        }
    }
}