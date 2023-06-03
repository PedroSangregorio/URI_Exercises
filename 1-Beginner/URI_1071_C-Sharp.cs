using System;

//Developed by: @PedroSangregorio

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
			int min, max, sum;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            if(x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            sum = 0;
            for(int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}