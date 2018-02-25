using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SalePerson : Employee
    {
        private int _numberProduct;

        public SalePerson()
        {

        }
        public SalePerson(int numberProduct, int idEm, string name, int age) : base(idEm, name, age)
        {

        }

        public int numberProductSG { get { return _numberProduct; } set { _numberProduct = value; } }
                
        public new void display()
        {
            Console.WriteLine(" number product ={0} ", _numberProduct);
            base.display();
        } 

        public override void sayHello(){
            base.sayHello();
            Console.WriteLine("Hi, Sale Persons!");
            }

    }
}
