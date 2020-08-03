using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions
{
    class Solution14
    {

        /*
         * Complete the 'getMinimumMoves' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public int getMinimumMoves(List<int> arr)
        {
            int moves = 0;
            int length = arr[0];

            for (int i = length; i >= 1; i--)
            {
                int max = arr[i];
                int maxI = i;

                for (int j = i; j <= length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        maxI = j;
                    }
                }

                if (maxI != length)
                {
                    arr.RemoveAt(maxI);
                    arr.Add(max);
                    moves++;
                }
            }

            return moves;
        }
    }
}
