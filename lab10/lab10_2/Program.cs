using System;

namespace lab10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UndirectedGraph obj = new UndirectedGraph(4);

            obj.addEdge(0, 1);
            obj.addEdge(0, 2);
            obj.addEdge(1, 2);
            obj.addEdge(2, 3);
           
            obj.displayAdjacencyMatrix();
 

            obj.addEdge(4, 1);
            obj.addEdge(4, 3);

            obj.displayAdjacencyMatrix();

            obj.removeVertex(1);
            obj.displayAdjacencyMatrix();
        }
    }
}
