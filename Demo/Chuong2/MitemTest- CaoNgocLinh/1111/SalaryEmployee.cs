using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class SalaryEmployee : Employee
    {
        public int _annualSalary;

        public SalaryEmployee()
        {

        }

        public SalaryEmployee(int annualSalary, int id, string firstName, string lastName, Gender gender, int age, int bonus)
            : base(id, firstName, lastName, gender, age, bonus)
        {
            _annualSalary = annualSalary;
        }

        public int AnnualSalary { set { _annualSalary = value; } }



        public new int getMonthlySalary()
        {

            Employee employee = new Employee();
            return (_annualSalary / 12) + employee.Bonus;
        }
    }
}
