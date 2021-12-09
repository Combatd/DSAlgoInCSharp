using System;

namespace BinarySearch
{
    class Search
    {
        public int binarySearch(int[] A, int n, int key)
        {
            int l = 0; // left index
            int r = n - 1; // right index
            while(l <= r) // while the left index is less than or equal to right index
            {
                int mid = (l + r) / 2;
                if(key == A[mid])
                {
                    return mid; // the midpoint is the key to find
                } else if (key < A[mid])
                {
                    r = mid - 1; // the right index is before the midpoint
                } else if (key > A[mid])
                {
                    l = mid + 1; // the left index is after the midpoint
                }
            }
            return -1; // key is not found
        }

        static void Main(string[] args)
        {
            Search s = new Search();
            int[] A = { 15, 21, 47, 84, 96 };
            int found = s.binarySearch(A, 5, 96);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
        }
    }
}
