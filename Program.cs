namespace Shortest_Path_Finding;

internal static class Program
{
    private static void Main()
    {
        var first = Console.ReadLine()!.Split();
        var n = int.Parse(first[0]);
        var edges = new Edge[n];
        var front = new int[n];

        // 初始化 front 陣列為 0
        Array.Fill(front, 0);

        for (var i = 0; i < int.Parse(first[1]); i++)
        {
            var parts = Console.ReadLine()!.Split();
            var u = int.Parse(parts[0]);
            edges[i].V = int.Parse(parts[1]);
            edges[i].W = int.Parse(parts[2]);
            edges[i].Next = front[u];
            front[u] = i;
        }

        BellmanFord.Start(edges, front, n, int.Parse(first[2]));
    }
}
/*
輸入：
第一行有三個整數：
節點數量 邊數N 選定節點
接下來有N行，每行都代表一個單向邊：
起點 終點 權重
例如：
6 8 0
0 1 1
1 2 2
0 3 5
0 4 6
3 4 7
4 5 8
1 3 4
2 3 3
 */