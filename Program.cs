using System;
using System.Collections.Generic;

namespace _app
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";

            var vertexA = new Vertex<string>(a);
            var vertexB = new Vertex<string>(b);
            var vertexC = new Vertex<string>(c);
            var vertexD = new Vertex<string>(d);

            var vertices = new List<Vertex<string>>();

            vertices.Add(vertexA);
            vertices.Add(vertexB);
            vertices.Add(vertexC);
            vertices.Add(vertexD);

            var graph = new Graph<string, WeightLabel>(vertices);

            graph.AddEdge(vertexA, vertexB);
            graph.AddEdge(vertexA, vertexC);

            graph.AddEdge(vertexB, vertexC);

            graph.AddEdge(vertexC, vertexD);


            Console.WriteLine(graph);
        }
    }
}
