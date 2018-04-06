using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne
{
    public static class Problem
    {
        public static int SumWithForLoop(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static int SumWithWhileLoop(int[] numbers)
        {
            int sum = 0;
            int counter = 0;
            while(counter < numbers.Length)
            {
                sum += numbers[counter];
                counter++;
            }
            return sum;
        }
        public static int SumWithRecursion(int[] numbers, int currentIndex)
        {
            if(currentIndex == numbers.Length-1)
                return numbers[currentIndex];

            return numbers[currentIndex] + SumWithRecursion(numbers, ++currentIndex);
        }
    }
}
