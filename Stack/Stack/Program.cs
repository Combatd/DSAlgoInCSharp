using System;

namespace Stack
{
    class StacksArray
    {
        int[] data; // to store elements of the stack
        int top; // to store the top element of the stack

        public StacksArray(int n)
        {
            data = new int[n]; // new array with the size of n
            top = 0; // initialize as empty array
        }

        public int length()
        {
            return top; // returns the index of the top element
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public bool isFull()
        {
            return top == data.Length;
        }

        public void push(int e)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is Full/Overflow");
                return;
            } else
            {
                data[top] = e;
                top = top + 1;
            }
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Staack is Empty");
                return -1;
            }
            int e = data[top - 1];
            top = top - 1;
            return e;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return data[top - 1];
        }

        public void display()
        {
            for(int i = 0; i < top; i++)
            {
                Console.Write(data[i] + "--");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StacksArray s = new StacksArray(10);
            s.push(5);
            s.push(3);
            s.display();
            Console.WriteLine("Size: " + s.length());
            Console.WriteLine("Element popped: " + s.pop());
            Console.WriteLine("IsEmpty: " + s.isEmpty());
            s.push(7);
            s.push(9);
            s.display();
            Console.WriteLine("Element on Top: " + s.peek());

            Console.ReadKey();
        }
    }
}
