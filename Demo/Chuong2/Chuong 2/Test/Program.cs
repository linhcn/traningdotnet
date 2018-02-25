using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    
    
    class Program
    {
        enum WeekDays{
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        static void Nhap(out int a, out string str)
        {
            Console.WriteLine("Nhap vao bien nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao chuoi: ");
            str = Console.ReadLine();

        }
        static int AddElement( int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
        static int AddElement1(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
        static void Print(params object[] obj)
        {
            foreach (var item in obj)
            {
                Console.WriteLine(item.ToString());
            }
           
        }
        static void printDay(WeekDays w){
        switch (w)
	{
		case WeekDays.Monday:
                Console.WriteLine("Hello Monday!");
                break;
        case WeekDays.Tuesday:
                Console.WriteLine("Hello Tuesday!");
                break;
        case WeekDays.Wednesday:
                Console.WriteLine("Hello Wednesday!");
                break;
        case WeekDays.Thursday:
                Console.WriteLine("Hello Thursday!");
                 break;
        case WeekDays.Friday:
                Console.WriteLine("Hello Friday!");
                break;
        case WeekDays.Saturday:
                Console.WriteLine("Hello Saturday!");
                break;
        case WeekDays.Sunday:Console.WriteLine("Hello Sunday!");
                break;
	        }
        }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //int[] a = { 1, 2, -2 };
            //int sum = AddElement(a);
            //int sum1 = AddElement1(1,2,-2,-4,0,5);
            //Console.WriteLine("sum ={0},sum1={1}", sum, sum1);
            //Print(1, 2, 1.5, "A");
            WeekDays w = WeekDays.Monday;
            printDay(w);
            Console.WriteLine(w);
            Console.WriteLine(Enum.GetName(typeof(WeekDays), 1));
            WeekDays d;
            Console.WriteLine("Nhap ngay:");
            string str = Console.ReadLine();
          
            bool kq = Enum.TryParse(str, out d);
            if (kq)
            {
                printDay(d);
            }
            else
                Console.WriteLine("Nhap sai");
          
            Console.ReadLine();

        }
    }
}
