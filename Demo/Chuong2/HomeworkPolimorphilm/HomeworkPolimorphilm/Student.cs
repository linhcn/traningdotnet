using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPolimorphilm
{
    class Student: Human
    {
        public int _grade;
        public Student()
        {

        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            _grade = grade;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("{0,20}",_grade);
        }

    }
}
