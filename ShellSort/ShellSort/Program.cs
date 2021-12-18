using System;

namespace ShellSort
{
    class Sort
    {
        public void shellShort(int[] A, int n) {
            int gap = n / 2; // The initial gap is half of length of array
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i]; // value of current index element in first iteration, a midpoint
                    int j = i - gap;
                    while (j >= 0 && A[j] > temp) // when the element to the left gap is less than the temp
                    {
                        A[j + gap] = A[j]; // the current element is greater than the element at the right of the gap, where we can swap
                        j = j - gap; // lets compare to the second part
                    }
                    A[j + gap] = temp; // swap the original position
                    i = i + 1; // we move up 1 and then run the loop again if it is less than length of array
                }
                gap = gap / 2; // divide the gap by 2 and continue loop if gap is greater than 0
            }
        }

        public void display(int[] A, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
