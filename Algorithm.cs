namespace Shortest_Path_Finding;

public class Algorithm
{
    protected readonly int N;
    protected readonly int M;
    protected readonly int S;
    protected readonly Edge[] Edges;
    protected readonly int[] Front;
    
    protected Algorithm()
    {
        var first = Console.ReadLine()!.Split();
        N = int.Parse(first[0]);
        M = int.Parse(first[1]);
        S = int.Parse(first[2]);
        Edges = new Edge[M];
        Front = new int[N];

        Array.Fill(Front, -1);

        for (var i = 0; i < M; i++)
        {
            var parts = Console.ReadLine()!.Split();
            var u = int.Parse(parts[0]);
            Edges[i].V = int.Parse(parts[1]);
            Edges[i].W = int.Parse(parts[2]);
            Edges[i].Next = Front[u];
            Front[u] = i;
        }
    }
}