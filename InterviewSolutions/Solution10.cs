namespace InterviewSolutions
{
    class Solution10
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;

            int value = A[0];
            int size = 1;

            do
            {
                value = A[value];
                size++;
            } while (value != -1);

            return size;
        }
    }

}
