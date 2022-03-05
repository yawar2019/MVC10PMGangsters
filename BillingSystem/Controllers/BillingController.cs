using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BillingSystem.Models;

namespace BillingSystem.Controllers
{
    public class BillingController : Controller
    {
        private DiagnosticBillingSystemEntities db = new DiagnosticBillingSystemEntities();

        // GET: Billing
        public ActionResult Index()
        {
            var docbilling = (from bill in db.tble_Billing
                              join
                              doc in db.Doctors
                              on bill.DoctorId equals doc.DoctorId
                              select new DocBillModel
                              {
                                  Id=bill.Id,
                                  BillId = bill.BillId,
                                  PatientName = bill.PatientName,
                                  DoctorName = doc.DoctorName,
                                  Investigation = bill.Investigation,
                                  Total = bill.Total,
                                  Paid = bill.Paid,
                                  Due = bill.Due,
                                  Expense = bill.Expense,
                                  ReferalAmount = bill.ReferalAmount,
                                  Status = bill.Status,

                              });
            return View(docbilling.ToList());
        }

        // GET: Billing/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Billing tble_Billing = db.tble_Billing.Find(id);
            if (tble_Billing == null)
            {
                return HttpNotFound();
            }
            return View(tble_Billing);
        }

        // GET: Billing/Create
        public ActionResult Create()
        {
            ViewBag.Doctors = new SelectList(db.Doctors, "DoctorId", "DoctorName");
            return View();
        }

        // POST: Billing/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BillId,PatientName,DoctorId,Investigation,Total,Paid,Due,Discount,Expense,ReferalAmount,Status")] tble_Billing tble_Billing)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Doctors = new SelectList(db.Doctors, "DoctorId", "DoctorName");
                db.tble_Billing.Add(tble_Billing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tble_Billing);
        }

        // GET: Billing/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Billing tble_Billing = db.tble_Billing.Find(id);
            if (tble_Billing == null)
            {
                return HttpNotFound();
            }
            return View(tble_Billing);
        }

        // POST: Billing/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BillId,PatientName,DoctorId,Investigation,Total,Paid,Due,Discount,Expense,ReferalAmount,Status")] tble_Billing tble_Billing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tble_Billing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tble_Billing);
        }

        // GET: Billing/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Billing tble_Billing = db.tble_Billing.Find(id);
            if (tble_Billing == null)
            {
                return HttpNotFound();
            }
            return View(tble_Billing);
        }

        // POST: Billing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tble_Billing tble_Billing = db.tble_Billing.Find(id);
            db.tble_Billing.Remove(tble_Billing);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
