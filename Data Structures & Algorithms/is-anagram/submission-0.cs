public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> charsS = new();
        Dictionary<char,int> charsT = new();
        
        for(int i=0; i < s.Length; i++)
        { 
            charsS[s[i]] = charsS.TryGetValue(s[i], out int valueS) ? valueS + 1 : 1;
            charsT[t[i]] = charsT.TryGetValue(t[i], out int valueT) ? valueT + 1 : 1;
        }

        foreach(var kvp in charsS)
        {
            if(!charsT.TryGetValue(kvp.Key, out int countT) || kvp.Value != countT) return false;
        }
        return true;
    }
}