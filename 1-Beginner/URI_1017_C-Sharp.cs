using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, speed, distance;
            double liters;

            time = int.Parse(Console.ReadLine());
            speed = int.Parse(Console.ReadLine());

            distance = time * speed;
            liters = distance / 12.0;

            Console.WriteLine(liters.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}