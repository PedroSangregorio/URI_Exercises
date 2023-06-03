using System;

//Developed by: @PedroSangregorio

namespace URI_1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddd;
            string destination;

            ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    destination = "Brasilia";
                    break;
                case 71:
                    destination = "Salvador";
                    break;
                case 11:
                    destination = "Sao Paulo";
                    break;
                case 21:
                    destination = "Rio de Janeiro";
                    break;
                case 32:
                    destination = "Juiz de Fora";
                    break;
                case 19:
                    destination = "Campinas";
                    break;
                case 27:
                    destination = "Vitoria";
                    break;
                case 31:
                    destination = "Belo Horizonte";
                    break;
                default:
                    destination = "DDD nao cadastrado";
                    break;
            }
			
            Console.WriteLine(destination);
        }
    }
}