public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> brackets = new Dictionary<char, char> {
            { ')','(' },
            { '}','{' },
            { ']','[' }
        };

        List<char> stack = new();

        foreach(var c in s)
        {

            if(brackets.ContainsKey(c))
            {
                if(stack.Count > 0 && stack[^1] == brackets[c])
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Add(c);
            }
        }
        if(stack.Count > 0)
        {
            return false;
        }
        return true;
    }
}
