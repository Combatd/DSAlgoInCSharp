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

        public int factorialRecursive(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return factorialRecursive(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            Console.WriteLine("Factorial: " + f.factorialIterative(5));
            Console.WriteLine("Factorial Recursion: " + f.factorialRecursive(5));
            Console.ReadKey();
        }
    }
}
