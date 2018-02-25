using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    class Triangle : Shape , IPoint
    {
        public override void draw()
        {
            Console.WriteLine("Triangle");
        }

        public new byte Point
        {
            get { return 3; }
        }
    }
}
