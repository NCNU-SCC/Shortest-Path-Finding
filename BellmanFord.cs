namespace Shortest_Path_Finding;

public class BellmanFord : Algorithm
{
    public BellmanFord()
    {
        var dis = Enumerable.Repeat(int.MaxValue, N).ToArray();
        var queue = new Queue(N) { Data = S };
        dis[S] = 0;

        while (queue.Count > 0)
        {
            var x = queue.Data;
            for (var i = Front[x]; i != -1; i = Edges[i].Next)
            {
                var k = Edges[i].V;
                var cost = dis[x] + Edges[i].W;
                if (cost >= dis[k]) continue;
                queue.Data = k;
                dis[k] = cost;
            }
        }

        Console.WriteLine(string.Join(' ', dis));
    }
}
