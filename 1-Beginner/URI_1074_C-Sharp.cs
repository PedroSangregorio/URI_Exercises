using System;

//Developed by: @PedroSangregorio

namespace URI_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int vValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < vValue; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 == 0 && x > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}