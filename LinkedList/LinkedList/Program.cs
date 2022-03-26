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

        public int length()
        {
            return size; // return how many elements are in the LinkedList
        }

        public bool isEmpty()
        {
            return size == 0; // if size is 0, this will return true
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null); // use argument element to create new Node
            if (isEmpty())
            {
                head = newest; // if the LinkedList is empty, the new element is the first node
            } else
            {
                tail.next = newest; // the new element is the next element of the current tail
            }
            tail = newest; // now the newest element is assigned as the last element of the list
            size = size + 1; // we increase the size by 1 as there is a new l
        }

        public void display()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size" + l.length());
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.ReadKey();
        }
    }
}
