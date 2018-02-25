using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Employee
    {
        public string lastName;
        public string firstName;
        public string cityOfBrith;

        public Employee(string lastName, string firstName, string cityOfBrith)
        {
            this[0] = lastName;
            this[1] = firstName;
            this[2] = cityOfBrith; 
        }

        public Employee()
        {
        }

        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0: lastName = value;
                        break;
                    case 1: firstName = value;
                        break;
                    case 2: cityOfBrith = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
            get
            {
                switch (index)
                {
                    case 0: return lastName;
                    case 1: return firstName;
                    case 2: return cityOfBrith;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }


    }
}
