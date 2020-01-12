using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions
{
    class Solution6
    {
        public int solution(int[] A)
        {
            Dictionary<int, int> keyValue = new Dictionary<int, int>();

            int N = A.Length;

            for (int i = 0; i < N; i++)
            {
                if (keyValue.ContainsKey(A[i]))
                {
                    int count = keyValue[A[i]];
                    keyValue.Remove(A[i]);
                    keyValue.Add(A[i], count + 1);
                }
                else
                    keyValue.Add(A[i], 1);
            }

            int result = 0;

            foreach (var it in keyValue)
            {
                int count = it.Value;
                result += (count * (count - 1)) / 2;
            }
            return result;
        }
    }
}
