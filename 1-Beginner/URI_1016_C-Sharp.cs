using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1016
{
    class Program
    {
        static void Main(String[] args)
        {
            int distance, time;
            distance = int.Parse(Console.ReadLine());
            time = distance * 2;
            Console.WriteLine(time + " minutos");
        }
    }
}