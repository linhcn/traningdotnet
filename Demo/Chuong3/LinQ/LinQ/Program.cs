using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        delegate bool AgeDelegate(Student t);
        class Student
        {
            private string _name;
            private int _age;

            public string Name { get { return _name; } }

            public int Age { get { return _age; } }

            public Student()
            {

            }
            public Student(string name, int age)
            {
                _age = age;
                _name = name;
            }

            public override string ToString()
            {
                return String.Format("{0} {1}", _age, _name);
            }

            public static void getAge(List<Student> list, AgeDelegate t)
            {
                foreach (Student item in list)
                {
                    if (t(item))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>{
                new Student(name:"Van A",age:20),
                new Student(name:"Van B",age:21),
                new Student(name:"Van C",age:22)
            };

            // dung truy van linQ

            var students = from s in list where s.Age > 20 select s;

            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
