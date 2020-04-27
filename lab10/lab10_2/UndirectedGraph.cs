using System;
using System.Collections.Generic;
using System.Text;

namespace lab10_2
{
    class UndirectedGraph

    {
        private int[,] matrix = new int[40, 40];
        private int vertices;

        public UndirectedGraph(int num)

        {
            this.vertices = num;
            Console.WriteLine($"count of vertices = {num} ");
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        public void displayAdjacencyMatrix()
        {
            Console.Write("\n\n Adjacency Matrix:");

           
            for (int i = 0; i < vertices; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < vertices; ++j)
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }
        }
        public void addEdge(int x, int y)
        {
           
            if ((x > vertices) || (y > vertices))
            {
                Console.WriteLine("\n Vertex does not exists!");
            }

            if (x == y)
            {
                Console.WriteLine("Same Vertex!");
            }
            else
            {
                matrix[y, x] = 1;
                matrix[x, y] = 1;
            }
        }
        public void addVertex()
        {
           
            vertices++;
            int i;

            for (i = 0; i < vertices; ++i)
            {
                matrix[i, vertices - 1] = 0;
                matrix[vertices - 1, i] = 0;
            }
        }

        public void removeVertex(int x)
        {
            if (x > vertices)
            {
                Console.WriteLine("Vertex not present!");
                return;
            }
            else
            {
                int i;

                while (x < vertices)
                { 
                    for (i = 0; i < vertices; ++i)
                    {
                        matrix[i, x] = matrix[i, x + 1];
                    }
                    for (i = 0; i < vertices; ++i)
                    {
                        matrix[x, i] = matrix[x + 1, i];
                    }
                    x++;
                }
                vertices--;
            }
        }
    }
}
