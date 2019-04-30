using System;

namespace _1.TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>(3);
            WprowadzenieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
            Console.ReadLine();
        }

        private static void  PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            double suma = 0.0;
            Console.WriteLine("W kolejce:");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzenieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                double wynik = 0.0;
                string wartoscWejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscWejsciowa, out wynik))
                {
                    kolejka.Zapisz(wynik);
                    continue;
                }
                break;
            }
        }
    }
}
