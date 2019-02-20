using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem0022.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private NameScore _nameScore;
        [TestInitialize]
        public void Initialize()
        {
            _nameScore = new NameScore();
        }

        [TestMethod]
        public void TestCalculateCorrectAlphabeticalValue()
        {
            var alphabeticalValue = _nameScore.CalculateAlphabeticalValue("Colin");
            Assert.AreEqual(3+15+12+9+14, alphabeticalValue);
        }

        [TestMethod]
        public void WhenCalculatingNameScore_ThenGetCorrectResult()
        {
            var names = new List<string>
            {
                "Anna",
                "Elsa",
                "Kristoff",
                "Olof",
                "Sven"
            };

            var nameScore = _nameScore.CalculateNameScore(names);

            Assert.AreEqual(30+74+312+192+300, nameScore);
        }
    }
}
