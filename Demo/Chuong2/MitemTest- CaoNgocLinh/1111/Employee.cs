using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Employee
    {
        public int _id;
        public string _firstName;
        public string _lastName;
        public Gender _gender;
        public int _age;
        public int _bonus;

        public Employee()
        {

        }

        public Employee(int id, string firstName, string lastName, Gender gender, int age, int bonus)
        {
            _id = id;
            _firstName = firstName;
            LastName = lastName;
            _gender = gender;
            _bonus = bonus;
            Age = age;
        }

        public string LastName {
            get {return _lastName ;}
            set {
                if (value.Length > 10)
                {
                    throw new Exception("Error! Last name must be  less than 10 characters");
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        public int Age {
            get { return _age;}
            set
            {

                _age = value;
            } 
        }
        public int Bonus { 
            get { return _age;}
            set
            {
                _bonus = value;
                if(Age > 50 ){
                    _bonus = 100;
                }
            }
        }

        public string getFullName()
        {
            return _lastName + " " + _firstName;
        }

        public abstract int getMonthlySalary();

        public virtual void displayInformation()
        {
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}", _id, _firstName, _lastName, getFullName(), _age, _bonus, getMonthlySalary());
        }
    }
}
