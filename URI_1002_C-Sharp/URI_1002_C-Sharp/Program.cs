using System;
using System.Globalization;

namespace uri
{
    class Program
    {
        static void Main(String[] args)
        {
            double A, R, π = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = π * R * R;
            Console.WriteLine("A=" + A.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}