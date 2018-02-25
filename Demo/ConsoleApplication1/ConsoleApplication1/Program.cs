using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int a = 1; int b = 2;
            double k = 5.5;
            float f = 5.5675677f;
            decimal h = 5.5m;

            Console.WriteLine("a = {0}, b = {1}, k = {2}, f = {3:f2}, h = {4:c}", a, b,k,f,h);

            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("nhập vào một chuổi");
            stringBuilder.Append(Console.ReadLine());
            Console.WriteLine("chuổi vừa nhập là:  {0}", stringBuilder);

            Console.WriteLine("nhập vào một số: ");
            int so;

            bool check = int.TryParse(Console.ReadLine(), out so);
            
            if (check)
            {
                Console.WriteLine("kiểu dữ liệu là: {0}", check);
            }
            else 
            {
                Console.WriteLine("kiểu dữ liệu là: {0}", check);
            }

            Console.ReadLine();


        }
    }
}
