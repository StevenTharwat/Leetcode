public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       if (strs.Count() == 0) return "";
if (strs.Count() == 1) return strs[0];
var minLength = strs.Min(s => s.Length);
string s = "";
for (int i = 1 ; i <= minLength ; i++)
{
    s = strs[0][..i];
    if (strs.Where(x => x.StartsWith(s)).Count() != strs.Count())
        return s[..( i - 1 )];
}
return s;
    }
}