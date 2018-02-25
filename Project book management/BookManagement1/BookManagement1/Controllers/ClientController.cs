using BookManagement1.Areas.Admin.Models;
using BookManagement1.DAL;
using BookManagement1.Models;
using BookManagement1.Uniti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManagement1.Controllers
{
    public class ClientController : Controller
    {
        private BookContext db = new BookContext();
        //
        // GET: /Client/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginCustomer()
        {
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

        [HttpPost]
        public ActionResult LoginCustomer(LoginModel loginModel)
        {
            string pass = EncryptData.md5(loginModel.Password);
            InsetToOrder(loginModel.UserName, pass);

            return RedirectToAction("SubmitSuccess");
            
        }

        [HttpGet]
        public ActionResult Register()
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "CustomerName,CustomerBirthday,CustomerGender,CustomerEmail,CustomerPhone,CustomerAddress,CustomerPass,CustomerAccount")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (CheckEmail(customer.CustomerEmail))
                {
                    ModelState.AddModelError("", "Email is Existed!");
                }
                else
                if (CheckUserName(customer.CustomerAccount))
                {
                    ModelState.AddModelError("", "Account is Existed!");
                }else
                {
                    string password = customer.CustomerPass;
                    customer.CustomerPass = EncryptData.md5(password);
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    InsetToOrder(customer.CustomerAccount, EncryptData.md5(password));
                    return RedirectToAction("LoginCustomer");
                }
            }
            List<CartItem> cartItems = (List<CartItem>)Session["CartSession"]; ;
            if (cartItems != null)
            {
                ViewBag.itemCart = cartItems.Count;
            }
            else
            {
                ViewBag.itemCart = 0;
            }
            return View(customer);
        }
        public bool CheckUserName(string userName)
        {
            return db.Customers.Count(x => x.CustomerAccount.Equals(userName)) > 0;
        }
        public bool CheckEmail(string email)
        {
            return db.Customers.Count(x => x.CustomerEmail.Equals(email)) > 0;
        }

        public void InsetToOrder(string username, string password)
        {

            Customer customer = db.Customers.Single(x => x.CustomerAccount.Equals(username) && x.CustomerPass.Equals(password));


            if (customer != null)
            {
                List<CartItem> cardItem = (List<CartItem>)Session["CartSession"];
                double totalMany = 0;
                foreach (var item in cardItem)
                {
                    totalMany = totalMany + item.Book.BookQuantity * item.Book.BookPrices;
                }
                BillOrder billOrder = new BillOrder
                {
                    CustormerRefId = customer.CustomerID,
                    BillOrderMoneyTotal = totalMany,
                    OrderDate = DateTime.Now,
                    PaidStatus = false,
                    PayDay = DateTime.Now,
                    Shipdate = DateTime.Now,
                    Customer = customer
                };
                db.BillOrders.Add(billOrder);
                db.SaveChanges();
                foreach (var item in cardItem)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        BillOrderRefId = billOrder.BillOrderID,
                        BookRefId = item.Book.BookID,
                        Quantity = item.Book.BookQuantity
                    };
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                }
            }
        }

        public ActionResult SubmitSuccess()
        {
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