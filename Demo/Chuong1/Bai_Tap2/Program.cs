using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai_Tap2
{
    class Program
    {
        StringBuilder chuoixuat = new StringBuilder();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Program program = new Program();
            try
            {
                String so = Console.ReadLine();
                Console.WriteLine(program.xuLiChuoi(so));
                Console.ReadLine();

            }
            catch (FormatException fex)
            {
                Console.WriteLine("không hợp lệ {0}", fex);
                Console.ReadLine();
            }

        }

        public void hangChuc(String st1, String st2, int i)
        {
            if (st2.Equals(st1))
            {
                if (st1.Equals("0"))
                {
                    chuoixuat.Append(Variable1.lE);
                     chuoixuat.Append(Variable1.number[i]);
                }
                else
                {
                    chuoixuat.Append(Variable1.MUOIK);
                    chuoixuat.Append(Variable1.number[i]);
                }

            }
        }

        public void hangTram(String str, int i)
        {
            if (str.Equals("0"))
            {
                chuoixuat.Append(Variable1.number[0]);
                 chuoixuat.Append(Variable1.TRAM);
            }
            chuoixuat.Append(Variable1.number[i]);
             chuoixuat.Append(Variable1.TRAM);

        }

        public void hangNghin(String str, int i)
        {
            StringBuilder chuoixuat = new StringBuilder();
            if (str.Equals("0"))
            {
                chuoixuat.Append(Variable1.number[0]);
                chuoixuat.Append(Variable1.NGHIN);
            }
            chuoixuat.Append(Variable1.number[i]);
            chuoixuat.Append(Variable1.NGHIN);
        }
        public StringBuilder xuLiChuoi(String soNhap)
        {
            Char[] soChuoi1 = soNhap.ToCharArray(0, soNhap.Length);
            StringBuilder resurlt = new StringBuilder();
            for (int a = 0; a < soChuoi1.Length; a++)
            {
                for (int i = 0; i < Variable1.number.Length; i++)
                {

                    switch (soChuoi1.Length)
                    {
                        case 1:
                            if (soChuoi1[0].ToString().Equals(i.ToString()))
                            {
                                chuoixuat.Append(Variable1.number[i]);
                            }
                            break;
                        case 2:
                            hangChuc(soChuoi1[a].ToString(),(i.ToString()),i);
                            resurlt = chuoixuat;
                            break;

                        case 3:
                            if (soChuoi1[a].ToString().Equals(i.ToString()))
                            {
                                chuoixuat.Append(Variable1.number[i]);
                                //kiem tra hang chuc
                                if (a == 1)
                                {
                                    if (a == 0)
                                    {
                                        chuoixuat.Append(Variable1.lE);
                                    }
                                    chuoixuat.Append(Variable1.lE);
                                }
                            }
                            break;
                        case 4:
                            if (soChuoi1[a].ToString().Equals(i.ToString()))
                            {
                                if (a == 0)
                                {
                                    chuoixuat.Append(Variable1.number[int.Parse(soChuoi1[a].ToString())]);
                                    chuoixuat.Append(Variable1.NGHIN);
                                    chuoixuat.Append(Variable1.number[int.Parse(soChuoi1[a].ToString())]);
                                    chuoixuat.Append(Variable1.TRAM);
                                    chuoixuat.Append(Variable1.lE);
                                    chuoixuat.Append(Variable1.number[i].ToString());
                                }
                                else
                                {
                                    chuoixuat.Append(Variable1.number[int.Parse(soChuoi1[a].ToString())]);
                                }

                            }
                            break;

                        default:
                            chuoixuat.Append("không không phải là số");
                            break;

                    }
                }

            }
            return chuoixuat;
        }


    }


}
