using System;

namespace InterviewSolutions
{
    enum Weekdays
    {
        Mon = 1,
        Tue = 2,
        Wed = 3,
        Thu = 4,
        Fri = 5,
        Sat = 6,
        Sun = 7
    }

    class Solution1
    {
        public string solution(string S, int K)
        {
            int weekday = (int)Weekdays.Mon;
            switch (S)
            {
                case "Mon":
                    weekday = (int)Weekdays.Mon;
                    break;
                case "Tue":
                    weekday = (int)Weekdays.Tue;
                    break;
                case "Wed":
                    weekday = (int)Weekdays.Wed;
                    break;
                case "Thu":
                    weekday = (int)Weekdays.Thu;
                    break;
                case "Fri":
                    weekday = (int)Weekdays.Fri;
                    break;
                case "Sat":
                    weekday = (int)Weekdays.Sat;
                    break;
                case "Sun":
                    weekday = (int)Weekdays.Sun;
                    break;
                default:
                    break;
            }

            return Enum.GetName(typeof(Weekdays), (weekday + K) % 7);
        }
    }
}
