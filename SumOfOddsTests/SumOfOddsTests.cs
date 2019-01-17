using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Right click a class and then click create unit test to create this test file

namespace SumOfOdds.Tests
{
    [TestClass()]
    public class SumOfOddsTests
    {
        // [TestMethod()] must be included before all test methods
        [TestMethod()]
        public void sumOddsTest5()
        {
            Assert.AreEqual(9,SumOfOdds.sumOdds(5));
        }

        [TestMethod()]
        public void sumOddsTest4()
        {
            Assert.AreEqual(4, SumOfOdds.sumOdds(4));
        }

        [TestMethod()]
        public void sumOddsTest9()
        {
            Assert.AreEqual(25, SumOfOdds.sumOdds(9));
        }
    }
}