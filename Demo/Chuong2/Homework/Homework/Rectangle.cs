using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Rectangle
    {

        private Point upperLest;
        private Point buttonRight;

        public Point UpperLest
        {
            set {upperLest = value ;}
            get {return upperLest;}
        }

        public Point ButtomRight
        {
            set { buttonRight = value; }
            get { return buttonRight; }
        }

        public Rectangle(Point point1, Point point2)
        {
            UpperLest = point1;
            ButtomRight = point2;
        }

        public Rectangle()
        {
        }

        public override string ToString()
        {
            return string.Format("UpperLest = {0} \n ButtionRight = {1}", UpperLest, ButtomRight);
        }
    }
}
