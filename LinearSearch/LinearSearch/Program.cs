using System;

namespace LinearSearch
{
    class Search
    {
        public int linearSearch(int[] A, int n, int key)
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
            Search s = new Search();
            int[] A = { 84, 21, 47, 96, 15 };
            int found = s.linearSearch(A, 5, 96);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
        }
    }
}
