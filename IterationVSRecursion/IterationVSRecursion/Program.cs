using System;

namespace IterationVSRecursion
{
    class Recursion
    {
        public void calculateIterative(int n)
        {
            while(n > 0)
            {
                int k = n * n; // k will be n squared
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            r.calculateIterative(4);
            Console.ReadKey(); // Console will wait until we look at the output
        }
    }
}
