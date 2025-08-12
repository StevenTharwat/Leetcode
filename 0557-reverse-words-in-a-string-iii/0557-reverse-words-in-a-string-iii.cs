public class Solution {
 public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return string.Empty;
            }

            char[] chars = ( s.Trim() + " " ).ToCharArray();
            int start = 0;
            int count = 0;

            for (int i = 0 ; i < chars.Length ; i++)
            {
                if (chars[i] == ' ')
                {
                    Array.Reverse(chars, start, count);
                    start = i + 1;
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            return new string(chars).Trim();
        }
}