using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Circle : Figure
    {
        public int _x;
        public int _y;
        public int _radius;

        public Circle() { }

        public Circle(int x, int y, int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override double calcSurface()
        {
            return 3.14 * _radius * _radius;
        }
    }
}
