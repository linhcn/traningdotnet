using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterFace
{
    class Program
    {
        enum SortBy
            {
                SORTBYNAME =1,
                SORTBYSPEED
            };

        static void Main(string[] args)
        {
            Program Program = new Program();
            Garage garage = new Garage();
            foreach (Car c in garage)
            {
                Console.WriteLine(c);
            }

            // sap xep mang object throw IComparable
            Console.WriteLine("\n=================sap xep the cac thuoc tinh==============");

            Console.WriteLine("***sap xep theo speed dung ICompare***");
            Car[] cr = {
                           new Car{
                               Name = "Ducati",
                               Speed = 110
                           },
                           new Car{
                               Name = "Ducati",
                               Speed = 110
                           },
                           new Car{
                               Name = "Audi",
                               Speed = 150
                           },
                           new Car{
                               Name = "Novol",
                               Speed = 120
                           }
                       };

            Array.Sort(cr, new CarSpeedCompare());

            foreach (Car c in cr)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\n***sap xep theo name dung ICompareTo***");

            Array.Sort(cr);

            foreach (Car c in cr)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\n============== lưa chọn sắp xếp=====================");
            bool tam = true;
            do{
                Console.WriteLine("\n Enter 1:\t To Sort name");
                Console.WriteLine(" Enter 2:\t To Sort speed");
                Console.WriteLine(" Enter Orther:\t To Exist");
                SortBy sb ;
                tam = Enum.TryParse(Console.ReadLine(), out sb);
                #region Menu
                switch (sb)
                {
                    case SortBy.SORTBYNAME:
                        Array.Sort(cr, new CarNameCompare());
                        Program.Display(cr);
                        break;
                    case SortBy.SORTBYSPEED:
                        Array.Sort(cr, new CarSpeedCompare());
                        Program.Display(cr);
                        
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                #endregion

            } while (tam == true);
            
            }
        public void Display(Car[] cr)
        {

            Console.Clear();
            Console.WriteLine("***************** Resurlt****************");
            string name = "Name";
            string speed = "Speed";
            Console.WriteLine(" {0,-20} {1,5:0}", name, speed);
            foreach (Car c in cr)
            {
                Console.WriteLine(c);
            }

        }
        }
}
