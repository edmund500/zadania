using System;

namespace Temperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.WriteLine("Jakiej konwersji chcesz dokonać: 1 - Celsjusz na Fahrenheit, 2 - Fahrenheit na Celsjusz, 3 - Wyjście z programu");
                    p = Convert.ToInt32(Console.ReadLine());
                    if (p == 1 || p == 2 || p == 3) ok = true;
                    else Console.WriteLine("\nMuszisz wybrać operację 1, 2 lub 3");
                }
                catch
                {
                    Console.WriteLine("\nPodano złą wartość");
                }
            }

            int stala = 32;
            double wspolczynnikC = 9d / 5d;
            double wspolczynnikF = 5d / 9d;

            switch (p)
            {
                case 1:
                    {
                        {
                            {
                                    bool ok2 = false;
                                    while (!ok2)
                                    try
                                    {
                                        Console.WriteLine("Podaj ilość stopni Celsjusza");
                                        double stopnieC = Convert.ToDouble(Console.ReadLine());
                                        if (stopnieC > 0 || stopnieC <= 0)
                                        {
                                            ok2 = true;
                                            double wynik = wspolczynnikC * stopnieC + stala;
                                            Console.WriteLine("\n{0} stopni Celsjusza to {1} stopni Fahrenheita", stopnieC, wynik);
                                            Console.ReadKey();
                                        }
                                    }
                                    catch
                                   {
                                   }
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        bool ok3 = false;
                        while(!ok3)
                        try
                        {
                            Console.WriteLine("Podaj ilość stopni Fahrenheita");
                            double stopnieF = Convert.ToDouble(Console.ReadLine());
                                if (stopnieF > 0 || stopnieF <= 0)
                                {
                                    ok3 = true;
                                    double wynik2 = wspolczynnikF * (stopnieF - stala);
                                    Console.WriteLine("\n{0} stopni Fahrenheita to {1} stopni Celsjusza", stopnieF, wynik2);
                                    Console.ReadKey();
                                }
                        }
                        catch
                        {
                        }
                    }
                    break;
                case 3: break;
            }
        }
    }
}