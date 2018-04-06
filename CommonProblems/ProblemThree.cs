using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    public static class ProblemThree
    {
        public static long[] GetFibonacciNums(int fibonacci)
        {
            long[] result = new long[fibonacci];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < fibonacci; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result;
        }
    }
}
