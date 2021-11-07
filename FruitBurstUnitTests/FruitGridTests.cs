using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitGridTests
    {
        [TestMethod]
        public void TestInitializationHeight()
        {
            FruitGrid grid = new FruitGrid(20, 19);
            int expected = 20;
            Assert.AreEqual(expected, grid.Height);
        }

        [TestMethod]
        public void TestInitializationWidth()
        {
            FruitGrid grid = new FruitGrid(20, 19);
            int expected = 19;
            Assert.AreEqual(expected, grid.Width);
        }

        [TestMethod]
        public void TestPopulateGrid_DoesNotEqualNull_AndGetVisibility()
        {
            FruitGrid grid = new FruitGrid(20, 20);
            bool result = grid.GetVisibility(5,5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetVisibility_OutOfRange() 
        {
            FruitGrid grid = new FruitGrid(5, 5);
            bool result = grid.GetVisibility(6,6);
        }
    }
}