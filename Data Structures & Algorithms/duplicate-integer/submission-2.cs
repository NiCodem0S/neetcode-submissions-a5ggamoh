public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hset = new();

        foreach(int num in nums)
        {
            if(!hset.Add(num)) {return true;}
        }

        return false;
    }
}