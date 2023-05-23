using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int quotient, note, coin, rest;
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rest = (int) (n * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            note = 100;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            note = 50;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            note = 20;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            note = 10;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            note = 5;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            note = 2;
            quotient = rest / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ".00");
            rest %= (note * 100);

            Console.WriteLine("MOEDAS:");

            coin = 100;
            quotient = rest / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 1.00");
            rest %= coin;

            coin = 50;
            quotient = rest / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0.50");
            rest %= coin;

            coin = 25;
            quotient = rest / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0.25");
            rest %= coin;

            coin = 10;
            quotient = rest / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0.10");
            rest %= coin;

            coin = 5;
            quotient = rest / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0.05");
            rest %= coin;

            Console.WriteLine(rest + " moeda(s) de R$ 0.01");
        }
    }
}