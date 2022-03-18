using AdoNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();

        public ActionResult GetCalcIndex()
        {
            ServiceReference1.CaculatorServiceSoapClient obj = new ServiceReference1.CaculatorServiceSoapClient();

            ServiceReference2.MyWcfServiceClient obj1 = new ServiceReference2.MyWcfServiceClient();
            ServiceReference3.Service1Client sobj = new ServiceReference3.Service1Client("NetTcpBinding_IService1");
            //return Content(obj.MyCalc(2, 6,2, '*').ToString()+obj1.add(22,55)+"final service "+sobj.add(12,23));

            return Content("final service "+sobj.add(12,23));
        }


        public ActionResult Index()
        {

            return View(db.GetEmployees());
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);

            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }

             
        }
    }
}