using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterFace
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[3];

        public Garage()
        {
            carArray[0] = new Car("Ducati",200);
            carArray[1] = new Car("Exciter", 150);
            carArray[2] = new Car("Lamborghini", 10000);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }
    }
}
