// Time Complexity :O(1)
// Space Complexity :O(1)
// Did this code successfully run on Leetcode :Yes
// Any problem you faced while coding this :yes how to handle empty stack.
public class MinStack
{
    private const int MaxValue = 2147483647;
    private Stack<int> mainStack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();
    private int min = 2147483647;

    public MinStack()
    {
        minStack.Push(min);
    }

    public void Push(int val)
    {
        mainStack.Push(val);
        min = Math.Min(val, min);
        minStack.Push(min);
    }

    public void Pop()
    {
        mainStack.Pop();
        minStack.Pop();
        min= minStack.Peek();

    }

    public int Top()
    {
        return mainStack.Peek();
    }

    public int GetMin()
    {
        return min;
    }


    public static void Main(string[] args)
    {
        MinStack obj = new MinStack();
        obj.Push(5);
        obj.Push(9);
        obj.Push(4);
        obj.Pop();
        obj.Push(12);
        obj.Pop();
        obj.Push(3);
        obj.Pop();
        obj.Pop();
        obj.Pop();
        int param_3 = obj.Top();
        int param_4 = obj.GetMin();
        Console.WriteLine(param_3);
        Console.WriteLine(param_4);
        Console.ReadLine();
    }
}
