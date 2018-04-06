using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemTwo.UnitTests
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void ListCombiner_WhenCalled_ShouldReturnCombinedList()
        {
            List<string> expected = new List<string>{ "a","b","c","d","e","f"};

            var actual = Problem.ListCombiner<string>(new List<string>
            {
                "a",
                "c",
                "e"
            },
            new List<string>
            {
                "b",
                "d",
                "f"
            });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
