using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolekcjeGeneryczneTest
{
    [TestClass]
    public class KolejkaTest
    {
        [TestMethod]
        public void UzyciePeekTesty()
        {
            Queue<double> kolejka = new Queue<double>();
            kolejka.Enqueue(5.5);
            kolejka.Enqueue(7.3);
            kolejka.Enqueue(52);
            kolejka.Enqueue(1);
            kolejka.Enqueue(4);
            Assert.AreEqual(5.5, kolejka.Peek());
        }
        [TestMethod]
        public void UzycieContainsTest()
        {
            Queue<double> kolejka = new Queue<double>();
            kolejka.Enqueue(5.5);
            kolejka.Enqueue(7.3);
            kolejka.Enqueue(52);
            kolejka.Enqueue(1);
            kolejka.Enqueue(4);
            Assert.IsTrue(kolejka.Contains(52));
        }
        [TestMethod]
        public void ToArrayTest()
        {
            Queue<double> kolejka = new Queue<double>();
            kolejka.Enqueue(5.5);
            kolejka.Enqueue(7.3);
            kolejka.Enqueue(52);
            kolejka.Enqueue(1);
            kolejka.Enqueue(4);
            double[] tab = new double[kolejka.Count];
            tab = kolejka.ToArray();
            kolejka.Dequeue();
            Assert.AreEqual(kolejka.Peek(), tab[1]);
            Assert.AreEqual(4, kolejka.Count);
        }
        [TestMethod]
        public void ClearTest()
        {
            Queue<double> kolejka = new Queue<double>();
            kolejka.Enqueue(5.5);
            kolejka.Enqueue(7.3);
            kolejka.Enqueue(52);
            kolejka.Enqueue(1);
            kolejka.Enqueue(4);
            kolejka.Clear();
            Assert.AreEqual(0, kolejka.Count);
        }
    }
}
