using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhentance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee Employee = new Employee("AB1", "Nguyen Van A", 25);
            //Employee.show();

            Employee[] arrayEmployee = {
               new Employee(id : "1", name : "Nguyen Van A", age : 23),
               new Employee(id : "2", name : "Nguyen Van B", age : 25)
            };

            foreach(Employee em in arrayEmployee){
                em.show();
            }

        }
    }
}
