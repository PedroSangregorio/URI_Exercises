using System;
using System.Globalization;

namespace URI_1002
{
    class Program
    {
        static void Main(String[] args)
        {
            double a, r, π = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = π * r * r;
            Console.WriteLine("A=" + a.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}