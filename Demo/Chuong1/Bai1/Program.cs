using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{

    class Program
    {
        /// <summary>
        /// Đây là chú thích hàm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            StringBuilder name = new StringBuilder();
            name.AppendLine("Cao Ngọc Linh");
            Console.WriteLine("Họ Tên: " + name);
            Console.ReadLine();

        }
    }
}
