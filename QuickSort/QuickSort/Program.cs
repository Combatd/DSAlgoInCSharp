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
        static void Main(string[] args)
        {
        }
    }
}
