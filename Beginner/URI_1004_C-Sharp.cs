using System;

//Developed by: @PedroSangregorio

namespace URI_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, prod;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            prod = x * y;

            Console.WriteLine("PROD = " + prod);
        }
    }
}