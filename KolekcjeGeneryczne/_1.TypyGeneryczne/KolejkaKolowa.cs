﻿namespace _1.TypyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        private T [] bufor;
        private int poczatekBufora;
        private int koniecBufora;
        public int Pojemnosc { get { return bufor.Length; } }
        public bool JestPusty { get { return koniecBufora==poczatekBufora; } }
        public bool JestPelny { get { return (koniecBufora +1) % bufor.Length == poczatekBufora; } }


        public KolejkaKolowa():this(5)
        {
        }
        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T [pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }
        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora==poczatekBufora)
            {
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            }
        }
        public T Czytaj()
        {
            T wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }
    }
}
