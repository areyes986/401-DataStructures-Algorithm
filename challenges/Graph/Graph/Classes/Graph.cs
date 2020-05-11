using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// this is so we can change sizes if need be
        /// </summary>
        /// <returns>the the # of nodes int the graph</returns>
        public int Size()
        {
            return _size;
        }

        /// <summary>
        /// Adds the vertex to the graph and changes size as the new vertexes are added in
        /// </summary>
        /// <param name="value">the value of the vertex</param>
        /// <returns>the vertex/node that is added</returns>
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        /// <summary>
        /// adds edges from point a to point b and the weight of the edge to each vertex
        /// </summary>
        /// <param name="a">vertex point a </param>
        /// <param name="b">vertex point b </param>
        /// <param name="weight"></param>
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Vertex = b,
                    Weight = weight
                }
                );
        }

        /// <summary>
        /// kind of having the edges have the vertexes point to each other. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(a, b, weight);
        }

        /// <summary>
        /// Creates a list of vertices, goes through each one in the graph, adds the keys in the vertices list and returns the vertices in it.
        /// </summary>
        /// <returns>all the nodes in the graph</returns>
        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }
            return vertices;
        }

        /// <summary>
        /// takes in a vertex and returns the collection of edges
        /// </summary>
        /// <param name="vertex">the inputted vertex</param>
        /// <returns>returns the edges that are connected to the vertex</returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// this just console.writes the values of the vertex as well as the weight of each edge
        /// </summary>
        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.WriteLine($"{vertex.Key.Value}: ");

                foreach (var edge in vertex.Value)
                {
                    Console.WriteLine($"{edge.Vertex.Value}, {edge.Weight} = > ");
                }
                Console.WriteLine("null");
            }

        }





    }
}
