namespace Shortest_Path_Finding;

public class DijkstraS : Algorithm
{
    private const int Inf = 0x3f3f3f3f;

    public DijkstraS()
    {
        var dist = Enumerable.Repeat(Inf, N).ToArray();
        var visited = new bool[N];
        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(S, 0);
        dist[S] = 0;

        while (pq.Count > 0)
        {
            pq.TryDequeue(out var u, out _);
            if (visited[u]) continue;
            visited[u] = true;

            for (var i = Front[u]; i != -1; i = Edges[i].Next)
            {
                var edge = Edges[i];
                var candidate = dist[u] + edge.W;
                if (candidate >= dist[edge.V]) continue;

                dist[edge.V] = candidate;
                pq.Enqueue(edge.V, candidate);
            }
        }

        Console.WriteLine(string.Join(' ', dist));
    }
}
