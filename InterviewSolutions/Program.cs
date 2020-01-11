using System;

namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1 solution1 = new Solution1();
            Solution2 solution2 = new Solution2();
            Solution3 solution3 = new Solution3();

            Console.WriteLine(solution1.solution("Sat", 38));
            Console.WriteLine(solution2.solution(new int[] { 0, 5, 4, 4, 5, 12 }));
            Console.WriteLine(solution3.solution(new int[] { 1, 2, 5, 9, 9 }, 5));

            Console.ReadLine();
        }
    }
}
