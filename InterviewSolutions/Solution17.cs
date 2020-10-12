using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewSolutions
{
    class Result17
    {

        /*
         * Complete the 'playlist' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts INTEGER_ARRAY songs as parameter.
         */

        public static long playlist(List<int> songs)
        {
            int result = 0;

            if (!(songs.Count >= 1 && songs.Count <= 100000))
            {
                return 0;
            }

            for (int i = 0; i < songs.Count; i++)
            {
                if (!(songs[i] >= 1 && songs[i] <= 1000))
                {
                    return 0;
                }

                for (int j = i + 1; j < songs.Count; j++)
                {
                    if ((songs[i] + songs[j]) % 60 == 0)
                        result++;
                }
            }

            return result;
        }

    }

    class Solution17
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT_PATH.txt", true);

            int songsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> songs = new List<int>();

            for (int i = 0; i < songsCount; i++)
            {
                int songsItem = Convert.ToInt32(Console.ReadLine().Trim());
                songs.Add(songsItem);
            }

            long result = Result17.playlist(songs);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
