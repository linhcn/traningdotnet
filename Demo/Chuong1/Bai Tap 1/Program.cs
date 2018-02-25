using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program bai_Tap_1 = new Program();

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào một tháng: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào một năm: ");
            int nam = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    bai_Tap_1.excuter(31);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:

                    bai_Tap_1.excuter(30);
                    break;
                case 2:
                    if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    {
                        bai_Tap_1.excuter(29);
                        break;
                    }
                    bai_Tap_1.excuter(28);
                    break;
                default:
                    Console.WriteLine("thang không hợp lệ");
                    Console.ReadLine();
                    break;
            }

        }

        public void excuter(int songay)
        {
            Console.WriteLine("tháng có {0}", songay, " ngày");
            Console.ReadLine();
        }

    }
}
