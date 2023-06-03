using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double value1, value2, value3, media;

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                value1 = double.Parse(s[0], CultureInfo.InvariantCulture);
                value2 = double.Parse(s[1], CultureInfo.InvariantCulture);
                value3 = double.Parse(s[2], CultureInfo.InvariantCulture);

                media = (value1 * 2.0 + value2 * 3.0 + value3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}