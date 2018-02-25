using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Student
    {
        public int _id;
        public string _firstName;
        public string _lastName;

        public Student() { }

        public Student(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string getFullName()
        {
            return _lastName+" "+ _firstName;
        }

        public override string ToString()
        {
            return String.Format("{0, -10} {1,-20} {2,-20} {3,-20}", _id, _lastName, _firstName, getFullName());
        }

    }
}
