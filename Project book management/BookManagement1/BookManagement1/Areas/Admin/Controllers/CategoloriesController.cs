using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BookManagement1.DAL;
using BookManagement1.Models;

namespace BookManagement1.Areas.Admin.Controllers
{
    public class CategoloriesController : Controller
    {
        private BookContext db = new BookContext();

        // GET: Admin/Categolories
        public ActionResult Index()
        {
            return View(db.Categolorys.ToList());
        }

        // GET: Admin/Categolories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categolory categolory = db.Categolorys.Find(id);
            if (categolory == null)
            {
                return HttpNotFound();
            }
            return View(categolory);
        }

        // GET: Admin/Categolories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categolories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoloryID,CategoloryName")] Categolory categolory)
        {
            if (ModelState.IsValid)
            {
                db.Categolorys.Add(categolory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categolory);
        }

        // GET: Admin/Categolories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categolory categolory = db.Categolorys.Find(id);
            if (categolory == null)
            {
                return HttpNotFound();
            }
            return View(categolory);
        }

        // POST: Admin/Categolories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoloryID,CategoloryName")] Categolory categolory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categolory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categolory);
        }

        // GET: Admin/Categolories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categolory categolory = db.Categolorys.Find(id);
            if (categolory == null)
            {
                return HttpNotFound();
            }
            return View(categolory);
        }

        // POST: Admin/Categolories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categolory categolory = db.Categolorys.Find(id);
            db.Categolorys.Remove(categolory);
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
