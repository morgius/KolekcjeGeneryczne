using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Zapisz(10);
            Zapisz(11);
            Zapisz(12);
            Zapisz(13);
            Zapisz(14);
            Zapisz(15);
            Zapisz(16);
            Console.ReadLine();

        }
        public static void Zapisz(double wartosc)
        {
             double[] bufor=new double[3];
             int poczatekBufora=0;
             int koniecBufora=0;
             bufor[koniecBufora] = wartosc;
             koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == poczatekBufora)
            {
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            }
        }
    }

}
