using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManagement1.DAL;
using BookManagement1.Models;

namespace BookManagement1.Controllers
{
    public class HomeController : Controller
    {
        private BookContext db = new BookContext();
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                Categolory sachbanchay = db.Categolorys.Single(x => x.CategoloryName.Equals("Sách bán chạy"));
                IEnumerable<Book> model = db.Books.Where(x => x.Categolorys.Any(c => c.CategoloryID == sachbanchay.CategoloryID));
                ViewData["sellrun"] = model;
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

            try
            {
                Categolory banchaytrongthang = db.Categolorys.Single(x => x.CategoloryName.Equals("Sách bán chạy trong tháng"));
                IEnumerable<Book> model2 = db.Books.Where(x => x.Categolorys.Any(c => c.CategoloryID == banchaytrongthang.CategoloryID));
                ViewData["sellinmonth"] = model2;
            }
            catch (Exception e)
            {
                e.GetBaseException(); 
            }
            try
            {
                Categolory sachsapphathanh = db.Categolorys.Single(x => x.CategoloryName.Equals("Sách sắp phát hành"));
                IEnumerable<Book> model3 = db.Books.Where(x => x.Categolorys.Any(c => c.CategoloryID == sachsapphathanh.CategoloryID));
                ViewData["sellPhatHang"] = model3;
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

            ////int sachsapphathanh = 0;
            ////int sachbanchaytronthanh = 0;
            ////int sachbanchay = 0;
            ////foreach (var item in list)
            ////{
            ////    sachbanchay = item.CategoloryID
            ////}



            // decive model3 to 2 path
            
            
            List<CartItem> cartItems = (List<CartItem>)Session["CartSession"];
            if (cartItems != null)
            {
                ViewBag.itemCart = cartItems.Count;
            }
            else
            {
                ViewBag.itemCart = 0;
            }
            return View();
        }
    }
}