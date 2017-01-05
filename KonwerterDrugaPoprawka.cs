using System;

namespace Temperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor_uzytkownika = 0;
            while (wybor_uzytkownika != 3)
            {
                Console.WriteLine("Jakiej konwersji chcesz dokonać: 1 - Celsjusz na Fahrenheit, 2 - Fahrenheit na Celsjusz, 3 - Wyjście z programu.");
                while (true)
                {
                    try
                    {
                        wybor_uzytkownika = Convert.ToInt16(Console.ReadLine());
                        if (wybor_uzytkownika == 1 || wybor_uzytkownika == 2 || wybor_uzytkownika == 3)
                            break;
                        else
                            Console.WriteLine("\nMuszisz wybrać operację 1, 2 lub 3!");
                    }
                    catch
                    {
                        Console.WriteLine("\nWprowadzono złą wartość!!! Spróbuj jeszcze raz:\n1 - Celsjusz na Fahrenheit, 2 - Fahrenheit na Celsjusz, 3 - Wyjście z programu.");
                    }

                }
                int stala = 32;
                double wspolczynnikC = 9d / 5d;
                double wspolczynnikF = 5d / 9d;

                switch (wybor_uzytkownika)
                {
                    case 1:
                    {
                        Console.WriteLine("Podaj ilość stopni Celsjusza.");
                        while (true)
                            try
                            {
                                double stopnieC = Convert.ToDouble(Console.ReadLine());
                                double wynik = wspolczynnikC * stopnieC + stala;
                                Console.WriteLine("\n{0} stopni Celsjusza to {1} stopni Fahrenheita.\n\n", stopnieC, wynik);
                                Console.WriteLine("Aby kontynować naciśnij dowolny klawisz.");
                                Console.ReadKey();
                                Console.WriteLine("\n");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nWprowadzono złą wartość! Podaj ilość stopni Celsjusza jeszcze raz.");
                            }
                    }
                    break;

                    case 2:
                    {
                        Console.WriteLine("Podaj ilość stopni Fahrenheita.");
                        while (true)
                            try
                            {
                                double stopnieF = Convert.ToDouble(Console.ReadLine());
                                double wynik2 = wspolczynnikF * (stopnieF - stala);
                                Console.WriteLine("\n{0} stopni Fahrenheita to {1} stopni Celsjusza.\n\n", stopnieF, wynik2);
                                Console.WriteLine("Aby kontynować naciśnij dowolny klawisz.");
                                Console.ReadKey();
                                Console.WriteLine("\n");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nWprowadzono złą wartość! Podaj ilość stopnij Fahrenheita jeszcze raz.");
                            }
                    }
                    break;

                    case 3:
                    break;
                }
            }
        }
    }
}