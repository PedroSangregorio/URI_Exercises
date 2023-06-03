using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, hours, rest, minutes, seconds;

            n = int.Parse(Console.ReadLine());

            hours = n / 3600;
            rest = n % 3600;
            minutes = rest / 60;
            seconds = rest % 60;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
    }
}