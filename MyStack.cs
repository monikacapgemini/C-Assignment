using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling

{
     class MyStack
    {
       
            private int[] ele;
            private int top;
            private int max;

            //Constructor initialize the variables || it calls as soon as object get created.
            public MyStack(int size)
            {
                ele = new int[size];
                top = -1;
                max = size;
            }

            public void push(int item)
            {
                if (top == max - 1)
                {
                    throw new Exception("Stack Overflow, can't perform push");
                }
                else
                {
                    ele[++top] = item;
                }
            }
            public int pop()
            {
                if (top == -1)
                {
                    throw new Exception("Stacck is Empty");
                }
                else
                {
                    Console.WriteLine("Poped element is " + ele[top]);
                    return ele[top--];
                }
            }
            public void printStack()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                else
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "): " + ele[i]);
                    }
                }
            }
        }

        class Program
        {
            static void Main()
            {
                //Stack is class || S is object
                MyStack S = new MyStack(5);

                //objectname.methodname() -> to call the method inside the class
                S.push(101); // Last in First Out
                S.push(202);
                S.push(303);
                S.push(404);
                S.push(505);

                Console.WriteLine("Items are : ");
                S.printStack();

                S.pop();
                S.pop();
                S.pop();
                S.pop();
                S.pop();

            }
        }
    }





