using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookManagement1.Models;
using BookManagement1.DAL;
using PagedList;
using PagedList.Mvc;

namespace BookManagement1.Areas.Admin.Controllers
{
    [Authorize]
    public class BillController : Controller
    {
        private BookContext db = new BookContext();

        // GET: /Admin/Bill/
        public ActionResult Index()
        {
            IEnumerable<BillOrder> bills = db.BillOrders.OrderByDescending(x => x.BillOrderID).Include(b => b.Customer).ToPagedList(1,10);
            var model = bills;
            return View(model);
        }

        // GET: /Admin/Bill/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillOrder billorder = db.BillOrders.Find(id);
            if (billorder == null)
            {
                return HttpNotFound();
            }
            return View(billorder);
        }

        // GET: /Admin/Bill/Create
        public ActionResult Create()
        {
            ViewBag.CustormerRefId = new SelectList(db.Customers, "CustomerID", "CustomerName");
            return View();
        }

        // POST: /Admin/Bill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CustormerRefId,Shipdate,OrderDate,PayDay,BillOrderMoneyTotal,PaidStatus")] BillOrder billorder)
        {
            if (ModelState.IsValid)
            {
                db.BillOrders.Add(billorder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustormerRefId = new SelectList(db.Customers, "CustomerID", "CustomerName", billorder.CustormerRefId);
            return View(billorder);
        }

        // GET: /Admin/Bill/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillOrder billorder = db.BillOrders.Find(id);
            if (billorder == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustormerRefId = new SelectList(db.Customers, "CustomerID", "CustomerName", billorder.CustormerRefId);
            return View(billorder);
        }

        // POST: /Admin/Bill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BillOrderID,CustormerRefId,Shipdate,OrderDate,PayDay,BillOrderMoneyTotal,PaidStatus")] BillOrder billorder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billorder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustormerRefId = new SelectList(db.Customers, "CustomerID", "CustomerName", billorder.CustormerRefId);
            return View(billorder);
        }

        // GET: /Admin/Bill/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillOrder billorder = db.BillOrders.Find(id);
            if (billorder == null)
            {
                return HttpNotFound();
            }
            return View(billorder);
        }

        // POST: /Admin/Bill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillOrder billorder = db.BillOrders.Find(id);
            db.BillOrders.Remove(billorder);
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
