using System.Collections.Generic;
using System.Linq;

namespace InterviewSolutions
{
    class LastBiValued
    {
        public int length { get; set; }
        public List<int> array { get; set; }
    }

    class Solution2
    {
        public int solution(int[] A)
        {
            List<LastBiValued> biValued = new List<LastBiValued>();

            for (int i = 0; i < A.Length; i++)
            {
                LastBiValued lastBiValued = sliceByBiValued(i, A);
                biValued.Add(lastBiValued);
            }

            return biValued.Max(x => x.length);
        }

        LastBiValued sliceByBiValued(int index, int[] A)
        {
            List<int> biValued = new List<int>();
            biValued.Add(A[index]);
            int length = 1;

            for (int i = index + 1; i < A.Length; i++)
            {
                if ((biValued.Count == 1 && !biValued.Contains(A[i])) || biValued.Contains(A[i]))
                {
                    biValued.Add(A[i]);
                    length += 1;
                }
                if (i + 1 == A.Length || !biValued.Contains(A[i + 1]))
                {
                    break;
                }
            }

            return new LastBiValued { array = biValued, length = length };
        }
    }
}
