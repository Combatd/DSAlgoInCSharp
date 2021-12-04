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
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
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
            SumOfNumbers s = new SumOfNumbers();
            Console.WriteLine("Sum " + s.sumN(5));
            Console.WriteLine("Sum " + s.sumNIteration(5));
            Console.WriteLine("Sum " + s.sumNRecursion(5));
            Console.ReadKey();
        }
    }
}
