using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1006
{
    class Program
    {
        static void Main(String[] args)
        {
            double a, b, c, average;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            average = (a * 2 + b * 3 + c * 5) / 10;

            Console.WriteLine("MEDIA = " + average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}