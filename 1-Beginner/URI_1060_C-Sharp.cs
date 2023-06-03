using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1060
{
    class Program
    {
        static void Main(String[] args)
        {
            double a, b, c, d, e, f;
            int count = 0;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0.0)
            {
                count += 1;
            }
            if (b > 0.0)
            {
                count += 1;
            }
            if (c > 0.0)
            {
                count += 1;
            }
            if (d > 0.0)
            {
                count += 1;
            }
            if (e > 0.0)
            {
                count += 1;
            }
            if (f > 0.0)
            {
                count += 1;
            }
            Console.WriteLine(count + " valores positivos");
        }
    }
}