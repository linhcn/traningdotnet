using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }
    class Point
    {
        
        #region ParameterRegion
        private float x;
        private float y;
        public PointColor pointColor;
        
        #endregion

        #region ControctorRegion
        public Point(float x, float y)
        {
            Y = y;
            X = x;
        }
        public Point(float x, float y, PointColor pointColor) : this(x, y)
        {
            this.pointColor = pointColor;
        }

        public Point(){}
        #endregion

        #region SetGetRegion

        public float X { 
            get { return x; }
            set { x = value; }
        }

        public float Y {
            get{return y;}
            set { y = value; }
        }

        public PointColor PointColor { get { return pointColor; } }
        #endregion


        #region disPlayRegion
        public void display()
        {
            Console.WriteLine("X = {0}, Y = {1}, Color is {2}", this.x, this.y, this.pointColor);
        }

        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}, Color is {2}", this.x, this.y, this.pointColor);
        }
        #endregion
        

    }
}
