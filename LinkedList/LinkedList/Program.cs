using System;

namespace LinkedList
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

    class LinkedList
    {
        private Node head; // the top vertex of the LinkedList
        private Node tail; // the bottom vertex of the LinkedList
        private int size; // LinkedList is used when we don't know how many elements will be in our collection

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0; // when first constructing LinkedList, it has no elements
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
