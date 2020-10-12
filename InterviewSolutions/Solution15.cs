using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InterviewSolutions
{
    class Result15
    {

        /*
         * Complete the 'getMaxUnits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. LONG_INTEGER_ARRAY boxes
         *  2. LONG_INTEGER_ARRAY unitsPerBox
         *  3. LONG_INTEGER truckSize
         */

        public static long getMaxUnits(List<long> boxes, List<long> unitsPerBox, long truckSize)
        {
            long[] innerMaxNums = new long[boxes.Sum()];

            int index = 0;

            for (int i = 0; i < innerMaxNums.Length && i < unitsPerBox.Count; i++)
            {
                long unit = unitsPerBox[i];

                for (int j = 0; j < boxes[i]; j++)
                {
                    innerMaxNums[index] = unit;
                    index++;
                }
            }

            return innerMaxNums.OrderByDescending(x => x).Take((int)truckSize).Sum();
        }

    }

    class Solution15
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT_PATH.txt", true);

            int boxesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> boxes = new List<long>();

            for (int i = 0; i < boxesCount; i++)
            {
                long boxesItem = Convert.ToInt64(Console.ReadLine().Trim());
                boxes.Add(boxesItem);
            }

            int unitsPerBoxCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> unitsPerBox = new List<long>();

            for (int i = 0; i < unitsPerBoxCount; i++)
            {
                long unitsPerBoxItem = Convert.ToInt64(Console.ReadLine().Trim());
                unitsPerBox.Add(unitsPerBoxItem);
            }

            long truckSize = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result15.getMaxUnits(boxes, unitsPerBox, truckSize);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
