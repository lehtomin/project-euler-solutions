using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Problem0006.UnitTests
{
    [TestClass]
    public class SumSquareDifferenceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenUpperLimitIsBiggerThanLowerLimit_ThenCalculateSumSquareDifferenceThrowsException()
        {
            SumSquareDifference.CalculateSumSquareDifference(5, -2);
        }

        [TestMethod]
        public void WhenCalculatingSumSquareDifference_ThenReturnCorrectResult()
        {
            var difference = SumSquareDifference.CalculateSumSquareDifference(1, 10);
            Assert.AreEqual(2640, difference);
        }

        [TestMethod]
        public void WhenUpperAndLowerLimitAreTheSame_ThenReturnCorrectResult()
        {
            var difference = SumSquareDifference.CalculateSumSquareDifference(5, 5);
            Assert.AreEqual(0, difference);
        }
    }
}
