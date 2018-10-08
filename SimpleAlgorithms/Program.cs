using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
            t.Start();

            //Test
            // col {a, c, y, i, t}, word = “cat” - true
            // col {a, c, y, t, i, t}, word = “catty” - true
            // col {A, c, y, i, t}, word = “cat” - false
            // col {} || null, word = “cat” -  false (empty or null collection)
            // col {a, g, h}, word = null || empty - false
            // col {D, o, ‘ ’, h, ‘ ’, ‘ ’, g} = “   ” - True (3 space character)
            // col {D, o, ‘ ’, h, g, B, u, l, e} = “Blue Dog” - True
            // col {D, o, h, g, B, u, l, e} = “Blue Dog” - False (no space to support phrase)

            //List<char> chars = new List<char>() { 'a', 'c', 'y', 't', 'i', 't' };
            //string word = "catty";

            //Console.WriteLine(GoogleInterview1.CanBuildWord(chars, word));

            //int[] nums = new int[] { 4,5,2,8,999,92,47,42,99,-12,-5,1001,123456,9,2,2,0,3,6,11,15,4245,0,1,45,75,245,121,333 };

            //Sort.MergeSort(nums);

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}


            //List<int> vertcies = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<Edge> edges = new List<Edge>()
            //{
            //    new Edge(1,2),
            //    new Edge(1,5),
            //    new Edge(1,7),
            //    new Edge(2,3),
            //    new Edge(3,7),
            //    new Edge(7,6),
            //    new Edge(5,8),
            //    new Edge(6,4),
            //    new Edge(4,8)
            //};

            //Graph graph = new Graph(vertcies, edges);

            ////HashSet<int> path = BFS.FindShortestPath(graph, 2, 8);
            //HashSet<int> path = DFS.FindPath(graph, 2, 8);

            //foreach (var i in path)
            //    Console.WriteLine("   " + i);


            List<int> vertcies = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<WeightedEdge> edges = new List<WeightedEdge>()
            {
                new WeightedEdge(1,2,2),
                new WeightedEdge(1,5,2),
                new WeightedEdge(1,7,3),
                new WeightedEdge(2,3,1),
                new WeightedEdge(3,7,2),
                new WeightedEdge(7,6,1),
                new WeightedEdge(5,8,4),
                new WeightedEdge(6,4,5),
                new WeightedEdge(4,8,1)
            };

            WeightedGraph graph = new WeightedGraph(vertcies, edges);

            //HashSet<int> path = BFS.FindShortestPath(graph, 2, 8);
            HashSet<WeightedVertex> path = Dijkstra.DijkstraShortestPath(graph, 6, 8);

            foreach (var i in path)
                Console.WriteLine("   " + i.Vertex + " -> w: " + i.Weight);



            t.Stop();
            //Console.WriteLine(t.ElapsedMilliseconds);

            Console.ReadKey();
        }

        public static bool IsEven(long x)
        {
            if ((x & 1) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
