using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonProblems.UnitTests
{
    [TestClass]
    public class ProblemOneTests
    {
        [TestMethod]
        public void SumWithForLoop_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15,5,3,7,2,6,2,10};
            var actual = ProblemOne.SumWithForLoop(numbers);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumWithWhileLoop_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15, 5, 3, 7, 2, 6, 2, 10 };
            var actual = ProblemOne.SumWithWhileLoop(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumWithRecursion_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15, 5, 3, 7, 2, 6, 2, 10 };
            var actual = ProblemOne.SumWithRecursion(numbers,0);

            Assert.AreEqual(expected, actual);
        }
    }
}
