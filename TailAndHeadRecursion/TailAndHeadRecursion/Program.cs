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

        public void calculateHead(int n)
        {
            if (n > 0) // base condition
            {
                calculate(n - 1); // recursive invocation
                int k = n * n; // n^2
                Console.WriteLine(k);             
            }
        }

        public void calculateTree(int n)
        {
            if (n > 0) // base condition
            {
                calculate(n - 1); // 1, 4, 1
                int k = n * n; // n^2
                Console.WriteLine(k);
                calculate(n - 1); // 1, 1, 1
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            r.calculateTree(4);
            Console.ReadKey(); // Wait until we press a key once output shows
        }
    }
}
