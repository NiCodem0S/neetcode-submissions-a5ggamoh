public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length -1;

        while(end > start)
        {
            bool skip = false;
            if(!Char.IsLetterOrDigit(s[start]))
            {
                start++;
                skip = true;
            }
            if(!Char.IsLetterOrDigit(s[end]))
            {
                end--;
                skip = true;
            }

            if(skip){
                continue;
            }

            if(Char.ToLower(s[start]) != Char.ToLower(s[end]))
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
