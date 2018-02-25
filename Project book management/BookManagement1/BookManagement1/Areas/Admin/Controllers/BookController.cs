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
using System.IO;

namespace BookManagement1.Areas.Admin.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private BookContext db = new BookContext();

        // GET: /Admin/Book/
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            IEnumerable<Book> model = db.Books.Include(b => b.Authors).Include(b => b.Production).Include(b => b.Topic);
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.BookName.Contains(searchString) || x.Authors.AuthorName.Contains(searchString));
            }
            //IEnumerable<Book> books = db.Books.Include(b => b.Authors).Include(b => b.Production).Include(b => b.Topic).OrderByDescending(x => x.BookID).ToPagedList(1, 10);
            ViewData["urlImage"] = Path.Combine(Server.MapPath("~/App_Data/image/"));
            ViewBag.SearchString = searchString;

            var modelResurt = model.OrderByDescending(x => x.BookName).ToPagedList(page, pageSize);
            return View(modelResurt);
        }

        // GET: /Admin/Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.tam = db.Categolorys.ToList();
            return View(book);
        }

        // GET: /Admin/Book/Create
        public ActionResult Create()
        {
            ViewBag.AuthorRefId = new SelectList(db.Authors, "AuthorID", "AuthorName");
            ViewBag.ProductionRefId = new SelectList(db.Productions, "ProductionID", "ProductionName");
            ViewBag.TopicRefId = new SelectList(db.Topics, "TopicID", "TopicName");
            ViewBag.CategoloryRefID = new SelectList(db.Categolorys, "CategoloryID", "CategoloryName");
            return View();
        }


        // POST: /Admin/Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookName,BookPrices,BookDescription,BookDateUpdate,BookQuantity,BookDiscount,TopicRefId,ProductionRefId,AuthorRefId,Categolorys,BookImage")] Book book)
        {


            if (ModelState.IsValid)
            {
                
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        book.BookImage = Path.Combine(
                        Server.MapPath("~/Content/image"), fileName);
                        file.SaveAs(book.BookImage);
                        book.BookImage = Path.GetFileName(file.FileName);
                    }
                }

                try
                {
                    int idcatefory = int.Parse(Request.Form["CategoloryRefID"]);
                    Categolory categolory = db.Categolorys.Find(idcatefory);
                    book.Categolorys.Add(categolory);
                }
                catch (Exception)
                {
                    db.Books.Add(book);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                    throw;
                }

                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            ViewBag.AuthorRefId = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorRefId);
            ViewBag.ProductionRefId = new SelectList(db.Productions, "ProductionID", "ProductionName", book.ProductionRefId);
            ViewBag.TopicRefId = new SelectList(db.Topics, "TopicID", "TopicName", book.TopicRefId);
            return View(book);
        }

        // GET: /Admin/Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorRefId = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorRefId);
            ViewBag.ProductionRefId = new SelectList(db.Productions, "ProductionID", "ProductionName", book.ProductionRefId);
            ViewBag.TopicRefId = new SelectList(db.Topics, "TopicID", "TopicName", book.TopicRefId);
            ViewBag.CategoloryRefID = new SelectList(db.Categolorys, "CategoloryID", "CategoloryName");
            return View(book);
        }

        // POST: /Admin/Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="BookID,BookName,BookPrices,BookDescription,BookDateUpdate,BookQuantity,BookDiscount,TopicRefId,ProductionRefId,AuthorRefId,Categolorys,BookImage")] Book book)
        {
            if (ModelState.IsValid)
            {
                int tam= book.BookID;
                int idcatefory = int.Parse(Request.Form["CategoloryRefID"]);
                
                Categolory Categolory = db.Categolorys.Single(c => c.CategoloryID == idcatefory);
                
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        book.BookImage = Path.Combine(
                        Server.MapPath("~/Content/image"), fileName);
                        file.SaveAs(book.BookImage);
                        book.BookImage = Path.GetFileName(file.FileName);
                    }
                }

                Categolory.Books.Add(book);
                book.Categolorys.Add(Categolory);
                db.Entry(book).State = EntityState.Modified;
                try
                {
                    
                db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                }
                return RedirectToAction("Index");
            }
            ViewBag.AuthorRefId = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorRefId);
            ViewBag.ProductionRefId = new SelectList(db.Productions, "ProductionID", "ProductionName", book.ProductionRefId);
            ViewBag.TopicRefId = new SelectList(db.Topics, "TopicID", "TopicName", book.TopicRefId);
            ViewBag.CategoloryRefID = new SelectList(db.Categolorys, "CategoloryID", "CategoloryName",book.Categolorys);
            return View(book);
        }

        // GET: /Admin/Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: /Admin/Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
