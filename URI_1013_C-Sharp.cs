using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, biggerAB, bigger;

            string[] vValue = Console.ReadLine().Split(' ');
            a = int.Parse(vValue[0]);
            b = int.Parse(vValue[1]);
            c = int.Parse(vValue[2]);

            bigger = (a + b + Math.Abs(a - b)) / 2;
            biggerAB = (bigger + c + Math.Abs(bigger - c)) / 2;

            Console.WriteLine(biggerAB + " eh o maior");
        }
    }
}