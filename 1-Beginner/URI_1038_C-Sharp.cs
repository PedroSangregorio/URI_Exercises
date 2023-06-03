using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, quantity;
            double total;

            String[] vValue  = Console.ReadLine().Split(' ');
            code = int.Parse(vValue[0]);
            quantity = int.Parse(vValue[1]);

            if (code == 1)
            {
                total = 4.0 * quantity;
            }
            else if(code == 2)
            {
                total = 4.5 * quantity;
            }
            else if (code == 3)
            {
                total = 5.0 * quantity;
            }
            else if (code == 4)
            {
                total = 2.0 * quantity;
            }
            else 
            {
                total = 1.5 * quantity;
            }         
          
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}