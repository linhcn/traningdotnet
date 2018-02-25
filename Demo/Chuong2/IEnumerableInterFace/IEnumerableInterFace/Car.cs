using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterFace
{
    

    class Car : IComparable
    {
        private string _name;
        private int _speed;
        public static int _maxSpeed = 300;

        public Car() { }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                if (_speed > _maxSpeed)
                {
                    _speed = _maxSpeed;
                }
            }
        }
        public override string ToString()
        {
            return String.Format(" {0,-20} {1,5:0}", this.Name, this.Speed);
        }


        public int CompareTo(object obj)
        {
            Car itemCar = obj as Car;
            Console.WriteLine(this._name.CompareTo(itemCar.Name));

            if (itemCar != null)
            {
                if (this._name.CompareTo(itemCar.Name) == -1)
                {
                    return 1;
                }
                if (this._name.CompareTo(itemCar.Name) == -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

                // if return about 1 sap xep truoc doi tuong ke do va nguoc lai
            }
            else
            {
                throw new ArgumentException("Paramater is not a Car");
            }
        }



    }
}
