using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quotient, rest, note;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            rest = n;

            note = 100;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");

            rest = rest % note;

            note = 50;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest %= note;

            note = 20;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest %= note;

            note = 10;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest %= note;

            note = 5;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest %= note;

            note = 2;
            quotient = rest / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            rest %= note;

            note = 1;
            Console.WriteLine(rest + " nota(s) de R$ " + note + ",00");
        }
    }
}