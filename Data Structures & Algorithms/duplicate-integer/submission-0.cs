public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> tab = new HashSet<int>();
        foreach(int n in nums)
        {
            if(tab.Contains(n))
            {
                return true;
            }
            else
            {
                tab.Add(n);
            }
        }
        return false;
    }
}