using System;

namespace Hashing
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
            }
            else
            {
                tail.next = newest; // the new element is the next element of the current tail
            }
            tail = newest; // now the newest element is assigned as the last element of the list
            size = size + 1; // we increase the size by 1 as there is a new l
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
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
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (isEmpty())
                {
                    tail = null;
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
            Node p = head;
            int i = 1;
            while (i < size - 1) // cannot make stale reference, have to start at head
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
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            Node p = head;
            int i = 1;
            while (i < position - 1)
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

        public void insertSorted(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {
                Node p = head;
                Node q = head; // head reference to object q
                while (p != null)
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newest.next = head;
                    head = newest; // the new node has to be inserted as a head in the sorted linked list
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size = size + 1;
        }

        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

    }

    class HashChain
    {
        int hashTableSize;
        LinkedList[] hashTable;

        public HashChain()
        {
            hashTableSize = 10;
            hashTable = new LinkedList[hashTableSize];
            for (int i = 0; i < hashTableSize; i++)
            {
                hashTable[i] = new LinkedList();
            }
        }

        public int hashCode(int key)
        {
            return key % hashTableSize;
        }

        public void insert(int element)
        {
            int i = hashCode(element);
            hashTable[i].insertSorted(element);
        }

        public bool search(int key)
        {
            int i = hashCode(key);
            return hashTable[i].search(key) != -1; // will return -1 if not found
        }

        public void display()
        {
            for (int i = 0; i < hashTableSize; i++)
            {
                Console.Write("[" + i + "]");
                hashTable[i].display();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            HashChain h = new HashChain();
            h.insert(54);
            h.insert(78);
            h.insert(64);
            h.insert(92);
            h.insert(34);
            h.insert(86);
            h.insert(28);
            h.display();
            Console.WriteLine("Element Found: " + h.search(78));
            Console.WriteLine("Element Found: " + h.search(44));

            Console.ReadKey();
        }
    }
}

