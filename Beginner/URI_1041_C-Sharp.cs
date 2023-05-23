using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            String[] vValues = Console.ReadLine().Split(' ');
            x = double.Parse(vValues[0], CultureInfo.InvariantCulture);
            y = double.Parse(vValues[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}