using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class QuestDemo
    {
        public void excuteQuest()
        {
            // tạo 1 thể hiện của lớp Queue
            Queue myQ = new Queue();
            myQ.Enqueue("Hello"); // đưa "Hello" vào cuối hàng đợi
            myQ.Enqueue("World"); // đưa "Word" vào cuối hàng đợi
            myQ.Enqueue("!"); // đưa "!" vào cuối hàng đợi

            // Hiển thị thuộc tính và giá trị của hàng đợi
            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count); //dùng để xem số lượng phần tử trong Queue
            Console.Write("\tValues:");
            PrintValues(myQ); // hàm này để in các giá trị trong Queue
            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write("    {0}", obj);
                Console.WriteLine();
            }

        }
    }
}
