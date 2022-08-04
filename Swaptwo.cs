using System;

namespace swaping
{
     public class Swaptwo
    {
        public static void Main(string[] args)
        {
            try
            {
                swap();


                 static void swap()
                {
                    int a = 5, b = 10;
                    Console.WriteLine("Before swap a="+a+"b="+b);
                    a=a*b;
                    b=a/b;
                    a=a/b;
                    Console.WriteLine("After swap a="+a+"b="+b);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}
