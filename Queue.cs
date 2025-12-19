namespace Shortest_Path_Finding;

public sealed class Queue(int n)
{
    private readonly Queue<int> _queue = new();
    private readonly bool[] _inQueue = new bool[n];
    
    public int Count => _queue.Count;
    
    public int Data
    {
        get
        {
            var value = _queue.Dequeue();
            _inQueue[value] = false;
            return value;
        }
        set
        {
            if (_inQueue[value]) return;
            _queue.Enqueue(value);
            _inQueue[value] = true;
        }
    }
}
