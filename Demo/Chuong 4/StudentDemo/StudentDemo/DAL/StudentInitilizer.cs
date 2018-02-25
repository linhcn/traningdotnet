using StudentDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentDemo.DAL
{
    public class StudentInitilizer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
        List<Student> students = new List<Student>
        {
            new Student{ StudentID=1, StudentName="A", StudentAge=20},
            new Student{ StudentID=2, StudentName="B", StudentAge=21},
            new Student{ StudentID=3, StudentName="C", StudentAge=22},
        };
        //foreach (var item in students)
        //{
        //    db.Students.Add(item);
        //}
        students.ForEach(s=>db.Students.Add(s));
        db.SaveChanges();


        }

    }
}