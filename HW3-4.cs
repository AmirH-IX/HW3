using System;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance, interest, goal;

            Console.WriteLine("Enter balance");
            balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter interest");
            interest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your goal");
            goal = Convert.ToInt32(Console.ReadLine());

            Goal(balance, interest, goal);
        }
        private static void Goal(int x, int y, int z)
        {
            int i=1;
            while (true)
            {
                if ((x*(z/100)*i)+x >= y)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    x+=(x*(z/100)*i);
                    i++;
                }
            }
        }
    }
}