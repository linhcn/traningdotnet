using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhentance
{
    class Employee : Person
    {
        private string _id;

        public Employee(string id,string name,int age) : base(name,age)
        {
            _id = id;
        }
        public Employee()
        {

        }

        public void show()
        {
            Console.WriteLine("Name: {0}", _id);
            base.display();
        }
    }
}
