
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection;

namespace MethoGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tam1 = { 1, 2, 3, 4, 5 };
            MethotGeneric.DisplayArray<int>(tam1);

            Student[] students = {
                                    new Student
                                    {
                                        _id = 1,
                                        _firstName = "A",
                                        _lastName = "Nguyen"
                                    },
                                    new Student
                                    {
                                        _id = 2,
                                        _firstName = "B",
                                        _lastName = "Nguyen"
                                    },
                                    new Student
                                    {
                                        _id = 3,
                                        _firstName = "C",
                                        _lastName = "Nguyen"
                                    }
                                };


            MethotGeneric.DisplayArray<Student>(students);


            Program program = new Program();

            int x = 5, y = 7;
            program.swap<int>(ref x, ref y);
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);

            double a = 5.5, b = 7.8;
            program.swap<double>(ref a, ref b);
            Console.WriteLine("x = {0}", a);
            Console.WriteLine("y = {0}", b);
            
            
        }

        public void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
