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

        public  void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if(isEmpty())
            {
                head = newest;
                tail = newest;
            } else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }

        public int removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            } else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if(isEmpty())
                {
                    tail = null;
                }
                return e;
            }
        }

        public int removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i < size - 1) // cannot make stale reference, have to start at head
            {
                p = p.next;
                i = i + 1;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size = size - 1;
            return e;
        }

        public int removeAny(int position)
        {
            if(position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size = size - 1;
            return e;
        }

        public int search(int key)
        {
            Node p = head;
            int index = 0;
            while(p != null)
            {
                if(p.element == key)
                {
                    return index;
                }
                p = p.next;
                index = index + 1;
            }
            return -1;
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
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size " + l.length());
            l.addFirst(15);
            l.display();
            l.addFirst(25);
            l.display();
            l.addAny(20, 3);
            l.display();
            Console.WriteLine("Size " + l.length());
            l.addAny(40, 5);
            Console.WriteLine("Size " + l.length());
            int element = l.removeFirst(); // no arguments but returns the node
            Console.WriteLine("Removed Element: " + element);
            Console.WriteLine("Size " + l.length());
            int ele = l.removeLast();
            Console.WriteLine("Removed Element: " + ele);
            l.display();
            Console.WriteLine("Size " + l.length());
            int elementAny = l.removeAny(3);
            Console.WriteLine("Removed Element:   " + elementAny);
            Console.WriteLine("Size: " + l.length());
            int position = l.search(12);
            Console.WriteLine("Result: " + position);
            Console.WriteLine("Size: " + l.length());

            Console.ReadKey();
        }
    }
}
