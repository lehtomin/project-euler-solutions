using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0019.UnitTests
{
    [TestClass]
    public class CalendarUtilsTests
    {
        private CalendarUtils _calendarUtils;

        [TestInitialize]
        public void Initialize()
        {
            _calendarUtils = new CalendarUtils();
        }

        [TestMethod]
        public void WhenYearIsDivisibleWith4And100ButNotWith400_ThenItIsNotLeapYear()
        {
            Assert.IsFalse(_calendarUtils.IsLeapYear(1900));
        }

        [TestMethod]
        public void WhenYearIsDivisibleWith4And100AndWith400_ThenItIsLeapYear()
        {
            Assert.IsTrue(_calendarUtils.IsLeapYear(2000));
        }

        [TestMethod]
        public void WhenYearIsDivisibleWith4ButNotACenturyDivisibleWith400_ThenItIsLeapYear()
        {
            Assert.IsTrue(_calendarUtils.IsLeapYear(2016));
        }

        [TestMethod]
        public void WhenItIsJanuary_ThenNumberOfDaysInAMonthIs31()
        {
            Assert.AreEqual(31, _calendarUtils.DaysInAMonth(1,2019));
        }

        [TestMethod]
        public void WhenItIsSeptember_ThenNumberOfDaysInAMonthIs30()
        {
            Assert.AreEqual(30, _calendarUtils.DaysInAMonth(4, 2019));
        }

        [TestMethod]
        public void WhenItIsFebruaryAndLeapYear_ThenNumberOfDaysInAMonthIs29()
        {
            Assert.AreEqual(29, _calendarUtils.DaysInAMonth(2, 2000));
        }

        [TestMethod]
        public void WhenItIsFebruaryAndNotLeapYear_ThenNumberOfDaysInAMonthIs28()
        {
            Assert.AreEqual(28, _calendarUtils.DaysInAMonth(2, 2019));
        }

        [TestMethod]
        public void WhenGettingSundaysThatAreOnFirstDayOfMonth_ThenGetCorrectAmount()
        {
            // Arrange
            var startDate = new DateTime(2019, 1, 1);
            var endDate = new DateTime(2019, 12, 31);

            // Act
            var result = _calendarUtils.GetSundaysThatAreOnTheFirstDayOfMonth(startDate, endDate);

            // Assert
            Assert.AreEqual(2, result.Count);
        }
    }
}
