using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPolimorphilm
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            #region ArrayStudent
            Student[] arrayStudent = {
                                         new Student{
                                             _firstName = "A",
                                             _lastName = "Nguyen",
                                             _grade = 8
                                         },
                                         new Student{
                                             _firstName = "B",
                                             _lastName = "Nguyen",
                                             _grade = 2
                                         },
                                         new Student{
                                             _firstName = "C",
                                             _lastName = "Nguyen",
                                             _grade = 1
                                         },
                                         new Student{
                                             _firstName = "D",
                                             _lastName = "Nguyen",
                                             _grade = 5
                                         },
                                         new Student{
                                             _firstName = "E",
                                             _lastName = "Nguyen",
                                             _grade = 3
                                         },
                                         new Student{
                                             _firstName = "F",
                                             _lastName = "Nguyen",
                                             _grade = 7
                                         },
                                         new Student{
                                             _firstName = "G",
                                             _lastName = "Nguyen",
                                             _grade = 4
                                         },
                                         new Student{
                                             _firstName = "H",
                                             _lastName = "Nguyen",
                                             _grade = 6
                                         },
                                         new Student{
                                             _firstName = "K",
                                             _lastName = "Nguyen",
                                             _grade = 9
                                         },
                                         new Student{
                                             _firstName = "J",
                                             _lastName = "Nguyen",
                                             _grade = 10
                                         },
                                     };
            #endregion

            #region ArrayWorker
            Worker[] arrayWorker = {
                                  new Worker{
                                             _firstName = "A",
                                             _lastName = "Nguyen",
                                             _weekSalary = 8000000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "B",
                                             _lastName = "Nguyen",
                                             _weekSalary = 700000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "C",
                                             _lastName = "Nguyen",
                                             _weekSalary = 500000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "D",
                                             _lastName = "Nguyen",
                                             _weekSalary = 9000000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "E",
                                             _lastName = "Nguyen",
                                             _weekSalary = 1000000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "F",
                                             _lastName = "Nguyen",
                                             _weekSalary = 700000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "G",
                                             _lastName = "Nguyen",
                                             _weekSalary = 3000000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "H",
                                             _lastName = "Nguyen",
                                            _weekSalary = 1200000,
											_hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "K",
                                             _lastName = "Nguyen",
                                             _weekSalary = 1700000,
											 _hoursWork = 5
                                         },
                                         new Worker{
                                             _firstName = "J",
                                             _lastName = "Nguyen",
                                             _weekSalary = 3000000,
											 _hoursWork = 5
                                         },
                              };
            #endregion

            Console.WriteLine("****************Human Management*****************");

            int option = 0;
            while(option != 4)
            {

                Console.WriteLine("Enter 1:\t To display student list");
                Console.WriteLine("Enter 2:\t To sort");
                Console.WriteLine("Enter 3:\t To display work list");
                Console.WriteLine("Enter 4:\t To sort");
                Console.WriteLine("Enter 5:\t To exitst");
                option = int.Parse(Console.ReadLine());

                #region Menu
                switch (option)
                {
                    case 1:

                        Console.Clear();
                        program.showInforStudent(arrayStudent);
                        break;
                    case 2:

                        Console.Clear();
                        Student student;
                        for (int i = 1; i < arrayStudent.Length; i++)
                        {

                            for (int j = i; j > 0; j--)
                            {
                                if (arrayStudent[j]._grade < arrayStudent[j - 1]._grade)
                                {
                                    student = arrayStudent[j];
                                    arrayStudent[j] = arrayStudent[j - 1];
                                    arrayStudent[j - 1] = student;
                                }

                            }
                        }
                        program.showInforStudent(arrayStudent);

                        break;
                    case 3:
                        Console.Clear();
                        program.showInforWork(arrayWorker);
                        break;
                    case 4:

                        Console.Clear();
                        for (int i = 0; i < arrayWorker.Length - 1; i++)
                        {
                            int tem = i;
                            Worker workerTemp = arrayWorker[i];
                            for (int j = i + 1; j < arrayWorker.Length; j++)
                            {
                                if (arrayWorker[j]._weekSalary < arrayWorker[tem]._weekSalary)
                                {
                                    tem = j;
                                }
                            }
                            arrayWorker[i] = arrayWorker[tem];
                            arrayWorker[tem] = workerTemp;

                        }
                        program.showInforWork(arrayWorker);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Number enter not invalid \n enter again");
                        break;
                }

                #endregion

            }
        }

        #region DisplayHuman

        public void showInforStudent(Student[] arrayStudent)
        {
            int tam = 1;
            Console.WriteLine("===========Infor Student============");
            Console.WriteLine("STT \t  Last name \t First name \t\t grade");
            foreach (Student st in arrayStudent)
            {
                Console.Write("{0,-2}", tam);
                st.display();
                tam++;
            }

        }

        public void showInforWork(Worker[] arrayWorker)
        {
            Console.WriteLine("===========Infor Worker============");
            Console.WriteLine("STT \t  Last name \t First name \t Money per hours ");
            int stt2 = 1;
            foreach (Worker worker in arrayWorker)
            {

                Console.Write("{0,-2}", stt2);
                worker.display();
                stt2++;
            }
        }

        #endregion

    }
}
