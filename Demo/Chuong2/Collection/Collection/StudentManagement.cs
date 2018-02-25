using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class StudentManagement : IEnumerable
    {

        private List<Student> _students = new List<Student>();
        
        public StudentManagement() { }

        public Student getStudent(int id)
        {
                return (Student)_students[id];
        }

        public void addStudent(Student student)
        {
            _students.Add(student);
        }

        public void addRangeStudent(Student[] students)
        {
            _students.AddRange(students);
        }


        public int count()
        {
            return _students.Count;
        }


        public void SortFirstName()
        {
            _students.Sort(new SortFirstName());
        }

        public void SortLastName()
        {
            _students.Sort(new SortLastName());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Student st in _students)
            {
                yield return st;
            }
        }
    }
}
