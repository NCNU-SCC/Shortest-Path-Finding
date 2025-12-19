namespace Shortest_Path_Finding;

internal static class Program
{
    private static void Main()
    {
        var b = new BellmanFord();
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