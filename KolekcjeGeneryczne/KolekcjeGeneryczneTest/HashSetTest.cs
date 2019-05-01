using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolekcjeGeneryczneTest
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectWithTest()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> {2,3,4};
            set1.IntersectWith(set2);
            Assert.IsTrue(set1.SetEquals(new int[] { 2, 3 }));
        }
        [TestMethod]
        public void UnionWithTest()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new int[] { 1,2,3,4 }));
        }
        [TestMethod]
        public void SymmetricExceptWithTest()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new int[] { 1, 4 }));
        }
        [TestMethod]
        public void RemoveWhereTest()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
            set1.RemoveWhere((a)=>a>1);
            Assert.IsTrue(set1.SetEquals(new int[] {1}));
        }
    }
}
