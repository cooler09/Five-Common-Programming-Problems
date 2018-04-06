using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    public static class ProblemFour
    {
        public static int LargestPossibleNumber(int[] numberCombination)
        {
            //Convert the ints to alpha numeric since the sort for alpha numeric is char by char
            string[] finalList = new string[numberCombination.Length];
            for (int i = 0; i<  numberCombination.Length; i++)
            {
                finalList[i] = numberCombination[i].ToString();
            }

            //Use the sort method which defaults to ascending order
            Array.Sort(finalList);
            //Order by descending
            Array.Reverse(finalList);

            //convert array to string then cast it to an integer
            string finalNumAsString = "";
            for (int i = 0; i < finalList.Length; i++)
            {
                finalNumAsString += finalList[i];
            }
            return Convert.ToInt32(finalNumAsString);
        }
    }
}
