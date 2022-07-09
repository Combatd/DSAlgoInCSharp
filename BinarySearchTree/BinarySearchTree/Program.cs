using System;

namespace BinarySearchTree
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    class BST
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
