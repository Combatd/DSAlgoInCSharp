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
        Node root;

        public BST()
        {
            root = null;
        }

        public void insert(Node tempRoot, int e)
        {
            Node temp = null; // reference to the parent node to which we will be inserting a new node or element
            while (tempRoot != null)
            {
                temp = tempRoot;
                if (e == tempRoot.element) // cannot have duplicate elements
                {
                    return;
                } else if (e < tempRoot.element) {
                    tempRoot = tempRoot.left;
                } else if (e > tempRoot.element)
                {
                    tempRoot = tempRoot.right;
                }
            }
            Node n = new Node(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                {
                    temp.left = n;
                } else
                {
                    temp.right = n;
                }
            } else
            {
                root = n;
            }
        }

        public void inOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                inOrder(tempRoot.left);
                Console.Write(tempRoot.element + " ");
                inOrder(tempRoot.right);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
