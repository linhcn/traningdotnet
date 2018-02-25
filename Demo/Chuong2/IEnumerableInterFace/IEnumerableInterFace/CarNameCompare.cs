using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterFace
{
    class CarNameCompare : IComparer
        {
           
            public int Compare(object x, object y)
            {
                Car itemCar1 = x as Car;
                Car itemCar2 = y as Car;
                if (itemCar1 != null && itemCar2 != null)
                {
                    return itemCar1.Name.CompareTo(itemCar2.Name);
                }
                else
                throw new ArgumentException();
            }
        }
}
