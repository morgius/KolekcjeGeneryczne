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
            Console.ReadLine();
        }
    }
}
