using System;

namespace QueueLinkedList
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class QueuesLinked
    {
        Node front;
        Node rear;
        int size;

        public QueuesLinked()
        {
            front = null;
            rear = null;
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

        public void enqueue(int e)
        {
            Node newest = new Node(e, null);
            if(isEmpty())
            {
                front = newest;
            } else
            {
                rear.next = newest;
                size = size + 1;
            }
        }

        public int dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int e = front.element;
            front = front.next;
            size = size - 1;
            if(isEmpty())
            {
                rear = null;
            }
            return e;
        }

        public void display()
        {
            Node p = front;
            while(p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
