using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //Point
            //PointColor color;
            //Enum.TryParse<PointColor>("1", out color);            
            //Point point1 = new Point();

            //point1.X = 1;
            //point1.Y = 3;
            //point1.pointColor = color;

            //point1.display();

            //Point [] listPoint = new Point[3];
            //listPoint[0] = new Point(4, 5, PointColor.BloodRed);
            //listPoint[1] = new Point(3, 6, PointColor.Gold);
            //listPoint[2] = new Point(7, 3, PointColor.LightBlue);
            //foreach (Point i in listPoint)
            //{
            //    i.display();
            //    Console.WriteLine(i);
            //}

            Rectangle Rectangle1 = new Rectangle
            {
                UpperLest = new Point(1, 3,PointColor.BloodRed),
                ButtomRight = new Point(1, 9, PointColor.Gold)
            };

            Console.WriteLine(Rectangle1);
        }
    }
}
