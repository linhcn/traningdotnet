using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n|{0,-10}|{1,-15}|{2,-15} |", "Id", "Name", "Age");
            List<Student> students = new List<Student>{
                                         new Student{
                                             _name = "Trung",
                                             _id = 1,
                                             _age = 20
                                          },
                                          new Student{
                                             _name = "Thanh",
                                             _id = 2,
                                             _age = 20
                                          },
                                           new Student{
                                             _name = "Ma",
                                             _id = 1,
                                             _age = 29
                                           },
                                          new Student{
                                             _name = "Cong",
                                             _id = 3,
                                             _age = 25
                                          },
                                          new Student{
                                             _name = "Mau",
                                             _id = 4,
                                             _age = 29
                                          },
                                             new Student{
                                             _name = "Muoi",
                                             _id = 2,
                                             _age = 29
                                          }
                                     };

            // ============ Query sytas ====================//

            Console.WriteLine("\n***************** select not DK and custom **********************\n");
            var sts = from s in students select new {ID = s._id, Name = "Mr " + s._name , Age = s._age};

            foreach (var item in sts)
            {
                Console.WriteLine("{0,-10} {1,-15} {2,-15}", item.ID, item.Name, item.Age);
            }

            Console.WriteLine("\n***************** select condition 18 < age < 21 *********************\n");
            var sts1 = from s in students where (s._age > 18 && s._age < 21) select s;
            foreach (Student student in sts1)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n***************** select sort by name **********************\n");
            var sts2 = from s in students orderby s._name select s;
            foreach (Student student in sts2)
            {
                Console.WriteLine(student);
            }

            //======= truy van theo method===============
            Console.WriteLine("\n***************** select SOME condition FOLLOW METHOD **********************\n");
            var sts5 = students.Where(s => s._age > 20).Where(s=>s._name.StartsWith("M")).OrderByDescending(s => s._id);

            foreach (Student student in sts5)
            {
                Console.WriteLine(student);
            }

            //=========== group by==============

            Console.WriteLine("\n***************** select condition group ... by... **********************\n");
            var sts6 = from s in students group s by s._name;

            foreach (var item in sts6)
            {
                Console.WriteLine(item.Key);
            }

            //====== ues join in object ============


            List<Student> students2 = new List<Student>{
                                         new Student{
                                             _name = "Trung",
                                             _id = 1,
                                             _age = 20,
                                             _idSubject = 5
                                          },
                                          new Student{
                                             _name = "Thanh",
                                             _id = 3,
                                             _age = 20,
                                             _idSubject = 1
                                          },
                                           new Student{
                                             _name = "Ma",
                                             _id = 2,
                                             _age = 29,
                                             _idSubject = 3
                                           }
                                     };

            List<Subject> subjectS = new List<Subject>{
                                         new Subject{
                                             _id = 1,
                                             _nameSubject = "Enviroment",
                                          },
                                         new Subject{
                                             _id = 2,
                                             _nameSubject = "Internal Technology",
                                          },
                                          new Subject{
                                             _id = 3,
                                             _nameSubject = "Computer",
                                          },
                                     };
            Console.WriteLine("\n***************** select condition join Method(name) **********************\n");

            var innerJoinResurt = students2.Join(
                subjectS ,
                st => st._idSubject,
                sb => sb._id,
                (st,sb) => new {
                                    StudentID = st._id,
                                    StudentName = st._name,
                                    SubjectName = sb._nameSubject
                                });


            Console.WriteLine("{0,-25} {1,-25} {2}","Student ID" ,"Name Student", "Name Subject");

            foreach (var item in innerJoinResurt)
            {
                Console.WriteLine("{0,-25} {1,-25} {2}",item.StudentID,item.StudentName,item.SubjectName);
            }

            Console.WriteLine("\n***************** select condition join Query(name) **********************\n");

            var innerJoinResurtQuery = from st in students2
                                       join sb in subjectS
                                       on st._idSubject equals sb._id
                                       orderby st._name ascending
                                       select new {
                                           StudentID = st._id,
                                           StudentName = st._name,
                                           SubjectName = sb._nameSubject
                                       };

            foreach (var item in innerJoinResurt)
            {
                Console.WriteLine("{0,-25} {1,-25} {2}", item.StudentID, item.StudentName, item.SubjectName);
            }
            Student Student = new Student(name: "Trung", id: 1, age: 20, idSubject: 5);
            bool kt = students2.Contains(Student,new SotudentIEqualtyComparer());
            Console.WriteLine(kt);

            // test element
            Console.WriteLine(students2.ElementAt(1));
            //

            Console.WriteLine(students2.ElementAtOrDefault(-1));

            Console.WriteLine(students2.Skip(2));

        }
    }

    class SotudentIEqualtyComparer : IEqualityComparer<Student>
    {

        public bool Equals(Student x, Student y)
        {
            return x._id == y._id;
        }

        public int GetHashCode(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
