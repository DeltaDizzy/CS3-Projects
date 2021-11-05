using System;
using System.Linq;

namespace FactorialSum 
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Enumerable.Range(2, 25))
            {
                Console.WriteLine($"{i}! is {Factorial(i)} which is {Factorial(i).ToString().ToCharArray().Select(c => c.ToString()).ToList().Select(s => long.Parse(s)).ToList().Sum()}");
            }
            Console.ReadLine();
        }

        static long Factorial(long n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }
    }
}