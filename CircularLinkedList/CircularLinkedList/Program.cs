using System;

namespace CircularLinkedList
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

    class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
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

        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null); // O(1)
            if (isEmpty())
            {
                newest.next = newest; // O(1)
                head = newest; // O(1)
                tail = newest; // O(1)
            } else
            {
                tail.next = newest; // O(1)
                newest.next = head; // O(1)
                head = newest; // O(1)
            }
            size = size + 1; // O(1)
        }

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null); // O(1)
            Node p = head; // O(1)
            int i = 1; // O(1)
            while (i < position - 1) { // O(n)
                p = p.next; // move the reference/pointer to next Node
                i = i + 1;
            }
            newest.next = p.next; // O(1)
            p.next = newest; // O(1)
            size = size + 1; // O(1)
        }

        public int removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("Circular List is Empty");
                return -1;
            }
            int e = head.element;
            tail.next = head.next;
            head = head.next;
            size = size - 1;
            if (isEmpty())
            {
                head = null;
                tail = null;
            }
            return e;
        }

        public int removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("Circular List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < length() - 1)
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            tail.next = head;
            int e = p.element;
            size = size - 1;
            return e;
        }

        public void display()
        {
            Node p = head;
            int i = 0;
            while(i < length())
            {
                Console.Write(p.element + "-->");
                p = p.next;
                i = i + 1;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CircularLinkedList l = new CircularLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addFirst(25);
            l.display();
            l.addFirst(35);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addAny(20, 3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addAny(20, 3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int element = l.removeFirst();
            Console.WriteLine("Removed Element: " + element);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int elementTwo = l.removeLast();
            Console.WriteLine("Removed Element: " + elementTwo);
            l.display();
            Console.WriteLine("Size: " + l.length());

            Console.ReadKey();
        }
    }
}
