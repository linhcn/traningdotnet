using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] arrayFigure = {
                                  new Square(){
                                      _x = 1,
                                      _y = 2,
                                      _size = 13
                                  },
                                  new Circle(){
                                      _x = 1,
                                      _y = 2,
                                      _radius = 13
                                  },
                                  new Square(){
                                      _x = 5,
                                      _y = 2,
                                      _size = 19
                                  },
                                  new Circle(){
                                      _x = 1,
                                      _y = 5,
                                      _radius = 3
                                  },
                              };
            double tongDienTichSquare = 0;
            double tongDienTichCircle = 0;
            foreach(var i in arrayFigure){
                if (i is Square)
                {
                    tongDienTichSquare = tongDienTichSquare + i.calcSurface();
                }
                else
                {
                    tongDienTichCircle = tongDienTichCircle + i.calcSurface();
                }
            }

            Console.WriteLine("Square: {0}", tongDienTichSquare);
            Console.WriteLine("Circle: {0}", tongDienTichCircle);
        }
    }
}
