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
                merge(A, left, mid, right);
            }
        }

        public void merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1]; // new array to merge into

            while(i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                } else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }

            while (i <= mid)
            {
                B[k] = A[i];
                i = i + 1;
                k = k + 1;
            }

            while (j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = left; x < right + 1; x++)
            {
                A[x] = B[x]; // copy elements of Array A into Array B
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
