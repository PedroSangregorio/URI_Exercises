using System;

//Developed by: @PedroSangregorio

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2, word3;
            word1 = Console.ReadLine();
            word2 = Console.ReadLine();
            word3 = Console.ReadLine();

            if (word1 == "vertebrado")
            {
                if (word2 == "ave")
                {
                    if (word3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (word2 == "inseto")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}