using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CounterTest1()
        {
            int[] numbers = new int[] { 1, 4, 2, 3, 4, 4,};
            int count = CountingNumbers.CountNumberinArray(4,numbers);
            Assert.AreEqual(3,count);
        }

        [TestMethod]
        public void CounterTest2()
        {
            int[] numbers = new int[] { 1, 4, 2, 3, 4, 4, };
            int count = CountingNumbers.CountNumberinArray(-4, numbers);
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CounterTest3()
        {
            int[] numbers = new int[] {};
            int count = CountingNumbers.CountNumberinArray(4, numbers);
            Assert.AreEqual(0, count);
        }

    }
}
