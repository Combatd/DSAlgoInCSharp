using System;

namespace QueueDoubleEnded
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

    class DeQueLinked
    {
        private Node front; // the top vertex of the LinkedList
        private Node rear; // the bottom vertex of the LinkedList
        private int size; // LinkedList is used when we don't know how many elements will be in our collection

        public DeQueLinked()
        {
            front = null;
            rear = null;
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
                front = newest; // if the LinkedList is empty, the new element is the first node
            }
            else
            {
                rear.next = newest; // the new element is the next element of the current tail
            }
            rear = newest; // now the newest element is assigned as the last element of the list
            size = size + 1; // we increase the size by 1 as there is a new l
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = front.element;
                front = front.next;
                size = size - 1;
                if (isEmpty())
                {
                    rear = null;
                }
                return e;
            }
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = front;
            int i = 1;
            while (i < size - 1) // cannot make stale reference, have to start at head
            {
                p = p.next;
                i = i + 1;
            }
            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null;
            size = size - 1;
            return e;
        }

        public int search(int key)
        {
            Node p = front;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
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
            Node p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public int first()
        {
            if(isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return front.element;
        }

        public int last()
        {
            if (isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return rear.element;
        }

        static void Main(string[] args)
        {
            DeQueLinked d = new DeQueLinked();
            d.addFirst(5);
            d.addFirst(3);
            d.addLast(7);
            d.addLast(12);
            d.display();
            Console.WriteLine("Size: " + d.length());
            Console.WriteLine("Front Element Removed: " + d.removeFirst());
            Console.WriteLine("Rear Element Removed: " + d.removeLast());
            Console.WriteLine("First Element: " + d.first());
            Console.WriteLine("LastElement: " + d.last());

            Console.ReadKey();
        }
    }
}
