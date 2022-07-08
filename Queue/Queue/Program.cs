using System;

namespace Queue
{
    class QueuesArray
    {
        int[] data;
        int front; // index front of the queue
        int rear; // index rear of the queue
        int size;

        public QueuesArray(int n)
        {
            data = new int[n]; // initialize with the capacity of the queue
            front = 0;
            rear = 0;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public bool isFull()
        {
            return size == data.Length;
        }

        public void enqueue(int e)
        {
            if(isFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else
            {
                data[rear] = e;
                rear = rear + 1;
                size = size + 1;
            }
        }

        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int e = data[front];
                front = front + 1;
                size = size - 1;
                return e;
            }
        }

        public void display()
        {
            for(int i = front; i < rear; i++)
            {
                Console.Write(data[i] + "--");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            QueuesArray q = new QueuesArray(10);
            q.enqueue(5);
            q.enqueue(3);
            q.display();
            Console.WriteLine("Size: " + q.length());
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.isEmpty());
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.isEmpty());
            q.enqueue(7);
            q.enqueue(9);
            q.enqueue(4);
            q.display();
            Console.WriteLine("Size: " + q.length());

            Console.ReadKey();
        }
    }
}
