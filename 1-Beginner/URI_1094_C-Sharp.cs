using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amount = 0;
            int c = 0;
            int r = 0;
            int s = 0;
            int tests = 0;
            char type;
            double percentC, percentR, percentS;
            
            for(int i = 1; i <= n; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                tests = int.Parse(s1[0]);
                type = char.Parse(s1[1]);

                amount += tests;
                
                if (type == 'C')
                {
                    c += tests;
                }
                else if (type == 'R')
                {
                    r += tests;
                }
                else
                {
                    s += tests;
                }
            }

            percentC = (double)c / amount * 100.00;
            percentR = (double)r / amount * 100.00;
            percentS = (double)s / amount * 100.00;

            Console.WriteLine("Total: " + amount + " cobaias");
            Console.WriteLine("Total de coelhos: " + c);
            Console.WriteLine("Total de ratos: " + r);
            Console.WriteLine("Total de sapos: " + s);
            Console.WriteLine("Percentual de coelhos: " + percentC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentS.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}