using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1011
{
    class Program
    {
        static void Main(String[] args)
        {
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double radiusPow = Math.Pow(radius, 3);
            double π = 3.14159;
            double result = (4.0 / 3.0) * π * (radiusPow);
            Console.WriteLine("VOLUME = " + result.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}