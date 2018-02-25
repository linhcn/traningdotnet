using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.Entity;
namespace AspNetDemo.DAL
{
    public class StudentInitilizer : DropCreateDatabaseIfModelChanges<StudentContext>
    {

        protected override void Seed(StudentContext context)
        {
            List<Student> students = new List<Student>{
                new Student{
                    StudentName = "Ngọc Linh",
                    StudentAge = 20

                },
                new Student{
                    StudentName = "Nguyen Van A",
                    StudentAge = 20

                }
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }

    }
}