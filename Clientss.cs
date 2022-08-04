using System;

namespace ConsoleApp6
{
     class Clientss
    {
        public static void Main(string[] args)
        {
            try
            {
                Circumference.Circle.Main(args);
                swaping.Swaptwo.Main(args);
                ParamArray.client.Main(args);
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); 
            }
            Console.ReadKey();
        }

    }
}
