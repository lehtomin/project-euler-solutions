using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0021.UnitTests
{
    [TestClass]
    public class AmicableNumbersTests
    {
        private AmicableNumbers _amicableNumbers;
        [TestInitialize]
        public void Initialize()
        {
            _amicableNumbers = new AmicableNumbers();
        }

        [TestMethod]
        public void WhenGettingAmicableNumbersUnder2000_ThenGetFourCorrectOnes()
        {
            var amicableNumbers = _amicableNumbers.GetAmicableNumbers(2000);

            Assert.AreEqual(4, amicableNumbers.Count());
            Assert.IsTrue(amicableNumbers.Contains(220));
            Assert.IsTrue(amicableNumbers.Contains(284));
            Assert.IsTrue(amicableNumbers.Contains(1184));
            Assert.IsTrue(amicableNumbers.Contains(1210));
        }
    }
}
