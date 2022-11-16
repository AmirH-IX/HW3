using System;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Power(n);
        }

        static void Power(int n)
        {
            Console.WriteLine(Math.Pow(n, 2));
            Console.WriteLine(Math.Pow(n, 3));
        }
    }
}