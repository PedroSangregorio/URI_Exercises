using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, number, average;
            int count;
            
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            count = 0;
            number = 0.0;

            if (a > 0.0)
            {
                count += 1;
                number += a;
                
            }
            if (b > 0.0)
            {
                count += 1;
                number += b;

            }
            if (c > 0.0)
            {
                count += 1;
                number += c;

            }
            if (d > 0.0)
            {
                count += 1;
                number += d;
            }
            if (e > 0.0)
            {
                count += 1;
                number += e;

            }
            if (f > 0.0)
            {
                count += 1;
                number += f;
            }
            
            average = number / count;

            Console.WriteLine(count + " valores positivos");
           
            Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}