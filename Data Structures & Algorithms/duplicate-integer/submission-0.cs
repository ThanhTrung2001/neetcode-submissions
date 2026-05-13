public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            dict.Add(i, nums[i]);
        }
        return dict.Values.Distinct().Count() != dict.Count;

    }
}