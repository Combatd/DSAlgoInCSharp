using System;

namespace FactorialOfNumber
{
    class Factorial
    {
        public int factorialIterative(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
