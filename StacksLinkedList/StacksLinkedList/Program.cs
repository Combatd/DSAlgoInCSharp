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

    class StacksLinked
    {
        Node top;
        int size;

        public StacksLinked()
        {
            top = null;
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

        public void push(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size = size + 1;
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = top.element;
            top = top.next;
            size = size - 1;
            return e;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            return top.element;
        }

        public void display()
        {
            Node p = top;
            while(p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StacksLinked s = new StacksLinked();
            s.push(5);
            s.push(3);
            s.display();
            Console.WriteLine("Size: " + s.length());
            Console.WriteLine("Element Removed: " + s.pop());
            Console.WriteLine("IsEmpty: " + s.isEmpty());
            Console.WriteLine("Element Removed: " + s.pop());
            Console.WriteLine("IsEmpty: " + s.isEmpty());
            s.push(7);
            s.push(9);
            s.display();
            Console.WriteLine("Element Top: " + s.peek());
            s.display();

            Console.ReadKey();
        }
    }
}
