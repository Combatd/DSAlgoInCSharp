using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public int element;
        public Node next;
        public Node prev;

        public Node(int e, Node n, Node p) // constructor
        {
            element = e;
            next = n;
            prev = p;
        }
    }

    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0; // initialize as empty
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
            Node newest = new Node(e, null, null);
            if(isEmpty())
            {
                head = newest;
                tail = newest; // both are newest as it is the only node in the list
            } else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size = size + 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            } else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny (int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            Node newest = new Node(e, null, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next; // we have to assign next to p.next first, because we don't want to lose the reference to the doubly linked list
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = head.element;
            head = head.next;
            head.prev = null;
            size = size - 1;
            if (isEmpty())
            {
                tail = null; // if it is empty, we have to make the tail null as well
            } else
            {
                head.prev = null;
            }
            return e;
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = tail.element;
            tail = tail.prev; // the new tail is before the node we are deleting
            tail.next = null; // setting to null deletes the last node
            size = size - 1;
            return e;
        }

        public int removeAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }

            Node p = head;
            int i = 1; // tracks how many nodes we will traverse
            while (i < position - 1)
            {
                p = p.next; // move reference/pointer p to next node
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            p.next.prev = p; // assign the previous reference to the node p
            size = size - 1;
            return e;
        }

        public void display()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DoublyLinkedList l = new DoublyLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addFirst(15);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addAny(20, 3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int element = l.removeFirst();
            Console.WriteLine("Removed Element: " + element);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int elementLast = l.removeLast();
            Console.WriteLine("Removed Element: " + elementLast);
            l.display();
            Console.WriteLine("Size: " + l.length());
            int removedElement = l.removeAny(3);
            Console.WriteLine("Removed Element: " + removedElement);
            l.display();
            Console.WriteLine("Size: " + l.length());

            Console.ReadKey();
        }
    }
}
