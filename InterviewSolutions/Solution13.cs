using System;
using System.Text;

namespace InterviewSolutions
{
    class Solution13
    {
        /*
         * Complete the 'getMaxDeletions' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */
        public int getMaxDeletions(string s)
        {
            int uCount = s.Split('U').Length - 1;
            int dCount = s.Split('D').Length - 1;
            int rCount = s.Split('R').Length - 1;
            int lCount = s.Split('L').Length - 1;

            return Math.Min(uCount, dCount) * 2 + Math.Min(rCount, lCount) * 2;
        }
    }
}
