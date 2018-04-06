using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonProblems.UnitTests
{
    [TestClass]
    public class ProblemFiveTests
    {
        [TestMethod]
        public void GetFibonacciNums_WhenCalled_ShouldReturnFibonacciNums()
        {
            var expected = new string[]
            {
                "1 + 2 + 3 - 4 + 5 + 6 + 78 + 9",
                "1 + 2 + 34 - 5 + 67 - 8 + 9",
                "1 + 23 - 4 + 5 + 6 + 78 - 9",
                "1 + 23 - 4 + 56 + 7 + 8 + 9",
                "12 + 3 + 4 + 5 - 6 - 7 + 89",
                "12 + 3 - 4 + 5 + 67 + 8 + 9",
                "12 - 3 - 4 + 5 - 6 + 7 + 89",
                "123 + 4 - 5 + 67 - 89",
                "123 + 45 - 67 + 8 - 9",
                "123 - 4 - 5 - 6 - 7 + 8 - 9",
                "123 - 45 - 67 + 89"
            };

            var actual = ProblemFive.GetAllCombinations();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
