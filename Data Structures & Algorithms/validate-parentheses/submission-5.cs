public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> brackets = new Dictionary<char, char> {
            { ')','(' },
            { '}','{' },
            { ']','[' }
        };

        Stack<char> stos = new Stack<char>();

        foreach(char c in s)
        {
            if(brackets.ContainsKey(c))
            {
                if(stos.Count > 0 && stos.Peek() == brackets[c])
                {
                    stos.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
             stos.Push(c);
            }
        }

        if(stos.Count > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
