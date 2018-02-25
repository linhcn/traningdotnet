using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPolimorphilm
{
    class Worker:Human
    {
        public float _weekSalary;
        public int _hoursWork;

        public Worker() { }

        public Worker(string firstName, string lastName, float weekSalary,int hoursWork):base(firstName,lastName) {

            _weekSalary = weekSalary;
			_hoursWork= hoursWork;
        }

        public float moneyPerHours()
        {

            return _weekSalary / (_hoursWork*5);
            
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("{0,20}", moneyPerHours());
        }
    }
}
