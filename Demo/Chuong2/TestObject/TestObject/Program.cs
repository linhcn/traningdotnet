using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();

            Employee1.ID = 1;
            Console.WriteLine(Employee1.ID);


            Employee Employee = new Employee(1, "Cao Ngọc Linh", age:20, pay:2000);
            Console.WriteLine(Employee);

            Console.ReadLine();

        }
    }
}
