using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class A_Star
    {
        //A* is the exact same impleamentation as dijkstra below except queue.Dequeue() and queue.Enqueue takes into account the extra
        //hueristic data A* star graphs have which is edge weight and an overall distance. 

        //public static HashSet<WeightedVertex> A_Star_Search(WeightedGraph graph, int startVertex, int endVertex)
        //{
        //    var visited = new HashSet<WeightedVertex>();
        //    WeightedVertex start = new WeightedVertex(startVertex, 0); //make start vertex with weight 0.

        //    if (!graph.AdjacencyList.ContainsKey(start.Vertex))  // || !graph.AdjacencyList.ContainsKey(end))
        //        return visited;

        //    var queue = new PriorityQueue<WeightedVertex>();
        //    queue.Enqueue(start);  //Enqueue performs Heapify insert sorting by weight + distance. 

        //    while (queue.Count > 0)
        //    {
        //        var weightedVertex = queue.Dequeue(); // Pops top Min element off according to weight + distance.

        //        if (weightedVertex.Vertex == endVertex)
        //            return visited;

        //        if (visited.Contains(weightedVertex))
        //            continue;

        //        visited.Add(weightedVertex);

        //        foreach (var neighbor in graph.AdjacencyList[weightedVertex.Vertex])
        //            if (!visited.Contains(neighbor))
        //                queue.Enqueue(neighbor);
        //    }

        //    return visited;
        //}
    }
}
