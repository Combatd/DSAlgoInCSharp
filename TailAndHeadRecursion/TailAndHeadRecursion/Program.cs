using System;

namespace TailAndHeadRecursion
{
    class Recursion
    {
        public void calculate(int n)
        {
            if (n > 0) // base condition
            {
                int k = n * n; // n^2
                Console.WriteLine(k);
                calculate(n - 1); // recursive invocation
            } 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
