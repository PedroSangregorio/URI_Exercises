using System;

//Developed by: @PedroSangregorio

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z, w1, x1, y1, z1, w2, x2, y2, z2, start, end, duration, rest;

            String[] vValues = Console.ReadLine().Split(' ');
            w1 = int.Parse(vValues[1]);

            vValues = Console.ReadLine().Split(' ');
            x1 = int.Parse(vValues[0]);
            y1 = int.Parse(vValues[2]);
            z1 = int.Parse(vValues[4]);

            vValues = Console.ReadLine().Split(' ');
            w2 = int.Parse(vValues[1]);

            vValues = Console.ReadLine().Split(' ');
            x2 = int.Parse(vValues[0]);
            y2 = int.Parse(vValues[2]);
            z2 = int.Parse(vValues[4]);

            start = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
            end = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

            duration = end - start;

            w = duration / (24 * 60 * 60);
            rest = duration % (24 * 60 * 60);
            x = rest / (60 * 60);
            rest = rest % (60 * 60);
            y = rest / 60;
            z = rest % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");
        }
    }
}