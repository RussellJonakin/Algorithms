using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    public class DFS
    {
        public static HashSet<int> SearchToEnd(Graph graph, int start)
        {
            var visited = new HashSet<int>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<int>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }

        public static HashSet<int> FindPath(Graph graph, int start, int end)
        {
            var visited = new HashSet<int>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<int>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                int vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                if (vertex == end)
                    break;

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }
    }
}
