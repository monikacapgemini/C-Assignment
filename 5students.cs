using System;

namespace Average
{
    public class _5students
    {
        public static void Main(string[] args)
        {
            try
            {
                student();
                static void student()
                {
                    double std1, std2, std3, std4, std5, highestmarks;

                    Console.WriteLine("Enter the marks of student1:");
                    std1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the marks of student2:");
                    std2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the marks of student3:");
                    std3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the marks of student4:");
                    std4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the marks of student5:");
                    std5 = Convert.ToDouble(Console.ReadLine());
                    double average = (std1+std2+std3+std4+std5)/5;
                    Console.WriteLine("The average marks of five students {0},{1},{2},{3},{4} is:{5}", std1, std2, std3, std4, std5, average);
                    if (std1>std2 &&std1>std3)
                        highestmarks = std1;
                    else if (std2>std1&&std2>std3)
                        highestmarks=std2;
                    else if (std3>std2 && std3>std4)
                        highestmarks =std3;
                    else if (std4>std3&&std4>std5)
                        highestmarks=std4;
                    else
                        highestmarks=std5;
                    Console.WriteLine("Highest marks among {0},{1},{2},{3},{4} is:{5}", std1, std2, std3, std4, std5, highestmarks);
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



