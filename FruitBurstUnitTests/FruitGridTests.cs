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
        public void TestPopulateGrid_DoesNotEqualNull()
        {
            FruitGrid grid = new FruitGrid(20, 20);
            bool result = grid.GetVisibility(5,5);
            Assert.IsFalse(result);
        }
    }
}