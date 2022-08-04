using System;

namespace ParamArray
{
    public class client
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                int n = numbers.Length;
                Param(numbers);

                static int Param(params int[] numbers)
                {
                    int sum = 0;
                    for (int i = 0; i<numbers.Length; i++)
                    {
                        sum=sum+numbers[i];
                    }
                    Console.WriteLine("sum of all integers:{0}", sum);
                    return sum;
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
 
