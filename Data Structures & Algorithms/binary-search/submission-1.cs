public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while(l<=r)
        {
            int middle = (int)((l+r)/2);

            if(target == nums[middle])
            {
                return middle;
            }

            if(target < nums[middle])
            {
                r = middle - 1;
            }
            else //target > middle
            {
                l = middle + 1;
            }
        }

        return -1;
    }
}
