using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    public class Graph
    {
        public Graph() { }
        public Graph(List<int> vertices, List<Edge> edges) : this()
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public Dictionary<int, List<int>> AdjacencyList { get; set; } = new Dictionary<int, List<int>>();

        public void AddVertex(int vertex)
        {
            AdjacencyList.Add(vertex, new List<int>());
        }

        public void AddEdge(Edge edge)
        {
            if (AdjacencyList.ContainsKey(edge.Vertex1) && AdjacencyList.ContainsKey(edge.Vertex2))
            {
                AdjacencyList[edge.Vertex1].Add(edge.Vertex2);
                AdjacencyList[edge.Vertex2].Add(edge.Vertex1);
            }
        }
    }

    public class WeightedGraph
    {
        public WeightedGraph() { }
        public WeightedGraph(List<int> vertices, List<WeightedEdge> edges) : this()
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public Dictionary<int, HashSet<WeightedVertex>> AdjacencyList { get; set; } = new Dictionary<int, HashSet<WeightedVertex>>();

        public void AddVertex(int vertex)
        {
            AdjacencyList.Add(vertex, new HashSet<WeightedVertex>());
        }

        public void AddEdge(WeightedEdge edge)
        {
            if (AdjacencyList.ContainsKey(edge.Vertex1) && AdjacencyList.ContainsKey(edge.Vertex2))
            {
                AdjacencyList[edge.Vertex1].Add(new WeightedVertex(edge.Vertex2, edge.Weight));
                AdjacencyList[edge.Vertex2].Add(new WeightedVertex(edge.Vertex1, edge.Weight));
            }
        }
    }

    public class WeightedVertex
    {
        public WeightedVertex() { }

        public WeightedVertex(int vertex, int weight) : this()
        {
            Vertex = vertex;
            Weight = weight;
        }

        public int Vertex { get; set; }
        public int Weight { get; set; }
    }

    public class A_StarWeightedVertex : WeightedVertex
    {
        public A_StarWeightedVertex() { }

        public A_StarWeightedVertex(int vertex, int weight, int distance) : base(vertex, weight)
        {
            Distance = distance;
        }

        public int Distance { get; set; }
    }

    public class Edge
    {
        public Edge(int vertex1, int vertex2)
        {
            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
        }

        public int Vertex1 { get; set; }
        public int Vertex2 { get; set; }
    }

    public class WeightedEdge : Edge
    {
        public WeightedEdge(int v1, int v2, int weight) : base(v1, v2)
        {
            this.Weight = weight;
        }

        public int Weight { get; set; }
    }
}



    //public class Graph<T>
    //{
    //    public Graph() { }
    //    public Graph(List<T> vertices, List<Tuple<T, T>> edges)
    //    {
    //        foreach (var vertex in vertices)
    //            AddVertex(vertex);

    //        foreach (var edge in edges)
    //            AddEdge(edge);
    //    }

    //    public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

    //    public void AddVertex(T vertex)
    //    {
    //        AdjacencyList[vertex] = new HashSet<T>();
    //    }

    //    public void AddEdge(Tuple<T, T> edge)
    //    {
    //        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
    //        {
    //            AdjacencyList[edge.Item1].Add(edge.Item2);
    //            AdjacencyList[edge.Item2].Add(edge.Item1);
    //        }
    //    }


    //    public HashSet<T> Bfs(Graph<T> graph, T start)
    //    {
    //        var visited = new HashSet<T>();

    //        if (!graph.AdjacencyList.ContainsKey(start))
    //            return visited;

    //        var queue = new Queue<T>();
    //        queue.Enqueue(start);

    //        while (queue.Count > 0)
    //        {
    //            var vertex = queue.Dequeue();

    //            if (visited.Contains(vertex))
    //                continue;

    //            visited.Add(vertex);

    //            foreach (var neighbor in graph.AdjacencyList[vertex])
    //                if (!visited.Contains(neighbor))
    //                    queue.Enqueue(neighbor);
    //        }

    //        return visited;
    //    }

    //    public HashSet<T> BfsShortestPath(Graph<T> graph, T start, T end)
    //    {
    //        var visited = new HashSet<T>();

    //        if (!graph.AdjacencyList.ContainsKey(start))
    //            return visited;

    //        var queue = new Queue<T>();
    //        queue.Enqueue(start);

    //        while (queue.Count > 0)
    //        {
    //            var vertex = queue.Dequeue();

    //            if (vertex == end)
    //                return visited;

    //            if (visited.Contains(vertex))
    //                continue;

    //            visited.Add(vertex);

    //            foreach (var neighbor in graph.AdjacencyList[vertex])
    //                if (!visited.Contains(neighbor))
    //                    queue.Enqueue(neighbor);
    //        }

    //        return visited;
    //    }
    //}


