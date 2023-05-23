using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1048
{
    class Progam
    {
        static void Main(string[] args)
        {
            double salary, percent, newSalary, moneyEarned;

            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 400.00)
            {
                percent = 15.0;
            }
            else if (salary <= 800.00)
            {
                percent = 12.0;
            }
            else if (salary <= 1200.00)
            {
                percent = 10.0;
            }
            else if (salary <= 2000.00)
            {
                percent = 7.0;
            }
            else
            {
                percent = 4.0;
            }

            moneyEarned = salary * percent / 100.0;
            newSalary = salary + moneyEarned;
        
            Console.WriteLine("Novo salario: " + newSalary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percent.ToString("F0")+ " %");
        }
    }
}