using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewSolutions
{
    class Result16
    {

        /*
         * Complete the 'featuredProduct' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY products as parameter.
         */

        public static string featuredProduct(List<string> products)
        {
            var saleInfo = new Dictionary<string, int>();

            foreach (var product in products)
            {
                if (saleInfo.ContainsKey(product))
                    continue;

                var numOfSold = findNumberOfRepeat(products, product, products.Count - 1);
                saleInfo.Add(product, numOfSold);
            }

            return saleInfo.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).First().Key;
        }

        private static int findNumberOfRepeat(List<string> products, string product, int length)
        {
            if (length < 0) return 0;
            else if (products[length] == product) return 1 + findNumberOfRepeat(products, product, length - 1);
            else return findNumberOfRepeat(products, product, length - 1);
        }

    }

    class Solution16
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT_PATH.txt", true);

            int productsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> products = new List<string>();

            for (int i = 0; i < productsCount; i++)
            {
                string productsItem = Console.ReadLine();
                products.Add(productsItem);
            }

            string result = Result16.featuredProduct(products);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
