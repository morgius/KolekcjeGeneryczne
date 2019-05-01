using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Stos();
            //HashSet();
            //Slownik();
            //SortowanySlownik();
            Console.ReadLine();
        }

        private static void SortowanySlownik()
        {
            SortedDictionary<string, List<Pracownik>> pracownicy = new SortedDictionary<string, List<Pracownik>>();
            pracownicy.Add("Sprzedaz", new List<Pracownik> {
                new Pracownik { Nazwisko = "Pryk",Imie ="Ania"},
                new Pracownik { Nazwisko = "Puk", Imie ="Kaja" },
                new Pracownik { Nazwisko = "Purk",Imie = "Kola" }});
            pracownicy.Add("Informatyka", new List<Pracownik> {
                new Pracownik { Nazwisko = "Zyr",Imie ="Ala"},
                new Pracownik { Nazwisko = "Zul", Imie ="Ola" },
                new Pracownik { Nazwisko = "Zap",Imie = "Ula" }});
            pracownicy.Add("Ksiegowosc", new List<Pracownik> {
                new Pracownik { Nazwisko = "Hup",Imie ="Jan"},
                new Pracownik { Nazwisko = "Huc", Imie ="Faj" },
                new Pracownik { Nazwisko = "Hop",Imie = "Danuta" }});
            foreach (var listaPracowikow in pracownicy)
            {
                Console.WriteLine($"{listaPracowikow.Key}, ilosc pracownikow: {listaPracowikow.Value.Count}");
            }
        }

        private static void Slownik()
        {
            Dictionary<string, List<Pracownik>> pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik> { new Pracownik { Nazwisko = "Kowal" } });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kowal" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Matol" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Siara" });
            pracownicy.Add("Informatyka", new List<Pracownik> {
                new Pracownik { Nazwisko = "Pryk" },
                new Pracownik { Nazwisko = "Salata" },
                new Pracownik { Nazwisko = "Jelop" }});
            foreach (KeyValuePair<string, List<Pracownik>> listaPracownikow in pracownicy)
            {
                foreach (Pracownik pracownik in listaPracownikow.Value)
                {
                    Console.WriteLine($"{pracownik.Nazwisko}, dział {listaPracownikow.Key}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Informatycy:");
            foreach (Pracownik pracownik in pracownicy["Informatyka"])
            {
                Console.WriteLine(pracownik.Nazwisko);
            }
        }

        private static void HashSet()
        {
            Console.WriteLine("HashSet\n");
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            //set.Add(new Pracownik { Imie = "Paweł" });
            //set.Add(new Pracownik { Imie = "Paweł" });
            Pracownik pracownik = new Pracownik { Imie = "Paweł" };
            set.Add(pracownik);
            set.Add(pracownik);
            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Paweł", Nazwisko = "Podsiadlo" });
            stos.Push(new Pracownik { Imie = "Kasia", Nazwisko = "Puk" });
            stos.Push(new Pracownik { Imie = "Ania", Nazwisko = "Doom" });
            stos.Push(new Pracownik { Imie = "Maja", Nazwisko = "Tide" });

            while (stos.Count > 0)
            {
                Pracownik pracownik = stos.Pop();
                Console.WriteLine($"{pracownik.Nazwisko}, {pracownik.Imie}");
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Paweł", Nazwisko = "Podsiadlo" });
            kolejka.Enqueue(new Pracownik { Imie = "Kasia", Nazwisko = "Puk" });
            kolejka.Enqueue(new Pracownik { Imie = "Ania", Nazwisko = "Doom" });
            kolejka.Enqueue(new Pracownik { Imie = "Maja", Nazwisko = "Tide" });

            while (kolejka.Count > 0)
            {
                Pracownik pracownik = kolejka.Dequeue();
                Console.WriteLine($"{pracownik.Nazwisko}, {pracownik.Imie}");
            }
            Console.WriteLine("-----");
        }
    }
}
