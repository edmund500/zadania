using System;

namespace temperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Jakiej konwersji chcesz dokonać?: 1 - Celsjusz na Fahrenheit, 2 Fahrenheit na Celsjusz");
            Console.WriteLine("Podaj ilość stopni Celsjusza");
            double stopnieC = Convert.ToDouble(Console.ReadLine());
            double wynik = 9d/5d * stopnieC + 32;
            Console.WriteLine(stopnieC + " stopni Celsjusza to " + wynik + " stopni Fahrenheita\n");

            Console.WriteLine("Podaj ilość stopni Fahrenheita");
            double stopnieF = Convert.ToDouble(Console.ReadLine());
            double wynik2 = 5d / 9d * (stopnieF - 32);
            Console.WriteLine(stopnieF + " stopni Fahrenheita to " + wynik2 + " stopni Celsjusza");
            Console.ReadKey();
        }
    }
}