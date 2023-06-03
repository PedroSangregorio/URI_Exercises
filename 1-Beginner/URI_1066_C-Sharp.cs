using System;

//Developed by: @PedroSangregorio

namespace URI_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, pairs, odd, positives, negatives;

            pairs = 0;
            odd = 0;
            positives = 0;
            negatives = 0;

            number = int.Parse(Console.ReadLine());
			
            if (number % 2 == 0)
            {
                pairs++;
            }
            else
            {
                odd++;
            }
            if (number > 0)
            {
                positives++;
            }
            else if (number < 0)
            { 
                negatives++; 
            }

            number = int.Parse(Console.ReadLine());
			
            if (number % 2 == 0)
            {
                pairs++;
            }
            else
            {
                odd++;
            }
            if (number > 0)
            {
                positives++;
            }
            else if (number < 0)
            {
                negatives++;
            }

            number = int.Parse(Console.ReadLine());
			
            if (number % 2 == 0)
            {
                pairs++;
            }
            else
            {
                odd++;
            }
            if (number > 0)
            {
                positives++;
            }
            else if (number < 0)
            {
                negatives++;
            }

            number = int.Parse(Console.ReadLine());
			
            if (number % 2 == 0)
            {
                pairs++;
            }
            else
            {
                odd++;
            }
            if (number > 0)
            {
                positives++;
            }
            else if (number < 0)
            {
                negatives++;
            }

            number = int.Parse(Console.ReadLine());
			
            if (number % 2 == 0)
            {
                pairs++;
            }
            else
            {
                odd++;
            }
            if (number > 0)
            {
                positives++;
            }
            else if (number < 0)
            {
                negatives++;
            }

            Console.WriteLine(pairs + " valor(es) par(es)");
            Console.WriteLine(odd + " valor(es) impar(es)");
            Console.WriteLine(positives + " valor(es) positivo(s)");
            Console.WriteLine(negatives + " valor(es) negativo(s)");
        }
    }
}