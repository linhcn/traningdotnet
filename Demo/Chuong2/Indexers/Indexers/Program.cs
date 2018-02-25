using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee[0] = "cao";
            employee[1] = "linh";
            employee[2] = "Da Nang";

            Console.WriteLine("lastName: {0}", employee[0]);
            Console.WriteLine("FirstName: {0}", employee[1]);
            Console.WriteLine("City Of Birth: {0}", employee[2]);
        }
    }
}
