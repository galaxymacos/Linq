using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TestEqualityOperator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var a = new[] {1, 2, 3};
            var b = new List<int> {1, 2, 3};
            Assert.IsTrue(a.SequenceEqual(b));
            Assert.That(a,Is.EqualTo(b));
            var c = new List<int> {3, 2, 1};
//            Assert.That(a,Is.EqualTo(c));
            Assert.That(a,Is.EquivalentTo(c));
        }
    }
}