using BookManagement1.Areas.Admin.Code;
using BookManagement1.Areas.Admin.Models;
using BookManagement1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookManagement1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private BookContext db = new BookContext();
        //
        // GET: /Admin/Login/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//so sanh giua token server va token browser neu kho thi ok
        public ActionResult Index(LoginModel loginModel )
        {

            if (Membership.ValidateUser(loginModel.UserName,loginModel.Password) && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(loginModel.UserName,loginModel.Rememberme);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("","Username or password not true");
            }
            return View(loginModel);
        }

        public ActionResult SigOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
	}
}