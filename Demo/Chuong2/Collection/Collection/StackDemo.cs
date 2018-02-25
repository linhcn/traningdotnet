using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class StackDemo
    {
        public void excuteStack()
        {
            Stack<String> stack = new Stack<string>();

            stack.Push("Cao ngọc Linh");
            stack.Push("Nguyen van a");
            stack.Push("Nguyen van b");
            stack.Push("Nguyen van c");
            stack.Push("Nguyen van d");
            stack.Push("Nguyen van e");

           PrintValues(stack);
        }

             public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
           
    }
}
