using System;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            day = Convert.ToInt32(Console.ReadLine());

            Age(day);
        }

        private static void Age(int day)
        {
            int year, month, week;

            year = day/365;
            day%=365;

            month = day/30;
            day%=30;

            week = day/7;
            day%=7;

            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(week);
            Console.WriteLine(day);
        }
    }
}