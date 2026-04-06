public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        for(int i=0;i<nums.Length;i++)
        {
            if(dict.TryGetValue(target - nums[i], out int index))
            {
                return new[] {index, i};
            }
            dict[nums[i]] = i;
        }
        return new int[0];
    }
}