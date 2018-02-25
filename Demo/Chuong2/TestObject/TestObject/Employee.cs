using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObject
{
    class Employee
    {
        private int Id;
        private string FName;
        private int Age;
        private double Pay;

        public Employee()
        {

        }

        public Employee(int id, string fName)
        {
            this.ID = id;
            this.FName = fName;
        }

        public Employee(int id, string fName, int age = 30, double pay = 1000) : this(id, fName) { this.Age = age; this.Pay = pay; }
        

        // get set for Employee

        public int ID
        {
            get {return Id;}
            set {this.Id = value;}
        }

        

        




















        public void showInfo()
        {
            Console.WriteLine("Id {0}, FName {1}, Age {2}, Pay {3} ", Id, FName, Age, Pay);
        }

        public override string ToString()
        {
            return string.Format("Id {0}, FName {1}, Age {2}, Pay {3} ", Id, FName, Age, Pay).ToString();
        }

    }
}
