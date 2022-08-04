using System;

namespace Calculator
{
    class Class1
    {
        static void Main(string[] args)
        {

            try
            {
                int num1 ;
                int num2 ;
                Console.WriteLine("Enter a number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Add");
                Console.WriteLine("\t2 - Subtract");
                Console.WriteLine("\t3 - Multiply");
                Console.WriteLine("\t4 - Divide");
                Console.Write("Your option? ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "2":
                        Console.WriteLine("Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "3":
                        Console.WriteLine("Your result: {num1} * {num2} = " + (num1* num2));
                        break;
                    case "4":
                        Console.WriteLine("Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); 
            }
           
            Console.Write("Press any key to close the Calculator ");
            Console.ReadKey();

        }
    }
}

