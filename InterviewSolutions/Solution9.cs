namespace InterviewSolutions
{
    class Solution9
    {

        /*
         * Complete the 'IndexOfContainedInteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER num1
         *  2. INTEGER num2
         */

        public int IndexOfContainedInteger(int num1, int num2)
        {
            var str2 = num2.ToString();
            var str1 = num1.ToString();

            if (str1.Length > str2.Length)
                return str1.IndexOf(str2);
            else if (str2.Length > str1.Length)
                return str2.IndexOf(str1);
            return str1 == str2 ? 0 : -1;
        }
    }

}
