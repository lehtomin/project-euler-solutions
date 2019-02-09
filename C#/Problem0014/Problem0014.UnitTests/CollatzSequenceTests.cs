using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0014.UnitTests
{
    [TestClass]
    public class CollatzSequenceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenStartingValueSmallerOrEqualToZero_WhenGettingCollatzSequence_ThenThrowError()
        {
            CalculateCollatzSequence.GetCollatzSequence(0);
        }

        [TestMethod]
        public void WhenStartingValueBiggerThanZero_WhenGettingCollatzSequence_ThenWeGetCorrectCollatzSequence()
        {
            var sequence = CalculateCollatzSequence.GetCollatzSequence(13);
            Assert.AreEqual(10, sequence.Count);
            Assert.AreEqual(13, sequence[0]);
            Assert.AreEqual(40, sequence[1]);
            Assert.AreEqual(20, sequence[2]);
            Assert.AreEqual(10, sequence[3]);
            Assert.AreEqual(5, sequence[4]);
            Assert.AreEqual(16, sequence[5]);
            Assert.AreEqual(8, sequence[6]);
            Assert.AreEqual(4, sequence[7]);
            Assert.AreEqual(2, sequence[8]);
            Assert.AreEqual(1, sequence[9]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivennMaxStartingValueSmallerOrEqualToZero_WhenGettingLongestCollatzSequence_ThenThrowError()
        {
            CalculateCollatzSequence.GetLongestCollatzSequence(0);
        }

        [TestMethod]
        public void GivennMaxStartingValueBiggerThanZero_WhenGettingLongestCollatzSequence_ThenGetCorrectResult()
        {
            var collatzSequence = CalculateCollatzSequence.GetLongestCollatzSequence(5);
            Assert.AreEqual(8, collatzSequence.Sequence.Count);
            Assert.AreEqual(3, collatzSequence.StartingValue);
        }
    }
}
