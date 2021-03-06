using System;

namespace Heaps
{
    class Sort
    {
        public void heapSort(int[] A, int n)
        {
            Heap h = new Heap();
            for (int i = 0; i <n; i++)
            {
                h.insert(A[i]);
            }
            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                A[k] = h.deleteMax();
                k = k - 1;
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
    }

    class Heap
    {
        int[] data;
        int maxSize;
        int csize;

        public Heap()
        {
            maxSize = 10;
            data = new int[maxSize];
            csize = 0;
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int length()
        {
            return csize;
        }

        public bool isEmpty()
        {
            return csize == 0;
        }

        public void insert(int e)
        {
            if (csize == maxSize)
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            csize = csize + 1;
            int hi = csize;
            while (hi > 1 && e > data[hi / 2])
            {
                data[hi] = data[hi / 2];
                hi = hi / 2;
            }
            data[hi] = e;
        }

        public int max()
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1]; // we don't consider index 0
        }

        public int deleteMax()
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int e = data[1];
            data[1] = data[csize];
            data[csize] = -1;
            csize = csize - 1;
            int i = 1;
            int j = i * 2;
            while (j <= csize)
            {
                if(data[j] < data[j + 1])
                {
                    j = j + 1;
                }
                if (data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i = 1;
                    j = i * 2;
                } else
                {
                    break;
                }
            }
            return e;
        }

        public void display()
        {
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Heap h = new Heap();
            h.insert(25);
            h.insert(14);
            h.insert(2);
            h.insert(20);
            h.insert(10);
            h.display();
            h.insert(40);
            h.display();

            int element = h.deleteMax();
            Console.WriteLine("Element Deleted: " + element);
            h.display();

            Sort s = new Sort();
            int[] A = { 63, 250, 835, 947, 651, 28 };
            Console.WriteLine("Original Array");
            s.display(A, 6);
            s.heapSort(A, 6);
            Console.WriteLine("Sorted Array");
            s.display(A, 6);

            Console.ReadKey();
        }
    }
}
