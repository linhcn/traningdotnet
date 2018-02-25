using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetDemo.DAL;

namespace AspNetDemo.Controllers
{

    public class StudentController : Controller
    {

        private StudentContext db = new StudentContext();
        //
        // GET: /Student/
        public ActionResult Index(Student student)
        {

            
            var item = db.Students.ToList();
            
            return View(item);
        }

        public ActionResult viewData()
        {
            ViewData["name"] = "khong co dau";
            return View();
        }

	}
}