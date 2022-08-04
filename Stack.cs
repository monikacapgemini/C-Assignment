using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize a stack
            Stack stack1 = new Stack();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            stack1.Push(40);
            stack1.Push(50);
            Console.WriteLine("Stack elements are...");
            foreach (int val in stack1)
            {
                Console.WriteLine(val);
            }
            Stack stack2 = (Stack)stack1.Clone();
            Console.WriteLine("Stack cloned elements are");
            foreach (int val in stack2)
            {
                Console.WriteLine(val);
                Console.ReadLine();
            }
        }
    }
}