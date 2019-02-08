using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0008.UnitTests
{
    [TestClass]
    public class ProductInSeriesTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GivenLettersInInput_WhenConvertingStringToIntArray_ThenThrowError()
        {
            ProductInSeries.ConvertStringToIntArray("1234086532t324");
        }

        [TestMethod]
        public void GivenNumberInput_WhenConvertingStringToIntArray_ThenGetCorrectArray()
        {
            var result = ProductInSeries.ConvertStringToIntArray("02358");

            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(5, result[3]);
            Assert.AreEqual(8, result[4]);
        }

        [TestMethod]
        public void WhenSeriesIsLongerThanAmountOfAdjacentDigits_ThenReturnCorrectResult()
        {
            var series = new List<int> { 1,9,5,7,3,8,4,9 };
            var result = ProductInSeries.GetLargestProductInASeries(series, 5);
            Assert.AreEqual(7560, result.Product);
            Assert.AreEqual(9, result.Factors[0]);
            Assert.AreEqual(5, result.Factors[1]);
            Assert.AreEqual(7, result.Factors[2]);
            Assert.AreEqual(3, result.Factors[3]);
            Assert.AreEqual(8, result.Factors[4]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenSeriesIsShorterThanAmountOfAdjacentDigits_ThenThrowError()
        {
            var series = new List<int>();
            ProductInSeries.GetLargestProductInASeries(series, 5);
        }
    }
}
