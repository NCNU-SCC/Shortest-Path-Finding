namespace Shortest_Path_Finding;

public static class BellmanFord
{
    private static void Add(bool[] inQueue, Queue<int> queue, int[] dis, int index, int cost)
    {
        if (!inQueue[index])
        {
            inQueue[index] = true;
            queue.Enqueue(index);
        }
        dis[index] = cost;
    }
    
    public static void Start(Edge[] edges, int[] front, int n, int s)
    {
        var dis = Enumerable.Repeat(int.MaxValue, n).ToArray();
        var queue = new Queue<int>();
        var inQueue = new bool[n];
        Add(inQueue, queue, dis, s, 0);

        while (queue.Count > 0)
        {
            var x = queue.Dequeue();
            inQueue[x] = false;
            for (var i = front[x]; i != 0; i = edges[i].Next)
            {
                var k = edges[i].V;
                var cost = dis[x] + edges[i].W;
                if (cost < dis[k]) Add(inQueue, queue, dis, k, cost);
            }
        }

        Console.WriteLine(string.Join(' ', dis));
    }
}