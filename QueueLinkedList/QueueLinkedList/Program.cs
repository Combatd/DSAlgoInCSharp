using System;

namespace QueueLinkedList
{
    public class Node
    {
        int element;
        Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
