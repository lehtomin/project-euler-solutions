using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0011.UnitTests
{
    [TestClass]
    public class ProductInGridTests
    {
        [TestMethod]
        public void GivenValidInput_WhenSearchingLargestProductFromAGrid_ThenGetCorrectResult()
        {
            const string input = "08 02 22\r\n10 49 99\r\n81 01 31";
            var parsedInput = ProductInGrid.ParseInput(input);
            var result = ProductInGrid.FindLargestProductInAGrid(parsedInput, 2);

            Assert.AreEqual(4851, result.Product);
            Assert.AreEqual(Direction.Horizontal, result.Direction);
            Assert.IsTrue(result.Factors.Contains(49));
            Assert.IsTrue(result.Factors.Contains(99));
        }
    }
}
