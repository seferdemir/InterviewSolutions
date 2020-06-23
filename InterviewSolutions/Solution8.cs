using System;
using System.Collections.Generic;

namespace InterviewSolutions
{
    class Solution8
    {
        /*
         * Complete the 'CountOfStringPair' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING_ARRAY words as parameter.
         */

        public int CountOfStringPair(List<string> words)
        {
            int pair = 0;

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[i] == GetReverse(words[j]))
                        pair++;
                }
            }

            return pair;
        }

        public string GetReverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
