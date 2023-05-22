using System;

//Developed by: @PedroSangregorio

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, first, second, third;
            String[] value = Console.ReadLine().Split(' ');
            n1 = int.Parse(value[0]);
            n2 = int.Parse(value[1]);
            n3 = int.Parse(value[2]);

            if (n1 < n2 && n1 < n3)
            {
                first = n1;
                if (n2 < n3)
                {
                    second = n2;
                    third = n3;
                }
                else
                {
                    second = n3;
                    third = n2;
                }
            }
            else if (n2 < n1 && n2 < n3)
            {
                first = n2;
                if (n1 < n3)
                {
                    second = n1;
                    third = n3;
                }
                else
                {
                    second = n3;
                    third = n1;
                }
            }
            else 
            {
                first = n3;
                if (n1 < n2)
                {
                    second = n1;
                    third = n2;
                }
                else
                {
                    second = n2;
                    third = n1;
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
