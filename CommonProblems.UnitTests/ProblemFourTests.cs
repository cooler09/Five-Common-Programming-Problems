using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonProblems.UnitTests
{
    [TestClass]
    public class ProblemFourTests
    {
        [TestMethod]
        public void LargestPossibleNumber_WhenCalled_ReturnsLargestNumberCombination()
        {
            var expected = 95021;
            int[] numberCombination = new int[] { 50, 2, 1, 9 };

            var actual = ProblemFour.LargestPossibleNumber(numberCombination);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LargestPossibleNumber_WhenCalledWithMoreCombinations_ReturnsLargestNumberCombination()
        {
            var expected = 91951501;
            int[] numberCombination = new int[] { 50, 51, 1,91, 9 };

            var actual = ProblemFour.LargestPossibleNumber(numberCombination);

            Assert.AreEqual(expected, actual);
        }
    }
}
