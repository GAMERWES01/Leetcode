namespace Leetcode._1_9999._1_999._200_299._220_229;

public class MyStack
{
    private Queue<int> _queue;
    
    public MyStack() {
        _queue = new Queue<int>();
    }
    
    public void Push(int x) {
        Queue<int> newQueue = new Queue<int>();
        newQueue.Enqueue(x);
        foreach (int value in _queue)
        {
            newQueue.Enqueue(value);
        }
        _queue = newQueue;
    }
    
    public int Pop() {
        return _queue.Dequeue();
    }
    
    public int Top() {
        return _queue.Peek();
    }
    
    public bool Empty()
    {
        return _queue.Count == 0;
    }
}