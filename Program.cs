using System;

namespace aula_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5); // uma hora e meia
            TimeSpan t3 = TimeSpan.FromMinutes(1.5); // cria um timespan de um minuto e meio
            TimeSpan t4 = TimeSpan.FromSeconds(1.5); // um segundo e meio
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5); // um milisegundo e meio
            TimeSpan t6 = TimeSpan.FromTicks(900000000L); // Cada Tick equivale a 100 nanosegundos esse numero 900000000 equivale ao numero de ticks

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);




        }
    }
}
