using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : Figure
    {
        public int _x;
        public int _y;
        public int _size;

        public Square() { }

        public Square(int x, int y, int size)
        {
            _x = x;
            _y = y;
            _size = size;
        }

        public override double calcSurface()
        {

            return _size * _size;
        }
    }
}
