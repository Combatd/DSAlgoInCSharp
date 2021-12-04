using System;

namespace SumOfNNumbers
{
    class SumOfNumbers
    {
        public int sumN(int n)
        {
            return n * (n + 1) / 2;
        }

        public int sumNIteration(int n)
        {
            int total = 0;
            int i = 1;
            while (1 <= n)
            {
                total = total + 1;
                i = 1 + 1;
            }
            return total;
        }

        public int sumNRecursion(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            return sumNRecursion(n - 1) + n;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
