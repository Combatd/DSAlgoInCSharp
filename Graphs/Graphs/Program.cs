using System;

namespace Graphs
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class QueuesLinked
    {
        Node front;
        Node rear;
        int size;

        public QueuesLinked()
        {
            front = null;
            rear = null;
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

        public void enqueue(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }
            rear = newest;
            size = size + 1;
        }

        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int e = front.element;
            front = front.next;
            size = size - 1;
            if (isEmpty())
            {
                rear = null;
            }
            return e;
        }

        public void display()
        {
            Node p = front;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    class Graph
    {
        int vertices;
        int[,] adjMat;

        public Graph(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
        }

        public void insertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }

        public bool existEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }

        public int vertexCount()
        {
            return vertices;
        }

        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (adjMat[i,j] != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        public void edges()
        {
            Console.WriteLine("Edges:");
            for(int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        Console.WriteLine(i + "--" + j);
                    }
                }
            }
        }

        public int outDegree(int v)
        {
            int count = 0;
            for (int j = 0; j < vertices; j++)
            {
                if (adjMat[v, j] != 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public int inDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (adjMat[i, v] != 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public void display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    Console.Write(adjMat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void BFS(int s)
        {
            int i = s; // starting vertex;
            QueuesLinked q = new QueuesLinked();
            int[] visited = new int[vertices];
            Console.Write(i + " ");
            visited[i] = 1;
            q.enqueue(i);
            while (!q.isEmpty())
            {
                i = q.dequeue();
                for (int j = 0; j < vertices; j++)
                {
                    if (adjMat[i, j] == 1 && visited[j] == 0)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.enqueue(j);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Graph g = new Graph(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges Count: " + g.edgeCount());
            //g.insertEdge(0, 1, 1);
            //g.insertEdge(0, 2, 1);
            //g.insertEdge(1, 0, 1);
            //g.insertEdge(1, 2, 1);
            //g.insertEdge(2, 0, 1);
            //g.insertEdge(2, 1, 1);
            //g.insertEdge(2, 3, 1);
            //g.insertEdge(3, 2, 1);

            //g.insertEdge(0, 1, 26);
            //g.insertEdge(0, 2, 16);
            //g.insertEdge(1, 0, 26);
            //g.insertEdge(1, 2, 12);
            //g.insertEdge(2, 0, 16);
            //g.insertEdge(2, 1, 12);
            //g.insertEdge(2, 3, 8);
            //g.insertEdge(3, 2, 8);

            //g.insertEdge(0, 1, 1);
            //g.insertEdge(0, 2, 1);
            //g.insertEdge(1, 2, 1);
            //g.insertEdge(2, 3, 1);

            g.insertEdge(0, 1, 26);
            g.insertEdge(0, 2, 16);
            g.insertEdge(1, 2, 12);
            g.insertEdge(2, 3, 8);

            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges Count: " + g.edgeCount());
            g.edges();
            Console.WriteLine("Edge between 1--3: " + g.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + (g.inDegree(2) + g.outDegree(2)));
            Console.WriteLine("InDegree of Vertex 2: " + g.inDegree(2));
            Console.WriteLine("OutDegree of Vertex 2: " + g.outDegree(2));
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            g.removeEdge(1, 2);
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));

            Graph x = new Graph(7);
            x.insertEdge(0, 1, 1);
            x.insertEdge(0, 5, 1);
            x.insertEdge(0, 6, 1);
            x.insertEdge(1, 0, 1);
            x.insertEdge(1, 2, 1);
            x.insertEdge(1, 5, 1);
            x.insertEdge(1, 6, 1);
            x.insertEdge(2, 3, 1);
            x.insertEdge(2, 4, 1);
            x.insertEdge(2, 6, 1);
            x.insertEdge(3, 4, 1);
            x.insertEdge(4, 2, 1);
            x.insertEdge(4, 5, 1);
            x.insertEdge(5, 2, 1);
            x.insertEdge(5, 3, 1);
            x.insertEdge(6, 3, 1);
            Console.WriteLine("Breadth First Search: ");
            x.BFS(0);

            Console.ReadKey();
        }
    }
}

