using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemOne.UnitTests
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void SumWithForLoop_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15,5,3,7,2,6,2,10};
            var actual = Problem.SumWithForLoop(numbers);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumWithWhileLoop_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15, 5, 3, 7, 2, 6, 2, 10 };
            var actual = Problem.SumWithWhileLoop(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumWithRecursion_WhenCalled_ShouldSumTotalNumbers()
        {
            var expected = 50;
            var numbers = new int[] { 15, 5, 3, 7, 2, 6, 2, 10 };
            var actual = Problem.SumWithRecursion(numbers,0);

            Assert.AreEqual(expected, actual);
        }
    }
}
