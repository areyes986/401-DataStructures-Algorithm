using Graph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddVertex()
        {
            Graph<string> graph = new Graph<string>();
            var actual = graph.AddNode("Mochi");
            Assert.Equal("Mochi", actual.Value);
        }

        [Fact]
        public void CanAddEdge()
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Mochi");
            var b = graph.AddNode("Kudo");
            graph.AddDirectedEdge(a, b, 20);
            var actual = graph.GetNeighbors(a);
            Assert.Equal(graph.AdjacencyList[a],actual);
        }

        [Fact]
        public void CanGetAllNodes()
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Mochi");
            var b = graph.AddNode("Kudo");
            var actual = graph.GetAllVertices();

            List<Vertex<string>> list = new List<Vertex<string>>();

            list.Add(a);
            list.Add(b);
            Assert.Equal(list, actual);
        }

        [Fact]
        public void CanGetAllNeighbors()
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Mochi");
            var b = graph.AddNode("Kudo");
            var c = graph.AddNode("Lucky");
            graph.AddDirectedEdge(a, b, 20);
            graph.AddDirectedEdge(b, c, 30);
            var actual = graph.GetNeighbors(c);
            Assert.Equal(graph.AdjacencyList[c], actual);
        }

        [Fact]
        public void NeighborsReturnWeight()
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Mochi");
            var b = graph.AddNode("Kudo");
            var c = graph.AddNode("Lucky");
            graph.AddDirectedEdge(a, b, 20);
            graph.AddDirectedEdge(b, c, 30);
            var actual = graph.GetNeighbors(b);
            Assert.Equal(30, actual[0].Weight);
        }

        [Fact]
        public void CanReturnSize()
        {
            Graph<string> graph = new Graph<string>();
            var a = graph.AddNode("Mochi");
            var b = graph.AddNode("Kudo");
            var c = graph.AddNode("Lucky");
            graph.AddDirectedEdge(a, b, 20);
            graph.AddDirectedEdge(b, c, 30);
            var actual = graph.Size();
            Assert.Equal(3, actual);
        }

        [Fact]
        public void GraphWithOneNodeandEdgeCanBeReturned()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddNode("Mochi");
            var actual = graph.GetAllVertices();

            Assert.Equal("Mochi", actual[0].Value);
        }

        [Fact]
        public void ReturnsNullIfEmptyGraph()
        {
            Graph<string> graph = new Graph<string>();
            var actual = graph.GetAllVertices();

            Assert.Empty(actual);

        }
    }
}
