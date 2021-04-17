/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 */

// @lc code=start
public class MinStack {

    /** initialize your data structure here. */
    Stack<int> mainStack;
    Stack<int> auxiliaryStack;

    public MinStack() {
        mainStack = new Stack<int>();
        auxiliaryStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        if(auxiliaryStack.Count == 0 || val <= auxiliaryStack.Peek())
            auxiliaryStack.Push(val);
    }
    
    public void Pop() {
        if(auxiliaryStack.Count > 0 && mainStack.Pop() == auxiliaryStack.Peek())
            auxiliaryStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return auxiliaryStack.Count > 0 ? auxiliaryStack.Peek() : mainStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

