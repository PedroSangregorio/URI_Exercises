using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1008
{
    class Program
    {
        static void Main(String[] args)
        {            
            int number, hours;
            double valueHour;

            number = int.Parse(Console.ReadLine());
            hours  = int.Parse(Console.ReadLine());
            valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double wage = hours * valueHour;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + wage.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}