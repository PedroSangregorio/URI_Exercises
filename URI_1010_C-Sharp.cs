using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1010
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] vPurchase1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(vPurchase1[0]);
            int units1 = int.Parse(vPurchase1[1]);
            double price1 = double.Parse(vPurchase1[2], CultureInfo.InvariantCulture);

            string[] vPurchase2 = Console.ReadLine().Split(' ');
            int code2 = int.Parse(vPurchase2[0]);
            int units2 = int.Parse(vPurchase2[1]);
            double price2 = double.Parse(vPurchase2[2], CultureInfo.InvariantCulture);

            double value = (units1 * price1) + (units2 * price2);

       //   Console.WriteLine("VALOR A PAGAR: R$ " + value.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("VALOR A PAGAR: R$ {0}", value.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}