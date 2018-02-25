using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection;

namespace MethoGeneric
{
    class MethotGeneric
    {

        public static void DisplayArray<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
               
                Console.Write(element + "");
                Console.WriteLine("\n");
            }
        }
    }
}
