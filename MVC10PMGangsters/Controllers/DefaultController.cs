using MVC10PMGangsters.Models;
using MVC10PMGangsters.MyCustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMGangsters.Controllers
{
    [MyFilter]

    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id)
        {
            return View();
        }

        public ActionResult Index2(EmployeeModel emp)
        {
            
            return View();
        }

        public ActionResult Index3(List<EmployeeModel> emp)
        {
            return View();
        }

        [MyFilter]
        public ActionResult CricketPremi()
        {
            ViewBag.Player ="Brain Lara";
            return View();
        }
    }
}