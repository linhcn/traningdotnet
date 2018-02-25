using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{

    enum Gender
    {
        MALE = 1,
        FEMALE,
        UNKNOWN,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15}", "Id", "First name", "Last name", "Full name", "Age", "Bonus", "Monthly", "LoveSpost");

            Console.WriteLine("\n*******************infor SalaryEmployee*******************\n");
            Employee emp1 = new SalaryEmployee
           {
               _annualSalary = 20,
               _age = 20,
               _firstName = "Linh",
               _lastName = "Cao",
               _gender = Gender.MALE,
               _id = 1,
               _bonus = 60
           };

            emp1.displayInformation();

            Console.WriteLine("\n*******************infor HourlyEmployee*******************\n");
            Employee emp2 = new HourlyEmployee
            {
                _hourlyPay = 8,
                _totalHoursWork = 20,
                _age = 20,
                _firstName = "Linh",
                _lastName = "Cao",
                _gender = Gender.MALE,
                _id = 1,
                _bonus = 10

            };

            emp2.displayInformation();

            #region ListEmps
            Employee[] employees = {
                                      new HourlyEmployee
                                      {
                                          _hourlyPay = 8,
                                         _totalHoursWork = 20,
                                         _age = 20,
                                         _firstName = "Linh",
                                         _lastName = "Cao",
                                         _gender = Gender.MALE,
                                         _id = 1,
                                         _bonus = 30,
                                          _nameOfSpost ="Volleyball"
                                      },
                                      new HourlyEmployee
                                      {
                                          _hourlyPay = 8,
                                         _totalHoursWork = 20,
                                         _age = 20,
                                         _firstName = "Linh",
                                         _lastName = "Cao",
                                         _gender = Gender.MALE,
                                         _id = 2,
                                         _bonus = 80,
                                         _nameOfSpost ="FoodBall"
                                      },
                                      new SalaryEmployee
                                       {
                                           _annualSalary = 20,
                                           _age = 20,
                                           _firstName = "A",
                                           _lastName = "nguyen",
                                           _gender = Gender.MALE,
                                           _id = 3,
                                           _bonus = 10
                                        },
                                        new SalaryEmployee
                                       {
                                           _annualSalary = 20,
                                           _age = 20,
                                           _firstName = "B",
                                           _lastName = "Le",
                                           _gender = Gender.MALE,
                                           _id = 4,
                                           _bonus = 50,
                                        }
                                  };
            #endregion
           
            
            Program program = new Program();

            int option = 0;
            while (option != 4)
            {

                Console.WriteLine("\nEnter 1:\t To display List Employee");
                Console.WriteLine("Enter 2:\t To sort by Last name");
                Console.WriteLine("Enter 3:\t To sort by Month salary");
                Console.WriteLine("Enter 4:\t To exitst");
                option = int.Parse(Console.ReadLine());

                #region Menu
                switch (option)
                {
                    case 1:
                        program.Display(employees);
                        break;
                    case 2:

                        Console.Clear();
                        Array.Sort(employees, new EmpSortByLastName());
                        program.Display(employees);

                        break;
                    case 3:
                        Console.Clear();
                        Array.Sort(employees, new EmpSortByMonthSalary());
                        program.Display(employees);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Number enter not invalid enter again");
                        break;
                }

                #endregion

            }

            Console.ReadLine();


        }
        public void Display(Employee[] emps)
        {

            Console.Clear();
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} {7,-15}", "Id", "First name", "Last name", "Full name", "Age", "Bonus", "Monthly", "LoveSpost");

            Console.WriteLine("***************** Resurlt****************");
            foreach (Employee emp in emps)
            {
                if(emp is HourlyEmployee){
                    HourlyEmployee hourlyEmployee = emp as HourlyEmployee;
                    hourlyEmployee.sportCharacteristics();
                }else{
                    SalaryEmployee salaryEmployee = emp as SalaryEmployee;
                    salaryEmployee.displayInformation();
                }
            }

        }
    }
}