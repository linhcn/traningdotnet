using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    class Hexagon: Shape,IPoint
    {
        public override void draw()
        {
            Console.WriteLine("Shape is Hexagon");
        }


        public new byte Point
        {
            get { return 5; }
        }
    }
}
