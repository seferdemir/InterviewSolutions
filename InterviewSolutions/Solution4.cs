using System;

namespace InterviewSolutions
{
    class Solution4
    {
        public int solution(string S)
        {
            int pair = 1;
            int glob = 0;

            char[] arr = S.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                char c = arr[i];
                char cNext = arr[i + 1];
                if (c == cNext)
                {
                    pair++;
                }
                else
                {
                    for (int k = 0; k < pair; k++)
                    {
                        char d = arr[i + k + 1];
                        if (d != cNext)
                        {
                            return 1;
                        }
                    }
                    i += pair;
                    pair = 1;
                    glob++;
                }
            }
            return glob;
        }
    }

}
