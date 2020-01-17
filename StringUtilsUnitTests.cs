using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace _30DaysTDD
{ 
    public class StringUtilsUnitTests
    {

        private StringUtils _stringUtils;

        [TestInitialize]
        public void InitializeStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }

        [TestMethod]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            var stringUtils = new StringUtils();

            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";

            var characterToScanFor = "n";

            var expectedResult = 5;

            var stringUtils = new StringUtils();

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "xx";
            var stringUtils = new StringUtils();

            _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
        }
    }
}
