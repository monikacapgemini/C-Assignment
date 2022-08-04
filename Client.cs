using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;
using System.Collections;

namespace Iclonableinterface
{
    
    class Client
    {
        public static void Main(string[] args)
        {

            try
            {
                
                StackImplementation.Stack mystack = new StackImplementation.Stack();
                mystack.Push(10);
                mystack.Push(20);
                mystack.Push(30);
                mystack.Push(40);
               mystack.PrintStack();
                mystack.Peek();
                Console.WriteLine("Item popped from Stack : {0}", mystack.Pop());
                mystack.PrintStack();
                StackImplementation.Stack mystack2 = (StackImplementation.Stack)mystack.Clone();
                Console.WriteLine("Cloned Stack",mystack2 );
                mystack.Push(10);
                mystack.Push(20);
                mystack.Push(30);
                mystack.Push(40);
                mystack.PrintStack();
                mystack.Peek();
                Console.WriteLine("Item popped from Stack : {0}", mystack.Pop());
                mystack2.PrintStack();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            
    }
}
