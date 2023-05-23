using System;
using System.Globalization;

//Developed by: @PedroSangregorio

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour, startMinute, endHour, endMinute, startInstant, endInstant, duration, hourDuration, minuteDuration;

            String[] vValue = Console.ReadLine().Split(' ');
            startHour = int.Parse(vValue[0]);
            startMinute = int.Parse(vValue[1]);
            endHour = int.Parse(vValue[2]);
            endMinute = int.Parse(vValue[3]);
            startInstant = (startHour * 60) + startMinute;
            endInstant = (endHour * 60) + endMinute;
            
            if (startInstant < endInstant)
            {
                duration = endInstant - startInstant;
            }
            else
            {
                duration = (24 * 60 - startInstant) + endInstant;
            }
            
            hourDuration = duration / 60;
            minuteDuration = duration % 60;

            Console.WriteLine("O JOGO DUROU " + hourDuration + " HORA(S) E " + minuteDuration + " MINUTO(S)");
        }
    }
}