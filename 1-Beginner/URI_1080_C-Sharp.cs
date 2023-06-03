using System;

//Developed by: @PedroSangregorio

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigger = int.Parse(Console.ReadLine());
            int position = 1;

            for(int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
				
                if(x > bigger)
                {
                    bigger = x;
                    position = i;
                }
            }
			
            Console.WriteLine(bigger);
            Console.WriteLine(position);
        }
    }
}