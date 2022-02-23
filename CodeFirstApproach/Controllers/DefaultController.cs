using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(employeeDetails emp)
        {
            db.EmployeeModels.Add(emp);//create query or insert query 
            int i = db.SaveChanges();//execute query
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Edit(int? id)
        {
            employeeDetails emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(employeeDetails emp)
        {
            db.Entry(emp).State=EntityState.Modified;//Update query 
            int i = db.SaveChanges();//execute query
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Delete(int? id)
        {
            employeeDetails emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            employeeDetails emp = db.EmployeeModels.Find(id);

            db.EmployeeModels.Remove(emp);//Delete query 
            int i = db.SaveChanges();//execute query
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }
    }
}