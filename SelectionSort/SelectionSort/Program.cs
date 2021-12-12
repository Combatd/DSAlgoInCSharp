using System;

namespace SelectionSort
{
    class Sort
    {
        public void selectionSort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i; // keep track of the "start" of iteration for comparisons
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position]) // find the largest element when making this comparison to the rest of array
                    {
                        position = j;
                    }
                }
                int temp = A[i]; // save the start element in a temp variable
                A[i] = A[position]; // swap temp to the new position to the right
                A[position] = temp; // swap the start element of this iteration to the left
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
