using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, duration;
			
            String[] vValue = Console.ReadLine().Split(' ');
            start = int.Parse(vValue[0]);
            end = int.Parse(vValue[1]);

            if (start < end)
            {
                duration = end - start;
                Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
            }
            else
            {
                duration = 24 - start + end;
                Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
            }
        }
    }
}