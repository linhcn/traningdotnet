using BookManagement1.DAL;
using BookManagement1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace BookManagement1.Controllers
{
    public class CartController : Controller
    {

        private BookContext db = new BookContext();
        private static string CartSession = "CartSession";
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var listCart = (List<CartItem>)cart;
            if (cart != null)
            {
                listCart = (List<CartItem>)cart;
            }
            if (listCart != null)
            {
                ViewBag.itemCart = listCart.Count;
            }
            else
            {
                ViewBag.itemCart = 0;
            }

            List<CartItem> cartItems = (List<CartItem>)Session["CartSession"];
            if (cartItems != null)
            {
                ViewBag.itemCart = cartItems.Count;
            }
            else
            {
                ViewBag.itemCart = 0;
            }

            ViewBag.totalPrice = TotalPrice();
            return View(listCart);
        }

        public ActionResult AddItem(int BookID, int Quantity)
        {

            IEnumerable<Book> listBook = db.Books.Where(x => x.BookID == BookID);
            Book book = null;
            foreach (var item in listBook)
            {
                book = item;
            }
            var cart = Session[CartSession];
            if (cart != null)
            {
                var listCart = (List<CartItem>)cart;
                if (listCart != null)
                {
                    if (listCart.Exists(x => x.Book.BookID == BookID))
                    {
                        foreach (var item in listCart)
                        {
                            if (item.Book.BookID == BookID)
                            {
                                item.Quantity += Quantity;
                            }
                        }
                    }
                    else
                    {
                        //create new item
                        var item = new CartItem();
                        item.Book = book;
                        item.Quantity = Quantity;
                        listCart.Add(item);
                    }
                    //assigning for session
                    Session[CartSession] = listCart;
                }
                
            }
            else
            {
                //create new item
                var item = new CartItem();
                item.Book = book;
                item.Quantity = Quantity;
                var listCart = new List<CartItem>();
                listCart.Add(item);
                // assigning values for Session
                Session[CartSession] = listCart;
            }
            return RedirectToAction("Index");
        }

        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session[CartSession];
            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.Book.BookID == item.Book.BookID);
                if (jsonItem!=null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new { 
                status = true
            });
        }

        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }
            

        public JsonResult deleteItemCart(long id)
        {
            var listCart = (List<CartItem>)Session[CartSession];
            listCart.RemoveAll(x => x.Book.BookID == id);
            Session[CartSession] = listCart;

            return Json(new
            {
                status = true
            });
        }

        public double TotalPrice()
        {
            var sessionCart = (List<CartItem>)Session[CartSession];
            double total = 0;
            try
            {
                foreach (var item in sessionCart)
                {
                    total = item.Book.BookPrices * item.Quantity;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
            

            return total;
        }


	}
}