using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class HourlyEmployee : Employee, ILoveSpost
    {
        public int _hourlyPay;
        public int _totalHoursWork;
        public string _nameOfSpost;

        public HourlyEmployee()
        {

        }

        public HourlyEmployee(int hourlyPay, int totalHoursWork, int id, string firstName, string lastName, Gender gender, int age, int bonus)
            : base(id, firstName, lastName, gender, age, bonus)
        {
            _hourlyPay = hourlyPay;
            _totalHoursWork = totalHoursWork;
        }

        public HourlyEmployee(int hourlyPay, int totalHoursWork, string nameOfSpost, int id, string firstName, string lastName, Gender gender, int age, int bonus)
            : base(id, firstName, lastName, gender, age, bonus)
        {
            _hourlyPay = hourlyPay;
            _totalHoursWork = totalHoursWork;
            NameOfSpost = nameOfSpost;
        }



        public string NameOfSpost
        {
            get { return _nameOfSpost; }
            set
            {
                if (_nameOfSpost.Equals("I Love Sport"))
                {
                    _nameOfSpost = "I Love Sport";
                }
                else
                {
                    _nameOfSpost = "Dislike Sport";
                }
            }
        }



        public new int getMonthlySalary()
        {
            Employee employee = new Employee();
            return _hourlyPay * _totalHoursWork + employee.Bonus;
        }

        public new void displayInformation()
        {
            base.displayInformation();
        }



        public void sportCharacteristics()
        {
            
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15}", _id, _firstName, _lastName, getFullName(), _age, _bonus, getMonthlySalary(), _nameOfSpost);
        }
    }
}