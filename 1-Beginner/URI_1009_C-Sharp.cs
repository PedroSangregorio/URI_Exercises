using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1009
{
    class Program
    {
        static void Main(String[] args)
        {
            string nome;
            double salary, sale, percent = 15.00 / 100.00;

            nome = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sale = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryAndCommission = salary + (percent * sale);

            Console.WriteLine("TOTAL = R$ " + salaryAndCommission.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}