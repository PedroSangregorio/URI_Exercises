using System;

//Developed by: @PedroSangregorio

namespace URI_1007
{
    class Program
    {
        static void Main(String[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int difference = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + difference);
        }
    }
}