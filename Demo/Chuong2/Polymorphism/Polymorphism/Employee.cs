
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee
    {
        private int _IdEm;
        private string _name;
        private int _age;

        #region contructor
        public Employee()
        {

        }
        public Employee(int id, string name, int age)
        {
            idEmSG = id;
            nameSG = name;
            ageSG = age;
        }
        #endregion
                
        #region setGet
        public int idEmSG { get { return _IdEm; } set { _IdEm = value; } }
        public string nameSG { get { return _name; } set { _name = value; } }

        public int ageSG { get { return _age; } set { _age = value; } } 
        #endregion
        
        #region show
        public void display()
        {
            Console.WriteLine("Id employee = {0}", _IdEm);
            Console.WriteLine("name employee = {0}", _name);
            Console.WriteLine("age employee = {0}", _age);
        }
        public virtual void sayHello()
        {
            Console.WriteLine("Hi Employee!");
        }
        #endregion
       
    }
}
