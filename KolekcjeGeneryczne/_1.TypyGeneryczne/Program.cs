using System;

namespace _1.TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaKolowa kolejka = new KolejkaKolowa(3);
            while (true)
            {
                double wynik = 0.0;
                string wartoscWejsciowa = Console.ReadLine();
                if(double.TryParse(wartoscWejsciowa,out wynik))
                {
                    kolejka.Zapisz(wynik);
                    continue;
                }
                break;
            }
            Console.WriteLine("W kolejce:");
            while (!kolejka.JestPusty)
            {
                Console.WriteLine(kolejka.Czytaj());
            }
            Console.ReadLine();
        }
    }
}
