using System;

namespace QuickSort
{
    /* Algorithm quickSort(A, low, high)
     * if low < high then
     *  pi = paritition(A, low, high)
     *  quickSort(A, low, pi - 1)
     *  quickSort(A, pi + 1, high)
     */

    /* Algorithm partition(A, low, high)
     *  pivot = A[low]
     *  i = low, j = high
     *  
     *  do
     *      i = i + 1
     *  while (A[i] <= Pivot)
     *  
     *      do
     *          j = j - 1
     *      while (A[j] > pivot)
     *          if i < j then
     *              swap(A[i], A[j])
     *  while (i < j)
     *      swap(A[low], A[j])
     *  return j
     */

    class Sort
    {
        public void quickSort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = partition(A, low, high);
                quickSort(A, low, partitionIndex - 1);
                quickSort(A, partitionIndex + 1, high);
            }
        }

        public int partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;

            do
            {
                while (i <= j && A[i] <= pivot)
                {
                    i = i + 1;
                }
                while (i <= j && A[j] > pivot)
                {
                    j = j - 1;
                }
                if (i <= j)
                {
                    swap(A, i, j);
                }
            } while (i < j);

            swap(A, low, j);
            return j;
        }

        public void swap(int[] A, int i, int j)
        {
            int temp = A[i]; // save the current value of A[i]
            A[i] = A[j]; // set the value as the value of A[j] 
            A[j] = temp; // set the value of A[j] as the old value of A[i]
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
            s.quickSort(A, 0, A.Length - 1);
            Console.WriteLine("Sorted Array: ");
            s.display(A, 6);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
