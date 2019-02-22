using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerSolutions.Common.UnitTests
{
    [TestClass]
    public class DivisorClassificationOfNumbersTests
    {
        private DivisorClassificationOfNumber _divisorClassificationOfNumber;

        [TestInitialize]
        public void Initialize()
        {
            _divisorClassificationOfNumber = new DivisorClassificationOfNumber();
        }

        [TestMethod]
        public void WhenNotPerfectNumber_ThenIsPerfectReturnsFalse()
        {
            var result = _divisorClassificationOfNumber.IsPerfect(5);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void WhenPerfectNumber_ThenIsPerfectReturnsTrue()
        {
            var result = _divisorClassificationOfNumber.IsPerfect(6);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WhenNotAbundantNumber_ThenIsAbundantReturnsFalse()
        {
            var result = _divisorClassificationOfNumber.IsAbundant(5);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void WhenAbundantNumber_ThenIsAbundantReturnsTrue()
        {
            var result = _divisorClassificationOfNumber.IsAbundant(12);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WhenNotDeficientNumber_ThenIsDeficientReturnsFalse()
        {
            var result = _divisorClassificationOfNumber.IsDeficient(12);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void WhenDeficientNumber_ThenIsDeficientReturnsTrue()
        {
            var result = _divisorClassificationOfNumber.IsDeficient(3);
            Assert.AreEqual(true, result);
        }
    }
}
