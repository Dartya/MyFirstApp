using System;
using MyInt = System.Int32;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt i = 4;
            i++;
            Console.WriteLine("Попытались и сделали, "+i);
            Console.WriteLine("Stop");
        }
    }
}
