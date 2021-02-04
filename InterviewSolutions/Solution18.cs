using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewSolutions
{
    class Result18
    {

        /*
         * Complete the 'SumOfEvenPalindromeNumbersDigits' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER maxNumber as parameter.
         */

        public static int SumOfEvenPalindromeNumbersDigits(int maxNumber)
        {
            // SumPalindromNumbers metodu cagrilabilir 
            // ve uretilen sonuc SumOfDigits e yollanarak cikti return edilir.
            return SumOfDigits(SumPalindromNumbers(maxNumber));
        }

        private static string GetPalindrom(string value)
        {
            // disaridan verilen degeri tersine ceviren kodlarinizi yaziniz
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static bool IsPalindrom(int number)
        {
            //GetPalindrom metodunu kullanarak sayinin palindrom olup olmadigini donunuz
            return number == int.Parse(GetPalindrom(number.ToString()));
        }

        private static int SumOfDigits(int total)
        {
            //disaridan girilen total degerin digit toplamini ureten kodu yaziniz
            if (total == 0)
                return 0;
            return (total % 10 + SumOfDigits(total / 10));
        }

        private static int SumPalindromNumbers(int maxNumber)
        {
            // IsPalindrom metodundan yararlanarak palindrom sayiyi tespit ediniz.
            // 0'dan verilen maxNumber degerine kadarina olan cift ve palindrom sayilarin toplamini donen kodlari yaziniz.
            int sum = 0;

            for (int i = 0; i < maxNumber; i += 2)
            {
                if (IsPalindrom(i))
                    sum += i;
            }
            return sum;
        }
    }

    class Solution18
    {
        public static void Main(string[] args)
        {
        }
    }
}
