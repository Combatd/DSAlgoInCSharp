using System;

namespace IterationVSRecursion
{
    class Recursion
    {
        public void calculateIterative(int n)
        {
            while (n > 0) // O(n + 1) = O(n) Linear
            {
                int k = n * n; // k will be n squared, 1 step
                Console.WriteLine(k); // 1 step
                n = n - 1; // 1 step
            }
        }

        public void calculateRecursive(int n)
        {
            if (n > 0) // base case
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateRecursive(n - 1); // recursive call
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            // r.calculateIterative(4);
            r.calculateRecursive(4);
            Console.ReadKey(); // Console will wait until we look at the output and then hit a key
        }
    }
}
