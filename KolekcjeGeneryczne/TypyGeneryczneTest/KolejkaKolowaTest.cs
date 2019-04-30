using System;
using _1.TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypyGeneryczneTest
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPustaTest()
        {
            KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>();
            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void NowaKolejkaTrzyelemetowaJestPelnaPoTrzechZapisach()
        {
            KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>(3);
            kolejka.Zapisz(1);
            kolejka.Zapisz(112);
            kolejka.Zapisz(1.34);
            Assert.IsTrue(kolejka.JestPelny);
        }
        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>(3);
            double wartoscJeden = 4.7;
            double wartoscDwa = 2.3;
            kolejka.Zapisz(wartoscJeden);
            kolejka.Zapisz(wartoscDwa);
            Assert.AreEqual(wartoscJeden, kolejka.Czytaj());
            Assert.AreEqual(wartoscDwa, kolejka.Czytaj());
            Assert.IsFalse(!kolejka.JestPusty);
        }
        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>(3);
            double[] wartosci = new double[] { 1.2, 45, 123.55, 7, 86, 43 };
            foreach (double wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}
