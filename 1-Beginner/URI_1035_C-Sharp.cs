using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            String[] input = Console.ReadLine().Split(' ');
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);
            d = int.Parse(input[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}