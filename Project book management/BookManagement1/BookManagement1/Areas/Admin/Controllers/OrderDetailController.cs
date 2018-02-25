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

namespace BookManagement1.Areas.Admin.Controllers
{
    public class OrderDetailController : Controller
    {
        private BookContext db = new BookContext();

        // GET: /Admin/OrderDetail/
        public ActionResult Index()
        {
            var orderdetails = db.OrderDetails.Include(o => o.BillOrder).Include(o => o.Book);
            return View(orderdetails.ToList());
        }

        // GET: /Admin/OrderDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderdetail = db.OrderDetails.Find(id);
            if (orderdetail == null)
            {
                return HttpNotFound();
            }
            return View(orderdetail);
        }

        // GET: /Admin/OrderDetail/Create
        public ActionResult Create()
        {
            ViewBag.BillOrderRefId = new SelectList(db.BillOrders, "BillOrderID", "BillOrderID");
            ViewBag.BookRefId = new SelectList(db.Books, "BookID", "BookName");
            return View();
        }

        // POST: /Admin/OrderDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="OrderDetailID,BillOrderRefId,BookRefId,Quantity")] OrderDetail orderdetail)
        {
            if (ModelState.IsValid)
            {
                db.OrderDetails.Add(orderdetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BillOrderRefId = new SelectList(db.BillOrders, "BillOrderID", "BillOrderID", orderdetail.BillOrderRefId);
            ViewBag.BookRefId = new SelectList(db.Books, "BookID", "BookName", orderdetail.BookRefId);
            return View(orderdetail);
        }

        // GET: /Admin/OrderDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderdetail = db.OrderDetails.Find(id);
            if (orderdetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.BillOrderRefId = new SelectList(db.BillOrders, "BillOrderID", "BillOrderID", orderdetail.BillOrderRefId);
            ViewBag.BookRefId = new SelectList(db.Books, "BookID", "BookName", orderdetail.BookRefId);
            return View(orderdetail);
        }

        // POST: /Admin/OrderDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="OrderDetailID,BillOrderRefId,BookRefId,Quantity")] OrderDetail orderdetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderdetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BillOrderRefId = new SelectList(db.BillOrders, "BillOrderID", "BillOrderID", orderdetail.BillOrderRefId);
            ViewBag.BookRefId = new SelectList(db.Books, "BookID", "BookName", orderdetail.BookRefId);
            return View(orderdetail);
        }

        // GET: /Admin/OrderDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderdetail = db.OrderDetails.Find(id);
            if (orderdetail == null)
            {
                return HttpNotFound();
            }
            return View(orderdetail);
        }

        // POST: /Admin/OrderDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderDetail orderdetail = db.OrderDetails.Find(id);
            db.OrderDetails.Remove(orderdetail);
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
