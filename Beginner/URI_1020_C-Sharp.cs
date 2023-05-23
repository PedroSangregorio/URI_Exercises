using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rest, year, month;

            n = int.Parse(Console.ReadLine());
            rest = n;

            year = rest / 365;
            Console.WriteLine(year + " ano(s)");
            rest %= 365;

            month = rest / 30;
            Console.WriteLine(month + " mes(es)");
            rest %= 30;

            Console.WriteLine(rest + " dia(s)");
        }
    }
}