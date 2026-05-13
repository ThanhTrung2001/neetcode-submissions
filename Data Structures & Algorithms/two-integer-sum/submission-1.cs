public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int needToFind = target - nums[i];

            if (map.ContainsKey(needToFind))
            {
                return new int[] { map[needToFind], i };
            }

            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
