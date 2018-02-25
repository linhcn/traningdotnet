using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Manager : Employee
    {
        private int _numberEm;

        public Manager()
        {

        }

        public Manager(int numberEm, int idEm, string name,int age):base(idEm,name,age)
        {
            numberEmSG = numberEm;
        }

        public int numberEmSG { get { return _numberEm; } set { _numberEm = value;} }

        public new void display()
        {
            Console.WriteLine(" number employee ={0} ", _numberEm);
            base.display();
        }

        public void sayYeah()
        {
            Console.WriteLine("say o yeah!");
        }
    }
}
