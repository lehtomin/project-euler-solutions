using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0012.UnitTests
{
    [TestClass]
    public class TriangularNumberTests
    {
        [TestMethod]
        public void TestGetCorrectTriangularNumbers()
        {
            var result = TriangularNumber.GetTriangularNumbers(1, 7);
            Assert.AreEqual(7, result.Count);
            Assert.IsTrue(result.Contains(1));
            Assert.IsTrue(result.Contains(3));
            Assert.IsTrue(result.Contains(6));
            Assert.IsTrue(result.Contains(10));
            Assert.IsTrue(result.Contains(15));
            Assert.IsTrue(result.Contains(21));
            Assert.IsTrue(result.Contains(28));
        }

        [TestMethod]
        public void TestGetFirstTriangularNumberWithCertainAmountOfDivisors()
        {
            var result = TriangularNumber.GetTriangularNumberWithCertainAmountOfDivisors(6);
            Assert.AreEqual(6, result.Divisors.Count);
            Assert.AreEqual(28, result.TriangularNumber);
        }
    }
}
