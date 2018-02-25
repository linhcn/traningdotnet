using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine().ToString());
            MakeToString makeToString = new MakeToString(number);
            makeToString.BlockProcessing();
            Console.WriteLine(makeToString.ReadThis());
        }
    }
}
