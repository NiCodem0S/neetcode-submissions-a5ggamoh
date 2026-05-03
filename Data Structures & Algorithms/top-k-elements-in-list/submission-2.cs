public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqs = new ();
        List<int>[] bucketTab = new List<int>[nums.Length + 1];

        for(int i=0; i<=nums.Length; i++)
        {
            bucketTab[i] = new List<int>();
        }

        foreach(var num in nums)
        {
            if(!freqs.TryAdd(num, 1))
            {
                freqs[num]++;
            }
        }
        
        foreach(var kvp in freqs)
        {
            bucketTab[kvp.Value].Add(kvp.Key);
        }

        int[] result = new int[k];
        int count = 0;

        for(int i=bucketTab.Length - 1; i>0 && count<k; i--)
        {
            foreach(int num in bucketTab[i])
            {
                result[count++] = num;
                if(count >= k){return result;};
            }
        }
        
        return result;
    }
}
