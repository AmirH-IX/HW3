using System;

namespace HW3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            SQRT(n);
        }

        private static void SQRT(int n)
        {
            Console.WriteLine(Math.Sqrt(n));
        }
    }
}