public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> freqS = new();
        Dictionary<char, int> freqT = new();

        for(int i=0; i<s.Length; i++)
        {
            if(!freqS.TryAdd(s[i],1))
            {
                freqS[s[i]]++;
            }

            if(!freqT.TryAdd(t[i],1))
            {
                freqT[t[i]]++;
            }
        }

        for(int i=0; i<s.Length; i++)
        {
            if(!freqT.TryGetValue(s[i], out int val))
            {
                return false;
            }

            if(val != freqS[s[i]])
            {
                return false;
            }
        }

        return true;

    }
}
