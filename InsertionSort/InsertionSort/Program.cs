using System;

namespace InsertionSort
{
    class Sort
    {
        public void insertionSort(int[] A, int n)
        {
            for(int i = 1; i < n; i++) // we assume first element is sorted
            {
                int temp = A[i]; // store the value of current element
                int position = i; // used to compare the element at A[position] with temp
                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position] - 1; // move elements greater than temp to the right
                    position = position - 1; // decrement the position index
                }
                A[position] = temp; // now we know where the temp element needs to be inserted after everything is moved to the right
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
