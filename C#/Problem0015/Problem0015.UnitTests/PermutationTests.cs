using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0015.UnitTests
{
    [TestClass]
    public class PermutationTests
    {

        [TestMethod]
        public void WhenSameAmountOfDifferentSymbols_ThenGetCorrectAmountOfPermutations()
        {
            var result = Permutation.CalculateAmountOfPermutations(new List<int> {2, 2});
            Assert.AreEqual(4*3*2*1/(2*1*2*1), result);
        }

        [TestMethod]
        public void WhenDifferentAmountsOfDifferentSymbols_ThenGetCorrectAmountOfPermutations()
        {
            var result = Permutation.CalculateAmountOfPermutations(new List<int> { 3, 2, 1 });
            Assert.AreEqual((6*5*4*3*2*1/(3*2*1*2*1*1)), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenNegativeInput_ThenCalculatingFactorialThrowsError()
        {
            Permutation.CalculateFactorial(-234);
        }
    }
}
