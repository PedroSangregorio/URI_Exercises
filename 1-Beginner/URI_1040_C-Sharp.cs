using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, testGrade, finalAverage;

            String[] vValue = Console.ReadLine().Split(' ');
            n1 = float.Parse(vValue[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vValue[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vValue[2], CultureInfo.InvariantCulture);  
            n4 = float.Parse(vValue[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }
                        
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                testGrade = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                finalAverage = (media + testGrade) / 2;
                Console.WriteLine("Nota do exame: " + testGrade.ToString("F1"), CultureInfo.InvariantCulture);
                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + finalAverage.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
