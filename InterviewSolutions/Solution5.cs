using System;

namespace InterviewSolutions
{
    class Solution5
    {
        public bool solution(int[] A)
        {
            int leftPointer = 1;
            int rightPointer = A.Length - 2;
            int leftPartSum, middlePartSum, rightPartSum;
            int[] sumArray = new int[A.Length];

            sumArray[0] = A[0];
            for (int i = 1; i < A.Length; i++)
                sumArray[i] = sumArray[i - 1] + A[i];

            while (leftPointer < rightPointer)
            {
                leftPartSum = sumArray[leftPointer] - A[leftPointer];
                middlePartSum = sumArray[rightPointer] - sumArray[leftPointer] - A[rightPointer];
                rightPartSum = sumArray[A.Length - 1] - sumArray[rightPointer];

                if (leftPartSum == middlePartSum && middlePartSum == rightPartSum)
                    return true;

                if (leftPartSum < rightPartSum)
                    leftPointer++;
                else if (leftPartSum > rightPartSum)
                    rightPointer--;
                else
                {
                    leftPointer++;
                    rightPointer--;
                }
            }
            return false;
        }
    }
}
