using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinQ
{
    class Student
    {
        public string _name;
        public int _id;
        public int _age;
        public int _idSubject;


        public Student()
        {

        }
        public Student(string name, int id, int age)
        {
            _age = age;
            _id = id;
            _name = name;
        }

        public Student(string name, int id, int age, int idSubject)
            : this(name, id, age)
        {
            _idSubject = idSubject;
        }

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-15} {2,-15} {3,-15}", _id, _name, _age, _idSubject);
        }
    }
}
