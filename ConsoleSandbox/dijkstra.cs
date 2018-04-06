using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    public class Dijkstra
    {
        //A* is the exact same impleamentation as dijkstra below except queue.Dequeue() and queue.Enqueue takes into account the extra
        //hueristic data A* star graphs have which is edge weight and an overall distance. 

        public static HashSet<WeightedVertex> DijkstraShortestPath(WeightedGraph graph, int startVertex, int endVertex)
        {
            var visited = new HashSet<WeightedVertex>();
            WeightedVertex start = new WeightedVertex(startVertex, 0); //make start vertex with weight 0.

            if (!graph.AdjacencyList.ContainsKey(start.Vertex))
                return visited;

            var heap = new MinHeap();
            heap.Add(start);

            while (heap.Count > 0)
            {
                WeightedVertex current = heap.PopMin();

                //if vistited.Contains(weightedVertex)
                if (visited.Any(x => x.Vertex == current.Vertex))
                    continue;

                visited.Add(current);

                if (current.Vertex == endVertex)
                    break;

                foreach (var neighbor in graph.AdjacencyList[current.Vertex])
                    if (!visited.Any(x => x.Vertex == neighbor.Vertex))
                        heap.Add(neighbor);
            }

            return visited;
        }
    }

    /// <summary>
    /// Heap like data structure that keeps a list data structure order by min element to max element.
    /// This is a (very) Poor Man's Min Heap.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MinHeap
    {
        public MinHeap()
        {
            this.innerList = new List<WeightedVertex>();
        }

        private List<WeightedVertex> innerList { get; set; }
        
        public int Count
        {
            get
            {
                return this.innerList.Count;
            }
        }

        /// <summary>
        /// Performs Heapify insert sorting by weight in ascending order.
        /// </summary>
        /// <param name="item"></param>
        public void Add(WeightedVertex item)
        {
            this.innerList.Add(item);

            this.innerList = this.innerList.OrderBy(x => x.Weight).ToList();
        }

        /// <summary>
        /// Removes the top Min weighted element off the heap and returns that element.
        /// </summary>
        /// <returns></returns>
        public WeightedVertex PopMin()
        {
            var x = this.innerList.ElementAtOrDefault(0);

            if (x != null)
                this.innerList.RemoveAt(0);

            return x;
        }
    }
}
