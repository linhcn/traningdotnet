using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        private static void PlusValue(int v)
        {
            v++;
            
        }
        private static void PlusRef(ref int r)
        {
            r++;
        }
        private static void PlusOut( out int o)
        {
            o = 0;
            o++;
        }
        static void Main(string[] args)
        {
            int v = 0;
            PlusValue(v);
            Console.WriteLine("Số {0}", v);

            int r = 0;
            PlusRef(ref r);
            Console.WriteLine("Số {0}", r);

            int o;
            PlusOut(out o);
            Console.WriteLine("Số {0}", o);

            Console.ReadLine();
        }
    }
}
