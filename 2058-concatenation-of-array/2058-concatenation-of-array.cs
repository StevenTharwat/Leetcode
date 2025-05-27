public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[nums.Length * 2];
nums.CopyTo(result, 0);
nums.CopyTo(result, nums.Length);
return result;
    }
}