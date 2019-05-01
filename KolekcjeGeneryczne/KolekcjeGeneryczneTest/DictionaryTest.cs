using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolekcjeGeneryczneTest
{
    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void SlownikJakoMapyTest()
        {
            Dictionary<int, string> mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            Assert.AreEqual("jeden", mapa[1]);
        }
        [TestMethod]
        public void WyszukiwanieTest()
        {
            Dictionary<int, string> mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            Assert.IsTrue(mapa.ContainsKey(4));
        }
        [TestMethod]
        public void SlownikJakoDictionaryContainsTestTest()
        {
            Dictionary<int, string> mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            Assert.AreEqual("jeden", mapa[1]);
        }
        [TestMethod]
        public void RemoveAtKeyTest()
        {
            Dictionary<int, string> mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            mapa.Add(4, "cztery");
            mapa.Remove(3);
            Assert.AreEqual(3, mapa.Count);
        }
    }
}
