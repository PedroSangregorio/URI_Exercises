using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distance;

            string[] vValues = Console.ReadLine().Split(' ');
            x1 = double.Parse(vValues[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vValues[1], CultureInfo.InvariantCulture);

            vValues = Console.ReadLine().Split(' ');
            x2 = double.Parse(vValues[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vValues[1], CultureInfo.InvariantCulture);
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}