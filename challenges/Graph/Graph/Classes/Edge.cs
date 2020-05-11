using Graph.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }

    }
}
