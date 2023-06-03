using System;

//Developed by: @PedroSangregorio

namespace URI_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= 10; i++)
            {
                int x = i * n;

                Console.WriteLine(i + " x " + n + " = " + x);
            }
        }
    }
}