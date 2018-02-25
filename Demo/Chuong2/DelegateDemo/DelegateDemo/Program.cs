using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    class Program
    {

        delegate int MyDel();

        delegate bool AgeDelegate(Student t);

        class MyClass
        {
            int IntValue = 5;
            public int add2()
            {
                IntValue += 2;
                return IntValue;
            }

            public int add3()
            {
                IntValue += 3;
                return IntValue;
            }
        }

        class Student
        {
            private string _name;
            private int _age;

            public string Name { get { return _name; } }

            public int Age { get { return _age;}}

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
                return String.Format("{0} {1}", _age,_name);
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

        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {

            MyClass mc = new MyClass();
            MyDel myDel1 = new MyDel(mc.add2);
            MyDel myDel = mc.add2;
            myDel += mc.add3;
            myDel += mc.add2;

            Console.WriteLine("value: {0}", myDel());

            //============= DEMO 2==================

            List<Student> list = new List<Student>{
                new Student(name:"Van A",age:20),
                new Student(name:"Van B",age:21),
                new Student(name:"Van C",age:22)
            };

            // dung truy van link

            var students = from s in list where s.Age > 20 select s;

            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }

            // viet theo kieu nac danh
            Student.getAge(list, delegate(Student student)
            {
                return student.Age > 20;
            });

            Student.getAge(list, delegate(Student student){
                return student.Name == "Van A";
            });

            // dung lambda
            Student.getAge(list, x => x.Age > 20);



        }


    }
}
