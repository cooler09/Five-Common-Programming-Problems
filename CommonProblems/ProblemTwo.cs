using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    public static class ProblemTwo
    {
        public static List<T> ListCombiner<T>(List<T> listOne, List<T> listTwo)
        {
            var combinedList = new List<T>();
            int iterator = listOne.Count > listTwo.Count ? listOne.Count : listTwo.Count;
            for (int i = 0; i < iterator; i++)
            {
                if (listOne[i] != null)
                    combinedList.Add(listOne[i]);
                if (listTwo[i] != null)
                    combinedList.Add(listTwo[i]);
            }

            return combinedList;
        }
    }
}
