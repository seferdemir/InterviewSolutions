using System;
using System.Collections.Generic;

namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1 solution1 = new Solution1();
            Solution2 solution2 = new Solution2();
            Solution3 solution3 = new Solution3();
            Solution4 solution4 = new Solution4();
            Solution5 solution5 = new Solution5();
            Solution6 solution6 = new Solution6();
            Solution7 solution7 = new Solution7();
            Solution8 solution8 = new Solution8();
            Solution9 solution9 = new Solution9();
            Solution10 solution10 = new Solution10();
            Solution11 solution11 = new Solution11();
            Solution12 solution12 = new Solution12();
            Solution13 solution13 = new Solution13();
            Solution14 solution14 = new Solution14();

            Console.WriteLine(solution1.solution("Sat", 38));
            Console.WriteLine(solution2.solution(new int[] { 0, 5, 4, 4, 5, 12 }));
            Console.WriteLine(solution3.solution(new int[] { 1, 2, 5, 9, 9 }, 5));
            Console.WriteLine(solution4.solution("RLRRLLRLRRLL"));
            Console.WriteLine(solution5.solution(new int[] { 1, 3, 4, 2, 2, 2, 1, 1, 2 }));
            Console.WriteLine(solution6.solution(new int[] { 3, 5, 6, 3, 3, 5 }));
            Console.WriteLine(solution7.solution(3, new int[] { 1, 2, 3, 3, 1, 3, 1 }));
            Console.WriteLine(solution8.CountOfStringPair(new System.Collections.Generic.List<string>() { "efsane", "ahane", "muazzam", "kral", "efe", "enasfe", "enaha" }));
            Console.WriteLine(solution9.IndexOfContainedInteger(65241, 24));
            Console.WriteLine(solution10.solution(new int[] { 1, 4, -1, 3, 2 }));
            Console.WriteLine(solution11.solution(new int[] { 3, 4, 3, 0, 2, 2, 3, 0, 0 }));
            Console.WriteLine(solution12.solution(123456));
            Console.WriteLine(solution13.getMaxDeletions("URRDRL"));
            Console.WriteLine(solution14.getMinimumMoves(new List<int> { 3, 1, 2, 3 }));

            Console.ReadLine();
        }
    }
}
