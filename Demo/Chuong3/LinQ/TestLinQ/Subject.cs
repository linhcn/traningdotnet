using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinQ
{
    class Subject
    {
        public int _id;
        public string _nameSubject;

        public Subject()
        {

        }

        public Subject(int id, string nameSubject)
        {
            _id = id;
            _nameSubject = nameSubject;
        }
    }
}
