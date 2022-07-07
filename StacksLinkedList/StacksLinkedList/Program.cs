using System;

namespace StacksLinkedList
{
    public class Node
    {
        public int element; // the data of the node/vertex
        public Node next; // this will allow us to traverse the collection of Nodes that are in different memory locations
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
