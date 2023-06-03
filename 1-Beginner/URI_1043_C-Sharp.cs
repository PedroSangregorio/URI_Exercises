using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, perimeter, area;

            String[] vValue = Console.ReadLine().Split(' ');

            a = double.Parse(vValue[0], CultureInfo.InvariantCulture);
            b = double.Parse(vValue[1], CultureInfo.InvariantCulture);
            c = double.Parse(vValue[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimeter = a + b + c;
                Console.WriteLine("Perimetro = " + perimeter.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}