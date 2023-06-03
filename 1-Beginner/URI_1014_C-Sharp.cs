using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1014
{
    class Program
    {
        static void Main(String[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double mediaKm = x / y;
            Console.WriteLine(mediaKm.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}