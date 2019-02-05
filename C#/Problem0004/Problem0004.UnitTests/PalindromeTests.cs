using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0004.UnitTests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void WhenValueNotPalindrome_ThenReturnFalse()
        {
            var result = Palindrome.IsPalindrome(1231);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void WhenValuePalindrome_ThenReturnTrue()
        {
            var result = Palindrome.IsPalindrome(201212102);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void WhenValueNegative_ThenReturnFalse()
        {
            var result = Palindrome.IsPalindrome(-666);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void WhenLengthOnlyOneCharacter_ThenReturnFalse()
        {
            var result = Palindrome.IsPalindrome(7);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestFindLargestPalindromeProductOfTwoDigitNumbers()
        {
            var result = Palindrome.FindPalindromeProductOfTwoFactors( 99);
            Assert.AreEqual(9009, result.Product);
            Assert.AreEqual(99, result.Factors.ElementAt(0));
            Assert.AreEqual(91, result.Factors.ElementAt(1));
        }
    }
}
