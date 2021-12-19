using System;

namespace MergeSort
{
    class Sort
    {
        public void mergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; // divide array into half
                mergeSort(A, left, mid); // left
                mergeSort(A, mid + 1, right); // right
                // merge(A, left, mid, right);
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
