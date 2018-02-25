using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    enum SortBy
    {
        SORTBYFIRSTNAME = 1,
        SORTBYLASTNAME
    };

    class Program
    {

        public static string FIRSTNAME = "First Name";
        public static string ID = "id";
        public static string LASTNAME = "Last Name";
        public static string FULLNAME = "Full Name";


        static void Main(string[] args)
        {

            Program Program = new Program();

            StackDemo stackDemo = new StackDemo();
            stackDemo.excuteStack();

            QuestDemo questDemo = new QuestDemo();
            questDemo.excuteQuest();







            Student student = new Student
            {
                _id = 1,
                _lastName = "Cao",
                _firstName = "Linh"

            };

            StudentManagement studentManagement = new StudentManagement();
            studentManagement.addStudent(student);

            Student[] students = {
                                     new Student
                                     {
                                         _id = 2,
                                         _lastName = "Nguyen",
                                         _firstName = "A"
                                     },
                                      new Student
                                     {
                                         _id = 1,
                                         _lastName = "Nguyen",
                                         _firstName = "B"
                                     },
                                      new Student
                                     {
                                         _id = 3,
                                         _lastName = "Nguyen",
                                         _firstName = "C"
                                     }
                                 };

            studentManagement.addRangeStudent(students);

            foreach(Student st in studentManagement){
                Console.WriteLine(st);
            }

            #region Menu
            Console.WriteLine("\n============== Choose methort sort=====================");
            bool tam = true;
            do
            {
                Console.WriteLine("\n Enter 1:\t To Sort FirstName");
                Console.WriteLine(" Enter 2:\t To Sort LastName");
                Console.WriteLine(" Enter Orther:\t To Exist");
                SortBy sb;
                tam = Enum.TryParse(Console.ReadLine(), out sb);
                
                switch (sb)
                {
                    case SortBy.SORTBYFIRSTNAME:
                        studentManagement.SortFirstName();
                        Program.Display(studentManagement);
                        break;
                    case SortBy.SORTBYLASTNAME:
                        studentManagement.SortLastName();
                        Program.Display(studentManagement);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

               

            } while (tam == true);
        }

            #endregion

        public void Display(StudentManagement studentManagement)
        {

            Console.Clear();
            Console.WriteLine("*************** Student *****************");
            Console.WriteLine("{0, -10} {1,-20} {2,-20} {3,-20}", ID, LASTNAME, FIRSTNAME, FULLNAME);
            foreach (Student st in studentManagement)
            {
                Console.WriteLine(st);
            }

        }
    }
}
