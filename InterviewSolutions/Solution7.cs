using System;

namespace InterviewSolutions
{
    class Solution7
    {
        public int solution(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M; i++)
                count[i] = 0;
            int maxOccurence = 0;
            int index = -1;
            for (int i = 0; i < N; i++)
            {
                if (count[A[i]] > 0)
                {
                    count[A[i]]++;
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                }
                else
                {
                    count[A[i]] = 1;
                }
            }
            return A[index];
        }
    }
}
