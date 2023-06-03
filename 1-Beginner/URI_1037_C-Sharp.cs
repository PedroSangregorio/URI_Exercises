using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double interval = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (interval > 75.00 && interval <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if (interval > 50.00 && interval <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (interval > 25.00 && interval <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (interval >= 0.00 && interval <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}