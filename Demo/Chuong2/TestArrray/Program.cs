using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập kích thước của mãng: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberN = new int[n];
            int[] numberT = new int[n];
            int size = 0;
            int chiso = n - 1;
            Console.WriteLine("nhập các giá trị cho mang");
            while (size < numberN.Length)
            {
                numberN[size] = int.Parse(Console.ReadLine());
                numberT[chiso] = numberN[size];
                size++;
                chiso--;
            }
            Console.WriteLine("mảng vừa nhập theo chiểu thuận");
            
            foreach (int nb in numberN)
            {
                Console.WriteLine(nb);
            }

            Console.WriteLine("mảng đảo ngược");
            foreach (int nt in numberT)
            {
                Console.WriteLine(nt);
            }

            //dùng các phương thức có sẵn để thực hiện đảo mảng

            Array.Reverse(numberT);

            Console.WriteLine("mảng khôi phục");
            foreach (int nt in numberT)
            {
                Console.WriteLine(nt);
            }
            // các phương thức khác của mảng
            Console.WriteLine("các phương thức khác:");
            Console.WriteLine("LastIndexOf(): {0}", Array.LastIndexOf(numberT, 3,2,3));
            Console.WriteLine("IndexOf(): {0}", Array.IndexOf(numberT, 3));
            Console.WriteLine("Sort(): sắp xếp mãng tăng dần");
            Array.Sort(numberT);
            foreach (int nt in numberT)
            {
                Console.WriteLine(nt);
            }

            Console.ReadLine();
        }
    }
}
