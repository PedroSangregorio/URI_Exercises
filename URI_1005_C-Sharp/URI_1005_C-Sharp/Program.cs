using System;

namespace URI_1005
{
    class Program
    {
        static void Main(String[] args)
        {

            double a, b;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("MEDIA = " + ((a * 3.5 + b * 7.5) / (3.5 + 7.5)).ToString("0.00000"));
        }
    }
}