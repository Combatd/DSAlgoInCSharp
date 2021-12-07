using System;

namespace LinearSearch
{
    class Search
    {
        public static int linearSearch(int[] A, int n, int key)
        {
            int index = 0; // iterator index
            while (index < n) // O(n)
            {
                if(A[index] == key) // O(1)
                {
                    return index;
                }
                index = index + 1; // iterate index by 1, O(n)
            }
            return -1;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
