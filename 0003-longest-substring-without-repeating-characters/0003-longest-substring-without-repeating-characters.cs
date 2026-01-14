public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var max = 0;
var map = new Dictionary<char, int>();
int left = 0;
for (int right = 0 ; right < s.Length ; right++)
{
    if(map.ContainsKey(s[right]))
    {
        left = Math.Max(map[s[right]]+1, left);
    }
    map[s[right]] = right;
    max = Math.Max(max, right - left + 1);
}
return max;
    }
}