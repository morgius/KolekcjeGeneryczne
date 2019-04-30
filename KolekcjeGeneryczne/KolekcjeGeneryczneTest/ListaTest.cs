using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolekcjeGeneryczneTest
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Add(4);
            Assert.AreEqual(4, listaLiczb[3]);
        }
        [TestMethod]
        public void ListaMozemyDodacNapozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Insert(0, 8);
            Assert.AreEqual(8, listaLiczb[0]);
        }
        [TestMethod]
        public void ListaMozemyWyszukiwacIndeks()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            Assert.AreEqual(listaLiczb.IndexOf(3), 2);
        }
        [TestMethod]
        public void ListaMozemyWyszukiwacCzyZawiera()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            Assert.IsTrue(listaLiczb.Contains(3));
        }
        [TestMethod]
        public void ListMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.AddRange(new int[] { 4, 5, 6, 7 });
            Assert.AreEqual(7, listaLiczb[6]);
        }
    }
}
