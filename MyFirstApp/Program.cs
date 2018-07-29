using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = 1;
                double b = 3.5;
                double x;
                Console.WriteLine("Введите значение х:");
                string res = Console.ReadLine();
                if (double.TryParse(res, out x))
                {
                    if ((x >= a) && (x <= b))
                    {
                        Console.WriteLine("х = " + x + " внутри отрезка");
                    }
                    else
                    {
                        Console.WriteLine("х = " + x + " не входит в отрезок");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            finally
            {
                Console.Write("Press <Enter>");
                Console.ReadLine();
            }
        }
    }
}