public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while(l<=r)
        {

            if(target == nums[(int)((l+r)/2)])
            {
                return (int)((l+r)/2);
            }

            if(target < nums[(int)((l+r)/2)])
            {
                r = (int)((l+r)/2) - 1;
            }
            else //target > (int)((l+r)/2)
            {
                l = (int)((l+r)/2) + 1;
            }
        }

        return -1;
    }
}
