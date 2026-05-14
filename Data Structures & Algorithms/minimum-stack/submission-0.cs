public class MinStack {

    public Stack<int> stos;
    public Stack<int> minStack;

    public MinStack() {
        stos = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stos.Push(val);
        if(minStack.Count > 0)
        {
            if(val < minStack.Peek())
            {
                minStack.Push(val);
            }
            else
            {
                minStack.Push(minStack.Peek());
            }
        }
        else
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        stos.TryPop(out _);
        minStack.TryPop(out _);
    }
    
    public int Top() {
        return stos.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
