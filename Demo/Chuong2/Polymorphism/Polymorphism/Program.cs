using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // code manager 
            Console.WriteLine("================= info manager=============");
            
            Manager manager = new Manager
            {
                numberEmSG = 1,
                idEmSG = 2,
                nameSG = "Cao Ngọc Linh",
                ageSG = 20
                
            };

            manager.display();

            // code person
            Console.WriteLine("================= info Sale Person=============");

            SalePerson SalePerson = new SalePerson
            {
                numberProductSG  = 1,
                idEmSG  = 2,
                nameSG = "Nguyen Van A",
                ageSG = 30
            };

            SalePerson.display();
            //user vitual
            SalePerson.sayHello();
            
            // trieu goi mot lop thong qua lop cha
            // dung trong truong hơp truy xuất đối tượng trong mãng
            Console.WriteLine("================== Mang Employee ================");
            Employee[] listEm = {
                new SalePerson
                    {
                        numberProductSG  = 10,
                        idEmSG  = 3,
                        nameSG = "Nguyen Van A",
                        ageSG = 35
                    },

                new SalePerson
                    {
                        numberProductSG  = 2,
                        idEmSG  = 3,
                        nameSG = "Nguyen Van B",
                        ageSG = 30
                    },
                new Manager
                    {// manager is a Employee up - casting
                        numberEmSG = 1,
                        idEmSG = 2,
                        nameSG = "Cao Ngọc Linh",
                        ageSG = 20
                
                    }
            };

            foreach(var item in listEm)
            {
                item.display();

            }

            // up - casting
            // chi chay tai thoi diem run time
            // giải phap dung tu khoa as tra ve null neu khong em kieu duoc
            Manager mg = listEm[2] as Manager;
            if (mg != null)
            {
                mg.sayYeah();
            }
            else
            {
                Console.WriteLine("invalida Cast!");
            }
            

        }

    }
}
