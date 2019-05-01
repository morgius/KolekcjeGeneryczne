using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolekcjeGeneryczneTest
{
    [TestClass]
    public class StosTest
    {
        [TestMethod]
        public void UzyciePeekTesty()
        {
            Stack<double> stos = new Stack<double>();
            stos.Push(5.5);
            stos.Push(7.3);
            stos.Push(52);
            stos.Push(1);
            stos.Push(4);
            Assert.AreEqual(4, stos.Peek());
        }
        [TestMethod]
        public void UzycieToArrayTesty()
        {
            Stack<double> stos = new Stack<double>();
            stos.Push(5.5);
            stos.Push(7.3);
            stos.Push(52);
            stos.Push(1);
            stos.Push(4);
            var tab= stos.ToArray();
            Assert.AreEqual(4, tab[0]);
        }
    }
}
