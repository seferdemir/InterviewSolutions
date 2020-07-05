namespace InterviewSolutions
{
    class Solution12
    {
        public int solution(int A)
        {
            var oldA = A.ToString();
            var newA = new char[oldA.Length];

            int i = 0;
            int j = oldA.Length - 1;
            int k = 0;

            while (i <= j)
            {
                newA[k] = oldA[i]; k++;

                if (j > i)
                {
                    newA[k] = oldA[j]; k++;
                }

                i++;
                j--;
            }

            return int.Parse(new string(newA));
        }
    }

}
