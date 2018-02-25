using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPolimorphilm
{
    class Human
    {
        public string _firstName;
        public string _lastName;

        public Human()
        {

        }

        public Human( string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }

        public virtual void display()
        {
            Console.Write(" {0,14}", _lastName);

            Console.Write(" {0,14}", _firstName);

        }
    }
}
