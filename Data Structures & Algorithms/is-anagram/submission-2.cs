public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> dictS = new();
        Dictionary<char, int> dictT = new();

        for(int i=0; i<s.Length; i++)
        {
            if(!dictS.TryAdd(s[i],1))
            {
                dictS[s[i]]++;
            }
            if(!dictT.TryAdd(t[i],1))
            {
                dictT[t[i]]++;
            }
        }

        foreach(var kvp in dictS)
        {
            if(!dictT.ContainsKey(kvp.Key))
            {
                return false;
            }
            else if(dictT[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }

        return true;

    }
}
