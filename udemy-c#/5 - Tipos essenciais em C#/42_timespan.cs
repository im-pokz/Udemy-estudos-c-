// TIMESPAN

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(9000000L); // ticks
            TimeSpan t3 = new TimeSpan(2, 11, 21); // horas, minutos, segundos
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // dias, horas, minutos, segundos
            TimeSpan t5 = new TimeSpan(2, 2, 11, 21, 321); // dias, horas, minutos, segundos, milisegundos
            TimeSpan t6 = TimeSpan.FromDays(1.5); // converte para o predicado informado
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(9000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
        }
    }
}