using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class SortLastName : IComparer<Student>
    {

        public int Compare(Student x, Student y)
        {
            Student st1 = x as Student;
            Student st2 = y as Student;

            if (st1 != null && st2 != null)
            {
                return st1._lastName.CompareTo(st2._lastName);
            }
            else
                throw new ArgumentException();
        }
    }
}
