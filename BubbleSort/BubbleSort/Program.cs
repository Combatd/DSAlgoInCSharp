using System;

namespace BubbleSort
{
    class Sort
    {
        public void bubbleSort(int[] A, int n)
        {
            for(int pass = n - 1; pass > 0; pass--) // n-1, the largest element will be sorted in first pass, second largest in last pass
            {
                for(int i = 0; i < pass; i++)
                {
                    if(A[i] > A[i + 1])
                    {
                        int temp = A[i]; // store the value of current element in temp
                        A[i] = A[i + 1]; // reassign current element value of next element
                        A[i + 1] = temp; // reassign current element to value of temp
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
