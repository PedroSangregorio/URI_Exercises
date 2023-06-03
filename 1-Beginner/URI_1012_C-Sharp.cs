using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangle, circle, trapeze, square, rectangle;

            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);

            triangle = a * c / 2.0;
            circle = 3.14159 * c * c;
            trapeze = (a + b) / 2.0 * c;
            square = b * b;
            rectangle = a * b;

            Console.WriteLine("TRIANGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}