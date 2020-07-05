using System.Linq;

namespace InterviewSolutions
{
    class Solution11
    {
        public int solution(int[] ranks)
        {
            int canReportSoldier = 0;

            int[] visited = new int[ranks.Length];

            int vi = 0;

            for (int i = 0; i < ranks.Length; i++)
            {
                if (!visited.Contains(ranks[i]))
                {
                    visited[vi] = ranks[i];
                    vi++;

                    for (int j = 0; j < ranks.Length; j++)
                    {
                        if (ranks[j] == ranks[i] - 1)
                        {
                            canReportSoldier++;
                        }
                    }
                }
            }

            return canReportSoldier;
        }
    }

}
