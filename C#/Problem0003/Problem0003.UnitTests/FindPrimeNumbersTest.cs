using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0003.UnitTests
{
    [TestClass]
    public class FindPrimeNumbersTest
    {
        [TestMethod]
        public void TestZeroIsNotAPrimeNumber()
        {
            var result = PrimeFactorization.IsPrimeNumber(0);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestTwoIsAPrimeNumber()
        {
            var result = PrimeFactorization.IsPrimeNumber(2);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void EvenNumberGreaterThanTwoIsNotPrimeNumber()
        {
            var result = PrimeFactorization.IsPrimeNumber(6);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MultipleOfPrimeNumberIsNotPrimeNumber()
        {
            var result = PrimeFactorization.IsPrimeNumber(7*3);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void NegativeNumberIsNotPrimeNumber()
        {
            var result = PrimeFactorization.IsPrimeNumber(-5);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsEven()
        {
            var odd = PrimeFactorization.IsEven(5);
            var even = PrimeFactorization.IsEven(14);
            var zero = PrimeFactorization.IsEven(0);
            var negative = PrimeFactorization.IsEven(-2);
            Assert.AreEqual(false, odd);
            Assert.AreEqual(true, even);
            Assert.AreEqual(true, zero);
            Assert.AreEqual(false, negative);
        }
    }
}
