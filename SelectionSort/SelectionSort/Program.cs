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

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.display(A, 6);
            s.selectionSort(A, 6);
            Console.WriteLine("Sorted Array: ");
            s.display(A, 6);
            Console.ReadKey(); // wait for user input
        }
    }
}
