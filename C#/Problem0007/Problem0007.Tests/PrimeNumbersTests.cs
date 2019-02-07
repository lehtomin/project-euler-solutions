using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program0007;

namespace Problem0007.Tests
{
    [TestClass]
    public class PrimeNumbersTests
    {
        [TestMethod]
        public void TestGenerateCorrectAmountOfPrimeNumbers()
        {
            var primes = PrimeNumbers.GeneratePrimeNumbers(10).ToList();
            Assert.AreEqual(10, primes.Count);
        }
    }
}

