using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            String[] vValue = Console.ReadLine().Split(' ');

            a = int.Parse(vValue[0]);
            b = int.Parse(vValue[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}