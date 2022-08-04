using System;

namespace Circumference
{
    public class Circle
    {
        public static void Main(string[] args)
        {
            try
            {
                area();
                static void area()
                {
                    double r, circum_circle, area;
                    double PI = 3.14;
                    Console.WriteLine("Radius of circle:");
                    r=Convert.ToDouble(Console.ReadLine());
                    circum_circle=2*PI*r;
                    Console.WriteLine("Circumference of circle:{0},", circum_circle);
                    area=PI*r*r;
                    Console.WriteLine("Area of circle:{0}", area);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
     class Client
    {
        public static void Main(string[] args)
        {
            Circle.Main(args);
        }
    }
   // Console.ReadKey();
}

