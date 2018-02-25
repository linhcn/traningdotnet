using StudentDemo.DAL;
using StudentDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDemo.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        //
        // GET: /Demo/
        public ActionResult Index()
        {
            //ViewBag.Message = "Controller Index";
            // ViewData["Message"] = "Controller Index";
            //  Student s = new Student { StudentID = 1, StudentName = "A" };
            //ViewBag.SV = s;
            // return View(s);

            var students = db.Students.ToList();
            return View(students);
        }
        public ActionResult ListStudent()
        {
            var listStudent = new List<Student>{
                new Student{ StudentID=1, StudentName= "A"},
                new Student{ StudentID=2, StudentName="B"}
            };
            return View(listStudent);
        }
        public ActionResult Create()
        {
            return View("AddNew");
        }
        public ActionResult Create2()
        {
            return View("AddNew2");
        }
        public ActionResult SaveStudent2(Student st, string btnSubmit)
        {
            switch (btnSubmit)
            {
                case "Save":
                    //st.StudentName = Request.Form["Name"];
                    //st.StudentAge = Convert.ToInt32(Request.Form["Age"]);
                    //st.Email = Request.Form["Email"];
                    if (ModelState.IsValid)
                    {
                        db.Students.Add(st);
                        db.SaveChanges();
                        return View("Index", db.Students.ToList()); 
                    }
                    else
                    {
                        return View("AddNew2");
                    }

                case "Cancel":
                    return View("Index", db.Students.ToList());
            }
            return new EmptyResult();
        }
        public ActionResult SaveStudent(Student st, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save":
                    st.StudentName = Request.Form["Name"];
                    st.StudentAge = Convert.ToInt32(Request.Form["Age"]);
                    st.Email = Request.Form["Email"];
                    db.Students.Add(st);
                    db.SaveChanges();

                    return View("Index",db.Students.ToList());

                case "Cancel":
                    return View("Index",db.Students.ToList());
            }
            return new EmptyResult();
        }

        //[ActionName("Hi")]
        //public string Hello()
        //{
        //    return "Hi everybody";
        //}
        //public ActionResult testLayout()
        //{
        //    return View("testLayout2");
        //}
        //public ActionResult testLayout3()
        //{
        //    return View();
        //}
        //public ActionResult testLayout4()
        //{
        //    return View();
        //}

    }
}