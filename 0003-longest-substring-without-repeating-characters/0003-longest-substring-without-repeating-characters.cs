public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // see the biggest index between 2 dublicate caractre and but the biggest in a variable 
        // 
        int max = 0;
HashSet<char> set = new HashSet<char>();
for (int i= 0; i < s.Length; i++){
    for (int j = i ; j < s.Length ; j++)
    {
        if (set.Contains(s[j]))
            break;
        set.Add(s[j]);
    }
    max = Math.Max(max, set.Count);
    set.Clear();
}
 return max;
    }
}