using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new StudentManagerDemoEntities();

            Student st = new Student { id = 1, name = "Cao Ngoc Linh", idCourse = 3 };
            db.Students.Add(st);
            db.SaveChanges();

            
        }
    }
}
